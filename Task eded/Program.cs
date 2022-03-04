using System;

namespace Task_eded
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //    Console.WriteLine("Sozu daxil edin: ");
            //    string soz = Console.ReadLine().ToLower();
            //    Console.WriteLine("Lazim olan herfi daxil edin: ");
            //    char herf = char.Parse(Console.ReadLine().ToLower());
            //    int count = 0;
            //    for (int i = 0; i < soz.Length; i++)

            //    {

            //        if (soz[i] == herf)

            //        {

            //            count++;

            //        }

            //    }

            //    Console.WriteLine(string.Format("'{0}' herfinden '{1}' dene var.", herf, count));
            #endregion Task1
            #region Task2
            //int sum = 0;
            //ArrayList[] = new ArrayList();
            //Console.Write("Array : ");
            //(Console.ReadLine());
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine("Sum of Numbers " + sum);
            //Console.ReadKey();
            #endregion Task2
            #region Task3
           
            int n=123;
            int th, h, t, u; 
            u = n % 10;
            t = (n / 10) % 10;
            h = (n / 100) % 10;
            th = n / 1000;
            Console.WriteLine("Thousands = %d , Hundreds = %d , Tens = %d , Units = %d/n", th, h, t, u);

           
           
            #endregion Task3
        }





    }




}


    


