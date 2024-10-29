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
            Familiar n6 = new Familiar("BisNieto1",10);
            Familiar n7 = new Familiar("BisNieto2", 18);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            ContadorEdad contador = new ContadorEdad(n1.Edad);
            Console.WriteLine($"Las edades de los familiares suman: {contador.ContarEdad(n1)}");
        }
    }
}
