using System;

namespace Anonim_Metod21._02._2023
{
    delegate bool Delegat(int a, int b);
    delegate int MyDelegat(int a);
    delegate int Day(int a);
    delegate void Number();
    delegate void Massiv(int[] mass);
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////

            Delegat Chet = delegate (int a, int b)
            {

                return a % 2 == 0 || b % 2 == 0;
            };
            Console.WriteLine(Chet(5, 6));

            //////////////////////

            MyDelegat Kvadr = delegate (int a)
            {
                return (a) * 2;
            };
            Console.WriteLine(Kvadr(4));

            //////////////////////

            MyDelegat Cub = a => (a) ^ 3;
            Console.WriteLine(Cub(4));

            //////////////////////
            Console.WriteLine("\n");
            int[] mass = new int[6];
            Random r = new Random();
            Massiv Print = (int[] mass) =>
            {
               
                int max = mass[0];
                for (int i =0; i<mass.Length;i++ )
                {
                    mass[i] = r.Next(2,10);
                    Console.Write(mass[i]+"\t");
                    if (mass[i]>max)
                    {
                        max= mass[i];
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Mаксимальный элимент = "+max);
            };
            Print(mass);
            Console.WriteLine("\n");

            //////////////////////

            Massiv Min = (int[] mass) =>
            {
                int min = mass[0];
                for (int i = 0; i<mass.Length; i++)
                {
                    mass[i] = r.Next(-3, 9);
                    Console.Write(mass[i]+"\t");
                    if (mass[i]<min)
                    {
                        min = mass[i];
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Mинимальный элимент = " + min);

            };

            //////////////////////

            Min(mass);
            Massiv NECHET = (int[] mass) =>
              {
                  Random r = new Random();

                  //int temp = mass[0];
                  for (int i = 0; i < mass.Length; i++)
                  {
                      mass[0] = 0;
                      mass[i] = r.Next(-2, 15);
                      Console.Write(mass[i]+"\t");
                      if (mass[i]%2!=0)
                      {

                          Console.WriteLine("Четные числа массива ------> " + mass[i]);
                      }
                     

                  }
                  Console.WriteLine("\n");
            };
            Console.WriteLine("\n");
            NECHET(mass);
        }
    }
}
