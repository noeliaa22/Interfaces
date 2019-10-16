using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Medico:Sanitario
    {
        public string Especialidad { get; set; }
        public int NumeroPacientes { get; set; }

        public Medico(string especialidad, int numeroPacientes, string dNI, string nombre, double sueldoBase, int edad):base(dNI,nombre,sueldoBase,edad)
        {
            Especialidad = especialidad;
            NumeroPacientes = numeroPacientes;
        }
        public override void Mostrar()
        {
            Console.WriteLine($"DNI: {DNI}\nNombre: {Nombre}\nEdad: {Edad}\nSueldo final: {CalculaSueldo()}");
            Console.WriteLine($"Especialidad: {Especialidad}\nNº Pacientes: {NumeroPacientes}");
        }
        public override double CalculaSueldo()
        {
            double sueldoFinal = SueldoBase + (NumeroPacientes * 1.2);
            return sueldoFinal;
        }

    }
}
