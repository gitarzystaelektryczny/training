using System;
using System.Runtime.InteropServices;

namespace Training1.Piotrek
{
    public class Piotrek :IPiotrek
    {
        public int Dodawanie()
        {
            int a = 5;
            int b = 3;
            return a + b;
        }
       

        public string Hello()
        {
            return "Hello Word!";
        }

       
        
    }
}