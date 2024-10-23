using System;
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
            P6();
            //~~~~~~~~~~~~

            //DoublingTest();

            //D1(4);
            //D2(10);
            //D3(4);
            //D3(8);
            //D4(7);



            //L1(6);
            //L2(10);
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
            Console.WriteLine();
            Console.WriteLine("START__-L-2-__");
            if(n==1 || n==2 || n==3){Console.WriteLine($"termen(n)={n}");}
            int termen=0;
            int backNumber=1;
            int maxImpar=3;
            for(int i=4;i<=n;i++){
                termen=i-backNumber;
                if(termen%2!=0 && termen>maxImpar){maxImpar=termen;backNumber++;}
                
            }
        Console.WriteLine($"L2({n})={termen}");

        }

        /// <summary>
        /// 1
        /// 1 1
        /// 2 1
        /// 1 2 1 1
        /// 1 1 1 2 2 1
        /// 3 1 2 2 1 1
        /// 1 3 1 1 2 2 2 1 
        /// 1 1 1 3 2 1 3 2 1 1
        /// </summary>
        /// <param name="n">numarul de linii care se afiseaza</param>
        private static void L1(int n)
        {

            // TODO:implement readout list of numbers

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
        //sper ca v este numarul de linii si probabil ca este
        //defapt pare ca v este si numarul maxim de stelute de pe o linie
        private static void D4(int v)
        {
            Console.WriteLine();
            Console.WriteLine("start ____D4___");
            Console.WriteLine($"D4({v})");
            for(int i=0;i<v;i++){
                Console.Write("*");
            }
            Console.WriteLine();
            int beginna=v/2;
            int finishMe=1;
            //from here should first while loop start
            while(beginna!=finishMe){
            for(int i=beginna;i>=finishMe;i--){
                Console.Write("*");
            }
                int delta=v-2*beginna;
                for(int i=0;i<delta;i++){Console.Write(" ");}
                for(int i=beginna;i>=finishMe;i--){
                    Console.Write("*");
                }
beginna--;
Console.WriteLine();
            }
//kinda here the while should end
//also the second while loop should start,in fact i used a do while loop but here it 
            //does not make any difference actually
            do{
                for(int i=beginna;i>=finishMe;i--){Console.Write("*");}
                int delta=v-2*beginna;
                for(int i=0;i<delta;i++){Console.Write(" ");}
                for(int i=beginna;i>=finishMe;i--){Console.Write("*");}
                beginna++;
                Console.WriteLine();
            }while(beginna!=v/2+1);
//let's make this the end separator :)
            for(int i=0;i<v;i++){Console.Write("*");}
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
            Console.WriteLine();
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
        /// n(n+1)(2n+1)(3n2+3n−1)/30.
        ///1**4+2**4+...+n**4
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private static void P6()
        {   
            Console.WriteLine();
            Console.WriteLine("____start__P____6 ");
            Console.Write("n=\t");
            int n=Convert.ToInt32(Console.ReadLine());
            long a=n,b=n+1,c=2*n+1,d=3*n*n+3*n-1;
            bool b2=true,b3=true,b5=true;
            if(a%5==0){a/=5;}else if(b%5==0){b/=5;}else if(c%5==0){c/=5;}else if(d%5==0){d/=5;}else{b5=false;}
            if(a%2==0){a/=2;}else if(b%2==0){b/=2;}else if(c%2==0){c/=2;}else if(d%2==0){d/=2;}else{b2=false;}
            if(a%3==0){a/=3;}else if(b%3==0){b/=3;}else if(c%3==0){c/=3;}else if(d%3==0){d/=3;}else{b3=false;}
            int threeTeen=30;
            if(b2){threeTeen/=2;}
            if(b5){threeTeen/=5;}
            if(b3){threeTeen/=3;}
            long result=a*b*c*d;result/=threeTeen;
            Console.WriteLine($"P6({n})={result}");
            
            //throw new NotImplementedException();//dont throw it :)
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
            //long suma = n * (n + 1) * (2 * n + 1) / 6 % M;
            long a = n;
            long b = n + 1;
            long c = (2 * n + 1);
            if (a % 2 == 0)
                a = a / 2;
            else
                b = b / 2;

            if (a % 3 == 0)
                a = a / 3;
            else if (b % 3 == 0)
                b = b / 3;
            else
                c = c / 3;

            // (a + b) mod M = (a mod M + b mod M) mod M
            // (a * b) mod M = (a mod M * b mod M) mod M
            long suma = a % M * b % M * c % M;
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
