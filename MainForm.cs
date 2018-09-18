using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Primer_Parcial.UI.NewFolder1;


namespace Primer_Parcial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistroVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RVendedor rv = new RVendedor();
            rv.Show();
        }
    }
}
