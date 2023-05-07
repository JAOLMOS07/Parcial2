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
        public List<Formulario> ObtenerFormulariosDesdeArchivo(string rutaArchivo)
        {
            List<Formulario> formularios = new List<Formulario>();

            try
            {
                StreamReader lector = new StreamReader(rutaArchivo);

                string linea;
                while ((linea = lector.ReadLine()) != null)
                {
                    string[] campos = linea.Split(',');

                    double numeroFormulario = double.Parse(campos[0]);
                    string idNit = campos[1];
                    string nombreRazonSocial = campos[2];
                    DateTime diaDeclaracionRealizada = DateTime.Parse(campos[3]);
                    bool emplazamiento = bool.Parse(campos[4]);
                    double valorDeclarado = double.Parse(campos[5]);
                    double totalPago = double.Parse(campos[6]);
           
                    formularios.Add(new Formulario(numeroFormulario, idNit, nombreRazonSocial, diaDeclaracionRealizada,emplazamiento, valorDeclarado, totalPago));
                    
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo: " + ex.Message);
            }

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
    }
}
