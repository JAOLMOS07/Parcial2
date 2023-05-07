using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class Servicio
    {
        public List<Formulario> listaFormularios = new List<Formulario>();
        Archivo repositorio = new Archivo();

        public Servicio()
        {
            listaFormularios = repositorio.ObtenerFormulariosDesdeArchivo();
        }

        public double SancionExtemporanea(Formulario formulario)
        {
            double CuotaInicial= (formulario.ValorDeclarado) * DiasExtemporaneos(formulario.DiaDeclaracionRealizada);

            if (formulario.Emplazamiento)
            {
                return CuotaInicial*0.3;
            }
            else
            {
                return CuotaInicial * 4 * SalarioMinimoDiarioLegalVigente();
            }
        }

        public int DiasExtemporaneos(DateTime FechaDeclaracion)
        {
           return FechaDeclaracion.Day - 10;
        }

        public double SalarioMinimoDiarioLegalVigente()
        {
            return 1160000 / 30;
        }

        public void TotalPago(Formulario formulario)
        {
            double Pago;
            
            if(DiasExtemporaneos(formulario.DiaDeclaracionRealizada) > 0)
            {
                 Pago = formulario.ValorDeclarado + SancionExtemporanea(formulario);
            }
            else
            {
                Pago = formulario.ValorDeclarado;
            }
            formulario.TotalPago = Pago;
        }

        public List<Formulario> ObtenerListaFormularios()
        {
            return repositorio.ObtenerFormulariosDesdeArchivo();
        }
        private void Refrescar()
        {
            listaFormularios=repositorio.ObtenerFormulariosDesdeArchivo();
        }
        public void Guardar(Formulario formulario)
        {
            TotalPago(formulario);
            repositorio.GuardarEnArchivo(formulario);
            Refrescar();
        }
            
        public double Consecutivo()
        {
            return listaFormularios[listaFormularios.Count - 1].NumeroFormulario+1;
        }
    }
}
