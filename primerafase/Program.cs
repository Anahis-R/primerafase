﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerafase
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipos de datos
            int a, b, suma; ; //declarar una variable tipo entero
            a = 10;
            b = 20;
            suma = a + b;
            Console.WriteLine("La suma de {​​​​0}​​​​ + {​​​​1}​​​​ = {​​​​2}​​​​", a, b, suma);
            Console.ReadKey();
            //tipo de dato: flotante
            float sueldo, egreso, total;
            Console.WriteLine("Ingresa el sueldo de trabajador: ");
            sueldo = float.Parse(Console.ReadLine());



            Console.WriteLine("Ingresa el sueldo de trabajador: ");
            egreso = float.Parse(Console.ReadLine());



            total = sueldo - egreso;
            Console.WriteLine("El liquido a recibir es: {​​​​0}​​​​ ", total);





            //tipo de dato: flotante de doble presicion
            double x1 = 200.5679;
            Console.WriteLine("Tipo de dato double: {​​​​0}​​​​", x1);



            //tipo de dato: caracteres(string)
            String nombre;
            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ", Bienvenidos al curso de Programacion");



            //tipo de dato boleano(tipo logico: verdadero/falso) (true/flase)
            bool sw;



            sw = (a + 50) > b;



            Console.WriteLine("El valor del booleano sw: {​​​​0}​​​​", sw);



            //Pilares fundamentales de la programacion estructuradas
            //ejecucion de sentencias secuenciales
            //uso de estructuras repetitivas
            //uso de estructuras selectivas
            saludos(nombre);
            saludos("Jose Alcivar");
            saludos("Josue Nazareno");
            saludos("Maria Alcivar");



            Console.WriteLine();
            Console.WriteLine("Llamada a funcion que devuelve valor");
            Console.WriteLine("Liquido a recibir para Juan{​​​​0}​​​​", calcularSueldo(300, 200));
            Console.WriteLine("Liquido a recibir para Carlos{​​​​0}​​​​", calcularSueldo(300, 200));
            Console.WriteLine("Liquido a recibir para Lesli{​​​​0}​​​​", calcularSueldo(300, 200));



            Console.WriteLine();
            Console.WriteLine(" * ", figura());
            Console.WriteLine(" *** ", figura());
            Console.WriteLine(" ****** ", figura());
            Console.WriteLine("******** ", figura());



            Console.WriteLine("El doble es :{​​​​0}​​​​", cuadrado(10));



            bateria();



            Multiplicar();
            Console.ReadKey();
        }
    }
}
