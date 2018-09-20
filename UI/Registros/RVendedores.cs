using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Primer_Parcial.BLL;
using Primer_Parcial.Entidades;

namespace Primer_Parcial.UI.NewFolder1
{
    public partial class RVendedor : Form
    {
        public RVendedor()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            VendedorIdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            SueldoNumericUpDown.Value = 0;
            PorcentajeRetencionNumericUpDown.Value = 0;
            RetencionNumericUpDown.Value = 0;
            VendedorErrorProvider.Clear();
        }

        private void Nuevo_Button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private Vendedor LlenaClase()
        {
            Vendedor vendedor = new Vendedor
            {
                VendedorId = Convert.ToInt32(VendedorIdNumericUpDown.Value),
                Nombre = NombreTextBox.Text,
                Sueldo = Convert.ToDecimal(SueldoNumericUpDown.Value),
                PorcentajeRentencion = Convert.ToDecimal(PorcentajeRetencionNumericUpDown.Value),
                Retencion = Convert.ToDecimal(RetencionNumericUpDown.Value)
            };
            return vendedor;
        }
        private void LlenaCampo(Vendedor vendedor)
        {
            VendedorIdNumericUpDown.Value = vendedor.VendedorId;
            NombreTextBox.Text = vendedor.Nombre;
            SueldoNumericUpDown.Value = vendedor.Sueldo;
            PorcentajeRetencionNumericUpDown.Value = vendedor.PorcentajeRentencion;
            RetencionNumericUpDown.Value = vendedor.Retencion;
        }

        private bool Validar()
        {
            bool paso = true;

            if (VendedorIdNumericUpDown.Value == 0)
            {
                VendedorErrorProvider.SetError(VendedorIdNumericUpDown, "Este campo tiene que ser diferente de 0");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text)){
                VendedorErrorProvider.SetError(NombreTextBox,"No se puede dejar este campo vacio");
                paso = false;
            }
            if (SueldoNumericUpDown.Value == 0)
            {
                VendedorErrorProvider.SetError(SueldoNumericUpDown, "Este campo tiene que ser diferente de 0");
                paso = false;
            }
            if (PorcentajeRetencionNumericUpDown.Value == 0)
            {
                VendedorErrorProvider.SetError(PorcentajeRetencionNumericUpDown, "Este campo tiene que ser diferente de 0");
                paso = false;
            }
            if (RetencionNumericUpDown.Value == 0)
            {
                VendedorErrorProvider.SetError(RetencionNumericUpDown, "Este campo tiene que ser diferente de 0");
                paso = false;
            }
            return paso;
        }

        private void Guardar_Button_Click(object sender, EventArgs e)
        {
            Vendedor vendedor;
            bool paso = false;

            if (!Validar())
                return;
            vendedor = LlenaClase();

            
            if (VendedorIdNumericUpDown.Value != 0)
                paso = VendedoresBLL.Guardar(vendedor);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un vendedor que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = VendedoresBLL.Modificar(vendedor);
            }
            
            if (paso)
            {
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Vendedor vendedor =VendedoresBLL.Buscar(id: (int)VendedorIdNumericUpDown.Value);
            return (vendedor != null);
        }

        private void Buscar_Button_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor();
            int.TryParse(VendedorIdNumericUpDown.Text, out int id);

            vendedor = VendedoresBLL.Buscar(id);

            if (vendedor != null) 
            {
                MessageBox.Show("Vendedor Encontrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenaCampo(vendedor);
            }
            else
            {
                MessageBox.Show("Vendedor no Encontado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        private void Eliminar_Button_Click(object sender, EventArgs e)
        {
            VendedorErrorProvider.Clear();
            int.TryParse(VendedorIdNumericUpDown.Text, out int id);

            if (!ExisteEnLaBaseDeDatos())
            {
                VendedorErrorProvider.SetError(VendedorIdNumericUpDown, "No se puede eliminar un vendedor que no existe");
                return;
            }
            if (VendedoresBLL.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Eliminado");
            }
        }

        private void RetencionNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            {
                if (Validar())
                {
                    MessageBox.Show("llenar el campo vacio", "trate de guardar de nuevo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                if (SueldoNumericUpDown.Value != 0 && PorcentajeRetencionNumericUpDown.Value != 0)
                {
                    RetencionNumericUpDown.Value = VendedoresBLL.CalculoRetencion(SueldoNumericUpDown.Value, PorcentajeRetencionNumericUpDown.Value);


                }
                else
                {
                    MessageBox.Show("algun campo no esta lleno correctamente", "trate de nuevo",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
