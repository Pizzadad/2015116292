using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class Estadodeevaluacion
    {
        Random r = new Random();
        private string _estado;

        public Estadodeevaluacion(string estado)
        {
            _estado = estado;
            
        }

        public string Estado
        {
            get { return _estado; }
        }

    }
}
