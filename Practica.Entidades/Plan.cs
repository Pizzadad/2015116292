using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    class Plan
    {
        private string _descripcion;
        TipoPlan _tipoplan;
        Random r = new Random();

        public Plan(TipoPlan tp)
        {
            _tipoplan = tp;
        }

        public TipoPlan Tipoplan { get { return _tipoplan; } }

        public string Descripcion
        {
            get
            {

                if (_tipoplan.Tipoplans == "PostPago")
                {
                    int aleatorio1 = r.Next(2);

                    switch (aleatorio1)
                    {
                        case 1:
                            _descripcion = "Plan 99 => Whattsap, Messenger, Snapchat, Spotify, 500mb"; break;
                        default:
                            _descripcion = "Plan 50 => Whattsap, Messenger, Snapchat, Spotify, 100mb"; break;
                    }


                }

                else { _descripcion = "No hay plan, eres prepago"; }

                return _descripcion;
            }

        }
    }
}
