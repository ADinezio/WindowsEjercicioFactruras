using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtorsCasos.Caso1
{
    public class Cliente
    {
        public Cliente() { }
        public Cliente(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Usuario usuario { get; set; }

    }
}
