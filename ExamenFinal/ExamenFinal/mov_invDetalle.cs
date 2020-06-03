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
    public partial class mov_invDetalle : Form
    {

        private movimientos_bancarios_2 frm_movimientos_bancarios_2;
        OdbcConnection conn = new OdbcConnection("Dsn=ERP");        
        String cuentaBank = "";
        String docu = "";
        public mov_invDetalle(string doc)
        {
            InitializeComponent();
            llenarComboProducto();
            llenarComboBodega();
            docu = doc;
        }

        private void frm_movimientos_bancarios_2_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_movimientos_bancarios_2 = null; }

        private void Mov_banc_encabezado_Load(object sender, EventArgs e)
        {

        }

        void llenarComboProducto()
        {
            //llenado de comboBox MEMBRESIA
            try
            {
                Cbo_producto.Items.Clear();
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT `codigo_producto`, `nombre_producto` FROM `productos` WHERE `estado`=1", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cbo_producto.Refresh();
                    //Cbo_membresia.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                    Cbo_producto.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        void llenarComboBodega()
        {
            //llenado de comboBox MEMBRESIA
            try
            {
                Cbo_bodegas.Items.Clear();
                conn.Open();
                OdbcCommand command = new OdbcCommand("SELECT `codigo_bodega` FROM `bodegas` WHERE `estado`=1", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cbo_bodegas.Refresh();
                    //Cbo_membresia.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                    Cbo_bodegas.Items.Add(reader.GetValue(0).ToString());
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
            MessageBox.Show("Se registro correctamente", "INGRESO DE " +
                    "DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            /*
            if (Cbo_producto.Text == "")
            {
                MessageBox.Show("Llene los campos solicitados", "VERIFICAR " +
                    "DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {                    
                    conn.Open();
                    OdbcCommand command = new OdbcCommand("INSERT INTO `compras_detalle`" +
                        "(`documento_compraenca`, `codigo_producto`, `cantidad_compradet`, `costo_compradet`, `codigo_bodega`) VALUES " +
                        "('" + docu + "','" + Cbo_producto.Text +"','" + txtCant.Text + "','" + txtCosto.Text + "','" + Cbo_bodegas.Text + "')", conn);
                    OdbcDataReader reader = command.ExecuteReader();
                    MessageBox.Show("Se registro correctamente", "INGRESO DE " +
                    "DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            } */
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
