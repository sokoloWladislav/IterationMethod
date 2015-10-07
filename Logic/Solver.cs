using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Solver
    {

        private static Matrix InitEMatrix()
        {
            double[,] e = new double[3, 3] 
            { { 1, 0, 0 },
              { 0, 1, 0 },
              { 0, 0, 1 } };
            return new Matrix(3, e);
        }

        public int SimpleIterationMethod(Matrix A, Vector f, double tau, double fault)
        {

            Matrix E = InitEMatrix();
            Matrix H = E.Add(A.Multiply(-tau));
            Vector phi = f.Multiply(tau);
            double q = H.GetNorm();
            Vector xs = new Vector(phi.Values);
            Vector xn = new Vector(H.Multiply(xs).Add(phi).Values);
            int counter = 0;
            while(q * (xn.Add(xs.Multiply(-1)).GetNorm()) / (1-q) >= fault)
            {
                xs.Values = xn.Values;
                xn.Values = H.Multiply(xs).Add(phi).Values;
                ++counter;
            }
            return counter;
        }
    }
}
