using System;
using System.Collections.Generic;

namespace Curvas_Bezier_y_B_Spline.Model
{
    public static class B_Spline_DeBoor
    {
         private static float[] GenerarVectorNudos(int numPuntosControl, int grado)
        {
            int n = numPuntosControl - 1;
            int numNudos = n + grado + 2;
            float[] U = new float[numNudos];
            int j = 0;

            for (int i = 0; i <= grado; i++) U[j++] = 0.0f;
            for (int i = 1; i <= n - grado; i++) U[j++] = (float)i;
            float maxNudo = n - grado + 1;
            for (int i = 0; i <= grado; i++) U[j++] = maxNudo;

            return U;
        }


        private static Punto2D CalcularPuntoDeBoor(int grado, float u, List<Punto2D> points, float[] U)
        {
            int n = points.Count - 1;


            int k = -1;
            for (int i = grado; i <= n; i++)
            {
                if (U[i] <= u && u < U[i + 1])
                {
                    k = i;
                    break;
                }
            }
            if (k == -1)
            {
                 if (u == U[n + 1]) k = n;
                else throw new InvalidOperationException("Parámetro u fuera del rango de nudos válido.");
            }

            // Inicializar los puntos de trabajo (rango k-p a k)
            List<Punto2D> P = new List<Punto2D>();
            for (int i = k - grado; i <= k; i++)
            {
                // Asegurar que i esté dentro del rango de puntos de control [0, n]
                if (i >= 0 && i <= n) P.Add(points[i]);
            }

            // Aplicar el esquema triangular iterativo (p veces)
            for (int r = 1; r <= grado; r++)
            {
                for (int i = P.Count - 1; i >= r; i--)
                {
                    // Indices de los nudos usados en la interpolación actual:
                    int i_global = k - P.Count + i + 1; // Mapea el índice relativo (i) al índice global del nudo (U[j])

                    float alpha_den = U[i_global + grado - r + 1] - U[i_global];

                    float alpha = 0.0f;
                    if (alpha_den != 0)
                    {
                        alpha = (u - U[i_global]) / alpha_den;
                    }

                    // Interpolación lineal: P_i^r = (1 - alpha) * P_{i-1}^{r-1} + alpha * P_i^{r-1}
                    P[i] = (1 - alpha) * P[i - 1] + alpha * P[i];
                }
            }

            return P[grado]; // El último punto calculado es S(u)
        }

        /// <summary>
        /// Genera la curva B-Spline (grado P) usando el Algoritmo de De Boor.
        /// </summary>
        public static List<Punto2D> GenerarCurva(List<Punto2D> points, int grado, int numSegmentos = 100)
        {
            int n = points.Count - 1;
            if (grado < 1 || grado > n) throw new ArgumentException("Grado no válido.");

            float[] U = GenerarVectorNudos(points.Count, grado);
            var curva = new List<Punto2D>();
            float u_min = U[grado];
            float u_max = U[n + 1];

            for (int k = 0; k <= numSegmentos; k++)
            {
                float t = (float)k / numSegmentos;
                float u = u_min + t * (u_max - u_min);

                curva.Add(CalcularPuntoDeBoor(grado, u, points, U));
            }
            return curva;
        }
    }
}