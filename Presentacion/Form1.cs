using Entidades;
using Logica;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        Servicio servicio = new Servicio();
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
            else
            {
                emplazamiento = false;
            }

            double valorDeclarado = double.Parse(txtvalorDeclarado.Text);
            Formulario formulario = new Formulario(numeroF, id, nombre, fecha, emplazamiento, valorDeclarado, 0);

            servicio.Guardar(formulario);
            limpiar();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        public void limpiar()
        {
            txtnumeroFormulario.Text = "";
            txtID.Text = "";
            txtNombre.Text = "";
            txtvalorDeclarado.Text = "";

        }

        private void txtFechaPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        public void Refrescar()
        {
            CargarDataGrid();
        }
        public void CargarDataGrid()
        {
            grillaDatos.DataSource = servicio.Mostrar();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            foreach (var item in servicio.Mostrar()) 
            {
                MessageBox.Show(item.ToString());
            }
            
            CargarDataGrid();
        }
    }
}