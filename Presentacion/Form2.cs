using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Servicio servicio = new Servicio();
            Formulario formulario = servicio.Traerultimo();
            txtNum.Text = formulario.NumeroFormulario + "";
            txtIDv.Text = formulario.IdNit;
            txtNombrev.Text = formulario.NombreRazonSocial;
            txtFechav.Text = formulario.DiaDeclaracionRealizada.ToShortDateString();
            txtValorDeclaradov.Text = formulario.ValorDeclarado + "";
            txtTotalDeclarado.Text = formulario.TotalPago + "";

        }
    }
}
