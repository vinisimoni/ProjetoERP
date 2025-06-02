using ProjetoCadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoERP.Telas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCadClientes_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cadCli = new frmCadastroCliente();
            cadCli.ShowDialog();
        }

        private void btnCadMateriais_Click(object sender, EventArgs e)
        {
            frmCadastroMaterial cadMat = new frmCadastroMaterial();
            cadMat.Show();
        }
    }
}
