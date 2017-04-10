using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class Distrito
    {
        private string _nombredis;

        public Distrito(string nombredis)
        {
            _nombredis = nombredis;
        }

        public string Nombredis { get { return _nombredis; } }
        
    }
}
