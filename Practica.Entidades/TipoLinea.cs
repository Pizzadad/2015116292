using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class TipoLinea
    {
        private string _tipolinea;

        public TipoLinea(string tipolinea)
        {
            _tipolinea = tipolinea;
        }
        public string NombreAdmi { get { return _tipolinea; } }
    }
}
