using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class TipoPlan
    {
        private string _tipoplan;

        public TipoPlan(string tipoplan)
        {
            _tipoplan = tipoplan;
        }

        public string Tipoplans { get { return _tipoplan; } }

    }
}
