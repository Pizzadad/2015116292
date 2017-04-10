using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.Entidades;
using System.Threading;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            var dni = "999999999";
            var nombre = "Dodo";
            var numero = "123456789";
            var tipolinea = "Celular";
            var administrador = "Entel";
            var tipoplan = "Prepago";
            var estado = "--------";
            var nombredis = "San Juan de Lurigancho";
            var modelo = "Iphone";


            var dni1 = "88888888";
            var nombre1 = "Sushi";
            var numero1 = "454545454";
            var tipolinea1 = "Celular";
            var administrador1 = "Claro";
            var tipoplan1 = "PostPago";
            var estado1 = "Aprobado";
            var nombredis1 = "Cerro Azul";
            var modelo1 = "J7";


            var dni2 = "77777777";
            var nombre2 = "Pizza";
            var numero2 = "666666666";
            var tipolinea2 = "Celular";
            var administrador2 = "Bitel";
            var tipoplan2 = "PostPago";
            var estado2 = "Desaprobado";
            var nombredis2 = "Horda";
            var modelo2 = "S7";

            var dni3 = "66666666";
            var nombre3 = "Dad";
            var numero3 = "555555555";
            var tipolinea3 = "Celular";
            var administrador3 = "Tuenti";
            var tipoplan3 = "PostPago";
            var estado3 = "Desaprobado";
            var nombredis3 = "San Juan de Lurigancho";
            var modelo3 = "S4";


            var evaluaciones = new Evaluacion();

            evaluaciones.Agregar(dni, nombre);
            evaluaciones.Agregar(dni1, nombre1);
            evaluaciones.Agregar(dni2, nombre2);


            evaluaciones.mostrarevaluacion(dni, nombre, numero, tipolinea, administrador, tipoplan, estado, nombredis, modelo);
            Thread.Sleep(2000);

            evaluaciones.mostrarevaluacion(dni1, nombre1, numero1, tipolinea1, administrador1, tipoplan1, estado1, nombredis1, modelo1);
            Thread.Sleep(2000);

            evaluaciones.mostrarevaluacion(dni2, nombre2, numero2, tipolinea2, administrador2, tipoplan2, estado2, nombredis2, modelo2);
            Thread.Sleep(2000);

            evaluaciones.mostrarevaluacion(dni3, nombre3, numero3, tipolinea3, administrador3, tipoplan3, estado3, nombredis3, modelo3);
        }
    }
}
