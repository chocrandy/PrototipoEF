﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaFRM
{
    public partial class mantenimiento_clientes : Form
    {
        string usuario = "";        
        public mantenimiento_clientes(String usuarioActivo)
        {
            InitializeComponent();
            usuario = usuarioActivo;
            string[] alias = { "Cod. Cliente", "Nombre", "Dirección", "Nit", "Teléfono", "Vendedor", "Estado" }; // Arreglo de nombres para campos
            navegador1.asignarAlias(alias); // Asignar nombres
            navegador1.asignarSalida(this); // Asignar form de salida
            Color nuevoColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); // Deficion de 
            navegador1.asignarColorFondo(nuevoColor);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("1"); // asignar 1 por defecto 
            // LOS COMBOS SE ASIGNAN SEGUN EL ORDEN EN QUE SE DECLAREN
            // 0 o 1 en modo, 0 pone el id y 1 coloca el nombre y consulta el id
            navegador1.asignarComboConTabla("vendedores", "nombre_vendedor", 1); 
            //navegador1.asignarComboConTabla("departamento", "nombre_departamento", 1); 
            navegador1.asignarTabla("clientes"); // tabla principal
            navegador1.asignarNombreForm("Clientes"); // Titulo y nombre del form
        }

        private void Navegador1_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario); // Pasa el parametro del usuario
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva); // Consulta permisos al iniciar
            navegador1.ObtenerIdAplicacion(aplicacionActiva);// Pasa el id de la aplicacion actual
        }
    }
}
