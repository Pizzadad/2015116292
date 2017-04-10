using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Entidades
{
    public class Evaluacion
    {
        List<Cliente> _cliente;
        List <lineatelefonica> _lineatele;
       

      /*  private Plan _pla ;
        private TipoPlan _tipoplan;
        private Trabajador _trabajador;
        private Tipodeevaluacion _tipoevalu;
        private Estadodeevaluacion _estadoevalu;
        private Distrito _dis;
        private Provincia _pro;
        private Departamento _dep;
        private Ubigeo _ubi;
        private Direccion _dire;
        private TipoLinea _tipolinea;
        private AdmiLinea _admilinea;
        */

        public Evaluacion()
        {
            _cliente = new List<Cliente>();
           
            _lineatele = new List<lineatelefonica>();
        }
    
        public void Agregar(string dni, string nombre)
        {
            _cliente.Add(new Cliente (dni, nombre)  );
        }

        public void mostrarevaluacion(string dni, string nombre, string numero, string tipolinea, string administrador, string tipoplan, string respuesta, string nombredis, string modeloequipo)
        {
            Trabajador _trabajador = new Trabajador();

            TipoPlan _tipoplan = new TipoPlan(tipoplan);
            Plan _pla = new Plan(_tipoplan);

            Tipodeevaluacion _tipoevalu = new Tipodeevaluacion();
            Estadodeevaluacion _estadoevalu = new Estadodeevaluacion(respuesta);
            Distrito _dis = new Distrito(nombredis);
            Provincia _pro = new Provincia( _dis);
            Departamento _dep = new Departamento(_pro);
            Ubigeo _ubi = new Ubigeo(_dep,_pro,_dis);
            Direccion _dire = new Direccion(_ubi);
            Centrodeatencion _centroatencion = new Centrodeatencion(_dire);

            TipoLinea _tipolinea = new TipoLinea(tipolinea);

           

            lineatelefonica _linea = new lineatelefonica(_tipolinea);
            AdmiLinea _admilinea = new AdmiLinea(_linea);

            Equipocelular _equipocelular = new Equipocelular(modeloequipo);
            AdministradorEquipo _admiequipo = new AdministradorEquipo(_equipocelular);


            _lineatele.Add(_linea);

            Console.WriteLine("Dni del cliente: [{0}]", dni);
            Console.WriteLine("Nombre del cliente: [{0}]", nombre);
            Console.WriteLine("Distrito del cliente: [{0}]", nombredis);
            Console.WriteLine("Provincia del cliente: [{0}]", _pro.Nombreprovi);
            Console.WriteLine("Ubigeo y Nombre del departamento: [{0}]", _ubi.Numubigeo + "," + _dep.Nombredepa);
            Console.WriteLine("La direccion es: [{0}]", _dire.Direc + ","+ nombredis);
            Console.WriteLine("Centro de Atencion: [{0}]", _centroatencion.Nombre);
            Console.WriteLine("Numero del cliente - Tipo de Linea - Administrador de Linea: [{0}]", numero + " , " + tipolinea +" , " +administrador);
            Console.WriteLine("Modelo del equipo - Administrador del Equipo: [{0}]", modeloequipo + " , " + _admiequipo.Nombreadmiequipo );
            Console.WriteLine("El tipo de plan es: [{0}]", tipoplan);
            Console.WriteLine("La descripcion del plan es: [{0}]", _pla.Descripcion);

            if (tipoplan == "Prepago") {

                Console.WriteLine("***NO HAY EVALUACION***");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("***EVALUACION***");
                Console.WriteLine("El nombre del responsable: " + _trabajador.Nombre);
                Console.WriteLine("El cargo del responsable: " + _trabajador.Tipotrab);
                Console.WriteLine("El tipo de evaluacion es: " + _tipoevalu.Estado);
                Console.WriteLine("El estado de evaluacion es [{0}]", respuesta);
                Console.WriteLine();

            }
        }
    }
}
