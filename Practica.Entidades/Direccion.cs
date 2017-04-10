using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class Direccion
    {
        private string _direc;
        Ubigeo _ubigeo;
        Random r = new Random();

        public Direccion(Ubigeo ubi)
        {
            _ubigeo = ubi;
        }

        public Ubigeo Ubigeo { get { return _ubigeo; } }

        public string Direc
        {
            get
            {
                if (_ubigeo.Numubigeo == "150100")
                {
                     _direc = "Av.Circunvalacion 425"; 
                       
                 } else if (_ubigeo.Numubigeo == "4545454")
                {
                    _direc = "Calle Jorge Chavez 440";
                }
                               
                else { _direc = "Av.Aca No Debiste entrar 666"; }

                return _direc;
            }

        }

    }
}
