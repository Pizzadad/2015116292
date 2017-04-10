using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class Trabajador
    {
        Random r = new Random();
        private string _nombre, _tipotrab;
        
       
        public string Tipotrab {
            get
            {
                int aleatorio3 = r.Next(2);

                switch (aleatorio3)
                {
                    case 1:
                        _tipotrab = "Asesor de Ventas"; break;
                    default:
                        _tipotrab = "Promotor de Ventas"; break;
                }
                return _tipotrab;
            }
        }
        public string Nombre
        {
            get
            {
                int aleatorio2 = r.Next(2);

                switch (aleatorio2)
                {
                    case 1:
                        _nombre = "Carlos"; break;
                    default:
                        _nombre = "Pablo"; break;
                }
                return _nombre;
            }
        }


    }

}

