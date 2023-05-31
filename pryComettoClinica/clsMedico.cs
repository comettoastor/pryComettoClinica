using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryComettoClinica
{
    internal class clsMedico
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public int Especialidad { get; set; }

        public void ListarMedicos(DataGridView dgvConsultas, ComboBox cmbEspecialidadC)
        {
            dgvConsultas.Rows.Clear();

            string auxiliar;
            string especialidad = "";
            int idEspecialidad = 0;
            string auxEsp;

            using (StreamReader streamReader = new StreamReader("MEDICOS.txt"))
            {
                while (streamReader.EndOfStream == false)
                {
                    auxiliar = streamReader.ReadLine();
                    if (cmbEspecialidadC.Text == "Todas")
                    {
                        using (StreamReader streamReaderE = new StreamReader("ESPECIALIDADES.txt"))
                        {
                            while (streamReaderE.EndOfStream == false)
                            {
                                auxEsp = streamReaderE.ReadLine();
                                if (auxiliar.Split(',')[2] == auxEsp.Split(',')[0])
                                {
                                    especialidad = auxEsp.Split(',')[1];
                                }
                            }
                            dgvConsultas.Rows.Add(auxiliar.Split(',')[0], auxiliar.Split(',')[1], especialidad);
                        }
                    }
                    else
                    {
                        using (StreamReader streamReaderE = new StreamReader("ESPECIALIDADES.txt"))
                        {
                            while (streamReaderE.EndOfStream == false)
                            {
                                auxEsp = streamReaderE.ReadLine();
                                if (cmbEspecialidadC.Text == auxEsp.Split(',')[1])
                                {
                                    idEspecialidad = int.Parse(auxEsp.Split(',')[0]);
                                }
                            }
                            if (int.Parse(auxiliar.Split(',')[2]) == idEspecialidad)
                            {
                                dgvConsultas.Rows.Add(auxiliar.Split(',')[0], auxiliar.Split(',')[1], cmbEspecialidadC.Text);
                            }
                        }
                    }
                }
            }
            
        }

        public void Grabar(TextBox txtMatricula, TextBox txtNombre, ComboBox cmbEspecialidadM, ComboBox cmbEspecialidadC)
        {
            if (txtMatricula.Text != "" && txtNombre.Text != "" && cmbEspecialidadM.SelectedIndex != -1)
            {
                string auxiliar;
                using (StreamReader streamReader = new StreamReader("MEDICOS.txt"))
                {
                    while (streamReader.EndOfStream == false)
                    {
                        auxiliar = streamReader.ReadLine();
                        if (auxiliar.Split(',')[0] == txtMatricula.Text)
                        {
                            MessageBox.Show("El médico ingresado ya existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                int idEspecialidad = 0;

                using (StreamReader streamReaderE = new StreamReader("ESPECIALIDADES.txt"))
                {
                    while (streamReaderE.EndOfStream == false)
                    {
                        auxiliar = streamReaderE.ReadLine();
                        if (cmbEspecialidadM.Text == auxiliar.Split(',')[1])
                        {
                            idEspecialidad = int.Parse(auxiliar.Split(',')[0]);
                        }
                    }
                }
                
                using (StreamWriter streamWriter = new StreamWriter("MEDICOS.txt", true))
                {
                    streamWriter.Write(txtMatricula.Text + "," + txtNombre.Text + "," + idEspecialidad.ToString() + "\n");
                    MessageBox.Show("Médico " + txtNombre.Text + " registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatricula.Text = "";
                    txtNombre.Text = "";
                    cmbEspecialidadM.SelectedIndex = -1;
                    cmbEspecialidadC.Text = "Todos";
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
