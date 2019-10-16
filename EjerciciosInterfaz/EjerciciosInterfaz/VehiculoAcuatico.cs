using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosInterfaz
{
    class VehiculoAcuatico : Vehiculo,IVehiculoAcuatico //No es necesario implementar IVehiculo porque ya lo implementa la clase padre
    {
        public int Eslora { get; set; }

        public VehiculoAcuatico(int eslora, string marca, string modelo):base(marca,modelo)
        {
            Eslora = eslora;
        }

        public void Flotar()
        {
            Console.WriteLine("Ha flotado");
        }
    }
}
