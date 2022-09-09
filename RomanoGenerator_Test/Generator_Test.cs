using CalidadT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanoGenerator_Test
{
    public class Generator_Test
    {

        // CASOS POSITIVOS
        [Test]
        public void Caso01() {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(1);

            Assert.AreEqual("I", result);

        }

        [Test]
        public void Caso02()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(9);

            Assert.AreEqual("IX", result);

        }

        [Test]
        public void Caso03()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(4);

            Assert.AreEqual("IV", result);

        }
        [Test]
        public void Caso04()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(49);

            Assert.AreEqual("XLIX", result);

        }
        [Test]
        public void Caso05()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(1000);

            Assert.AreEqual("M", result);

        }
        [Test]
        public void Caso06()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(1001);

            Assert.AreEqual("", result);

        }
        [Test]
        public void Caso07()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(0);

            Assert.AreEqual("error", result);

        }
        [Test]
        public void Caso08()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(15);

            Assert.AreEqual("XV", result);

        }
        [Test]
        public void Caso09()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(-1);

            Assert.AreEqual("error", result);

        }
        [Test]
        public void Caso10()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(-1);

            Assert.AreEqual("error", result);

        }
        [Test]
        public void Caso11()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(-1);

            Assert.AreEqual("error", result);

        }
        [Test]
        public void Caso12()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(-1);

            Assert.AreEqual("error", result);

        }


        [Test]
        public void Caso13()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(-50);

            Assert.AreEqual("error", result);

        }

        [Test]
        public void Caso14()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(0);

            Assert.AreEqual("", result);

        }

        [Test]
        public void Caso15()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(-50);

            Assert.AreEqual("error", result);

        }

        [Test]
        public void Caso16()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(-49);

            Assert.AreEqual("error", result);

        }

        [Test]
        public void Caso17()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(-50);

            Assert.AreEqual("error", result);

        }

        [Test]
        public void Caso18()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(2000);

            Assert.AreEqual("", result);

        }

        [Test]
        public void Caso19()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(-1000);

            Assert.AreEqual("error", result);

        }

        [Test]
        public void Caso20()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(455);

            Assert.AreEqual("CDLV", result);

        }

        [Test]
        public void Caso21()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(-455);

            Assert.AreEqual("error", result);

        }

        [Test]
        public void Caso22()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(122);

            Assert.AreEqual("CXXII", result);

        }

        [Test]
        public void Caso23()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(345);

            Assert.AreEqual("CCCXLV", result);

        }

        [Test]
        public void Caso24()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(149);

            Assert.AreEqual("CXLIX", result);

        }

        [Test]
        public void Caso25()
        {
            var romanoGenerator = new RomanoGenerator();

            var result = romanoGenerator.GetRomano(690);

            Assert.AreEqual("DCXC", result);

        }

    }
}
