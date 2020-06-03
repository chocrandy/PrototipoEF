using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace CapaVistaFRM
{
    public partial class transEncab : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=ERP");
        public transEncab()
        {
            InitializeComponent();
            llenarComboNomina();
        }
        //SELECT SUM(A.`sueldo_empleado`) FROM `empleado` A, `nominad` B WHERE A.`codigo_empleado`= B.`codigo_empleado` AND B.`codigo_nomina`='N0420' AND A.`estado`=1 GROUP BY A.`codigo_empleado`

        void sumaEmpleados(String nomina)
        {
            try
            {
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT SUM(A.`sueldo_empleado`) FROM `empleado` A, `nominad` B " +
                    "WHERE A.`codigo_empleado`= B.`codigo_empleado` " +
                    "AND B.`codigo_nomina`='" + nomina + "' " +
                    "AND A.`estado`=1 GROUP BY A.`codigo_empleado`", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Lbl_empleados.Text = reader.GetValue(0).ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        void sumaNomina(String nomina)
        {
            try
            {                
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT SUM(`valor_nominaD`) FROM `nominad` " +
                    "WHERE `codigo_nomina`='" + nomina + "'", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Lbl_conceptos.Text = reader.GetValue(0).ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        void llenarDataGrid(String nominaS)
        {
            //llenado de DataGrid Renta Detalle
            OdbcCommand cod = new OdbcCommand();
            cod.Connection = conn;
            cod.CommandText = ("SELECT `codigo_empleado`, `codigo_concepto`, `valor_nominaD` FROM `nominad` " +
                "WHERE `codigo_nomina`='" + nominaS + "'");
            try
            {
                OdbcDataAdapter eje = new OdbcDataAdapter();
                eje.SelectCommand = cod;
                DataTable datos = new DataTable();
                eje.Fill(datos);
                Dgv_nomina.DataSource = datos;
                eje.Update(datos);
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostar el DataGrid" + e.ToString());
                conn.Close();
            }

        }
        void llenarComboNomina()
        {
            try
            {
                Cbo_nomina.Items.Clear();
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT `codigo_nomina` FROM `nominae`", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cbo_nomina.Refresh();
                    Cbo_nomina.Items.Add(reader.GetValue(0).ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            
        }

        private void Chk_registrado_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void TransEncab_Load(object sender, EventArgs e)
        {

        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            if (Cbo_nomina.Text == "")
            {
                MessageBox.Show("Seleccione una opción", "VERIFICAR " +
                    "DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                llenarDataGrid(Cbo_nomina.Text);
                sumaNomina(Cbo_nomina.Text);
                sumaEmpleados(Cbo_nomina.Text);
                decimal totalTotal = Convert.ToDecimal(Lbl_conceptos.Text) + Convert.ToDecimal(Lbl_empleados.Text);
                Lbl_totalT.Text = totalTotal.ToString();
            }
        }

        private void Btn_pagar_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Dgv_nomina.DataSource;
            dt.Clear();
            Lbl_conceptos.Text = "0.00";
            Lbl_totalT.Text = "0.00";
            Lbl_empleados.Text = "0.00";
            MessageBox.Show("Se realizó el pago correctamente", "PAGO", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
