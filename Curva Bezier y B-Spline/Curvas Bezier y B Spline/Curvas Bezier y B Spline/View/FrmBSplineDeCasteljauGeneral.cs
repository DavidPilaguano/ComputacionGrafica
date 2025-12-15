using Curvas_Bezier_y_B_Spline.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Curvas_Bezier_y_B_Spline.View
{
   
    public partial class FrmBSplineDeCasteljauGeneral : Form
    {
        // 1. CONFIGURACIÓN GRÁFICA
        private const float WORLD_SIZE = 200.0f;
        private List<Punto2D> _puntosCurva = new List<Punto2D>();
        private List<Punto2D> _puntosControl = new List<Punto2D>();

        // Parámetros de la B-Spline
        private const int GRADO_CURVA = 3; // Cúbica (p=3)
        private const int PUNTOS_MINIMOS = GRADO_CURVA + 1; // Mínimo de 4 puntos

         public FrmBSplineDeCasteljauGeneral()
        {
            InitializeComponent();
            this.Text = $"B-Spline De Boor Iterativo (Grado {GRADO_CURVA})";

            this.pnlGrafico.Paint += new PaintEventHandler(pnlGrafico_Paint);
            this.pnlGrafico.Resize += new EventHandler(pnlGrafico_Resize);

            // Puntos de ejemplo (B-Spline Cúbica, 6 puntos de control)
            txtPuntosControl.Text = "10,10; 40,180; 100,20; 160,180; 190,10; 100,150";
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Leer y validar N puntos de control
                _puntosControl = LeerPuntosDeControlGeneral();

                if (_puntosControl.Count < PUNTOS_MINIMOS)
                {
                    throw new Exception($"Para una B-Spline Cúbica (Grado {GRADO_CURVA}) se requieren al menos {PUNTOS_MINIMOS} puntos de control.");
                }

                _puntosCurva = B_Spline_DeBoor.GenerarCurva(_puntosControl, GRADO_CURVA);
               
                pnlGrafico.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dibujar la curva: " + ex.Message, "Error de B-Spline (De Boor)",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _puntosControl.Clear();
                _puntosCurva.Clear();
                pnlGrafico.Invalidate();
            }
        }

        // --- MÉTODOS DE LECTURA Y DIBUJO ---

        private List<Punto2D> LeerPuntosDeControlGeneral()
        {
            var puntos = new List<Punto2D>();
            string input = txtPuntosControl.Text;
            string[] puntoStrings = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            if (puntoStrings.Length < 2)
                throw new Exception("Ingrese al menos dos puntos de control (ej: X1,Y1; X2,Y2; ...).");

            foreach (string ps in puntoStrings)
            {
                string[] coords = ps.Trim().Split(',');
                if (coords.Length != 2)
                    throw new Exception($"Formato de punto inválido: '{ps}'. Use 'X,Y'.");
                if (!float.TryParse(coords[0].Trim(), out float x) || !float.TryParse(coords[1].Trim(), out float y))
                    throw new Exception($"Coordenadas deben ser numéricas en '{ps}'.");
                if (x < 0 || y < 0)
                    throw new Exception("Las coordenadas no pueden ser negativas.");
                puntos.Add(new Punto2D(x, y));
            }
            return puntos;
        }

        private void pnlGrafico_Resize(object sender, EventArgs e)
        {
            pnlGrafico.Invalidate();
        }

        private void pnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = pnlGrafico.Width;
            int height = pnlGrafico.Height;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            float scaleFactor = Math.Min(width, height) / WORLD_SIZE;

            DibujarCuadricula(g, width, height, scaleFactor);
            DibujarElementos(g, scaleFactor, height);
        }

        private void DibujarCuadricula(Graphics g, int width, int height, float scaleFactor)
        {
            Pen penGrid = new Pen(Color.LightGray, 1);
            int step = 20;

            for (int i = 0; i <= WORLD_SIZE; i += step)
            {
                float x = i * scaleFactor;
                float y = height - (i * scaleFactor);

                g.DrawLine(penGrid, x, 0, x, height);
                g.DrawLine(penGrid, 0, y, width, y);

                using (Brush brush = new SolidBrush(Color.Gray))
                {
                    g.DrawString(i.ToString(), this.Font, brush, x + 2, height - 15);
                    if (i != 0)
                    {
                        g.DrawString(i.ToString(), this.Font, brush, 2, y - 15);
                    }
                }
            }
        }

        private void DibujarElementos(Graphics g, float scaleFactor, int height)
        {
            if (_puntosControl.Count < 2) return;

            var screenPoints = _puntosControl
                .Select(p => WorldToScreen(p, scaleFactor, height))
                .ToArray();

            Pen penPolygon = new Pen(Color.Gray, 1) { DashPattern = new float[] { 4, 2 } };
            g.DrawLines(penPolygon, screenPoints);

            using (Brush brush = new SolidBrush(Color.Blue))
            {
                for (int i = 0; i < screenPoints.Length; i++)
                {
                    PointF p = screenPoints[i];
                    g.FillEllipse(brush, p.X - 4, p.Y - 4, 8, 8);
                    g.DrawString($"P{i}", this.Font, brush, p.X + 6, p.Y - 10);
                }
            }

            if (_puntosCurva.Count >= 2)
            {
                var curveScreenPoints = _puntosCurva
                    .Select(p => WorldToScreen(p, scaleFactor, height))
                    .ToArray();

                using (Pen penCurve = new Pen(Color.Red, 3)) // Curva B-Spline
                {
                    g.DrawLines(penCurve, curveScreenPoints);
                }
            }
        }

        private PointF WorldToScreen(Punto2D pWorld, float scaleFactor, int height)
        {
            float xScreen = pWorld.X * scaleFactor;
            float yScreen = height - (pWorld.Y * scaleFactor);
            return new PointF(xScreen, yScreen);
        }
    }
}