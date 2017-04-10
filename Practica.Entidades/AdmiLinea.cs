using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class AdmiLinea
    {
        private string _nombre;
        private lineatelefonica _lineatele;

        public AdmiLinea(lineatelefonica lineatele)
        {
            _lineatele = lineatele;
        }

        public string Nombre { get { return _nombre; } }
        public lineatelefonica Lineatelefonica { get { return _lineatele; } }
    }
}
