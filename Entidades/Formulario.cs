using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Formulario
    {
        public double NumeroFormulario;
        public string IdNit;
        public string NombreRazonSocial;
        public DateTime DiaDeclaracionRealizada;
        public bool Emplazamiento;
        public double ValorDeclarado;
        public double TotalPago;

        public Formulario() { }

        public Formulario(double numeroFormulario, string idNit, string nombreRazonSocial, DateTime diaDeclaracionRealizada, double valorDeclarado,double totalPago)
        {
            NumeroFormulario = numeroFormulario;
            IdNit = idNit;
            NombreRazonSocial = nombreRazonSocial;
            DiaDeclaracionRealizada = diaDeclaracionRealizada;
            ValorDeclarado = valorDeclarado;
            TotalPago = totalPago;
        }

        public Formulario(double numeroFormulario, string idNit, string nombreRazonSocial, DateTime diaDeclaracionRealizada, bool emplazamiento, double valorDeclarado, double totalPago)
        {
            NumeroFormulario = numeroFormulario;
            IdNit = idNit;
            NombreRazonSocial = nombreRazonSocial;
            DiaDeclaracionRealizada = diaDeclaracionRealizada;
            Emplazamiento = emplazamiento;
            ValorDeclarado = valorDeclarado;
            TotalPago = totalPago;
        }

        public override string ToString()
        {
            return $"{NumeroFormulario};{IdNit};{NombreRazonSocial};{DiaDeclaracionRealizada.ToShortDateString()};" +
                $"{ValorDeclarado},{TotalPago}";
        }
    }
}
