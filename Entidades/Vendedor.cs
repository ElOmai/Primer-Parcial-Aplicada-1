using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial.Entidades
{
    public class Vendedor
    {
        [Key]
        public int VendedorId { get; set; }
        public string Nombre { get; set; }
        public decimal Sueldo { get; set; }
        public decimal Retencion { get; set; }
        public decimal PorcentajeRentencion { get; set; }
        public DateTime FechaVendedor { get; set; }

        public Vendedor(int vendedorId, string nombre, decimal sueldo, decimal retencion, decimal porcentajeRentencion)
        {
            VendedorId = vendedorId;
            Nombre = nombre;
            Sueldo = sueldo;
            Retencion = retencion;
            PorcentajeRentencion = porcentajeRentencion;
            FechaVendedor = DateTime.Now;

        }

        public Vendedor()
        {
            VendedorId = 0;
            Nombre = string.Empty;
            Sueldo = 0;
            Retencion = 0;
            PorcentajeRentencion = 0;
            FechaVendedor = DateTime.Now;
        }
    }
}
