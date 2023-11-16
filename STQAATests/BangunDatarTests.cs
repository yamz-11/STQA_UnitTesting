using Microsoft.VisualStudio.TestTools.UnitTesting;
using UAS_PAW1;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace UAS_PAW1.Tests
{
    [TestFixture()]
    public class BangunDatarTests
    {
        BangunDatar bd = new BangunDatar();

        [SetUp]
        public void init()
        {
            bd = new BangunDatar();
        }
        [Test()]
        public void PersegiPanjangTest()
        {
            Double HasilPP = bd.PersegiPanjang(4, 5);
            Assert.AreEqual(20, HasilPP);
        }

        [Test()]
        public void persegiTest()
        {
            Double HasilPG = bd.persegi(4);
            Assert.AreEqual(256, HasilPG);
        }

        [Test()]
        public void lingkaranTest()
        {
            Double HasilLK = bd.lingkaran(5);
            Assert.AreEqual(78, 5, HasilLK);
        }

        [Test()]
        public void segitigaTest()
        {
            Double HasilST = bd.segitiga(4, 5);
            Assert.AreEqual(10, HasilST);
        }

        [Test()]
        public void jajargenjangTest()
        {
            Double HasilJG = bd.jajargenjang(4, 6);
            Assert.AreEqual(20, HasilJG);
        }
    }
}