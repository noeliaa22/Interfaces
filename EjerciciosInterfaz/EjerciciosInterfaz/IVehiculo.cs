using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosInterfaz
{
    interface IVehiculo
    {
        void Arrancar();
        void Frenar();
        void Aparcar();
        void Acelerar(int cuanto);

    }
}
