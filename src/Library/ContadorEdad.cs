using System;

namespace Library;

public class ContadorEdad
{
    public int contador { get; set; }

    public ContadorEdad()
    {
        this.contador = 0;
    }

    public int ContarEdad(Familiar primerFamiliar)
    {
        this.contador += primerFamiliar.Edad;

        // Imprimir el nombre y la edad del familiar actual
        Console.WriteLine($"{primerFamiliar.Nombre}, Edad: {primerFamiliar.Edad}");

        // Recorrer todos los hijos
        foreach (var hijo in primerFamiliar.Hijos)
        {
            ContarEdad(hijo);
        }

        return contador;
    }
    
}