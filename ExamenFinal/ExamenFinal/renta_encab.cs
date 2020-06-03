using RentaVideo;
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
    public partial class renta_encab : Form
    {
        //private renta_detalle frm_renta_Detalle;

        OdbcConnection conn = new OdbcConnection("Dsn=rentavideos");
        public renta_encab()
        {
            InitializeComponent(); /*/
            llenarTxtRentaEncab();
            llenarComboMembresia();
            llenarComboEmpleado(); /*/
        }

        /*/
        private void frm_renta_Detalle_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_renta_Detalle = null; } /*/

        private void Renta_encab_Load(object sender, EventArgs e)
        {
                
        }

        void llenarTxtRentaEncab()
        {
            //llenado de textBox Cod Renta Encabezado
            /*/
            try
            {
                txt_codEncab.Text = "";                
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT MAX(ID_ENCABEZADO)+1 FROM `renta_encabezado`", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {                                     
                    txt_codEncab.Text = reader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            /*/
        }

        void llenarComboMembresia()
        {
            //llenado de comboBox MEMBRESIA
            try
            {
                Cbo_membresia.Items.Clear();
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT MEMBRESIA FROM `cliente` WHERE ESTADO = 1", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cbo_membresia.Refresh();
                    //Cbo_membresia.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                    Cbo_membresia.Items.Add(reader.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        void llenarComboEmpleado()
        {
            //llenado de comboBox EMPLEADO
            try
            {
                Cbo_empleado.Items.Clear();
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT EMPLEADO FROM `empleado` WHERE ESTADO = 1", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cbo_empleado.Refresh();
                    Cbo_empleado.Items.Add(reader.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void Btn_siguiente_Click(object sender, EventArgs e)
        {
            /*/
            if (txt_codEncab.Text == "" || Cbo_membresia.Text == "" || Cbo_empleado.Text == "")
            {
                MessageBox.Show("Debe llenar todo los campos. ", "VERIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conn.Open();
                OdbcCommand codigo = new OdbcCommand();
                codigo.Connection = conn;
                codigo.CommandText = ("INSERT INTO `renta_encabezado`(`MEMBRESIA`, `EMPLEADO`, `FECHA_INICIO`, `FECHA_FIN`) "
                    + "VALUES ( '" + Cbo_membresia.Text + "' , '" + Cbo_empleado.Text + "', '" + Dtp_inicio.Text + "', '" + Dtp_fin.Text + "' )");
                try
                {
                    codigo.ExecuteNonQuery();
                    conn.Close();
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(" Error al hacer el INSERT en RENTA_ENCABEZADO. \n\n Error: " + ex.ToString());
                    conn.Close();
                }
                //RENTA_DETALLE
                if (frm_renta_Detalle == null)
                {
                    frm_renta_Detalle = new renta_detalle(txt_codEncab.Text, Cbo_membresia.Text, Cbo_empleado.Text, Dtp_inicio.Value, Dtp_fin.Value);
                    frm_renta_Detalle.FormClosed += new FormClosedEventHandler(frm_renta_Detalle_FormClosed);
                    frm_renta_Detalle.Show();
                }
                else
                {
                    frm_renta_Detalle.Activate();
                }
            }
            /*/
        }
    }
}
