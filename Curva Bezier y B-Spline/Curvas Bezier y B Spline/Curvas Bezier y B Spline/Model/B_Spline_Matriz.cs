using System;
using System.Collections.Generic;

namespace Curvas_Bezier_y_B_Spline.Model
{
    public static class B_Spline_Matriz
    {
         private static readonly float[,] M_BS = new float[,]
        {
            { -1f/6f,  3f/6f, -3f/6f, 1f/6f },
            {  3f/6f, -6f/6f,  3f/6f, 0f/6f },
            { -3f/6f,  0f/6f,  3f/6f, 0f/6f },
            {  1f/6f,  4f/6f,  1f/6f, 0f/6f }
        };

        public static List<Punto2D> GenerarCurva(List<Punto2D> points, int numSegmentos = 100)
        {
            if (points == null || points.Count < 4)
                throw new ArgumentException("Se requieren al menos 4 puntos para la B-Spline Cúbica.");

            var curva = new List<Punto2D>();
            int n = points.Count;

            // Recorrer los segmentos. Cada segmento requiere 4 puntos (P_i, P_{i+1}, P_{i+2}, P_{i+3}).
            // Hay n - 3 segmentos de curva válidos (de i=0 hasta i=n-4)
            for (int i = 0; i <= n - 4; i++)
            {
                // Puntos de control para el segmento actual
                var P_segmento = new Punto2D[] { points[i], points[i + 1], points[i + 2], points[i + 3] };

                for (int k = 0; k <= numSegmentos; k++)
                {
                    float t = (float)k / numSegmentos;
                    float t2 = t * t;
                    float t3 = t2 * t;

                    // 1. Vector T = [t³, t², t, 1]
                    float[] T = { t3, t2, t, 1 };

                    // 2. Multiplicación de polinomios (T * M_BS)
                    Punto2D P_curva = new Punto2D(0, 0);

                    // Multiplicar (T * M_BS) * P_segmento
                    for (int j = 0; j < 4; j++)
                    {
                        float coeficiente = 0;
                        for (int l = 0; l < 4; l++)
                        {
                            // Calcula el coeficiente [T * M_BS]_j
                            coeficiente += T[l] * M_BS[l, j];
                        }
                        // Aplica el coeficiente al punto de control P_segmento[j]
                        P_curva += coeficiente * P_segmento[j];
                    }

                    if (k < numSegmentos || i == n - 4) 
                    {
                        curva.Add(P_curva);
                    }
                }
            }
            return curva;
        }
    }
}