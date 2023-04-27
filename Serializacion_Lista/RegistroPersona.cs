using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion_Lista
{
    internal class RegistroPersona
    {
        [Serializable]
        public class Persona
        {
            private string nombre;
            private int edad;
            private string correoElectronico;

            public Persona() : this("", 0, "")
            {

            }

            public Persona(string Vnombre, int Vedad, string VcorreoElectronico)
            {
                Nombre = Vnombre;
                Edad = Vedad;
                CorreoElectronico = VcorreoElectronico;
            }

            public string Nombre { get => nombre; set => nombre = value; }
            public int Edad { get => edad; set => edad = value; }
            public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }

            public override string ToString()
            {
                return "Nombre: " + Nombre + "\n" +
                    "Edad: " + Edad + "\n" +
                    "Correo: " + CorreoElectronico;
            }
        }
    }
}
