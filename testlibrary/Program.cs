using System;
using VIN_LIB;
namespace testlibrary
{
    class Program
    {
         

        static void Main(string[] args)
        {
            int X = 25;
            int Z = 17;
            string V = "HHMCM56557C404453";
           string resul= VIN_LIB.VIN_LIB.GetVINCountry(V);
           int summa = VIN_LIB.VIN_LIB.Numbers(X, Z);
            string years = VIN_LIB.VIN_LIB.Years(V); 
            Console.WriteLine(resul);
            Console.WriteLine(summa);
            Console.WriteLine(years);


        }
    }
}
