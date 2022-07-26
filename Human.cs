using System;
using System.Collections.Generic;
using System.Text;

namespace ForVlad
{
    class Human
    {
        private const int head = 1;
        private const int body = 1;
        private const int arm = 2;
        private const int leg = 2;

        public void ToThinth()
        {
            Console.WriteLine("The Human have {0} head(s) ", head);
        }
        public void ToUpHeand()
        {
            Console.WriteLine("The HUman has {0} ", arm);
        }
        public int HowMachHas()
        {
            Console.WriteLine("Bls bla bla");
            return body;
        }

        public void ToGo()
        {
            Console.WriteLine("The Human go with {0} legs", leg);
        }
        private void ToDzuryty()
        {
            Console.WriteLine("Confidecialno");
        }
    }
}
