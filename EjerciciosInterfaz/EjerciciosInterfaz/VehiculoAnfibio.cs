using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosInterfaz
{
    class VehiculoAnfibio: Vehiculo,IVehiculoAcuatico,IVehiculoTerrestre
    {
        public int MetrosSumergibles { get; set; }

        public VehiculoAnfibio(int metrosSumergibles,string marca,string modelo):base(marca,modelo)
        {
            MetrosSumergibles = metrosSumergibles;
        }

        public void Flotar()
        {
            throw new NotImplementedException();
        }

        public void SubirCuesta()
        {
            throw new NotImplementedException();
        }
    }
}
