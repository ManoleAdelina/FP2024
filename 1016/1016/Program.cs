﻿using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace _1024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //~~~~~~~~~~~~

            //DoublingTest();

            //D1(4);
            //D2(4);
            //D3(14);
            //D4(7);


            L1(6);
            L2(10);
        }
        /// <summary>
        /// Sa se genereze/afiseze primii n termeni ai sirului:
        /// 1 
        /// 2 3 
        /// 3 4 5 
        /// 4 5 6 7 
        /// 5 6 7 8 9 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private static void L2(int n)
        {
            int i, j, k;
            for (i = 1; i <= n; i++)
            {
                k = i;
                for (j = 1; j <= i; j++)
                {

                    Console.Write($"{k} ");
                    k++;

                };

            }
        }

        /// <summary>
        /// 1
        /// 1 1
        /// 2 1
        /// 1 2 1 1
        /// 1 1 1 2 2 1
        /// 3 1 2 2 1 1
        /// </summary>
        /// <param name="n"></param>
        private static void L1(int n)
        {
            // TODO
        }


        /// <summary>
        /// *******
        /// *** ***
        /// **   **
        /// *     *
        /// **   **
        /// *** ***
        /// *******
        /// </summary>
        /// <param name="v">v trebuie sa fie impar</param>
        /// <exception cref="NotImplementedException"></exception>
        private static void D4(int v)
        {

            if (v % 2 != 0)
            {
                int steluteInitiale = v;
                int stelute = v;
                int spatii = -1;
                //prima linie
                for (int i = 0; i < v; i++)
                    Console.Write("*");
                Console.WriteLine(" ");

                int j = 2;
                //mijloc
                for (int k = 0; k < (steluteInitiale - 1) / 2; k++)
                {

                    stelute = (v - j) / 2 + 1;
                    spatii += 2;
                    for (int i = 0; i < stelute; i++)
                        Console.Write("*");
                    for (int i = 0; i < spatii; i++)
                        Console.Write(" ");
                    for (int i = 0; i < stelute; i++)
                        Console.Write("*");
                    Console.WriteLine();
                    j = j + 2;
                }

                for (int k = 1; k < (steluteInitiale - 1) / 2; k++)
                {
                    stelute++;
                    spatii -= 2;
                    for (int i = 0; i < stelute; i++)
                        Console.Write("*");
                    for (int i = 0; i < spatii; i++)
                        Console.Write(" ");
                    for (int i = 0; i < stelute; i++)
                        Console.Write("*");
                    Console.WriteLine();
                    j = j - 2;

                }

                for (int i = 0; i < steluteInitiale; i++)
                    Console.Write("*");
            }
        }

        /// <summary>
        ///    *
        ///   * *
        ///  *   *
        /// * * * *
        /// </summary>
        /// <param name="n"></param>
        /// <exception cref="NotImplementedException"></exception>
        private static void D3(int n)
        {
            // prima linie
            for (int i = 0; i < n - 1; i++)
                Console.Write(' ');
            Console.WriteLine("*");

            // liniile din mijloc
            int ns1 = n - 2, ns2 = 1;
            for (int k = 2; k <= n - 1; k++)
            {
                for (int i = 0; i < ns1; i++)
                    Console.Write(' ');
                Console.Write("*");
                for (int i = 0; i < ns2; i++)
                    Console.Write(' ');
                Console.WriteLine("*");
                ns1--;
                ns2 += 2;
            }


            // ultima linie
            for (int i = 0; i < n; i++)
                Console.Write("* ");
        }

        /// <summary>
        /// *
        /// **
        /// ***
        /// ****
        ///     ****
        ///      ***
        ///       **
        ///        *
        /// </summary>
        /// <param name="v"></param>
        /// <exception cref="NotImplementedException"></exception>
        private static void D2(int n)
        {
            D1(n);
            int n_sp = n, n_st = n;
            for (int i = 0; i < n; i++)
            {
                string spatii = new string(' ', n_sp);
                string stelute = new string('*', n_st);
                Console.WriteLine($"{spatii}{stelute}");
                n_sp++;
                n_st--;
            }
        }

        /// <summary>
        /// *
        /// **
        /// ***
        /// ****
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private static void D1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                //string line = new string('*', i);
                //Console.WriteLine(line);
                // SAU

                for (int j = 0; j < i; j++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }

        private static void DoublingTest()
        {
            int n = 1;
            while (n < 1000000)
            {
                S1(n);
                n = n * 2;
            }
        }

        /// <summary>
        /// S = 1 + 2*3 + 3*4*5 + .... + (n+0)*(n+1)*...*(n+n-1)
        /// (i+0) * (i+1)*...*(i + i-1)
        /// </summary>
        /// <example>1+2*3+3*4*5 = 67</example>
        /// <exception cref="NotImplementedException"></exception>
        private static void S1(int n)
        {
            // O(n^2) - complexitate patratica 
            long suma = 0;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 1; i <= n; i++)
            {
                //if (i % 100 == 0)
                //{
                //    Console.Write('.');
                //}
                long f = 1;
                for (int j = 0; j <= i - 1; j++)
                    f = f * (i + j);
                suma += f; // suma = suma + f
            }
            sw.Stop();
            Console.WriteLine($"{n} - {sw.ElapsedTicks}");
        }

        /// <summary>
        /// S =1^4+2^4+...+n^4
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private static void P6()
        {
            int n = int.Parse(Console.ReadLine());

            long suma = (n * (n + 1) * (6 * n * n * n + 9 * n * n + n + 1));

            throw new NotImplementedException();
        }

        /// <summary>
        /// S =1^3+2^3+...+n^3
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private static void P5()
        {
            int n = 10;
            int suma = (int)Math.Pow(n * (n + 1) / 2, 2);
            Console.WriteLine(suma);
        }

        /// <summary>
        /// S = (1^2+2^2+...+n^2) mod 1.000.000.007;
        /// </summary>
        private static void P4()
        {
            // O(1) - algoritm constant
            long n=1000000000;
            long M = 1000000007;
            n = int.Parse(Console.ReadLine());
            long suma = n * (n + 1) * (2 * n + 1) / 6 % M;
            Console.WriteLine(suma);
        }

        /// <summary>
        /// S = 1^2+2^2+...+n^2;
        /// </summary>
        private static void P3()
        {
            // O(n) - algoritm liniar
            int n;
            n = int.Parse(Console.ReadLine());
            long suma = 0;
            for (int i = 1; i <= n; i++)
                suma = suma + i * i;
            Console.WriteLine(suma);
        }

        /// <summary>
        /// S = 1+2+...+n = n(n+1)/2
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private static void P2()
        {
            // O(1) - algoritm constant
            int n;
            n = int.Parse(Console.ReadLine());
            long suma = n * (n + 1) / 2;
            Console.WriteLine(suma);
        }

        /// <summary>
        /// S = 1+2+...+n
        /// </summary>
        private static void P1()
        {
            // O(n) - algoritm liniar
            int n;
            n = int.Parse(Console.ReadLine());
            long suma = 0;
            for (int i = 1; i <= n; i++)
                suma = suma + i;
            Console.WriteLine(suma);
        }
    }
}
