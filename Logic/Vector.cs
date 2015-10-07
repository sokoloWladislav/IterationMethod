using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{ 
    public class Vector
    {
        private int n;
        private double[] values;

        public Vector(int n)
        {
            values = new double[n];
            this.n = n;
        }

        public Vector(double[] vector)
        {
            values = new double[vector.Length];
            n = vector.Length;
            this.Values = vector;
        }

        public double[] Values
        {
            get
            {
                return values;
            }
            set
            {
                for (int i = 0; i < n; ++i)
                    values[i] = value[i];
            }
        }

        public Vector Multiply(double number)
        {
            Vector result = new Vector(this.Values);
            for (int i = 0; i < n; ++i)
                    result.Values[i] *= number;
            return result;
        }

        public double Multiply(Vector vector)
        {
            double sum = 0;
            for (int i = 0; i < n; ++i)
                sum += values[i] * vector.values[i];
            return sum;
        }

        public double GetNorm()
        {
            double sum = 0;
            for(int i = 0; i < n; ++i)
                sum += values[i] * values[i];
            return Math.Sqrt(sum);
        }

        public Vector Add(Vector vector)
        {
            double[] temp = new double[n];
            for (int i = 0; i < n; ++i)
                temp[i] = values[i] + vector.Values[i];
            return new Vector(temp);
        }
    }
}
