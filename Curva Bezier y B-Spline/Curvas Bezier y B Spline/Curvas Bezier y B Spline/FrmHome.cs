using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Curvas_Bezier_y_B_Spline.View;

namespace Curvas_Bezier_y_B_Spline
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void bezierCuadraticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form frm in this.MdiChildren)
                {
                frm.Close();
            }
            FrmBezierCuadratica frmBezierCuadratica = new FrmBezierCuadratica();
            frmBezierCuadratica.MdiParent = this;
            frmBezierCuadratica.Dock = DockStyle.Fill;
            frmBezierCuadratica.Show();

        }

        private void bezierCubicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmBezierCubica frmBezierCubica = new FrmBezierCubica();
            frmBezierCubica.MdiParent = this;
            frmBezierCubica.Dock = DockStyle.Fill;
            frmBezierCubica.Show();

        }

        private void bezierGradoNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmBezierGradoN frmBezierGradoN = new FrmBezierGradoN();
            frmBezierGradoN.MdiParent = this;
            frmBezierGradoN.Dock = DockStyle.Fill;
            frmBezierGradoN.Show();
        }

        private void bSplineCoxDeBoorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmBSplineCoxDeBoor frmBSplineCoxDeBoor = new FrmBSplineCoxDeBoor();
            frmBSplineCoxDeBoor.MdiParent = this;
            frmBSplineCoxDeBoor.Dock = DockStyle.Fill;
            frmBSplineCoxDeBoor.Show();

        }

        private void bSplineMatrizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmBSplineMatriz frmBSplineMatriz = new FrmBSplineMatriz();
            frmBSplineMatriz.MdiParent = this;
            frmBSplineMatriz.Dock = DockStyle.Fill;
            frmBSplineMatriz.Show();

        }

        private void bSplineDeCasteljauGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmBSplineDeCasteljauGeneral frmBSplineDeCasteljauGeneral = new FrmBSplineDeCasteljauGeneral();
            frmBSplineDeCasteljauGeneral.MdiParent = this;
            frmBSplineDeCasteljauGeneral.Dock = DockStyle.Fill;
            frmBSplineDeCasteljauGeneral.Show();

        }
    }
}
