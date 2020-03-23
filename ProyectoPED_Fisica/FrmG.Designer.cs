namespace ProyectoPED_Fisica
{
    partial class FrmG
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmG));
            this.AreaDatos = new System.Windows.Forms.Panel();
            this.txtResultante = new System.Windows.Forms.TextBox();
            this.btnResultante = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIngresar = new System.Windows.Forms.Button();
            this.txtangulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmagnitud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBoperaciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AreaGrafica = new System.Windows.Forms.Panel();
            this.EPvalidaciones = new System.Windows.Forms.ErrorProvider(this.components);
            this.AreaDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPvalidaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // AreaDatos
            // 
            this.AreaDatos.BackColor = System.Drawing.Color.Transparent;
            this.AreaDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AreaDatos.BackgroundImage")));
            this.AreaDatos.Controls.Add(this.txtResultante);
            this.AreaDatos.Controls.Add(this.btnResultante);
            this.AreaDatos.Controls.Add(this.groupBox1);
            this.AreaDatos.Controls.Add(this.CBoperaciones);
            this.AreaDatos.Controls.Add(this.label1);
            this.AreaDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.AreaDatos.Location = new System.Drawing.Point(0, 0);
            this.AreaDatos.Name = "AreaDatos";
            this.AreaDatos.Size = new System.Drawing.Size(263, 486);
            this.AreaDatos.TabIndex = 0;
            this.AreaDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.AreaDatos_Paint);
            // 
            // txtResultante
            // 
            this.txtResultante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultante.Location = new System.Drawing.Point(20, 375);
            this.txtResultante.Multiline = true;
            this.txtResultante.Name = "txtResultante";
            this.txtResultante.ReadOnly = true;
            this.txtResultante.Size = new System.Drawing.Size(210, 99);
            this.txtResultante.TabIndex = 6;
            this.txtResultante.Visible = false;
            // 
            // btnResultante
            // 
            this.btnResultante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultante.Location = new System.Drawing.Point(61, 335);
            this.btnResultante.Name = "btnResultante";
            this.btnResultante.Size = new System.Drawing.Size(126, 34);
            this.btnResultante.TabIndex = 5;
            this.btnResultante.Text = "Obtener resultante";
            this.btnResultante.UseVisualStyleBackColor = true;
            this.btnResultante.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIngresar);
            this.groupBox1.Controls.Add(this.txtangulo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtmagnitud);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 191);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtIngresar
            // 
            this.txtIngresar.Location = new System.Drawing.Point(51, 133);
            this.txtIngresar.Name = "txtIngresar";
            this.txtIngresar.Size = new System.Drawing.Size(87, 43);
            this.txtIngresar.TabIndex = 4;
            this.txtIngresar.Text = "Ingresar";
            this.txtIngresar.UseVisualStyleBackColor = true;
            this.txtIngresar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtangulo
            // 
            this.txtangulo.Location = new System.Drawing.Point(41, 101);
            this.txtangulo.Name = "txtangulo";
            this.txtangulo.Size = new System.Drawing.Size(100, 26);
            this.txtangulo.TabIndex = 3;
            this.txtangulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtangulo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ángulo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtmagnitud
            // 
            this.txtmagnitud.Location = new System.Drawing.Point(41, 43);
            this.txtmagnitud.Name = "txtmagnitud";
            this.txtmagnitud.Size = new System.Drawing.Size(100, 26);
            this.txtmagnitud.TabIndex = 1;
            this.txtmagnitud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmagnitud_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Magnitud:";
            // 
            // CBoperaciones
            // 
            this.CBoperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoperaciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoperaciones.FormattingEnabled = true;
            this.CBoperaciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multilicación"});
            this.CBoperaciones.Location = new System.Drawing.Point(61, 54);
            this.CBoperaciones.Name = "CBoperaciones";
            this.CBoperaciones.Size = new System.Drawing.Size(148, 26);
            this.CBoperaciones.TabIndex = 1;
            this.CBoperaciones.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operación:";
            this.label1.Visible = false;
            // 
            // AreaGrafica
            // 
            this.AreaGrafica.BackColor = System.Drawing.Color.DimGray;
            this.AreaGrafica.Location = new System.Drawing.Point(263, 0);
            this.AreaGrafica.Name = "AreaGrafica";
            this.AreaGrafica.Size = new System.Drawing.Size(855, 487);
            this.AreaGrafica.TabIndex = 1;
            this.AreaGrafica.Paint += new System.Windows.Forms.PaintEventHandler(this.AreaGrafica_Paint);
            // 
            // EPvalidaciones
            // 
            this.EPvalidaciones.ContainerControl = this;
            // 
            // FrmG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 486);
            this.Controls.Add(this.AreaGrafica);
            this.Controls.Add(this.AreaDatos);
            this.Name = "FrmG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AreaDatos.ResumeLayout(false);
            this.AreaDatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPvalidaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AreaDatos;
        private System.Windows.Forms.ComboBox CBoperaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultante;
        private System.Windows.Forms.Button btnResultante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txtIngresar;
        private System.Windows.Forms.TextBox txtangulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmagnitud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel AreaGrafica;
        private System.Windows.Forms.ErrorProvider EPvalidaciones;
    }
}

