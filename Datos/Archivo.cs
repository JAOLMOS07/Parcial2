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

            if (File.Exists(ruta))
            {
                using (StreamReader reader = new StreamReader(ruta))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');

                        double numeroFormulario = Convert.ToDouble(datos[0]);
                        string idNit = datos[1];
                        string nombreRazonSocial = datos[2];
                        DateTime diaDeclaracionRealizada = DateTime.ParseExact(datos[3], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        bool emplazamiento = Convert.ToBoolean(datos[4]);
                        double valorDeclarado = Convert.ToDouble(datos[5]);
                        double totalPago = Convert.ToDouble(datos[6]);

                        if (emplazamiento)
                        {
                            formularios.Add(new Formulario(numeroFormulario, idNit, nombreRazonSocial, diaDeclaracionRealizada, emplazamiento, valorDeclarado, totalPago));
                        }
                        else
                        {
                            formularios.Add(new Formulario(numeroFormulario, idNit, nombreRazonSocial, diaDeclaracionRealizada, valorDeclarado, totalPago));
                        }
                    }
                }
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
