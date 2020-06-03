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
    public partial class nominaEncab : Form
    {
        OdbcConnection conn = new OdbcConnection("Dsn=ERP");
        bool existe = true;
        public nominaEncab()
        {
            InitializeComponent();
            llenarComboNomina();
            llenarComboEmpleado();
            llenarComboConcepto();
        }


        private void Mov_banc_encabezado_Load(object sender, EventArgs e)
        {

        }
        
        void VerificarNomina(String nomina)
        {            
            try
            {
                String dato = "";
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT `codigo_nomina` FROM `nominae` " +
                    "WHERE `codigo_nomina`='" + nomina +"'", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dato = reader.GetValue(0).ToString();
                }
                conn.Close();

                if (dato == nomina)
                {
                    existe = true;
                }
                else if (dato == "")
                {
                    existe = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        void llenarComboConcepto()
        {
            try
            {
                Cbo_concepto.Items.Clear();
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT `codigo_concepto` FROM `concepto` WHERE `estado`=1", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cbo_concepto.Refresh();
                    Cbo_concepto.Items.Add(reader.GetValue(0).ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        void llenarComboEmpleado()
        {
            try
            {
                Cbo_empleado.Items.Clear();
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT `codigo_empleado` FROM `empleado` WHERE `estado`=1", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cbo_empleado.Refresh();                    
                    Cbo_empleado.Items.Add(reader.GetValue(0).ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
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


        private void Btn_siguiente_Click(object sender, EventArgs e)
        { 
            
            if (Cbo_nomina.Text == "" || Cbo_empleado.Text == "" || 
                Cbo_concepto.Text == "" || Txt_valor.Text == "")
            {
                MessageBox.Show("Ingrese todos los valores", "VERIFICAR " +
                    "DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                VerificarNomina(Cbo_nomina.Text);                
                if (existe == false)
                {
                    conn.Open();
                    OdbcCommand codigo2 = new OdbcCommand();
                    codigo2.Connection = conn;
                    codigo2.CommandText = ("INSERT INTO `nominae`(`codigo_nomina`, `fecha_inicial_nomina`, `fecha_final_nomina`) " +
                        "VALUES ('" + Cbo_nomina.Text + "', '" + Dtp_inicial.Text + "', '" + Dtp_final.Text + "')");
                    try
                    {
                        codigo2.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (OdbcException ex)
                    {
                        MessageBox.Show(" Error al hacer el INSERT en NOMINA ENCABEZADO. \n\n Error: " + ex.ToString());
                        conn.Close();
                    }
                }
                else
                {
                    float auxValor = float.Parse(Txt_valor.Text);
                    conn.Open();
                    OdbcCommand codigo1 = new OdbcCommand();
                    codigo1.Connection = conn;
                    codigo1.CommandText = ("INSERT INTO `nominad`(`codigo_nomina`, `codigo_empleado`, `codigo_concepto`, `valor_nominaD`) " +
                        "VALUES ('" + Cbo_nomina.Text + "', '" + Cbo_empleado.Text + "', '" + Cbo_concepto.Text + "', '" + auxValor + "')");
                    try
                    {
                        codigo1.ExecuteNonQuery();
                        conn.Close();                        
                        Txt_valor.Text = "";
                        Cbo_concepto.Text = "";
                        Cbo_empleado.Text = "";
                        Cbo_concepto.Text = "";

                        MessageBox.Show(" Se registro correctamente.", "REGISTRO",
                            MessageBoxButtons.OK);
                        conn.Close();
                    }
                    catch (OdbcException ex)
                    {
                        MessageBox.Show(" Error al hacer el INSERT en NOMINA DETALLE. \n\n Error: " + ex.ToString());
                        conn.Close();
                    }
                }
            }        
        }


    }
}
