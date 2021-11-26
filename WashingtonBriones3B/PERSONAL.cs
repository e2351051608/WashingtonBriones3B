using System;
using System.Collections.Generic;
using System.Text;

namespace WashingtonBriones3B
{
    public class PERSONAL : PERSONAS
    {
        public class PERSONAL
        {
            int añodeincorporación;
            int númerodedespacho;
            string sección;
            public PERSONAL(int añodeincorporación, int númerodedespacho, string sección)
            {
                this.añodeincorporación = añodeincorporación;
                this.númerodedespacho = númerodedespacho;
                this.sección = sección;
            }
            public int getañodeincorporación()
            {
                return añodeincorporación;
            }
            public void setañodeincorporación(int añodeincorporación)
            {
                this.añodeincorporación = añodeincorporación;
            }
            public int getnúmerodedespacho()
            {
                return númerodedespacho;
            }
            public void setnúmerodedespacho(int númerodedespacho)
            {
                this.númerodedespacho = númerodedespacho;
            }
            public string getsección()
            {
                return sección;
            }
            public void setsección(string sección)
            {
                this.sección = sección;
            }
        }
    }
}