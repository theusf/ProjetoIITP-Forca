using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apPrincipal
{
    public partial class frmPrincipal : Form
    {
        Forca frmForca = null;
        Cadastro frmCadastro = null;
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuJogo_Click(object sender, EventArgs e)
        {
            frmForca = new Forca();
            frmForca.Show();
        }

        private void cADASTRAEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro = new Cadastro();
            frmCadastro.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Close();
            
        }
    }
}
