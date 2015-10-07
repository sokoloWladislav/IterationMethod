using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Matrix
    {
        private int n;
        double[,] values;
        public Matrix(int n)
        {
            this.n = n;
            values = new double[n, n];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    values[i, j] = 0;
        }
        
        public Matrix(int n, double[,] matrix)
        {
            this.n = n;
            this.values = new double[n, n];
            this.Values = matrix;
        }

        public double[,] Values {
            get 
            {
                return values; 
            }
            set
            {
                for (int i = 0; i < n; ++i)
                    for (int j = 0; j < n; ++j)
                        values[i, j] = value[i, j];
            }
        }

        public Matrix Add(Matrix matrix)
        {
            double[,] temp = new double[n, n];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    temp[i, j] = values[i, j] * matrix.Values[i, j];
            return new Matrix(n, temp);
        }

        public Matrix Multiply(double number)
        {
            Matrix result = new Matrix(n);
            for(int i = 0; i < n; ++i)
                for(int j = 0; j < n; ++j)
                    result.Values[i, j] = number * values[i, j];
            return result;
        }

        public Vector Multiply(Vector vector)
        {
            Vector result = new Vector(n);
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    result.Values[i] += values[i, j] * vector.Values[j];
            return result;
        }

        public double GetNorm()
        {
            double sum = 0;
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    sum += values[i, j] * values[i, j];
            return Math.Sqrt(sum);
        }
    }
}
