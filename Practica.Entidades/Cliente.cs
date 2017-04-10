using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class Cliente
    {
        private string _nombre, _dni;
   
        public Cliente(string nombre, string dni)
        {
            _nombre = nombre;
            _dni = dni;
                    }

        public string Nombre { get { return _nombre; } }
        public string Dni { get { return _dni; } }
    }
}
