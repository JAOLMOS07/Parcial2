using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class Servicio
    {
        public Servicio() { }

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

        public double TotalPago(Formulario formulario)
        {
            if(DiasExtemporaneos(formulario.DiaDeclaracionRealizada) > 0)
            {
                return formulario.ValorDeclarado + SancionExtemporanea(formulario);
            }
            else
            {
                return formulario.ValorDeclarado;
            }
        }
    }
}
