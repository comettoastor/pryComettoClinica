using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pryComettoClinica
{
    internal class clsEspecialidad
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public string Grabar(string txtID, string txtNombre)
        {
            if (txtID == "" || txtNombre == "")
            {
                return "Faltan datos por completar!";
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
                        return "Ya existe una especialidad con ese ID";
                    }
                }
            }

            using (StreamWriter streamWriter = new StreamWriter("ESPECIALIDADES.txt",true))
            {
                streamWriter.WriteLine(ID + "," + Nombre);
                txtID = "";
                txtNombre = "";
                return "Especialidad " + Nombre + " registrada correctamente";
            }
        }
    }
}
