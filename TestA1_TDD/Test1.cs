

namespace TestA1_TDD
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void Devuelve_Menos_Uno()
        {
            int num1 = -5;
            int resul = A1_TDD.CalcularFactorial(num1);
            Assert.AreEqual(-1, resul);
        }

        [TestMethod]
        public void Devuelve_Uno()
        {
            int num1 = 0;
            int resul = A1_TDD.CalcularFactorial(num1);
            Assert.AreEqual(1, resul);
        }

        [TestMethod]
        public void = Devuelve_El_Factorial(num1)
        {
            int num1 = 5;
            int resul = A1_TDD.CalcularFactorial(num1);
            Assert.AreEqual(120, resul);
        }
    }
}
