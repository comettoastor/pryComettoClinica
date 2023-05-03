using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryComettoClinica
{
    internal class clsEspecialidad
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public void Grabar(string txtID, string txtNombre)
        {
            if (txtID == "" || txtNombre == "")
            {
                MessageBox.Show("Faltan datos por completar!", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ID = int.Parse(txtID);
            Nombre = txtNombre;

            string auxiliar;

            using (StreamReader streamReader = new StreamReader("ESPECIALIDADES.txt"))
            {
                while (streamReader.EndOfStream == false)
                {
                    auxiliar = streamReader.ReadLine();
                    if (ID == int.Parse(auxiliar.Split(',')[0]))
                    {
                        MessageBox.Show("Ya existe una especialidad con ese ID","Repetido",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            
            using (StreamWriter streamWriter = new StreamWriter("ESPECIALIDADES.txt",true))
            {
                streamWriter.WriteLine(ID + "," + Nombre);
                txtID = "";
                txtNombre = "";
                MessageBox.Show("Especialidad " + Nombre + " registrada correctamente","Registrada",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        public void ListarEspecialidades(List<clsEspecialidad> lstEspecialidades, clsEspecialidad objEspecialidad)
        {
            string auxiliar;
            string[] vecEspecialidad;

            using (StreamReader streamReader = new StreamReader("ESPECIALIDADES.txt"))
            {
                while (streamReader.EndOfStream == false)
                {
                    auxiliar = streamReader.ReadLine();
                    vecEspecialidad = auxiliar.Split(',');
                    ID = int.Parse(vecEspecialidad[0]);
                    Nombre = vecEspecialidad[1];
                    lstEspecialidades.Add(objEspecialidad);
                }
            }

            
        }

        public void CargarEspecialidades(List<clsEspecialidad> lstEspecialidades, ComboBox cmbEspecialidadC, ComboBox cmbEspecialidadM)
        {
            foreach (clsEspecialidad especialidad in lstEspecialidades)
            {
                cmbEspecialidadC.Items.Add(especialidad.Nombre);
                cmbEspecialidadM.Items.Add(especialidad.Nombre);
            }

            cmbEspecialidadC.Items.Add("Todas");
            cmbEspecialidadC.Text = "Todas";
        }
    }
}
