using Curvas_Bezier_y_B_Spline.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvas_Bezier_y_B_Spline.View
{
    public partial class FrmBezierCuadratica : Form
    {
        private const float WORLD_SIZE = 100.0f;
        private List<Punto> _puntosCurva = new List<Punto>();
        private List<Punto> _puntosControl = new List<Punto>();

        public FrmBezierCuadratica()
        {
            InitializeComponent();
           
            this.pnlGrafico.Paint += new PaintEventHandler(pnlGrafico_Paint);
            this.pnlGrafico.Resize += new EventHandler(pnlGrafico_Resize);

            txtP0X.Text = "10"; txtP0Y.Text = "10";
            txtP1X.Text = "50"; txtP1Y.Text = "80";
            txtP2X.Text = "90"; txtP2Y.Text = "10";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Leer y validar puntos de control
                _puntosControl = LeerPuntosDeControl();

                // 2. Generar la curva utilizando la lógica modular
                _puntosCurva = BezierCuadratica.GenerarCurva(_puntosControl);

                // 3. Forzar el redibujo del panel
                pnlGrafico.Invalidate();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error de entrada: " + ex.Message, "Error de Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _puntosControl.Clear();
                _puntosCurva.Clear();
                pnlGrafico.Invalidate();
            }
        }

        private List<Punto> LeerPuntosDeControl()
        {
            var puntos = new List<Punto>();

            var inputs = new Dictionary<string, (TextBox X, TextBox Y)>
            {
                {"P0", (txtP0X, txtP0Y)},
                {"P1", (txtP1X, txtP1Y)},
                {"P2", (txtP2X, txtP2Y)}
            };

            foreach (var kvp in inputs)
            {
                if (string.IsNullOrWhiteSpace(kvp.Value.X.Text) || string.IsNullOrWhiteSpace(kvp.Value.Y.Text))
                {
                    throw new Exception($"Las coordenadas de {kvp.Key} no pueden estar vacías.");
                }

                if (!float.TryParse(kvp.Value.X.Text, out float x) || !float.TryParse(kvp.Value.Y.Text, out float y))
                {
                    throw new Exception($"Las coordenadas de {kvp.Key} deben ser números válidos.");
                }

                if (x < 0 || y < 0)
                {
                    // Validación solicitada: no negativos
                    throw new Exception($"Las coordenadas no pueden ser negativas.");
                }

                puntos.Add(new Punto(x, y));
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
            int step = 10; 
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

            using (Brush brush = new SolidBrush(Color.Red))
            {
                for (int i = 0; i < screenPoints.Length; i++)
                {
                    PointF p = screenPoints[i];
                    // Dibujar círculo (8x8 píxeles)
                    g.FillEllipse(brush, p.X - 4, p.Y - 4, 8, 8);
                    // Etiqueta Px
                    g.DrawString($"P{i}", this.Font, brush, p.X + 6, p.Y - 10);
                }
            }

             if (_puntosCurva.Count >= 2)
            {
                var curveScreenPoints = _puntosCurva
                    .Select(p => WorldToScreen(p, scaleFactor, height))
                    .ToArray();

                using (Pen penCurve = new Pen(Color.Blue, 2))
                {
                    // Dibuja la curva, el número de segmentos (100) la hará suave
                    g.DrawLines(penCurve, curveScreenPoints);
                }
            }
        }

         private PointF WorldToScreen(Punto pWorld, float scaleFactor, int height)
        {
            float xScreen = pWorld.X * scaleFactor;
            float yScreen = height - (pWorld.Y * scaleFactor);
            return new PointF(xScreen, yScreen);
        }
    }
}