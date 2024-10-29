using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Familiar n1 = new Familiar("Abuelo", 89);
            Familiar n2 = new Familiar("Hijo1", 59);
            Familiar n3 = new Familiar("Hijo2", 50);
            Familiar n4 = new Familiar("Nieto1", 47);
            Familiar n5 = new Familiar("Nieto2",35);
            Familiar n6 = new Familiar("Nieto3",10);
            Familiar n7 = new Familiar("Nieto4", 18);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            Visitors visitor = new Visitors(n1);
            Console.WriteLine($"Las edades de los familiares suman: {visitor.ContarEdad(n1)}.");
            Console.WriteLine($"El nombre mas largo de todos es: {visitor.GetNombreMasLargo(n1)}.");
            Console.WriteLine($"El familiar de mayor edad es: {visitor.FamiliarmayorEdad.Nombre}, {visitor.FamiliarmayorEdad.Edad} años.");
        }
    }
}
