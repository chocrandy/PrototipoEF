using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;
using CapaDatos;

namespace CapaVistaFRM
{
    public partial class MDI_nomina : Form
    {
        //mantenimiento_concepto
        private mantenimiento_bodegas frm_mantenimiento_bodegas;           
        private mantenimiento_vendedores frm_mantenimiento_vendedores;
        private mantenimiento_clientes frm_mantenimiento_clientes;
        private mantenimiento_lineas frm_mantenimiento_lineas;
        private mantenimiento_marcas frm_mantenimiento_marcas;
        private mantenimiento_productos frm_mantenimiento_productos;
        private mantenimiento_proveedores frm_mantenimiento_proveedores;
        private mantenimiento_ordenCompra frm_mantenimiento_ordenCompra;
        private mov_inv frm_mov_inv;

        //sentencia sn = new sentencia();
        String usuarioActivo = "rchocm";

        public MDI_nomina()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
        }

        //==========Funciones para evitar que se habrá 2 veces la misma ventana==========          
        
        private void frm_mantenimiento_bodegas_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_bodegas = null; }
        private void frm_mantenimiento_ordenCompra_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_ordenCompra = null; }
        //mantenimiento_ordenCompra
        private void frm_mantenimiento_vendedores_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_vendedores = null; }
        private void frm_mantenimiento_clientes_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_clientes = null; }
        private void frm_mantenimiento_lineas_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_lineas = null; }
        private void frm_mantenimiento_marcas_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_marcas = null; }
        private void frm_mantenimiento_productos_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_productos = null; }
        private void frm_mantenimiento_proveedores_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_proveedores = null; }
        private void frm_mov_inv_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mov_inv = null; }

        //====================Funciones de declaración de Eventos====================

        private void ConciliaciónBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            
        }

        private void BalanceGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TipoDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ActualizaciónDePólizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ConsultarConciliaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MovimientosBancariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void RevisiónDePresupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            
        }
        
        private void MDI_FRM_Load(object sender, EventArgs e)
        {           
            frm_login login = new frm_login();
            login.ShowDialog();
            Lbl_usuario.Text = login.obtenerNombreUsuario();            
            usuarioActivo = Lbl_usuario.Text;            
        } 

        private void SeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            
        }

        private void Btn_prueba_Click(object sender, EventArgs e)
        {
            //                      Usuario        Mensaje a guardar     Tabla
            //sn.insertarBitacora(Lbl_usuario.Text, "Probó la Bitacora", "General");
        }

        private void MódulosToolStripMenuItem_Click(object sender, EventArgs e)
        {                        
            
        }

        private void BancosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void ChequeraToolStripMenuItem_Click(object sender, EventArgs e)
        {     
            
        }

        private void CuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            
        }

        private void ClasificadorDeMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            
        }

        private void MonedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ModulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MonedasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void EmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void BonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void RentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ConsultaDeRentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void DevolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void DepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void EmpleadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void PuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void NominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NOMINA            
            /*/
            if (frm_nominaEncab == null)
            {
                frm_nominaEncab = new nominaEncab();
                frm_nominaEncab.MdiParent = this;
                frm_nominaEncab.FormClosed += new FormClosedEventHandler(frm_nominaEncab_FormClosed);
                frm_nominaEncab.Show();
            }
            else
            {
                frm_nominaEncab.Activate();
            } /*/
        }

        private void TransferenciaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TRANSFERENCIA
            //transEncab
            /*/
            if (frm_transEncab == null)
            {
                frm_transEncab = new transEncab();
                frm_transEncab.MdiParent = this;
                frm_transEncab.FormClosed += new FormClosedEventHandler(frm_transEncab_FormClosed);
                frm_transEncab.Show();
            }
            else
            {
                frm_transEncab.Activate();
            } /*/
        }

        private void SeguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MDI_Seguridad seguridad = new MDI_Seguridad(Lbl_usuario.Text);
            seguridad.lbl_nombreUsuario.Text = Lbl_usuario.Text;
            seguridad.ShowDialog();
        }

        private void BodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BODEGAS            
            if (frm_mantenimiento_bodegas == null)
            {
                frm_mantenimiento_bodegas = new mantenimiento_bodegas(usuarioActivo);
                frm_mantenimiento_bodegas.MdiParent = this;
                frm_mantenimiento_bodegas.FormClosed += new FormClosedEventHandler(frm_mantenimiento_bodegas_FormClosed);
                frm_mantenimiento_bodegas.Show();
            }
            else
            {
                frm_mantenimiento_bodegas.Activate();
            }
        }

        private void VendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VENDEDORES
            //mantenimiento_vendedores
            if (frm_mantenimiento_vendedores == null)
            {
                frm_mantenimiento_vendedores = new mantenimiento_vendedores(usuarioActivo);
                frm_mantenimiento_vendedores.MdiParent = this;
                frm_mantenimiento_vendedores.FormClosed += new FormClosedEventHandler(frm_mantenimiento_vendedores_FormClosed);
                frm_mantenimiento_vendedores.Show();
            }
            else
            {
                frm_mantenimiento_vendedores.Activate();
            }
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CLIENTES
            //mantenimiento_clientes
            if (frm_mantenimiento_clientes == null)
            {
                frm_mantenimiento_clientes = new mantenimiento_clientes(usuarioActivo);
                frm_mantenimiento_clientes.MdiParent = this;
                frm_mantenimiento_clientes.FormClosed += new FormClosedEventHandler(frm_mantenimiento_clientes_FormClosed);
                frm_mantenimiento_clientes.Show();
            }
            else
            {
                frm_mantenimiento_clientes.Activate();
            }
        }

        private void LineasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LINEAS
            //mantenimiento_lineas
            if (frm_mantenimiento_lineas == null)
            {
                frm_mantenimiento_lineas = new mantenimiento_lineas(usuarioActivo);
                frm_mantenimiento_lineas.MdiParent = this;
                frm_mantenimiento_lineas.FormClosed += new FormClosedEventHandler(frm_mantenimiento_lineas_FormClosed);
                frm_mantenimiento_lineas.Show();
            }
            else
            {
                frm_mantenimiento_lineas.Activate();
            }
        }

        private void MarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MARCAS
            //mantenimiento_marcas
            if (frm_mantenimiento_marcas == null)
            {
                frm_mantenimiento_marcas = new mantenimiento_marcas(usuarioActivo);
                frm_mantenimiento_marcas.MdiParent = this;
                frm_mantenimiento_marcas.FormClosed += new FormClosedEventHandler(frm_mantenimiento_marcas_FormClosed);
                frm_mantenimiento_marcas.Show();
            }
            else
            {
                frm_mantenimiento_marcas.Activate();
            }
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PRODUCTOS
            //mantenimiento_productos
            if (frm_mantenimiento_productos == null)
            {
                frm_mantenimiento_productos = new mantenimiento_productos(usuarioActivo);
                frm_mantenimiento_productos.MdiParent = this;
                frm_mantenimiento_productos.FormClosed += new FormClosedEventHandler(frm_mantenimiento_productos_FormClosed);
                frm_mantenimiento_productos.Show();
            }
            else
            {
                frm_mantenimiento_productos.Activate();
            }
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PROVEEDORES
            //mantenimiento_proveedores
            if (frm_mantenimiento_proveedores == null)
            {
                frm_mantenimiento_proveedores = new mantenimiento_proveedores(usuarioActivo);
                frm_mantenimiento_proveedores.MdiParent = this;
                frm_mantenimiento_proveedores.FormClosed += new FormClosedEventHandler(frm_mantenimiento_proveedores_FormClosed);
                frm_mantenimiento_proveedores.Show();
            }
            else
            {
                frm_mantenimiento_proveedores.Activate();
            }
        }

        private void MovimientosDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MOVIMIENTOS DE INVENTARIO ENCABEZADO
            //mov_inv
            if (frm_mov_inv == null)
            {
                frm_mov_inv = new mov_inv();
                frm_mov_inv.MdiParent = this;
                frm_mov_inv.FormClosed += new FormClosedEventHandler(frm_mov_inv_FormClosed);
                frm_mov_inv.Show();
            }
            else
            {
                frm_mov_inv.Activate();
            }
        }

        private void ComprasEncabezadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //COMPRAS ENCABEZADO
            //mantenimiento_ordenCompra
            if (frm_mantenimiento_ordenCompra == null)
            {
                frm_mantenimiento_ordenCompra = new mantenimiento_ordenCompra(usuarioActivo);
                frm_mantenimiento_ordenCompra.MdiParent = this;
                frm_mantenimiento_ordenCompra.FormClosed += new FormClosedEventHandler(frm_mantenimiento_ordenCompra_FormClosed);
                frm_mantenimiento_ordenCompra.Show();
            }
            else
            {
                frm_mantenimiento_ordenCompra.Activate();
            }
        }
    }
}
