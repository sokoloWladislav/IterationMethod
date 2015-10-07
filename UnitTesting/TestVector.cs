using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace UnitTesting
{
    [TestClass]
    public class TestVector
    {
        [TestMethod]
        public void Test_GetNorm()
        {
            Vector vector = new Vector(3);
            double[] A = { 4, 0, 3 };
            vector.Values = A;
            
            double actual = vector.GetNorm();

            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void Test_Multiply()
        {
            
            double[] A = { 1, 2, 3 };
            double[] B = { 2, 4, 5 };
            Vector vector = new Vector(A);
            Vector vector2 = new Vector(B);

            Vector actual2 = vector.Multiply(3);

            Assert.AreEqual(3, actual2.Values[0]);
            Assert.AreEqual(6, actual2.Values[1]);
            Assert.AreEqual(9, actual2.Values[2]);

            double actual = vector.Multiply(vector2);

            Assert.AreEqual(25, actual);
        }

        [TestMethod]
        public void Test_Add()
        {
            double[] a = { 1, 2, 3 };
            double[] b = { 2, 4, 6 };
            Vector A = new Vector(a);
            Vector B = new Vector(b);

            Vector c = A.Add(B);

            Assert.AreEqual(3, c.Values[0]);
            Assert.AreEqual(6, c.Values[1]);
            Assert.AreEqual(9, c.Values[2]);
        }

    }
}
