using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class FrmCrud : Form
    {
        public FrmCrud()
        {
            InitializeComponent();
        }

        private void cdastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCliente cadCliente = new FrmCadCliente();
            cadCliente.Show();
        }
    }
}
