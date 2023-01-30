using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6ex1
{
   public class Dulap
    {
        private int lungime;
        private int latime;
        private int inaltime;

        public Dulap(int lungime, int latime, int inaltime)
        {
            this.lungime = lungime;
            this.latime = latime;
            this.inaltime = inaltime;
        }

        public int CalculeazaVolum()
        {
            int volumDulap = lungime * latime * inaltime;
            return volumDulap;
        }
    }
}
