using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class Tipodeevaluacion
    {
        Random r = new Random();
        private string _tipoevaluacion;

        public string Estado
        {
            get
            {
                int aleatorio4 = r.Next(3);

                switch (aleatorio4)
                {
                    case 1:
                        _tipoevaluacion = "Renovacion de Contrato"; break;
                    case 2:
                        _tipoevaluacion = "Portabilidad"; break;
                    default:
                        _tipoevaluacion = "Linea Nueva"; break;
                }
                return _tipoevaluacion;
            }
        }

    }
}
