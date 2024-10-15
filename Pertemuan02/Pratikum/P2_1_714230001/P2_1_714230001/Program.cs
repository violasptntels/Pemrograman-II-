using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714230001
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Masukan angka1: ");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan angka2: ");
            double input2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(input1+" + "+input2+" = "+(input1 + input2));
            Console.WriteLine(input1+" - "+input2+" = "+(input1 - input2));
            Console.WriteLine(input1+" * "+input2+" = "+(input1 * input2));
            Console.WriteLine(input1+" / "+input2+" = "+(input1  / input2));
            Console.ReadKey();
        }
    }
}
