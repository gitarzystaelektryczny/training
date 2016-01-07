using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Training1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Arek.Arek objectArek = new Arek.Arek();
            objectArek.Hello();
            Piotrek.Piotrek oPiotrek = new Piotrek.Piotrek();
            Console.WriteLine("Wynik:{0}", oPiotrek.Dodawanie());
            
            Console.ReadLine();
        }
        

        
    }
}
