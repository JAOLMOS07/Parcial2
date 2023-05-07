using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;
using System.Globalization;

namespace Datos
{
    
    public class Archivo
    {
        string ruta = "formularios.txt";
        public List<Formulario> ObtenerFormulariosDesdeArchivo()
        {
            List<Formulario> formularios = new List<Formulario>();
            StreamReader lector = new StreamReader(ruta);

                while (!lector.EndOfStream)
                {
                    formularios.Add(Mapeador(lector.ReadLine()));
                }
                lector.Close();
            return formularios;
        }
        public void GuardarEnArchivo(Formulario formulario)
        {

            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(ruta, true);
                sw.WriteLine(formulario.NumeroFormulario + ";" + formulario.IdNit + ";" + formulario.NombreRazonSocial + ";" + formulario.DiaDeclaracionRealizada.ToString("yyyy-MM-dd") + ";" + formulario.Emplazamiento.ToString() + ";" + formulario.ValorDeclarado + ";" + formulario.TotalPago);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar en archivo: " + ex.Message);
            }
            finally
            {
                if (sw != null) 
                {
                    sw.Close();
                }
                   
            }
        }

        private Formulario Mapeador(string Formul)
        {
            Formulario formulario = new Formulario();

            try
            {
                String[] campos = Formul.Split(';');
                Console.WriteLine(Formul);
                formulario.NumeroFormulario = double.Parse(campos[0]);
                formulario.IdNit= campos[1];
                formulario.NombreRazonSocial = campos[2];
                formulario.DiaDeclaracionRealizada = DateTime.Parse(campos[3]);
                formulario.Emplazamiento = bool.Parse(campos[4]);
                formulario.ValorDeclarado = double.Parse(campos[5]);
                formulario.TotalPago = double.Parse(campos[6]);

                return formulario;
            }
            catch
            {
                return formulario;
            }
        }
    }
}
