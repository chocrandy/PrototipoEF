namespace CapaVistaFRM
{
    partial class nominaEncab
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
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.Dtp_final = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Dtp_inicial = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Cbo_nomina = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_siguiente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_valor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Cbo_concepto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbo_empleado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Gpb_datos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "NÓMINA";
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.Controls.Add(this.Dtp_final);
            this.Gpb_datos.Controls.Add(this.label3);
            this.Gpb_datos.Controls.Add(this.Dtp_inicial);
            this.Gpb_datos.Controls.Add(this.label5);
            this.Gpb_datos.Controls.Add(this.Cbo_nomina);
            this.Gpb_datos.Controls.Add(this.label2);
            this.Gpb_datos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datos.Location = new System.Drawing.Point(25, 73);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Size = new System.Drawing.Size(680, 108);
            this.Gpb_datos.TabIndex = 4;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Encabezado";
            // 
            // Dtp_final
            // 
            this.Dtp_final.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_final.CustomFormat = "yyyy-MM-dd";
            this.Dtp_final.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_final.Location = new System.Drawing.Point(458, 56);
            this.Dtp_final.Name = "Dtp_final";
            this.Dtp_final.Size = new System.Drawing.Size(180, 27);
            this.Dtp_final.TabIndex = 43;
            this.Dtp_final.Value = new System.DateTime(2020, 4, 18, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Fecha Final:";
            // 
            // Dtp_inicial
            // 
            this.Dtp_inicial.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_inicial.CustomFormat = "yyyy-MM-dd";
            this.Dtp_inicial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_inicial.Location = new System.Drawing.Point(237, 56);
            this.Dtp_inicial.Name = "Dtp_inicial";
            this.Dtp_inicial.Size = new System.Drawing.Size(178, 27);
            this.Dtp_inicial.TabIndex = 41;
            this.Dtp_inicial.Value = new System.DateTime(2020, 4, 18, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Fecha Inicial:";
            // 
            // Cbo_nomina
            // 
            this.Cbo_nomina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_nomina.FormattingEnabled = true;
            this.Cbo_nomina.Location = new System.Drawing.Point(25, 54);
            this.Cbo_nomina.Name = "Cbo_nomina";
            this.Cbo_nomina.Size = new System.Drawing.Size(178, 29);
            this.Cbo_nomina.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código de Nómina:";
            // 
            // Btn_siguiente
            // 
            this.Btn_siguiente.BackColor = System.Drawing.Color.White;
            this.Btn_siguiente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_siguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_siguiente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_siguiente.ForeColor = System.Drawing.Color.Black;
            this.Btn_siguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_siguiente.Location = new System.Drawing.Point(561, 332);
            this.Btn_siguiente.Name = "Btn_siguiente";
            this.Btn_siguiente.Size = new System.Drawing.Size(130, 47);
            this.Btn_siguiente.TabIndex = 37;
            this.Btn_siguiente.Text = "Registrar >>";
            this.Btn_siguiente.UseVisualStyleBackColor = false;
            this.Btn_siguiente.Click += new System.EventHandler(this.Btn_siguiente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_valor);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Cbo_concepto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Cbo_empleado);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 108);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // Txt_valor
            // 
            this.Txt_valor.Location = new System.Drawing.Point(459, 54);
            this.Txt_valor.Name = "Txt_valor";
            this.Txt_valor.Size = new System.Drawing.Size(179, 27);
            this.Txt_valor.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(455, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 19);
            this.label12.TabIndex = 42;
            this.label12.Text = "Valor:";
            // 
            // Cbo_concepto
            // 
            this.Cbo_concepto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_concepto.FormattingEnabled = true;
            this.Cbo_concepto.Location = new System.Drawing.Point(237, 54);
            this.Cbo_concepto.Name = "Cbo_concepto";
            this.Cbo_concepto.Size = new System.Drawing.Size(178, 29);
            this.Cbo_concepto.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Concepto:";
            // 
            // Cbo_empleado
            // 
            this.Cbo_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_empleado.FormattingEnabled = true;
            this.Cbo_empleado.Location = new System.Drawing.Point(25, 54);
            this.Cbo_empleado.Name = "Cbo_empleado";
            this.Cbo_empleado.Size = new System.Drawing.Size(178, 29);
            this.Cbo_empleado.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Empleado:";
            // 
            // nominaEncab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_siguiente);
            this.Controls.Add(this.Gpb_datos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "nominaEncab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nómina";
            this.Load += new System.EventHandler(this.Mov_banc_encabezado_Load);
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gpb_datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_nomina;
        private System.Windows.Forms.Button Btn_siguiente;
        private System.Windows.Forms.DateTimePicker Dtp_final;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Dtp_inicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Cbo_concepto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbo_empleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_valor;
        private System.Windows.Forms.Label label12;
    }
}