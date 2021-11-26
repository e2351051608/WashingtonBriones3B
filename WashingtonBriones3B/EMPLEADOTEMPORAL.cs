using System;
using System.Collections.Generic;
using System.Text;

namespace WashingtonBriones3B
{
    public class EMPLEADOTEMPORAL : Empleado
    {
        public class EMPLEADOTEMPORAL
        {
            string Fechadeingreso;
            string fechadesalida;
            int sueldofijo;
            public EMPLEADOTEMPORAL(string Fechadeingreso, string fechasalida, int sueldofijo)
            {
                this.Fechadeingreso = Fechadeingreso;
                this.fechadesalida = fechasalida;
                this.sueldofijo = sueldofijo;
            }
            public int getsueldofijo()
            {
                return sueldofijo;
            }
            public void setsueldofijo(int sueldofijo)
            {
                this.sueldofijo = sueldofijo;
            }
        }
    }
}