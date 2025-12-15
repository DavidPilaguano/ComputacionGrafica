namespace Curvas_Bezier_y_B_Spline
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bezierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSplineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezierCuadraticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezierCubicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezierGradoNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSplineCoxDeBoorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSplineMatrizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSplineDeCasteljauGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bezierToolStripMenuItem,
            this.bSplineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bezierToolStripMenuItem
            // 
            this.bezierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bezierCuadraticaToolStripMenuItem,
            this.bezierCubicaToolStripMenuItem,
            this.bezierGradoNToolStripMenuItem});
            this.bezierToolStripMenuItem.Name = "bezierToolStripMenuItem";
            this.bezierToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.bezierToolStripMenuItem.Text = "Bezier";
            // 
            // bSplineToolStripMenuItem
            // 
            this.bSplineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSplineCoxDeBoorToolStripMenuItem,
            this.bSplineMatrizToolStripMenuItem,
            this.bSplineDeCasteljauGeneralToolStripMenuItem});
            this.bSplineToolStripMenuItem.Name = "bSplineToolStripMenuItem";
            this.bSplineToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.bSplineToolStripMenuItem.Text = "B-Spline";
            // 
            // bezierCuadraticaToolStripMenuItem
            // 
            this.bezierCuadraticaToolStripMenuItem.Name = "bezierCuadraticaToolStripMenuItem";
            this.bezierCuadraticaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.bezierCuadraticaToolStripMenuItem.Text = "Bezier Cuadratica";
            this.bezierCuadraticaToolStripMenuItem.Click += new System.EventHandler(this.bezierCuadraticaToolStripMenuItem_Click);
            // 
            // bezierCubicaToolStripMenuItem
            // 
            this.bezierCubicaToolStripMenuItem.Name = "bezierCubicaToolStripMenuItem";
            this.bezierCubicaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.bezierCubicaToolStripMenuItem.Text = "Bezier Cubica";
            this.bezierCubicaToolStripMenuItem.Click += new System.EventHandler(this.bezierCubicaToolStripMenuItem_Click);
            // 
            // bezierGradoNToolStripMenuItem
            // 
            this.bezierGradoNToolStripMenuItem.Name = "bezierGradoNToolStripMenuItem";
            this.bezierGradoNToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.bezierGradoNToolStripMenuItem.Text = "Bezier Grado n";
            this.bezierGradoNToolStripMenuItem.Click += new System.EventHandler(this.bezierGradoNToolStripMenuItem_Click);
            // 
            // bSplineCoxDeBoorToolStripMenuItem
            // 
            this.bSplineCoxDeBoorToolStripMenuItem.Name = "bSplineCoxDeBoorToolStripMenuItem";
            this.bSplineCoxDeBoorToolStripMenuItem.Size = new System.Drawing.Size(337, 34);
            this.bSplineCoxDeBoorToolStripMenuItem.Text = "B Spline CoxDeBoor";
            this.bSplineCoxDeBoorToolStripMenuItem.Click += new System.EventHandler(this.bSplineCoxDeBoorToolStripMenuItem_Click);
            // 
            // bSplineMatrizToolStripMenuItem
            // 
            this.bSplineMatrizToolStripMenuItem.Name = "bSplineMatrizToolStripMenuItem";
            this.bSplineMatrizToolStripMenuItem.Size = new System.Drawing.Size(337, 34);
            this.bSplineMatrizToolStripMenuItem.Text = "B_Spline_Matriz";
            this.bSplineMatrizToolStripMenuItem.Click += new System.EventHandler(this.bSplineMatrizToolStripMenuItem_Click);
            // 
            // bSplineDeCasteljauGeneralToolStripMenuItem
            // 
            this.bSplineDeCasteljauGeneralToolStripMenuItem.Name = "bSplineDeCasteljauGeneralToolStripMenuItem";
            this.bSplineDeCasteljauGeneralToolStripMenuItem.Size = new System.Drawing.Size(337, 34);
            this.bSplineDeCasteljauGeneralToolStripMenuItem.Text = "B_Spline_DeCasteljauGeneral";
            this.bSplineDeCasteljauGeneralToolStripMenuItem.Click += new System.EventHandler(this.bSplineDeCasteljauGeneralToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 800);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bezierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bezierCuadraticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bezierCubicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bezierGradoNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bSplineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bSplineCoxDeBoorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bSplineMatrizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bSplineDeCasteljauGeneralToolStripMenuItem;
    }
}