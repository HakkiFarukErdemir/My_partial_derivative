using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypartialderivative
{
    public class MyDerivative : Component
    {
        int x, y, sonuckat,sonucus;

        public int Tkat
        {
            set { x = value; }
        }
        public int Tus
        {
            set { y = value; }
        }
        public int Tsonuckat
        {
            get { return sonuckat; }
        }
        public int Tsonucus
        {
            get { return sonucus; }
        }
        public void Hesapla()
        {
            sonuckat = x + 1;
            sonucus = y - 1;
        }
    }
}
