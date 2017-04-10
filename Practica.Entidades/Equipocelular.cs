using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class Equipocelular
    {
        private string _modeloequipo;
        public Equipocelular (string modeloequipo)
        {
            _modeloequipo = modeloequipo;
        }
        public string Modeloequipo { get { return _modeloequipo; } }

    }
}
