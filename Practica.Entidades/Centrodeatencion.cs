using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class Centrodeatencion
    {
        private string nombre;
        private Direccion _direccion;

        public Centrodeatencion(Direccion direccion)
        {
            _direccion = direccion;
        }

        public Direccion Direccion { get { return _direccion; } }

        public string Nombre
        {
            get
            {
                if (_direccion.Direc== "Av.Circunvalacion 425")
                {
                    nombre = "Centro de Atencion, Campoy";

                }
                else if (_direccion.Direc == "Calle Jorge Chavez 440")
                {
                    nombre = "Centro de Atencion, Playa Cerro Azul";
                }

                else { nombre = "Centro de Atencion, La Horda"; }

                return nombre;
            }

        }

    }
}
