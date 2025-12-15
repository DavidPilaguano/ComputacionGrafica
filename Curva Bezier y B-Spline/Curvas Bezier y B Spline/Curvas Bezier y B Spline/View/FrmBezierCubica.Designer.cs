namespace Curvas_Bezier_y_B_Spline.View
{
    partial class FrmBezierCubica
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtP2Y = new System.Windows.Forms.TextBox();
            this.txtP2X = new System.Windows.Forms.TextBox();
            this.txtP1Y = new System.Windows.Forms.TextBox();
            this.txtP1X = new System.Windows.Forms.TextBox();
            this.txtP0Y = new System.Windows.Forms.TextBox();
            this.txtP0X = new System.Windows.Forms.TextBox();
            this.pnlGrafico = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtP3X = new System.Windows.Forms.TextBox();
            this.txtP3Y = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Punto_2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Punto_1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Punto_0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "Dibujar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // txtP2Y
            // 
            this.txtP2Y.Location = new System.Drawing.Point(322, 243);
            this.txtP2Y.Name = "txtP2Y";
            this.txtP2Y.Size = new System.Drawing.Size(100, 26);
            this.txtP2Y.TabIndex = 19;
            // 
            // txtP2X
            // 
            this.txtP2X.Location = new System.Drawing.Point(186, 243);
            this.txtP2X.Name = "txtP2X";
            this.txtP2X.Size = new System.Drawing.Size(100, 26);
            this.txtP2X.TabIndex = 18;
            // 
            // txtP1Y
            // 
            this.txtP1Y.Location = new System.Drawing.Point(322, 188);
            this.txtP1Y.Name = "txtP1Y";
            this.txtP1Y.Size = new System.Drawing.Size(100, 26);
            this.txtP1Y.TabIndex = 17;
            // 
            // txtP1X
            // 
            this.txtP1X.Location = new System.Drawing.Point(186, 188);
            this.txtP1X.Name = "txtP1X";
            this.txtP1X.Size = new System.Drawing.Size(100, 26);
            this.txtP1X.TabIndex = 16;
            // 
            // txtP0Y
            // 
            this.txtP0Y.Location = new System.Drawing.Point(322, 138);
            this.txtP0Y.Name = "txtP0Y";
            this.txtP0Y.Size = new System.Drawing.Size(100, 26);
            this.txtP0Y.TabIndex = 15;
            // 
            // txtP0X
            // 
            this.txtP0X.Location = new System.Drawing.Point(186, 138);
            this.txtP0X.Name = "txtP0X";
            this.txtP0X.Size = new System.Drawing.Size(100, 26);
            this.txtP0X.TabIndex = 14;
            // 
            // pnlGrafico
            // 
            this.pnlGrafico.Location = new System.Drawing.Point(506, 12);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Size = new System.Drawing.Size(595, 576);
            this.pnlGrafico.TabIndex = 13;
            this.pnlGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrafico_Paint);
            this.pnlGrafico.Resize += new System.EventHandler(this.pnlGrafico_Resize);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Punto_3";
            // 
            // txtP3X
            // 
            this.txtP3X.Location = new System.Drawing.Point(186, 295);
            this.txtP3X.Name = "txtP3X";
            this.txtP3X.Size = new System.Drawing.Size(100, 26);
            this.txtP3X.TabIndex = 27;
            // 
            // txtP3Y
            // 
            this.txtP3Y.Location = new System.Drawing.Point(322, 295);
            this.txtP3Y.Name = "txtP3Y";
            this.txtP3Y.Size = new System.Drawing.Size(100, 26);
            this.txtP3Y.TabIndex = 28;
            // 
            // FrmBezierCubica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 615);
            this.ControlBox = false;
            this.Controls.Add(this.txtP3Y);
            this.Controls.Add(this.txtP3X);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtP2Y);
            this.Controls.Add(this.txtP2X);
            this.Controls.Add(this.txtP1Y);
            this.Controls.Add(this.txtP1X);
            this.Controls.Add(this.txtP0Y);
            this.Controls.Add(this.txtP0X);
            this.Controls.Add(this.pnlGrafico);
            this.Name = "FrmBezierCubica";
            this.Text = "FrmBezierCubica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtP2Y;
        private System.Windows.Forms.TextBox txtP2X;
        private System.Windows.Forms.TextBox txtP1Y;
        private System.Windows.Forms.TextBox txtP1X;
        private System.Windows.Forms.TextBox txtP0Y;
        private System.Windows.Forms.TextBox txtP0X;
        private System.Windows.Forms.Panel pnlGrafico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtP3X;
        private System.Windows.Forms.TextBox txtP3Y;
    }
}