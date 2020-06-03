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
        private mantenimiento_concepto frm_mantenimiento_concepto;
        private mantenimiento_departamento frm_mantenimiento_departamento;
        private mantenimiento_empleado frm_mantenimiento_empleado;
        private mantenimiento_puesto frm_mantenimiento_puesto;
        private nominaEncab frm_nominaEncab;
        private transEncab frm_transEncab;

        //sentencia sn = new sentencia();
        String usuarioActivo = "rchocm";

        public MDI_nomina()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
        }

        //==========Funciones para evitar que se habrá 2 veces la misma ventana==========          
        private void frm_mantenimiento_concepto_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_concepto = null; }
        private void frm_mantenimiento_departamento_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_departamento = null; }
        private void frm_mantenimiento_empleado_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_empleado = null; }
        private void frm_mantenimiento_puesto_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_puesto = null; }
        private void frm_nominaEncab_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_nominaEncab = null; }
        private void frm_transEncab_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_transEncab = null; }        

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
            MDI_Seguridad seguridad = new MDI_Seguridad(Lbl_usuario.Text);
            seguridad.lbl_nombreUsuario.Text = Lbl_usuario.Text;
            seguridad.ShowDialog();
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
            //CONCEPTO            
            if (frm_mantenimiento_concepto == null)
            {
                frm_mantenimiento_concepto = new mantenimiento_concepto(usuarioActivo);
                frm_mantenimiento_concepto.MdiParent = this;
                frm_mantenimiento_concepto.FormClosed += new FormClosedEventHandler(frm_mantenimiento_concepto_FormClosed);
                frm_mantenimiento_concepto.Show();
            }
            else
            {
                frm_mantenimiento_concepto.Activate();
            }
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
            //DEPARTAMENTO            
            if (frm_mantenimiento_departamento == null)
            {
                frm_mantenimiento_departamento = new mantenimiento_departamento(usuarioActivo);
                frm_mantenimiento_departamento.MdiParent = this;
                frm_mantenimiento_departamento.FormClosed += new FormClosedEventHandler(frm_mantenimiento_departamento_FormClosed);
                frm_mantenimiento_departamento.Show();
            }
            else
            {
                frm_mantenimiento_departamento.Activate();
            }
        }

        private void EmpleadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //EMPLEADO            
            if (frm_mantenimiento_empleado == null)
            {
                frm_mantenimiento_empleado = new mantenimiento_empleado(usuarioActivo);
                frm_mantenimiento_empleado.MdiParent = this;
                frm_mantenimiento_empleado.FormClosed += new FormClosedEventHandler(frm_mantenimiento_empleado_FormClosed);
                frm_mantenimiento_empleado.Show();
            }
            else
            {
                frm_mantenimiento_empleado.Activate();
            }
        }

        private void PuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PUESTO            
            if (frm_mantenimiento_puesto == null)
            {
                frm_mantenimiento_puesto = new mantenimiento_puesto(usuarioActivo);
                frm_mantenimiento_puesto.MdiParent = this;
                frm_mantenimiento_puesto.FormClosed += new FormClosedEventHandler(frm_mantenimiento_puesto_FormClosed);
                frm_mantenimiento_puesto.Show();
            }
            else
            {
                frm_mantenimiento_puesto.Activate();
            }
        }

        private void NominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NOMINA            
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
            }
        }

        private void TransferenciaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TRANSFERENCIA
            //transEncab
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
            }
        }
    }
}
