using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа, позволяющая найти СКНФ по результирующему столбцу.\n");

            int[] A = new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 };
            int[] B = new int[8] { 0, 0, 1, 1, 0, 0, 1, 1 };
            int[] C = new int[8] { 0, 1, 0, 1, 0, 1, 0, 1 };
            int[] F = new int[8];
            List<string> Result = new List<string>();

            int i, k = 0;

            Console.WriteLine("Введите результирующий столбец:");
            for (i = 0; i < 8; i++)
            {
                F[i] = Convert.ToInt16(Console.ReadLine());
                if (F[i] == 1)
                    k++;
            }

            if (k == 8)
            {
                Console.WriteLine("\nСКНФ нет!");
            }
            else
            {
                Console.WriteLine("\nВычисление СКНФ...\n");
                for (i = 0; i < 8; i++)
                {
                    if (F[i] == 0)
                    {
                        if (A[i] == 0)
                            Result.Add("(A");
                        else
                            Result.Add("((-A)");

                        Result.Add("u");

                        if (B[i] == 0)
                            Result.Add("B");
                        else
                            Result.Add("(-B)");

                        Result.Add("u");

                        if (C[i] == 0)
                            Result.Add("C)");
                        else
                            Result.Add("(-C))");

                        if (i + 1 < 8)
                            Result.Add(" * ");
                    }
                }

                for (i = 0; i < Result.Count; i++)
                    Console.Write(Result[i]);
            }
            Console.ReadKey();
        }
    }
}
