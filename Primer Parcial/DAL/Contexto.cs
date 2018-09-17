using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Primer_Parcial.Entidades;


namespace Primer_Parcial.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Entidad> Entidades { get; set; }
        public Contexto() : base("ConStr")
        { }
    };
}