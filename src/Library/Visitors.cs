using System;

namespace Library;

public class Visitors
{
    public int ContadorEdad { get; set; }
    public string NombreMasLargo { get; set; }
    public Familiar FamiliarmayorEdad { get; set; }

    public Visitors(Familiar primerFamiliar)
    {
        this.ContadorEdad = primerFamiliar.Edad;
        this.FamiliarmayorEdad = primerFamiliar;
        this.NombreMasLargo = primerFamiliar.Nombre;
    }

    public int ContarEdad(Familiar primerFamiliar)
    {
        // Imprimir el nombre y la edad del familiar actual
        Console.WriteLine($"{primerFamiliar.Nombre}, Edad: {primerFamiliar.Edad}");

        // Recorrer todos los hijos
        foreach (var hijo in primerFamiliar.Hijos)
        {   
            this.ContadorEdad = hijo.AceptarContadorEdad(this);
            ContarEdad(hijo);
        }

        return ContadorEdad;
    }

    public string GetNombreMasLargo(Familiar primerFamiliar)
    {
        foreach (var hijo in primerFamiliar.Hijos)
        {
            if (hijo.AceptarLongitudNombre(this))
            {
                NombreMasLargo = hijo.Nombre;
            }
            GetNombreMasLargo(hijo);
        }
        return NombreMasLargo;
    }

    public Familiar GetMayorEdad(Familiar primerFamiliar)
    {
        foreach (var hijo in primerFamiliar.Hijos)
        {
            if (hijo. Edad > FamiliarmayorEdad.Edad)
            {
                FamiliarmayorEdad = hijo;
            }
            GetMayorEdad(hijo);
        }

        return FamiliarmayorEdad;
    }
    
}