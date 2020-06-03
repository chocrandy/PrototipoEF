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
    public partial class mov_inv : Form
    {

        private mov_invDetalle frm_movimientos_bancarios_2;
        OdbcConnection conn = new OdbcConnection("Dsn=ERP");        
        String cuentaBank = "";
        public mov_inv()
        {
            InitializeComponent();
            llenarComboProducto();
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
                OdbcCommand command = new OdbcCommand("SELECT `documento_compraenca` FROM `compras_encabezado` WHERE `estado`=1", conn);
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cbo_producto.Refresh();
                    //Cbo_membresia.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                    Cbo_producto.Items.Add(reader.GetValue(0).ToString());
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
            if (Cbo_producto.Text == "")
            {
                MessageBox.Show("Seleccione un producto", "VERIFICAR " +
                    "DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {                
                cuentaBank = Cbo_producto.Text;
                //ENCABEZADO_MOVIMIENTOS_BANCARIOS
                if (frm_movimientos_bancarios_2 == null)
                {
                    frm_movimientos_bancarios_2 = new mov_invDetalle(cuentaBank);
                    frm_movimientos_bancarios_2.MdiParent = this.MdiParent;
                    frm_movimientos_bancarios_2.FormClosed += new FormClosedEventHandler(frm_movimientos_bancarios_2_FormClosed);
                    frm_movimientos_bancarios_2.Show();
                }
                else
                {
                    frm_movimientos_bancarios_2.Activate();
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
