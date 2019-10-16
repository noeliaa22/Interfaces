using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Enfermero : Sanitario
    {
        public string Puesto { get; set; } //UCI o Planta

        public Enfermero(string puesto, string dNI, string nombre, double sueldoBase, int edad) : base(dNI, nombre, sueldoBase, edad)
        {
            Puesto = puesto;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"DNI: {DNI}\nNombre: {Nombre}\nEdad: {Edad}\nSueldo final: {CalculaSueldo()}");
            Console.WriteLine($"Puesto: {Puesto}");
        }
        public override double CalculaSueldo()
        {
            double sueldoFinal = 0;
            if (Puesto == "UCI")
            {
                sueldoFinal = SueldoBase + 200;
            }
            else if (Puesto == "Planta")
            {
                sueldoFinal = SueldoBase;
            }
            return sueldoFinal;
        }
    }
}
