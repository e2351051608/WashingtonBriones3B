using System;
using System.Collections.Generic;
using System.Text;

namespace WashingtonBriones3B
{
    public class PERSONAS
    {
        private string apellidos;
        private string nombre;
        private int ID;
        private string ESTADOCIVIL;

        public PERSONAS(string apellidos, string nombre, int ID, string ESTADOCIVIL)
        {
            this.apellidos = apellidos;
            this.nombre = nombre;
            this.ID = ID;
            this.ESTADOCIVIL = ESTADOCIVIL;

        }
        public string getapellidos()
        {
            return apellidos;
        }
        public void setapellidos(string apeliidos)
        {
            this.apellidos = apeliidos;
        }

        public string getnombre()
        {
            return nombre;
        }
        public void setnombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int getID()
        {
            return ID;
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }

        public string getESTADOCIVIL()
        {
            return ESTADOCIVIL;
        }
        public void setESTADOCIVIL(string ESTADOCIVIL)
        {
            this.ESTADOCIVIL = ESTADOCIVIL;
        }
    }
}