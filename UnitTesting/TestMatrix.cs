using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace UnitTesting
{
    [TestClass]
    public class TestMatrix
    {
        [TestMethod]
        public void Test_Multiply()
        {
            Matrix A = new Matrix(3);
            double[,] B = new double[3, 3];
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    B[i, j] = 2;
            A.Values = B;
            double[] d = { 1, 0, 2 };
            Vector vector = new Vector(d);

            Matrix result = A.Multiply(4);
            Vector result2 = A.Multiply(vector);

            Assert.AreEqual(8, result.Values[0, 0]);
            Assert.AreEqual(8, result.Values[0, 2]);
            Assert.AreEqual(8, result.Values[2, 2]);
            //Assert.AreEqual(6, result2.Values[0]);
            //Assert.AreEqual(6, result2.Values[1]);
            //Assert.AreEqual(6, result2.Values[2]);
        }

    }
}
