using Entidades;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int numeroF = int.Parse(txtnumeroFormulario.Text);
            string id = txtID.Text;
            string nombre = txtNombre.Text;
            DateTime fecha;

            if (DateTime.TryParse(txtFechaPicker.Text, out DateTime fechaSeleccionada))
            {
                fecha = fechaSeleccionada;
            }
            else
            {
            
                fecha = DateTime.MinValue;
            }
            bool emplazamiento;
            if (rSi.Checked)
            {
                emplazamiento = true;
            }
            else {
            emplazamiento= false;
            }

            double valorDeclarado = double.Parse(txtvalorDeclarado.Text);
            Formulario formulario = new Formulario(numeroF,id,nombre,fecha,valorDeclarado,0);


        }
    }
}