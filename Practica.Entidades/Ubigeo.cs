using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class Ubigeo
    {
        private string _ubigeo;
        Departamento _departamento;
        Provincia _provi;
        Distrito _distr;

        public Ubigeo(Departamento dep, Provincia prov, Distrito dis)
        {
            _departamento = dep;
            _provi = prov;
            _distr = dis;
        }

        public Departamento Departamento { get { return _departamento; } }
        public Provincia Provincia { get { return _provi; } }
        public Distrito Distrito { get { return _distr; } }

        public string Numubigeo
        {
            get
            {
                if (_departamento.Nombredepa == "Lima" && _provi.Nombreprovi == "Lima")
                {
                    _ubigeo = "150100";

                } else if (_departamento.Nombredepa == "Lima" && _provi.Nombreprovi == "Cañete")
                {
                    _ubigeo = "4545454";
                }
                            
                else
                {
                    _ubigeo = "666666";
                }

                return _ubigeo;
            }

        }

    }
}
