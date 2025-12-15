using System;
using System.Collections.Generic;
using System.Drawing;

namespace Curvas_Bezier_y_B_Spline.Model
{
    public struct Punto
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Punto(float x, float y)
        {
            X = x;
            Y = y;
        }
    }

    public static class BezierCuadratica
    {
        private const int NUM_PUNTOS_CONTROL_REQUERIDOS = 3;

        public static Punto CalcularPunto(Punto P0, Punto P1, Punto P2, float t)
        {
            float B0 = (1 - t) * (1 - t);   // (1-t)²
            float B1 = 2 * t * (1 - t);     // 2t(1-t)
            float B2 = t * t;               // t²

            float x = P0.X * B0 + P1.X * B1 + P2.X * B2;
            float y = P0.Y * B0 + P1.Y * B1 + P2.Y * B2;

            return new Punto(x, y);
        }

        public static List<Punto> GenerarCurva(List<Punto> points, int numSegmentos = 100)
        {
            if (points == null || points.Count != NUM_PUNTOS_CONTROL_REQUERIDOS)
            {
                throw new ArgumentException($"Se requieren exactamente {NUM_PUNTOS_CONTROL_REQUERIDOS} puntos de control para la Bézier Cuadrática.");
            }

            var P0 = points[0];
            var P1 = points[1];
            var P2 = points[2];
            var curva = new List<Punto>();

            for (int i = 0; i <= numSegmentos; i++)
            {
                float t = (float)i / numSegmentos;
                curva.Add(CalcularPunto(P0, P1, P2, t));
            }

            return curva;
        }
    }
}