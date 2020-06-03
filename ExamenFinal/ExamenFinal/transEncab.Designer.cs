namespace CapaVistaFRM
{
    partial class transEncab
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
            this.Gpb_detalleMov = new System.Windows.Forms.GroupBox();
            this.Dgv_nomina = new System.Windows.Forms.DataGridView();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.Cbo_nomina = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_pagar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_conceptos = new System.Windows.Forms.Label();
            this.Lbl_empleados = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_totalT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Gpb_detalleMov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_nomina)).BeginInit();
            this.Gpb_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transferencia Bancaria";
            // 
            // Gpb_detalleMov
            // 
            this.Gpb_detalleMov.Controls.Add(this.Dgv_nomina);
            this.Gpb_detalleMov.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_detalleMov.ForeColor = System.Drawing.Color.Black;
            this.Gpb_detalleMov.Location = new System.Drawing.Point(12, 176);
            this.Gpb_detalleMov.Name = "Gpb_detalleMov";
            this.Gpb_detalleMov.Size = new System.Drawing.Size(680, 196);
            this.Gpb_detalleMov.TabIndex = 29;
            this.Gpb_detalleMov.TabStop = false;
            this.Gpb_detalleMov.Text = "Detalle de Nóminas";
            // 
            // Dgv_nomina
            // 
            this.Dgv_nomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_nomina.Location = new System.Drawing.Point(15, 31);
            this.Dgv_nomina.Name = "Dgv_nomina";
            this.Dgv_nomina.Size = new System.Drawing.Size(643, 147);
            this.Dgv_nomina.TabIndex = 29;
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.BackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.ForeColor = System.Drawing.Color.Black;
            this.Btn_consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultar.Location = new System.Drawing.Point(490, 35);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(149, 42);
            this.Btn_consultar.TabIndex = 37;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.UseVisualStyleBackColor = false;
            this.Btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.Controls.Add(this.Cbo_nomina);
            this.Gpb_datos.Controls.Add(this.Btn_consultar);
            this.Gpb_datos.Controls.Add(this.label7);
            this.Gpb_datos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datos.Location = new System.Drawing.Point(12, 54);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Size = new System.Drawing.Size(680, 99);
            this.Gpb_datos.TabIndex = 36;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Nómina a Pagar";
            // 
            // Cbo_nomina
            // 
            this.Cbo_nomina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_nomina.FormattingEnabled = true;
            this.Cbo_nomina.Location = new System.Drawing.Point(219, 43);
            this.Cbo_nomina.Name = "Cbo_nomina";
            this.Cbo_nomina.Size = new System.Drawing.Size(178, 29);
            this.Cbo_nomina.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Código de Nómina:";
            // 
            // Btn_pagar
            // 
            this.Btn_pagar.BackColor = System.Drawing.Color.White;
            this.Btn_pagar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_pagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_pagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_pagar.ForeColor = System.Drawing.Color.Black;
            this.Btn_pagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_pagar.Location = new System.Drawing.Point(416, 433);
            this.Btn_pagar.Name = "Btn_pagar";
            this.Btn_pagar.Size = new System.Drawing.Size(208, 34);
            this.Btn_pagar.TabIndex = 38;
            this.Btn_pagar.Text = "Pagar";
            this.Btn_pagar.UseVisualStyleBackColor = false;
            this.Btn_pagar.Click += new System.EventHandler(this.Btn_pagar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Conceptos: ";
            // 
            // Lbl_conceptos
            // 
            this.Lbl_conceptos.AutoSize = true;
            this.Lbl_conceptos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_conceptos.Location = new System.Drawing.Point(206, 437);
            this.Lbl_conceptos.Name = "Lbl_conceptos";
            this.Lbl_conceptos.Size = new System.Drawing.Size(51, 24);
            this.Lbl_conceptos.TabIndex = 40;
            this.Lbl_conceptos.Text = "0.00";
            // 
            // Lbl_empleados
            // 
            this.Lbl_empleados.AutoSize = true;
            this.Lbl_empleados.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_empleados.Location = new System.Drawing.Point(206, 398);
            this.Lbl_empleados.Name = "Lbl_empleados";
            this.Lbl_empleados.Size = new System.Drawing.Size(51, 24);
            this.Lbl_empleados.TabIndex = 42;
            this.Lbl_empleados.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Empleados: ";
            // 
            // Lbl_totalT
            // 
            this.Lbl_totalT.AutoSize = true;
            this.Lbl_totalT.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_totalT.Location = new System.Drawing.Point(512, 392);
            this.Lbl_totalT.Name = "Lbl_totalT";
            this.Lbl_totalT.Size = new System.Drawing.Size(51, 24);
            this.Lbl_totalT.TabIndex = 44;
            this.Lbl_totalT.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 43;
            this.label6.Text = "Total: ";
            // 
            // transEncab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 492);
            this.Controls.Add(this.Lbl_totalT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Lbl_empleados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_conceptos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_pagar);
            this.Controls.Add(this.Gpb_datos);
            this.Controls.Add(this.Gpb_detalleMov);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "transEncab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencia Bancaria - Consulta";
            this.Load += new System.EventHandler(this.TransEncab_Load);
            this.Gpb_detalleMov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_nomina)).EndInit();
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gpb_detalleMov;
        private System.Windows.Forms.DataGridView Dgv_nomina;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.GroupBox Gpb_datos;
        private System.Windows.Forms.ComboBox Cbo_nomina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_pagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_conceptos;
        private System.Windows.Forms.Label Lbl_empleados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_totalT;
        private System.Windows.Forms.Label label6;
    }
}