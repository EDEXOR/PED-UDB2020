namespace ProyectoPED_Fisica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAnguloVector = new System.Windows.Forms.Label();
            this.lblMagnitudVector = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtValorY = new System.Windows.Forms.TextBox();
            this.txtValorX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResultadoConversion = new System.Windows.Forms.Label();
            this.btnDibujaPolares = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDirecciones = new System.Windows.Forms.ComboBox();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.txtMagnitud = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblAnguloVector);
            this.groupBox1.Controls.Add(this.lblMagnitudVector);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtValorY);
            this.groupBox1.Controls.Add(this.txtValorX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(493, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordenadas Rectangulares";
            // 
            // lblAnguloVector
            // 
            this.lblAnguloVector.AutoSize = true;
            this.lblAnguloVector.Location = new System.Drawing.Point(86, 238);
            this.lblAnguloVector.Name = "lblAnguloVector";
            this.lblAnguloVector.Size = new System.Drawing.Size(22, 21);
            this.lblAnguloVector.TabIndex = 9;
            this.lblAnguloVector.Text = "#";
            // 
            // lblMagnitudVector
            // 
            this.lblMagnitudVector.AutoSize = true;
            this.lblMagnitudVector.Location = new System.Drawing.Point(86, 211);
            this.lblMagnitudVector.Name = "lblMagnitudVector";
            this.lblMagnitudVector.Size = new System.Drawing.Size(22, 21);
            this.lblMagnitudVector.TabIndex = 8;
            this.lblMagnitudVector.Text = "#";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "Ángulo θ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Magnitud: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Conversión Rectangulares a Polares";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dibujar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValorY
            // 
            this.txtValorY.Location = new System.Drawing.Point(140, 83);
            this.txtValorY.Name = "txtValorY";
            this.txtValorY.Size = new System.Drawing.Size(52, 27);
            this.txtValorY.TabIndex = 3;
            this.txtValorY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorY_KeyPress);
            // 
            // txtValorX
            // 
            this.txtValorX.Location = new System.Drawing.Point(140, 45);
            this.txtValorX.Name = "txtValorX";
            this.txtValorX.Size = new System.Drawing.Size(52, 27);
            this.txtValorX.TabIndex = 2;
            this.txtValorX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorX_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coordenada y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coordenada x:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(801, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Longitudes de ejes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(801, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Eje x = 500 unidades";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(801, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Eje y = 600 unidades";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblResultadoConversion);
            this.groupBox2.Controls.Add(this.btnDibujaPolares);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbDirecciones);
            this.groupBox2.Controls.Add(this.txtAngulo);
            this.groupBox2.Controls.Add(this.txtMagnitud);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(762, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 300);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coordenadas Polares";
            // 
            // lblResultadoConversion
            // 
            this.lblResultadoConversion.AutoSize = true;
            this.lblResultadoConversion.Location = new System.Drawing.Point(48, 238);
            this.lblResultadoConversion.Name = "lblResultadoConversion";
            this.lblResultadoConversion.Size = new System.Drawing.Size(152, 21);
            this.lblResultadoConversion.TabIndex = 6;
            this.lblResultadoConversion.Text = "Componente X , Y";
            // 
            // btnDibujaPolares
            // 
            this.btnDibujaPolares.Location = new System.Drawing.Point(52, 158);
            this.btnDibujaPolares.Name = "btnDibujaPolares";
            this.btnDibujaPolares.Size = new System.Drawing.Size(98, 31);
            this.btnDibujaPolares.TabIndex = 5;
            this.btnDibujaPolares.Text = "Dibujar";
            this.btnDibujaPolares.UseVisualStyleBackColor = true;
            this.btnDibujaPolares.Click += new System.EventHandler(this.btnDibujaPolares_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Conversión Polares a Rectagulares";
            // 
            // cmbDirecciones
            // 
            this.cmbDirecciones.FormattingEnabled = true;
            this.cmbDirecciones.Items.AddRange(new object[] {
            "al Norte del Este",
            "al Norte del Oeste",
            "al Este del Norte",
            "al Oeste del Norte",
            "al Sur del Este",
            "al Sur del Oeste",
            "al Este del Sur",
            "al Oeste del Sur",
            "Noreste",
            "Noroeste",
            "Sureste",
            "Suroeste"});
            this.cmbDirecciones.Location = new System.Drawing.Point(38, 115);
            this.cmbDirecciones.Name = "cmbDirecciones";
            this.cmbDirecciones.Size = new System.Drawing.Size(121, 29);
            this.cmbDirecciones.TabIndex = 4;
            this.cmbDirecciones.SelectedIndexChanged += new System.EventHandler(this.cmbDirecciones_SelectedIndexChanged);
            // 
            // txtAngulo
            // 
            this.txtAngulo.Location = new System.Drawing.Point(112, 82);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(64, 27);
            this.txtAngulo.TabIndex = 3;
            this.txtAngulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAngulo_KeyPress);
            // 
            // txtMagnitud
            // 
            this.txtMagnitud.Location = new System.Drawing.Point(112, 46);
            this.txtMagnitud.Name = "txtMagnitud";
            this.txtMagnitud.Size = new System.Drawing.Size(64, 27);
            this.txtMagnitud.TabIndex = 2;
            this.txtMagnitud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMagnitud_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ángulo θ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Magnitud:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficando Vectores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtValorY;
        private System.Windows.Forms.TextBox txtValorX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.TextBox txtMagnitud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDirecciones;
        private System.Windows.Forms.Button btnDibujaPolares;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblResultadoConversion;
        private System.Windows.Forms.Label lblAnguloVector;
        private System.Windows.Forms.Label lblMagnitudVector;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

