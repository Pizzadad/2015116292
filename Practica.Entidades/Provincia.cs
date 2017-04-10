using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class Provincia
    {
        private string _nombreprovi;
        private string _nombredis;
        Distrito dis;


        public Provincia(Distrito distrito)
        {
            dis = distrito;
        }

        public Distrito Distrito { get { return dis; } }

        public string Nombreprovi { get
            {

                if (dis.Nombredis == "San Juan de Lurigancho")
                {
                    _nombreprovi = "Lima";
                    
                } else if(dis.Nombredis == "Cerro Azul")
                {
                    _nombreprovi = "Cañete";
                }

                else { _nombreprovi = "Azeroth"; }
                
                return _nombreprovi;
            }

        }
      
    }
}
