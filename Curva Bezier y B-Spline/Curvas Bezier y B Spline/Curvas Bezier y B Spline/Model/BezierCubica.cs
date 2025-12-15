using System.Drawing;
using System.Collections.Generic;
using System;

namespace Curvas_Bezier_y_B_Spline.Model
{
    
    public static class BezierCubica
    {
        private const int NUM_PUNTOS_CONTROL_REQUERIDOS = 4;

           public static Punto CalcularPunto(Punto P0, Punto P1, Punto P2, Punto P3, float t)
        {
            float one_minus_t = 1 - t;

            // Polinomios de Bernstein (coeficientes)
            float B0 = one_minus_t * one_minus_t * one_minus_t;     // (1-t)³
            float B1 = 3 * t * one_minus_t * one_minus_t;           // 3t(1-t)²
            float B2 = 3 * t * t * one_minus_t;                     // 3t²(1-t)
            float B3 = t * t * t;                                   // t³

            // Cálculo del punto C(t)
            float x = P0.X * B0 + P1.X * B1 + P2.X * B2 + P3.X * B3;
            float y = P0.Y * B0 + P1.Y * B1 + P2.Y * B2 + P3.Y * B3;

            return new Punto(x, y);
        }

         public static List<Punto> GenerarCurva(List<Punto> points, int numSegmentos = 100)
        {
            if (points == null || points.Count != NUM_PUNTOS_CONTROL_REQUERIDOS)
            {
                throw new ArgumentException($"Se requieren exactamente {NUM_PUNTOS_CONTROL_REQUERIDOS} puntos de control para la Bézier Cúbica.");
            }

            var P0 = points[0];
            var P1 = points[1];
            var P2 = points[2];
            var P3 = points[3];
            var curva = new List<Punto>();

            for (int i = 0; i <= numSegmentos; i++)
            {
                float t = (float)i / numSegmentos;
                try
                {
                    curva.Add(CalcularPunto(P0, P1, P2, P3, t));
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al calcular punto en t={t}: {ex.Message}");
                }
            }
            return curva;
        }
    }
}