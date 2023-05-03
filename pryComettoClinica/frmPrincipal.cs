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
    public partial class frmPrincipal : Form
    {
        List<clsMedico> lstMedicos = new List<clsMedico>();
        List<clsEspecialidad> lstEspecialidades = new List<clsEspecialidad>();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
            clsEspecialidad objEspecialidad = new clsEspecialidad();
            objEspecialidad.Grabar(txtNumeroE.Text, txtNombreE.Text);
            objEspecialidad.ListarEspecialidades(lstEspecialidades,objEspecialidad);

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsEspecialidad objEspecialidad = new clsEspecialidad();
            objEspecialidad.ListarEspecialidades(cmbEspecialidadM, cmbEspecialidadC, lstEspecialidades, objEspecialidad);
            clsMedico objMedico = new clsMedico();
            objMedico.ListarMedicos(dgvConsultas, objMedico, lstMedicos, cmbEspecialidadC);
        }

        private void btnRegistrarM_Click(object sender, EventArgs e)
        {
            clsMedico objMedico = new clsMedico();
            objMedico.Grabar(txtMatricula.Text,txtNombreM.Text,cmbEspecialidadM,cmbEspecialidadC);
            objMedico.ListarMedicos(dgvConsultas,objMedico,lstMedicos,cmbEspecialidadC);
        }

        private void cmbEspecialidadC_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsMedico objMedico = new clsMedico();
            objMedico.ListarMedicos(dgvConsultas, objMedico, lstMedicos, cmbEspecialidadC);
        }
    }
}
