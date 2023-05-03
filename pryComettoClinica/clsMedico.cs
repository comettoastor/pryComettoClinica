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

        public void ListarMedicos(DataGridView dgvConsultas,clsMedico objMedico, List<clsMedico> lstMedicos, ComboBox cmbEspecialidadC)
        {
            string auxiliar;
            string[] vectorMedicos;

            using (StreamReader streamReader = new StreamReader("MEDICOS.txt"))
            {
                while (streamReader.EndOfStream == false)
                {
                    auxiliar = streamReader.ReadLine();
                    if (auxiliar != "")
                    {
                        vectorMedicos = auxiliar.Split(',');
                        objMedico.Matricula = int.Parse(vectorMedicos[0]);
                        objMedico.Nombre = vectorMedicos[1];
                        objMedico.Especialidad = int.Parse(vectorMedicos[2]);
                        lstMedicos.Add(objMedico);
                    }
                }
            }

            dgvConsultas.Rows.Clear();

            string especialidad = "";
            int idEspecialidad = 0;
            string auxEsp;

            using (StreamReader streamReader = new StreamReader("MEDICOS.txt"))
            {
                while (streamReader.EndOfStream == false)
                {
                    auxiliar = streamReader.ReadLine();
                    if (auxiliar != "")
                    {
                        vectorMedicos = auxiliar.Split(',');
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
                                dgvConsultas.Rows.Add(vectorMedicos[0], vectorMedicos[1], especialidad);
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
                                streamReaderE.DiscardBufferedData();
                                streamReaderE.BaseStream.Position = 0;
                                if (int.Parse(vectorMedicos[2]) == idEspecialidad)
                                {
                                    dgvConsultas.Rows.Add(vectorMedicos[0], vectorMedicos[1], cmbEspecialidadC.Text);
                                }
                            }
                        }
                    }
                }
            }
            
        }

        public void Grabar(string txtMatricula,string txtNombre, ComboBox cmbEspecialidadM, ComboBox cmbEspecialidadC)
        {
            if (txtMatricula != "" && txtNombre != "" && cmbEspecialidadM.SelectedIndex != -1)
            {
                string auxiliar;
                string[] vectorMedicos;
                using (StreamReader streamReader = new StreamReader("MEDICOS.txt"))
                {
                    while (streamReader.EndOfStream == false)
                    {
                        auxiliar = streamReader.ReadLine();
                        vectorMedicos = auxiliar.Split(',');
                        if (vectorMedicos[0] == txtMatricula)
                        {
                            MessageBox.Show("El médico ingresado ya existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                int idEspecialidad = 0;
                string auxEsp;

                using (StreamReader streamReaderE = new StreamReader("ESPECIALIDADES.txt"))
                {
                    while (streamReaderE.EndOfStream == false)
                    {
                        auxEsp = streamReaderE.ReadLine();
                        if (cmbEspecialidadM.Text == auxEsp.Split(',')[1])
                        {
                            idEspecialidad = int.Parse(auxEsp.Split(',')[0]);
                        }
                    }
                }
                
                using (StreamWriter streamWriter = new StreamWriter("MEDICOS.txt", true))
                {
                    streamWriter.Write(txtMatricula + "," + txtNombre + "," + idEspecialidad.ToString() + "\n");
                    streamWriter.Close();
                    MessageBox.Show("Médico " + txtNombre + " registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatricula = "";
                    txtNombre = "";
                    cmbEspecialidadM.SelectedIndex = -1;
                    cmbEspecialidadC.Text = "Todos";
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
