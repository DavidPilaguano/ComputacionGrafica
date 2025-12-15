using System;
using System.Collections.Generic;
using System.Linq;

namespace Curvas_Bezier_y_B_Spline.Model
{
    public static class B_Spline_CoxDeBoor
    {
        // Genera el vector de nudos uniforme acoplado [0,0,0,0, 1, 2, 3, ..., k, k, k, k]
        private static float[] GenerarVectorNudos(int numPuntosControl, int grado)
        {
            int n = numPuntosControl - 1;
            int numNudos = n + grado + 2; 
            float[] U = new float[numNudos];
            int j = 0;

            // Repetir el valor inicial (0) 'grado + 1' veces (p+1)
            for (int i = 0; i <= grado; i++) U[j++] = 0.0f;

            // Nudos internos uniformes (de 1 a n-p)
            for (int i = 1; i <= n - grado; i++) U[j++] = (float)i;

            // Repetir el valor final (máx) 'grado + 1' veces (p+1)
            float maxNudo = n - grado + 1;
            for (int i = 0; i <= grado; i++) U[j++] = maxNudo;

            return U;
        }

        // Función Base de Cox-de Boor (recursiva)
        private static float FuncionBase(int i, int p, float u, float[] U)
        {
            if (p == 0)
            {
                // [U_i, U_{i+1})
                return (U[i] <= u && u < U[i + 1]) ? 1.0f : 0.0f;
            }

            float N1 = 0, N2 = 0;
            
            // Primer término: (u - U_i) / (U_{i+p} - U_i) * N(i, p-1, u)
            float den1 = U[i + p] - U[i];
            if (den1 != 0) N1 = (u - U[i]) / den1 * FuncionBase(i, p - 1, u, U);

            // Segundo término: (U_{i+p+1} - u) / (U_{i+p+1} - U_{i+1}) * N(i+1, p-1, u)
            float den2 = U[i + p + 1] - U[i + 1];
            if (den2 != 0) N2 = (U[i + p + 1] - u) / den2 * FuncionBase(i + 1, p - 1, u, U);

            return N1 + N2;
        }

        /// <summary>
        /// Genera la curva B-Spline (grado P) usando la fórmula de Cox-de Boor.
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

                Punto2D p_curva = new Punto2D(0, 0);

                // S(u) = Sumatoria [N(i, p, u) * P_i]
                for (int i = 0; i <= n; i++)
                {
                    float Ni_p_u = FuncionBase(i, grado, u, U);
                    if (Ni_p_u > 0)
                    {
                        p_curva += Ni_p_u * points[i]; 
                    }
                }
                curva.Add(p_curva);
            }
            return curva;
        }
    }
}