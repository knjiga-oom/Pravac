using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOVerzija;

namespace Testovi
{
    [TestClass]
    public class TestPravca
    {
        [TestMethod]
        public void TranslatirajZaDeltaXJednako0PomičePravacVertikalnoZaZadaniDeltaY()
        {
            {
                Pravac p1 = new Pravac(1, 0);
                p1.Translatiraj(0, 5);
                Assert.AreEqual(1.0, p1.K, 1e-5);
                Assert.AreEqual(5.0, p1.L, 1e-5);
            }
            {
                Pravac p1 = new Pravac(2, 0);
                p1.Translatiraj(0, 5);
                Assert.AreEqual(2.0, p1.K, 1e-5);
                Assert.AreEqual(5.0, p1.L, 1e-5);
            }
            {
                Pravac p1 = new Pravac(0, 5);
                p1.Translatiraj(0, 5);
                Assert.AreEqual(0.0, p1.K, 1e-5);
                Assert.AreEqual(10.0, p1.L, 1e-5);
            }
        }

        [TestMethod]
        public void TranslatirajZaDeltaYJednako0PomičePravacHorizontalnoZaZadaniDeltaX()
        {
            {
                Pravac p1 = new Pravac(1, 0);
                p1.Translatiraj(5, 0);
                Assert.AreEqual(1.0, p1.K, 1e-5);
                Assert.AreEqual(-5.0, p1.L, 1e-5);
            }
            {
                Pravac p1 = new Pravac(2, 0);
                p1.Translatiraj(5, 0);
                Assert.AreEqual(2.0, p1.K, 1e-5);
                Assert.AreEqual(-10.0, p1.L, 1e-5);
            }
            {
                Pravac p1 = new Pravac(0, 5);
                p1.Translatiraj(5, 0);
                Assert.AreEqual(0.0, p1.K, 1e-5);
                Assert.AreEqual(5, p1.L, 1e-5);
            }
        }

        [TestMethod]
        public void TranslatirajZaZadaniDeltaXDeltaYPomičePravacHorizontalnoIVertikalnoZaZadaniDeltaXDeltaY()
        {
            {
                Pravac p1 = new Pravac(1, 0);
                p1.Translatiraj(5, 0);
                Assert.AreEqual(1.0, p1.K, 1e-5);
                Assert.AreEqual(-5.0, p1.L, 1e-5);
            }

            {
                Pravac p1 = new Pravac(2, 0);
                p1.Translatiraj(5, 0);
                Assert.AreEqual(2.0, p1.K, 1e-5);
                Assert.AreEqual(-10.0, p1.L, 1e-5);
            }
        }
    }
}
