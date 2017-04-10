using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class Departamento
    {

        private string _nombredepa;
        Provincia prov;


        public Departamento(Provincia provincia)
        {
            prov = provincia;
        }

        public Provincia Provincia { get { return prov; } }
        public string Nombredepa { get
            {
                if (prov.Nombreprovi == "Lima" || prov.Nombreprovi == "Cañete")
                {
                    _nombredepa = "Lima";

                } 
                else { _nombredepa = "Warcraft"; }
                return _nombredepa;
            }

        }
         

    }
}
