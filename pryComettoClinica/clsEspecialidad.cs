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
        public void CargarEspecialidades(ComboBox cmbEspecialidadM, ComboBox cmbEspecialidadC)
        {
            string auxiliar;

            cmbEspecialidadM.Items.Clear();
            cmbEspecialidadC.Items.Clear();

            using (StreamReader streamReader = new StreamReader("ESPECIALIDADES.txt"))
            {
                while (streamReader.EndOfStream == false)
                {
                    auxiliar = streamReader.ReadLine();
                    Nombre = auxiliar.Split(',')[1];
                    
                    cmbEspecialidadM.Items.Add(Nombre);
                    cmbEspecialidadC.Items.Add(Nombre);
                }
            }

            cmbEspecialidadC.Items.Add("Todas");
            cmbEspecialidadC.Text = "Todas";
        }
    }
}
