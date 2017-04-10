using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class AdministradorEquipo
    {
        string _nombreadmiequipo;
        Equipocelular _equipocelular;

        public AdministradorEquipo(Equipocelular equipocelular)
        {
            _equipocelular = equipocelular;
        }

        public Equipocelular Equipocelular { get { return _equipocelular; } }
        public string Nombreadmiequipo { get {
                if (_equipocelular.Modeloequipo == "Iphone")
                {
                    _nombreadmiequipo = "Apple";

                }
                
                else { _nombreadmiequipo = "Compañia Samsung"; }


                return _nombreadmiequipo; }
        }
    }
}
