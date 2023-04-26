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
        public frmPrincipal()
        {
            InitializeComponent();
        }
        public void CargaEspecialidades()
        {
            string auxiliar;
            StreamReader streamReader = new StreamReader("ESPECIALIDADES.txt");
            cmbEspecialidadM.Items.Clear();
            cmbEspecialidadC.Items.Clear();
            while (streamReader.EndOfStream == false)
            {
                auxiliar = streamReader.ReadLine();
                if (auxiliar != "")
                {
                    string especialidad = auxiliar.Split(',')[1];
                    cmbEspecialidadM.Items.Add(especialidad);
                    cmbEspecialidadC.Items.Add(especialidad);
                }
            }
            cmbEspecialidadC.Items.Add("Todas");
            cmbEspecialidadC.Text = "Todas";
            streamReader.Close();
        }
        public void CargaMedicos()
        {
            string auxiliar;
            string auxEsp;
            string especialidad = "";
            string[] vectorMedicos;
            StreamReader streamReader = new StreamReader("MEDICOS.txt");
            StreamReader streamReaderE = new StreamReader("ESPECIALIDADES.txt");
            dgvConsultas.Rows.Clear();
            while (streamReader.EndOfStream == false)
            {
                auxiliar = streamReader.ReadLine();
                if (auxiliar != "")
                {
                    vectorMedicos = auxiliar.Split(',');
                    if (cmbEspecialidadC.Text == "Todas")
                    {
                        while (streamReaderE.EndOfStream == false)
                        {
                            auxEsp = streamReaderE.ReadLine();
                            if (auxiliar.Split(',')[2] == auxEsp.Split(',')[0])
                            {
                                especialidad = auxEsp.Split(',')[1];
                                break;
                            }
                        }
                        streamReaderE.DiscardBufferedData();
                        streamReaderE.BaseStream.Position = 0;
                        dgvConsultas.Rows.Add(vectorMedicos[0], vectorMedicos[1], especialidad);
                    }
                }
            }
            streamReader.Close();
            streamReaderE.Close();
        }
        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
            if (txtNumeroE.Text != "" && txtNombreE.Text != "")
            {
                string auxiliar;
                string[] vectorEspecialidades;
                StreamReader streamReader = new StreamReader("ESPECIALIDADES.txt");
                while (streamReader.EndOfStream == false)
                {
                    auxiliar = streamReader.ReadLine();
                    if (auxiliar != "")
                    {
                        vectorEspecialidades = auxiliar.Split(',');
                        if (vectorEspecialidades[0] == txtNumeroE.Text)
                        {
                            MessageBox.Show("La especialidad ingresada ya existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            streamReader.Close();
                            return;
                        }
                    }
                }
                streamReader.Close();
                StreamWriter streamWriter = new StreamWriter("ESPECIALIDADES.txt", true);
                streamWriter.Write(txtNumeroE.Text + "," + txtNombreE.Text + "\n");
                streamWriter.Close();
                MessageBox.Show("Especialidad " + txtNombreE.Text + " registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargaEspecialidades();
                txtNumeroE.Text = "";
                txtNombreE.Text = "";
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargaEspecialidades();
            CargaMedicos();
        }

        private void btnRegistrarM_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text != "" && txtNombreM.Text != "" && cmbEspecialidadM.SelectedIndex != -1)
            {
                string auxiliar;
                string[] vectorMedicos;
                StreamReader streamReader = new StreamReader("MEDICOS.txt");
                while (streamReader.EndOfStream == false)
                {
                    auxiliar = streamReader.ReadLine();
                    if (auxiliar != "")
                    {
                        vectorMedicos = auxiliar.Split(',');
                        if (vectorMedicos[0] == txtMatricula.Text)
                        {
                            MessageBox.Show("El médico ingresado ya existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            streamReader.Close();
                            return;
                        }
                    }
                }
                streamReader.Close();
                StreamReader streamReaderE = new StreamReader("ESPECIALIDADES.txt");
                int idEspecialidad = 0;
                string auxEsp;
                while (streamReaderE.EndOfStream == false)
                {
                    auxEsp = streamReaderE.ReadLine();
                    if (cmbEspecialidadM.Text == auxEsp.Split(',')[1])
                    {
                        idEspecialidad = int.Parse(auxEsp.Split(',')[0]);
                    }
                }
                streamReaderE.Close();
                StreamWriter streamWriter = new StreamWriter("MEDICOS.txt", true);
                streamWriter.Write(txtMatricula.Text + "," + txtNombreM.Text + "," + idEspecialidad.ToString() + "\n");
                streamWriter.Close();
                MessageBox.Show("Médico " + txtNombreM.Text + " registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargaMedicos();
                txtMatricula.Text = "";
                txtNombreM.Text = "";
                cmbEspecialidadM.SelectedIndex = -1;
                cmbEspecialidadC.Text = "Todos";
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEspecialidadC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string auxiliar;
            string[] vectorMedicos;
            StreamReader streamReader = new StreamReader("MEDICOS.txt");
            dgvConsultas.Rows.Clear();
            StreamReader streamReaderE = new StreamReader("ESPECIALIDADES.txt");
            string especialidad = "";
            int idEspecialidad = 0;
            string auxEsp;
            while (streamReader.EndOfStream == false)
            {
                auxiliar = streamReader.ReadLine();
                if (auxiliar != "")
                {
                    vectorMedicos = auxiliar.Split(',');
                    if (cmbEspecialidadC.Text == "Todas")
                    {
                        while (streamReaderE.EndOfStream == false)
                        {
                            auxEsp = streamReaderE.ReadLine();
                            if (auxiliar.Split(',')[2] == auxEsp.Split(',')[0])
                            {
                                especialidad = auxEsp.Split(',')[1];
                            }
                        }
                        streamReaderE.DiscardBufferedData();
                        streamReaderE.BaseStream.Position = 0;
                        dgvConsultas.Rows.Add(vectorMedicos[0], vectorMedicos[1], especialidad);
                    }
                    else
                    {
                        while (streamReaderE.EndOfStream == false)
                        {
                            auxEsp = streamReaderE.ReadLine();
                            if (cmbEspecialidadC.Text == auxEsp.Split(',')[1])
                            {
                                idEspecialidad = int.Parse(auxEsp.Split(',')[0]);
                            }
                        }
                        streamReaderE.DiscardBufferedData();
                        streamReaderE.BaseStream.Position = 0;
                        if (int.Parse(vectorMedicos[2]) == idEspecialidad)
                        {
                            dgvConsultas.Rows.Add(vectorMedicos[0], vectorMedicos[1], cmbEspecialidadC.Text);
                        }
                    }
                }
            }
            streamReader.Close();
            streamReaderE.Close();
        }
    }
}
