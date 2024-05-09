using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DecToBina(10);
            Console.WriteLine("\n Number to words");
            NumberToChar(12345);
        }

        public static void DecToBina(int n)
        {
            Console.WriteLine(n);
            int i;
            int[] a = new int[10]; 

            for(i=0; n>0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }

            Console.WriteLine("Binary");

            for(i = i-1; i>=0; i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }


        public static void NumberToChar(int n)
        {
            Console.WriteLine(n);
            int r;
            int sum = 0;

            while(n > 0)
            {
                r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }

            n = sum;

            while(n > 0)
            {
                r = n % 10;

                switch (r)
                {
                    case 1:
                        Console.Write("one ");
                        break;
                    case 2:
                        Console.Write("two ");
                        break;
                    case 3:
                        Console.Write("three ");
                        break;
                    case 4:
                        Console.Write("four ");
                        break;
                    case 5:
                        Console.Write("five ");
                        break;
                    case 6:
                        Console.Write("six ");
                        break;
                    case 7:
                        Console.Write("seven ");
                        break;
                    case 8:
                        Console.Write("eight ");
                        break;
                    case 9:
                        Console.Write("nine ");
                        break;
                    case 0:
                        Console.Write("zero ");
                        break;
                    default:
                        Console.Write("tttt ");
                        break;
                }//end of switch
                 //
                n = n / 10;

            }//end of while loop

            Console.WriteLine();
        }

    }
        
    
}
