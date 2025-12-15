namespace Curvas_Bezier_y_B_Spline.View
{
    partial class FrmBezierCuadratica
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
            this.pnlGrafico = new System.Windows.Forms.Panel();
            this.txtP0X = new System.Windows.Forms.TextBox();
            this.txtP0Y = new System.Windows.Forms.TextBox();
            this.txtP1X = new System.Windows.Forms.TextBox();
            this.txtP1Y = new System.Windows.Forms.TextBox();
            this.txtP2X = new System.Windows.Forms.TextBox();
            this.txtP2Y = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlGrafico
            // 
            this.pnlGrafico.Location = new System.Drawing.Point(526, 22);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Size = new System.Drawing.Size(595, 576);
            this.pnlGrafico.TabIndex = 0;
            this.pnlGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrafico_Paint);
            this.pnlGrafico.Resize += new System.EventHandler(this.pnlGrafico_Resize);
            // 
            // txtP0X
            // 
            this.txtP0X.Location = new System.Drawing.Point(206, 148);
            this.txtP0X.Name = "txtP0X";
            this.txtP0X.Size = new System.Drawing.Size(100, 26);
            this.txtP0X.TabIndex = 1;
            this.txtP0X.Resize += new System.EventHandler(this.pnlGrafico_Resize);
            // 
            // txtP0Y
            // 
            this.txtP0Y.Location = new System.Drawing.Point(342, 148);
            this.txtP0Y.Name = "txtP0Y";
            this.txtP0Y.Size = new System.Drawing.Size(100, 26);
            this.txtP0Y.TabIndex = 2;
            this.txtP0Y.Resize += new System.EventHandler(this.pnlGrafico_Resize);
            // 
            // txtP1X
            // 
            this.txtP1X.Location = new System.Drawing.Point(206, 198);
            this.txtP1X.Name = "txtP1X";
            this.txtP1X.Size = new System.Drawing.Size(100, 26);
            this.txtP1X.TabIndex = 3;
            this.txtP1X.Resize += new System.EventHandler(this.pnlGrafico_Resize);
            // 
            // txtP1Y
            // 
            this.txtP1Y.Location = new System.Drawing.Point(342, 198);
            this.txtP1Y.Name = "txtP1Y";
            this.txtP1Y.Size = new System.Drawing.Size(100, 26);
            this.txtP1Y.TabIndex = 4;
            this.txtP1Y.Resize += new System.EventHandler(this.pnlGrafico_Resize);
            // 
            // txtP2X
            // 
            this.txtP2X.Location = new System.Drawing.Point(206, 253);
            this.txtP2X.Name = "txtP2X";
            this.txtP2X.Size = new System.Drawing.Size(100, 26);
            this.txtP2X.TabIndex = 5;
            this.txtP2X.Resize += new System.EventHandler(this.pnlGrafico_Resize);
            // 
            // txtP2Y
            // 
            this.txtP2Y.Location = new System.Drawing.Point(342, 253);
            this.txtP2Y.Name = "txtP2Y";
            this.txtP2Y.Size = new System.Drawing.Size(100, 26);
            this.txtP2Y.TabIndex = 6;
            this.txtP2Y.Resize += new System.EventHandler(this.pnlGrafico_Resize);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dibujar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDibujar_Click);
            this.button1.Resize += new System.EventHandler(this.pnlGrafico_Resize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Punto_0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.Resize += new System.EventHandler(this.pnlGrafico_Resize);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "X";
            this.label2.Resize += new System.EventHandler(this.pnlGrafico_Resize);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y";
            this.label3.Resize += new System.EventHandler(this.pnlGrafico_Resize);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Punto_1";
            this.label4.Resize += new System.EventHandler(this.pnlGrafico_Resize);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Punto_2";
            this.label5.Resize += new System.EventHandler(this.pnlGrafico_Resize);
            // 
            // FrmBezierCuadratica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 632);
            this.ControlBox = false;
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
            this.Name = "FrmBezierCuadratica";
            this.Text = "FrmBezierCuadratica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrafico;
        private System.Windows.Forms.TextBox txtP0X;
        private System.Windows.Forms.TextBox txtP0Y;
        private System.Windows.Forms.TextBox txtP1X;
        private System.Windows.Forms.TextBox txtP1Y;
        private System.Windows.Forms.TextBox txtP2X;
        private System.Windows.Forms.TextBox txtP2Y;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}