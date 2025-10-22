

namespace TestA1_TDD
{
    [TestClass]
    public sealed class Test_CaluclarFactorial
    {

        [TestMethod]
        public void Devuelve_Menos_Uno()
        {
            int num1 = -5;
            long resul = A1_TDD.A1_TDD.CalcularFactorial(num1);
            Assert.AreEqual(-1, resul);
        }

        [TestMethod]
        public void Devuelve_Uno()
        {
            int num1 = 0;
            long resul = A1_TDD.A1_TDD.CalcularFactorial(num1);
            Assert.AreEqual(1, resul);
        }

        [TestMethod]
        public void Devuelve_El_Factorial()
        {
            int num1 = 5;
            long resul = A1_TDD.A1_TDD.CalcularFactorial(num1);
            Assert.AreEqual(120, resul);
        }
    }
}
