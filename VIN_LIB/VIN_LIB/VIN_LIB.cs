using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public static class VIN_LIB
    {
      /* КАК ЭТО ДЕЛАТЬ!? 
         public static Boolean CheckVIN(string VIN) { }*/
      
        //тестовый метод на проверку работы библиотеки
        public static int Numbers(int A, int B)
        {
            return A + B;
        }

        //Как сделать проверку условия СРАЗУ 2х символов?
        public static string GetVINCountry(String vin)
        {
            
            if (vin[0] == 'A' || vin[0] == 'B' || vin[0] == 'C' || vin[0] == 'D' || vin[0] == 'E' || vin[0] == 'F' || vin[0] == 'G' || vin[0] == 'H')
            {
                vin = "Africa";
                return vin;
            }
            else
            {
                vin = "False";
                return vin;
            }
        }

        //Как быть с повторением?
        public static string Years(String vin)
        {

             switch (vin[9])
             {
                     case 'A':  vin = "1980"; break;
                     case 'B':  vin = "1981"; break;
                     case 'C':  vin = "1982"; break;
                     case 'D':  vin = "1983"; break;
                     case 'E':  vin = "1984"; break;
                     case 'F':  vin = "1985"; break;
                     case 'G':  vin = "1986"; break;
                     case 'H':  vin = "1987"; break;
                     case 'J':  vin = "1988"; break;
                     case 'K':  vin = "1989"; break;
                     case 'L':  vin = "1990"; break;
                     case 'M':  vin = "1991"; break;
                     case 'N':  vin = "1992"; break;
                     case 'P':  vin = "1993"; break;
                     case 'R':  vin = "1994"; break;
                     case 'S':  vin = "1995"; break;
                     case 'T':  vin = "1996"; break;
                     case 'V':  vin = "1997"; break;
                     case 'W':  vin = "1998"; break;
                     case 'X':  vin = "1999"; break;
                     case 'Y':  vin = "2000"; break;
                case '1': vin = "2001"; break;
                case '2': vin = "2002"; break;
                case '3': vin = "2003"; break;
                case '4': vin = "2004"; break;
                case '5': vin = "2005"; break;
                case '6': vin = "2006"; break;
                case '7': vin = "2007"; break;
                case '8': vin = "2008"; break;
                case '9': vin = "2009"; break;
                
               
            }
            return vin;


        }

    }
}
