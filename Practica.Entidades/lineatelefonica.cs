using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class lineatelefonica
    {
        private string _numero;
        private TipoLinea _tipolinea;
        //private Cliente _cli;

       public lineatelefonica(TipoLinea tipolinea)
        {
            _tipolinea = tipolinea;
        }

        public string Numero { get { return _numero; } }
        public TipoLinea Admilinea { get { return _tipolinea; } }
        
    }
}

