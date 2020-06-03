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
    public partial class movimientos_bancarios_2 : Form
    {
        //movBancarios movBank = new movBancarios();
        string[] words;
        string nombreProd = "";
        public movimientos_bancarios_2(String nomproducto)
        {
            InitializeComponent();            
            nombreProd = nomproducto; 
            Txt_cuentaBancaria.Text = nomproducto;
            
        }                             
        
        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            
            if (Cbo_tipo.Text == "" || Dtp_fechaMov.Text == "" || 
                Txt_descripcion.Text == "" || Cbo_cargoAbono.Text == "" || Txt_monto.Text == "" || 
                Cbo_tipo.SelectedItem == null || Cbo_beneRegistrado.SelectedItem == null || 
                Cbo_cargoAbono.SelectedItem == null)
            {
                MessageBox.Show("Debe llenar todos los campos", "VERIFICAR DATOS", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                /*/
                try
                {
                    decimal montoAux = Convert.ToDecimal(Txt_monto.Text);
                    decimal saldoActualAux = Convert.ToDecimal(Txt_saldoActual.Text);
                    decimal totalAux = 0;
                    if (montoAux > 0)
                    {
                        if (saldoActualAux >= 0)
                        {
                            totalAux = saldoActualAux - montoAux;
                            if (Cbo_cargoAbono.Text == "Cargo")
                            {
                                if (totalAux < 0)
                                {
                                    MessageBox.Show(" No se puede realizar el registro. " +
                                        "\n El Saldo de la cuenta es Insuficiente.", "VERIFICAR SALDO",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (totalAux >= 0)
                                {
                                    if (Chk_registrado.Checked == true)
                                    {
                                        Cbo_beneRegistrado.Enabled = false;
                                        Txt_beneNoRegistrado.Enabled = true;
                                        beneficiarioFinal = Txt_beneNoRegistrado.Text;
                                    }
                                    else if (Chk_registrado.Checked == false)
                                    {
                                        Cbo_beneRegistrado.Enabled = true;
                                        Txt_beneNoRegistrado.Enabled = false;
                                        beneficiarioFinal = Cbo_beneRegistrado.Text;
                                    }

                                    //string cuentaBancaria, string tipo_mov, string no_referencia, string beneficiario, string descrip, string cargoAbono, int monto, int saldoAnterior
                                    movBank.GuardarDetalleMov(words[0], Cbo_tipo.Text, Txt_referencia.Text, beneficiarioFinal, Txt_descripcion.Text, Cbo_cargoAbono.Text, montoAux, saldoActualAux);
                                    movBank.ModificarDetalleMov();
                                    Cbo_tipo.Refresh();
                                    Cbo_tipo.Items.Clear();
                                    Cbo_tipo.Text = "";
                                    Txt_referencia.Text = "";
                                    Cbo_beneRegistrado.Refresh();
                                    Cbo_beneRegistrado.Items.Clear();
                                    Cbo_beneRegistrado.Text = "";
                                    Txt_beneNoRegistrado.Text = "";
                                    Txt_descripcion.Text = "";
                                    Cbo_cargoAbono.Refresh();
                                    Cbo_cargoAbono.Text = "";
                                    Txt_monto.Text = "";
                                    Txt_saldoActual.Text = "";

                                    registro();
                                    llenarCombos();
                                    llenarDetalleMovBank();
                                    llenarCargoAbono();
                                }
                            }
                            else if (Cbo_cargoAbono.Text == "Abono")
                            {
                                if (Chk_registrado.Checked == true)
                                {
                                    Cbo_beneRegistrado.Enabled = false;
                                    Txt_beneNoRegistrado.Enabled = true;
                                    beneficiarioFinal = Txt_beneNoRegistrado.Text;
                                }
                                else if (Chk_registrado.Checked == false)
                                {
                                    Cbo_beneRegistrado.Enabled = true;
                                    Txt_beneNoRegistrado.Enabled = false;
                                    beneficiarioFinal = Cbo_beneRegistrado.Text;
                                }

                                //string cuentaBancaria, string tipo_mov, string no_referencia, string beneficiario, string descrip, string cargoAbono, int monto, int saldoAnterior
                                movBank.GuardarDetalleMov(words[0], Cbo_tipo.Text, Txt_referencia.Text, beneficiarioFinal, Txt_descripcion.Text, Cbo_cargoAbono.Text, montoAux, saldoActualAux);
                                movBank.ModificarDetalleMov();
                                Cbo_tipo.Refresh();
                                Cbo_tipo.Items.Clear();
                                Cbo_tipo.Text = "";
                                Txt_referencia.Text = "";
                                Cbo_beneRegistrado.Refresh();
                                Cbo_beneRegistrado.Items.Clear();
                                Cbo_beneRegistrado.Text = "";
                                Txt_beneNoRegistrado.Text = "";
                                Txt_descripcion.Text = "";
                                Cbo_cargoAbono.Refresh();
                                Cbo_cargoAbono.Text = "";
                                Txt_monto.Text = "";
                                Txt_saldoActual.Text = "";

                                registro();
                                llenarCombos();
                                llenarDetalleMovBank();
                                llenarCargoAbono();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Verifique que el Saldo Actual sea mayor o igual a 0. " +
                                "\n Consulte con el Administrador. ", "VERIFICAR SALDO ACTUAL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Verifique que el Monto sea Mayor a 0.", "VERIFICAR MONTO",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique que el campo Monto sea un número. ", 
                        "VERIFICAR MONTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }/*/
            } 
            }

        private void Chk_registrado_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Gpb_detalle_Enter(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }

    }
