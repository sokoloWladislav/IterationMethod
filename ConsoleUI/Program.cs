using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector x = initXVector(1, 1);
            Matrix A = InitAMatrix();
            Vector f = A.Multiply(x);
            double[] tau = {1.0 / (4 * A.GetNorm()), 1.0 / (2 * A.GetNorm()), 1.0 / A.GetNorm()};
            double[] fault = {0.01, 0.0001, 0.000001};
            Solver solver = new Solver();
            Matrix result = new Matrix(3);
            for(int i = 0; i < 3; ++i)
                for(int j = 0; j < 3; ++j)
                    result.Values[i, j] = solver.SimpleIterationMethod(A, f, tau[i], fault[j]);
            Show(result);
        }

        private static Matrix InitAMatrix()
        {
            double[,] a = new double[3, 3]
            { { 1.0 / 21, 1.0 / 22, 1.0 / 23 },
              { 1.0 / 22, 1.0 / 23, 1.0 / 24 },
              { 1.0 / 23, 1.0 / 24, 1.0 / 25 } };
            return new Matrix(3, a);
        }

        private static Vector initXVector(double a, double b)
        {
            Random rand = new Random();
            double[] temp = new double[3];
            for (int i = 0; i < 3; ++i)
                temp[i] = a - (b - a) * rand.Next();
            return new Vector(temp);
        }

        public static void Show(Matrix matrix)
        {
            for (int i = 0; i < 3; ++i)
            {
                Console.Write("|");
                for (int j = 0; j < 3; ++j)
                {
                    Console.Write("{0, 7}", matrix.Values[i, j]);
                    Console.Write("|");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

    
}
