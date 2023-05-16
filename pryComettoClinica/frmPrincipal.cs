using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryComettoClinica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            picLogo.ImageLocation = "clinica_logo.png";
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            frmEspecialidades frmEspecialidades = new frmEspecialidades();
            frmEspecialidades.ShowDialog();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            frmMedicos frmMedicos = new frmMedicos();
            frmMedicos.ShowDialog();
        }
    }
}
