using System;
using Primer_Parcial.DAL;
using Primer_Parcial.Entidades;
using Primer_Parcial.BLL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Primer_Parcial.BLL
{
    public class VendedoresBLL
    {
        public static bool Guardar(Vendedor vendedor)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Vendedores.Add (vendedor) != null)
                {
                    db.SaveChanges();
                    paso = true;
                }

                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool Modificar(Vendedor vendedor)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(vendedor).State = System.Data.Entity.EntityState.Modified;
                paso = (db.SaveChanges() > 0);
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Vendedores.Find(id);
                db.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
                db.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        public static Vendedor Buscar(int id)
        {
            Contexto db = new Contexto();
            Vendedor vendedor = new Vendedor();
            try
            {
                vendedor = db.Vendedores.Find(id);
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return vendedor;
        }
        public static List<Vendedor> GetList(Expression<Func<Vendedor, bool>> persona)
        {
            List<Vendedor> vendedores = new List<Vendedor>();
            Contexto db = new Contexto();
            try
            {
                vendedores = db.Vendedores.Where(persona).ToList();
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return vendedores;
        }

    }
}
