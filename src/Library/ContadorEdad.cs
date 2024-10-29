using System;

namespace Library;

public class ContadorEdad
{
    public int contador { get; set; }

    public ContadorEdad(int edadPrimerFamiliar)
    {
        this.contador = edadPrimerFamiliar;
    }

    public int ContarEdad(Familiar primerFamiliar)
    {
        // Imprimir el nombre y la edad del familiar actual
        Console.WriteLine($"{primerFamiliar.Nombre}, Edad: {primerFamiliar.Edad}");

        // Recorrer todos los hijos
        foreach (var hijo in primerFamiliar.Hijos)
        {   
            this.contador = hijo.AceptarContador(this);
            ContarEdad(hijo);
        }

        return contador;
    }
    
}