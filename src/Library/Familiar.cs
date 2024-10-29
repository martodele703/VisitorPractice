using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Familiar
    {
        private string nombre;
        private int edad;
        private List<Familiar> hijos = new List<Familiar>();

        public string Nombre {
            get
            {
                return this.nombre;
            }
        }

        public int Edad {
            get
            {
                return this.edad;
            }
        }

        public ReadOnlyCollection<Familiar> Hijos {
            get
            {
                return this.hijos.AsReadOnly();
            }
        }

        public Familiar(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public void AddChildren(Familiar familiar)
        {
            this.hijos.Add(familiar);
        }

        public int AceptarContadorEdad(Visitors visitor)
        {
            return visitor.ContadorEdad + Edad;
        }

        public bool AceptarLongitudNombre(Visitors visitor)
        {
            return visitor.NombreMasLargo.Length < Nombre.Length;
        }
    }
}
