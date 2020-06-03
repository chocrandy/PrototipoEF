namespace CapaVistaFRM
{
    partial class renta_encab
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
            this.Gpb_encabezado = new System.Windows.Forms.GroupBox();
            this.txt_codEncab = new System.Windows.Forms.TextBox();
            this.Cbo_empleado = new System.Windows.Forms.ComboBox();
            this.Dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.Dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.Cbo_membresia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_siguiente = new System.Windows.Forms.Button();
            this.Gpb_encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Encabezado de Renta";
            // 
            // Gpb_encabezado
            // 
            this.Gpb_encabezado.Controls.Add(this.txt_codEncab);
            this.Gpb_encabezado.Controls.Add(this.Cbo_empleado);
            this.Gpb_encabezado.Controls.Add(this.Dtp_fin);
            this.Gpb_encabezado.Controls.Add(this.Dtp_inicio);
            this.Gpb_encabezado.Controls.Add(this.Cbo_membresia);
            this.Gpb_encabezado.Controls.Add(this.label6);
            this.Gpb_encabezado.Controls.Add(this.label5);
            this.Gpb_encabezado.Controls.Add(this.label4);
            this.Gpb_encabezado.Controls.Add(this.label3);
            this.Gpb_encabezado.Controls.Add(this.label2);
            this.Gpb_encabezado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_encabezado.Location = new System.Drawing.Point(18, 91);
            this.Gpb_encabezado.Name = "Gpb_encabezado";
            this.Gpb_encabezado.Size = new System.Drawing.Size(616, 198);
            this.Gpb_encabezado.TabIndex = 4;
            this.Gpb_encabezado.TabStop = false;
            this.Gpb_encabezado.Text = "Encabezado de la Renta";
            // 
            // txt_codEncab
            // 
            this.txt_codEncab.Enabled = false;
            this.txt_codEncab.Location = new System.Drawing.Point(27, 60);
            this.txt_codEncab.Name = "txt_codEncab";
            this.txt_codEncab.Size = new System.Drawing.Size(145, 27);
            this.txt_codEncab.TabIndex = 21;
            // 
            // Cbo_empleado
            // 
            this.Cbo_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_empleado.FormattingEnabled = true;
            this.Cbo_empleado.Location = new System.Drawing.Point(341, 137);
            this.Cbo_empleado.Name = "Cbo_empleado";
            this.Cbo_empleado.Size = new System.Drawing.Size(219, 29);
            this.Cbo_empleado.TabIndex = 12;
            // 
            // Dtp_fin
            // 
            this.Dtp_fin.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fin.CustomFormat = "yyyy-MM-dd";
            this.Dtp_fin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fin.Location = new System.Drawing.Point(422, 60);
            this.Dtp_fin.Name = "Dtp_fin";
            this.Dtp_fin.Size = new System.Drawing.Size(171, 27);
            this.Dtp_fin.TabIndex = 16;
            this.Dtp_fin.Value = new System.DateTime(2020, 4, 17, 0, 0, 0, 0);
            // 
            // Dtp_inicio
            // 
            this.Dtp_inicio.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_inicio.CustomFormat = "yyyy-MM-dd";
            this.Dtp_inicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_inicio.Location = new System.Drawing.Point(218, 60);
            this.Dtp_inicio.Name = "Dtp_inicio";
            this.Dtp_inicio.Size = new System.Drawing.Size(164, 27);
            this.Dtp_inicio.TabIndex = 15;
            this.Dtp_inicio.Value = new System.DateTime(2020, 4, 17, 0, 0, 0, 0);
            // 
            // Cbo_membresia
            // 
            this.Cbo_membresia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_membresia.FormattingEnabled = true;
            this.Cbo_membresia.Location = new System.Drawing.Point(83, 137);
            this.Cbo_membresia.Name = "Cbo_membresia";
            this.Cbo_membresia.Size = new System.Drawing.Size(200, 29);
            this.Cbo_membresia.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(418, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha de Devolución";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha de Renta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente (Membresia)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cod. Encabezado";
            // 
            // Btn_siguiente
            // 
            this.Btn_siguiente.BackColor = System.Drawing.Color.White;
            this.Btn_siguiente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_siguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_siguiente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_siguiente.ForeColor = System.Drawing.Color.Black;
            this.Btn_siguiente.Location = new System.Drawing.Point(466, 311);
            this.Btn_siguiente.Name = "Btn_siguiente";
            this.Btn_siguiente.Size = new System.Drawing.Size(143, 47);
            this.Btn_siguiente.TabIndex = 37;
            this.Btn_siguiente.Text = "Siguiente >>";
            this.Btn_siguiente.UseVisualStyleBackColor = false;
            this.Btn_siguiente.Click += new System.EventHandler(this.Btn_siguiente_Click);
            // 
            // renta_encab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(646, 377);
            this.Controls.Add(this.Btn_siguiente);
            this.Controls.Add(this.Gpb_encabezado);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "renta_encab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encabezado de Renta";
            this.Load += new System.EventHandler(this.Renta_encab_Load);
            this.Gpb_encabezado.ResumeLayout(false);
            this.Gpb_encabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gpb_encabezado;
        private System.Windows.Forms.TextBox txt_codEncab;
        private System.Windows.Forms.ComboBox Cbo_empleado;
        private System.Windows.Forms.DateTimePicker Dtp_fin;
        private System.Windows.Forms.DateTimePicker Dtp_inicio;
        private System.Windows.Forms.ComboBox Cbo_membresia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_siguiente;
    }
}