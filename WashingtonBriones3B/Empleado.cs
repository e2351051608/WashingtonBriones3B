using System;
using System.Collections.Generic;
using System.Text;

namespace WashingtonBriones3B
{
    public class Empleado
    {
        private string apellidos;
        private string nombres;
        private int edad;
        private string departamento;
     
        public Empleado(string apellidos, string nombres, int edad, string departamento)
        {
            this.apellidos = apellidos;
            this.nombres = nombres;
            this.edad = edad;
            this.departamento = departamento;

        }
        public string getapellidos()
        {
            return apellidos;
        }
        public void setapellidos(string apeliidos)
        {
            this.apellidos = apeliidos;
        }

        public string getnombres()
        {
            return nombres;
        }
        public void setnombres(string nombres)
        {
            this.nombres = nombres;
        }

        public int getedad()
        {
            return edad;
        }
        public void setedad(int edad)
        {
            this.edad = edad;
        }

        public string getdepartamenteo()
        {
            return departamento;
        }
        public void setdepartamento(string departamento)
        {
            this.departamento = departamento;
        }


    }
}
