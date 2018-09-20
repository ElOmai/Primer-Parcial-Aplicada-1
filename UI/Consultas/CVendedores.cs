using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Primer_Parcial.Entidades;

namespace Primer_Parcial.UI.Consultas
{
    public partial class CVendedor : Form
    {
        public CVendedor()
        {
            InitializeComponent();
        }

        private void Buscar_Button_Click(object sender, EventArgs e)
        {
            ConsultardataGridView.DataSource = null;
            Vendedor vendedor = new Vendedor();
            Expression<Func<Vendedor, bool>> Filtro = x => true;


            switch (FiltrocomboBox.SelectedIndex)
            {


                case 0://Vendedor ID

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!");
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(criteriotextBox.Text);
                        if (FechacheckBox.Checked == true)
                        {
                            Filtro = x => x.VendedorId == id && (x.FechaVendedor.Day >= MinDate.Value.Day) && (x.FechaVendedor.Month >= MinDate.Value.Month) && (x.FechaVendedor.Year >= MinDate.Value.Year) && (x.FechaVendedor.Day <= MaxDate.Value.Day) && (x.FechaVendedor.Month <= MinDate.Value.Month) && (x.FechaVendedor.Year <= MaxDate.Value.Year);
                            GeneralerrorProvider.Clear();
                        }
                        else
                        {
                            Filtro = x => x.VendedorId == id;
                            GeneralerrorProvider.Clear();
                        }

                        if (BLL.VendedoresBLL.GetList(Filtro).Count() == 0)
                        {
                            MessageBox.Show("Este ID, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    break;

                case 1://Nombre
                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    else
                    {
                        if (FechacheckBox.Checked == true)
                        {
                            Filtro = x => x.Nombre.Contains(criteriotextBox.Text) && (x.FechaVendedor.Day >= MinDate.Value.Day) && (x.FechaVendedor.Month >= MinDate.Value.Month) && (x.FechaVendedor.Year >= MinDate.Value.Year) && (x.FechaVendedor.Day <= MaxDate.Value.Day) && (x.FechaVendedor.Month <= MaxDate.Value.Month) && (x.FechaVendedor.Year <= MaxDate.Value.Year);
                            GeneralerrorProvider.Clear();
                        }
                        else
                        {
                            Filtro = x => x.Nombre.Contains(criteriotextBox.Text);
                            GeneralerrorProvider.Clear();
                        }

                        if (BLL.VendedoresBLL.GetList(Filtro).Count() == 0)
                        {
                            MessageBox.Show("Esta Descripcion, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                    }
                    break;
                case 2://Sueldo


                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!");
                        return;
                    }
                    else
                    {
                        int Sueldos = Convert.ToInt32(criteriotextBox.Text);
                        if (FechacheckBox.Checked == true)
                        {
                            Filtro = x => x.Sueldo == Sueldos && (x.FechaVendedor.Day >= MinDate.Value.Day) && (x.FechaVendedor.Month >= MinDate.Value.Month) && (x.FechaVendedor.Year >= MinDate.Value.Year) && (x.FechaVendedor.Day <= MaxDate.Value.Day) && (x.FechaVendedor.Month <= MaxDate.Value.Month) && (x.FechaVendedor.Year <= MaxDate.Value.Year);
                            GeneralerrorProvider.Clear();
                        }
                        else
                        {
                            Filtro = x => x.Sueldo == Sueldos;
                            GeneralerrorProvider.Clear();
                        }


                        if (BLL.VendedoresBLL.GetList(Filtro).Count() == 0)
                        {
                            MessageBox.Show("Esta Sueldo, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }


                    }
                    break;
                case 3://Retencion


                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!");
                        return;
                    }
                    else
                    {
                        int Retencion = Convert.ToInt32(criteriotextBox.Text);
                        if (FechacheckBox.Checked == true)
                        {
                            Filtro = x => x.Retencion == Retencion && (x.FechaVendedor.Day >= MinDate.Value.Day) && (x.FechaVendedor.Month >= MinDate.Value.Month) && (x.FechaVendedor.Year >= MinDate.Value.Year) && (x.FechaVendedor.Day <= MaxDate.Value.Day) && (x.FechaVendedor.Month <= MaxDate.Value.Month) && (x.FechaVendedor.Year <= MaxDate.Value.Year);
                            GeneralerrorProvider.Clear();
                        }
                        else
                        {
                            Filtro = x => x.Retencion == Retencion;
                            GeneralerrorProvider.Clear();
                        }
                        if (BLL.VendedoresBLL.GetList(Filtro).Count() == 0)
                        {
                            MessageBox.Show("Esta Retencion No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                    }
                    break;
                case 4://%Retencion
                    {


                        if (Validar(1))

                        {
                            MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (Validar(2))
                        {
                            MessageBox.Show("Debe Digitar un Numero!");
                            return;
                        }
                        else
                        {
                            int PorcentajeRentencion = Convert.ToInt32(criteriotextBox.Text);
                            if (FechacheckBox.Checked == true)
                            {
                                Filtro = x => x.PorcentajeRentencion == PorcentajeRentencion && (x.FechaVendedor.Day >= MinDate.Value.Day) && (x.FechaVendedor.Month >= MinDate.Value.Month) && (x.FechaVendedor.Year >= MinDate.Value.Year) && (x.FechaVendedor.Day <= MaxDate.Value.Day) && (x.FechaVendedor.Month <= MaxDate.Value.Month) && (x.FechaVendedor.Year <= MaxDate.Value.Year);
                                GeneralerrorProvider.Clear();
                            }
                            else
                            {
                                Filtro = x => x.PorcentajeRentencion == PorcentajeRentencion;
                                GeneralerrorProvider.Clear();
                            }
                            if (BLL.VendedoresBLL.GetList(Filtro).Count() == 0)
                            {
                                MessageBox.Show("Este # de PorcentajeRentencion, No Existe ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                        }
                    }
                    break;
                case 5://Todo
                    Filtro = x => true;
                    if (BLL.VendedoresBLL.GetList(Filtro).Count() == 0)
                    {
                        MessageBox.Show("Lista esta Vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    break;
            }
            ConsultardataGridView.DataSource = BLL.VendedoresBLL.GetList(Filtro);

        }

        private bool Validar(int error)
        {
            bool paso = false;

            if (error == 1 && string.IsNullOrEmpty(criteriotextBox.Text))
            {
                GeneralerrorProvider.SetError(criteriotextBox, "Por Favor, LLenar Casilla!");
                paso = true;
            }
            if (error == 2 && int.TryParse(criteriotextBox.Text, out int num) == false)
            {
                GeneralerrorProvider.SetError(criteriotextBox, "Debe Digitar un Numero");
                paso = true;
            }

            if (error == 3 && int.TryParse(criteriotextBox.Text, out num) == true)
            {
                GeneralerrorProvider.SetError(criteriotextBox, "Debe Digitar Caracteres");
                paso = true;
            }

            return paso;
        }

        private void CVendedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'primerParcialDBDataSet.Vendedors' table. You can move, or remove it, as needed.
            this.vendedorsTableAdapter.Fill(this.primerParcialDBDataSet.Vendedors);

        }
    }
}
