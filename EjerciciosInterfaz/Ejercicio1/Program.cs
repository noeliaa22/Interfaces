using System;
using System.Collections.Generic; //IMPORTANTE
using System.Linq; //Para usar el Element At


namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desde el método main() de la clase principal crear una lista de sanitarios 
             * y añadir 2 médicos y 3 enfermeros y realizar las siguientes operaciones: */



            List<Sanitario> sanitarios = new List<Sanitario>()
            {
                new Medico("Neurólogo",56,"12345678A","Dr. Lopez",1500,67),
                new Medico("Cardiólogo",34,"12345679B","Dra. Mendez",1500,38),
                new Enfermero("UCI","87654321N","Andrea",1000,28),
                new Enfermero("UCI","87654322H","Sandra",1000,25),
                new Enfermero("Planta","87654323K","Ane",1000,30),
            };

            // 1-Mostrar los datos de todos los sanitarios

            foreach (Sanitario item in sanitarios)
            {
                item.Mostrar();
                Console.WriteLine(item.GetType().Name);
                Console.WriteLine();
            }

            Console.WriteLine("\n\nSE LES HA SUBIDO UN 1% EL SUELDO\nDATOS ACTUALIZADOS:\n");

            //2-Subirles el sueldo un 1%
            foreach (Sanitario item in sanitarios)
            {
                item.SueldoBase = item.SueldoBase * 1.01;
            }

            //  3-Mostrar de nuevo los datos
            foreach (Sanitario item in sanitarios)
            {
                item.Mostrar();
                Console.WriteLine(item.GetType().Name);
                Console.WriteLine();
            }

            Console.WriteLine("\n\nDE LOS SANITARIOS PUEDEN JUBILARSE:\n");
            //   4-Mostrar los datos de los que se puedan jubilar
            foreach (Sanitario item in sanitarios)
            {
                if (item.Jubilable())
                {
                    item.Mostrar();
                    Console.WriteLine(item.GetType().Name);
                    Console.WriteLine();
                }
            }




        }
    }
}
