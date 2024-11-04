using P4_1_714230001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230001
{
    internal class ProductTest_714230001
    {
        static void Main(string[] args)
        {
            //Product_714230001 myProduct = new Product_714230001();

            //jawaban no 14 sehingga bisa running
            //Console.WriteLine(myProduct.GetMyType());

            //myProduct.MyType = "DVD";

            //Console.WriteLine(myProduct.MyType);

            Book_714230001 product1 = new Book_714230001("Book", "C# Object Oriented Solution", "300");
            DVD_714230001 product2 = new DVD_714230001("Ethernal Sunshine Of The Spotless Mind", "145");

            product1.DisplayInfo();
            product2.DisplayInfo();

        }
    }
}