using System;
using System.Collections.Generic;
using System.Linq;

namespace Curvas_Bezier_y_B_Spline.Model
{
     public struct Punto2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Punto2D(float x, float y)
        {
            X = x;
            Y = y;
        }

       
        public static Punto2D operator +(Punto2D a, Punto2D b)
        {
            return new Punto2D(a.X + b.X, a.Y + b.Y);
        }

        public static Punto2D operator *(Punto2D p, float f)
        {
            return new Punto2D(p.X * f, p.Y * f);
        }

        public static Punto2D operator *(float f, Punto2D p)
        {
            return new Punto2D(p.X * f, p.Y * f);
        }
    }


    public static class BezierDeCasteljau
    {
         public static List<Punto2D> GenerarCurva(List<Punto2D> points, int numSegmentos = 100)
        {
            if (points == null || points.Count < 2)
                throw new ArgumentException("Se requieren al menos 2 puntos de control para iniciar el algoritmo De Casteljau.");

            int n = points.Count - 1; // Grado de la curva (N)
            var curva = new List<Punto2D>();

            for (int i = 0; i <= numSegmentos; i++)
            {
                float t = (float)i / numSegmentos;
                float one_minus_t = 1 - t;

                // Copia inicial de los puntos de control (Nivel r=0)
                List<Punto2D> P_r = new List<Punto2D>(points);

                // El bucle externo itera los niveles de interpolación (r=1 a n)
                for (int r = 1; r <= n; r++)
                {
                    List<Punto2D> P_next = new List<Punto2D>();

                    // El bucle interno calcula los puntos del siguiente nivel P_j^r
                    for (int j = 0; j <= n - r; j++)
                    {
                        // Fórmula de De Casteljau (Interpolación Lineal):
                        // P_j^r = (1-t) * P_j^(r-1) + t * P_(j+1)^(r-1)
                        Punto2D new_point = one_minus_t * P_r[j] + t * P_r[j + 1];
                        P_next.Add(new_point);
                    }
                    P_r = P_next;
                }

                curva.Add(P_r[0]);
            }
            return curva;
        }
    }
}