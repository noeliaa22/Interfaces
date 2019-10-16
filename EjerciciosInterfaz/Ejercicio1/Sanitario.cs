using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Sanitario:IPersonalLaboral
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public double SueldoBase { get; set; }
        public int Edad { get; set; }

        public Sanitario(string dNI, string nombre, double sueldoBase, int edad)
        {
            DNI = dNI;
            Nombre = nombre;
            SueldoBase = sueldoBase;
            Edad = edad;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"DNI: {DNI}\nNombre: {Nombre}\nEdad: {Edad}\nSueldo final: {CalculaSueldo()}");
        }

        public bool Jubilable()
        {
            if (Edad>=65)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual double CalculaSueldo()
        {
            return SueldoBase;
        }
    }
}
