using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_17._02._2023
{
    delegate int Math(int a, int b);
    delegate void Math2(int a);

    class Class1 {
        public static int Plus(int a, int b) {
            a += b;
            Console.WriteLine(a);
            return a;
        }   
        public static int Minus (int a, int b) {
            a -= b;
            Console.WriteLine(a);
            return a;
        }
        public static int Multicast(int a, int b) { 
            a *= b; Console.WriteLine(a);
            return a;
        }

        public static void Chet(int a) { 
            if(a % 2 == 0) {
                Console.WriteLine($"{a} is chet");
            }
        }
        public static void Nechet(int a) { 
            if(a % 2 != 0) {
                Console.WriteLine($"{a} is nechet");
            }
        }
        public static void Prime(int a) {
            Random rand = new Random();
            int num = rand.Next(100);
            while(num == a) { 
                num = rand.Next(100); 
            }
            if(a > 1) { 
                if(a % num != 0) {
                    Console.WriteLine($"{a} it's a prime number");
                }
                else { Console.WriteLine($"{a} it's not a prime number"); }
            }
        }
        public static void Fib(int a) {
            int First = 0;
            int Second = 1;
            int Next = 0;
            int Finish = a;
            Console.Write($"{First}" + "\t");
            Next = First + Second;
            while (Next <= Finish) {
                if (Next == a) {
                    Console.Write(Next + "\t");
                    First = Second;
                    Second = Next;
                    Next = First + Second;
                }
            }
        }



        static void Main(string[] args)
        {
            Math[] math = { Plus, Minus, Multicast };

            Math2 math2 = new Math2(Chet);
            math2 += Nechet;
            math2 += Prime;
            //math2 += Fib;
            math2.Invoke(24);

        }
    }

}
