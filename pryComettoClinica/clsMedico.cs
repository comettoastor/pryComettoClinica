using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryComettoClinica
{
    internal class clsMedico
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public int Especialidad { get; set; }

        public void GrabarMedico(int txtMatricula, string txtNombre)
        {
            Matricula = txtMatricula;
            Nombre = txtNombre;


        }
    }
}
