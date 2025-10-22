

using System.Runtime.CompilerServices;

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

    [TestClass]
    public sealed class Test_EsContrasenyaValida
    {
        [TestMethod]
        public void Constrasenya_Vacia()
        {
            string contraseña = "";
            bool resul = A1_TDD.A1_TDD.EsContrasenyaValida(contraseña);
            Assert.IsFalse(resul);
        }

        [TestMethod]
        public void Contrasenya_nula()
        {
            string contraseña = null;
            bool resul = A1_TDD.A1_TDD.EsContrasenyaValida(contraseña);
            Assert.IsFalse(resul);
        }

        [TestMethod]
        public void Contrasenya_Valida()
        {
            string contraseña = "12345678#";
            bool resul = A1_TDD.A1_TDD.EsContrasenyaValida(contraseña);
            Assert.IsTrue(resul);
        }
    }
}
