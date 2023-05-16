using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryComettoClinica
{
    public partial class frmMedicos : Form
    {
        public frmMedicos()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsEspecialidad objEspecialidad = new clsEspecialidad();
            objEspecialidad.CargarEspecialidades(cmbEspecialidadM, cmbEspecialidadC);
            clsMedico objMedico = new clsMedico();
            objMedico.ListarMedicos(dgvConsultas, cmbEspecialidadC);
        }

        private void btnRegistrarM_Click(object sender, EventArgs e)
        {
            clsMedico objMedico = new clsMedico();
            objMedico.Grabar(txtMatricula,txtNombreM,cmbEspecialidadM,cmbEspecialidadC);
            objMedico.ListarMedicos(dgvConsultas,cmbEspecialidadC);
        }

        private void cmbEspecialidadC_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsMedico objMedico = new clsMedico();
            objMedico.ListarMedicos(dgvConsultas, cmbEspecialidadC);
        }
    }
}
