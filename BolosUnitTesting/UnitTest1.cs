using NUnit.Framework;
using T1Calidad;

namespace BolosUnitTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void puntaje20()
        {
            var prueba = new CodigoBolos();
            var resultado = prueba.resultado(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
            Assert.AreEqual(20, resultado);
        }
        [Test]
        public void puntaje300()
        {
            var prueba = new CodigoBolos();
            var resultado = prueba.resultado(10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0);
            Assert.AreEqual(300, resultado);
        }
        [Test]
        public void puntaje53()
        {
            var prueba = new CodigoBolos();
            var resultado = prueba.resultado(7, 2, 3, 1, 4, 3, 1, 2, 4, 2, 5, 0, 0, 6, 2, 4, 4, 2, 1, 0);
            Assert.AreEqual(53, resultado);
        }
        [Test]
        public void puntaje250()
        {
            var prueba = new CodigoBolos();
            var resultado = prueba.resultado(10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 4, 4, 2, 0);
            Assert.AreEqual(250, resultado);
        }
        [Test]
        public void puntaje55()
        {
            var prueba = new CodigoBolos();
            var resultado = prueba.resultado(7, 2, 3, 1, 4, 3, 1, 2, 4, 2, 5, 0, 0, 6, 2, 4, 4, 2, 3, 0);
            Assert.AreEqual(55, resultado);
        }
        [Test]
        public void puntaje60()
        {
            var prueba = new CodigoBolos();
            var resultado = prueba.resultado(3, 4, 2, 5, 1, 6, 2, 3, 2, 6, 1, 0, 4, 3, 6, 3, 2, 5, 2, 0);
            Assert.AreEqual(60, resultado);
        }
        [Test]
        public void puntaje40()
        {
            var prueba = new CodigoBolos();
            var resultado = prueba.resultado(2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2);
            Assert.AreEqual(40, resultado);
        }
        [Test]
        public void puntaje62()
        {
            var prueba = new CodigoBolos();
            var resultado = prueba.resultado(3, 3, 3, 3,3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 5);
            Assert.AreEqual(62, resultado);
        }
        [Test]
        public void puntaje80()
        {
            var prueba = new CodigoBolos();
            var resultado = prueba.resultado(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4);
            Assert.AreEqual(80, resultado);
        }
        [Test]
        public void puntaje200()
        {
            var prueba = new CodigoBolos();
            var resultado = prueba.resultado(5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5);
            Assert.AreEqual(200, resultado);
        }
        [Test]
        public void puntaje30()
        {
            var prueba = new CodigoBolos();
            var resultado = prueba.resultado(2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1);
            Assert.AreEqual(30, resultado);
        }
        [Test]
        public void puntaje50()
        {
            var prueba = new CodigoBolos();
            var resultado = prueba.resultado(4, 1,4 ,1, 4, 1, 4, 1, 4, 1, 4, 1, 4, 1, 4, 1, 4, 1, 4, 1);
            Assert.AreEqual(50, resultado);
        }
        [Test]
        public void puntaje35()
        {
            var prueba = new CodigoBolos();
            var resultado = prueba.resultado(2, 2, 2, 1, 2, 2, 2, 1, 2, 2, 2, 1, 2, 2, 2, 1, 2, 2, 2, 1);
            Assert.AreEqual(35, resultado);
        }
        [Test]
        public void puntaje34()
        {
            var prueba = new CodigoBolos();
            var resultado = prueba.resultado(2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 5);
            Assert.AreEqual(34, resultado);
        }
        [Test]
        public void puntaje38()
        {
            var prueba = new CodigoBolos();
            var resultado = prueba.resultado(2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 5, 2, 5);
            Assert.AreEqual(38, resultado);
        }

    }
}