namespace Curvas_Bezier_y_B_Spline.View
{
    partial class FrmBezierGradoN
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPuntosControl = new System.Windows.Forms.TextBox();
            this.pnlGrafico = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Puntos separados por;";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 36;
            this.button1.Text = "Dibujar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // txtPuntosControl
            // 
            this.txtPuntosControl.Location = new System.Drawing.Point(12, 294);
            this.txtPuntosControl.Name = "txtPuntosControl";
            this.txtPuntosControl.Size = new System.Drawing.Size(287, 26);
            this.txtPuntosControl.TabIndex = 30;
            // 
            // pnlGrafico
            // 
            this.pnlGrafico.Location = new System.Drawing.Point(455, 43);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Size = new System.Drawing.Size(595, 576);
            this.pnlGrafico.TabIndex = 29;
            this.pnlGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrafico_Paint);
            this.pnlGrafico.Resize += new System.EventHandler(this.pnlGrafico_Resize);
            // 
            // FrmBezierGradoN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 663);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPuntosControl);
            this.Controls.Add(this.pnlGrafico);
            this.Name = "FrmBezierGradoN";
            this.Text = "FrmBezierGradoN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPuntosControl;
        private System.Windows.Forms.Panel pnlGrafico;
    }
}