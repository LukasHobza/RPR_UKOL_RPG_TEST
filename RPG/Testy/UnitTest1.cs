using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RPG;

namespace Testy
{
    [TestClass]
    public class UnitTest1
    {
        Form1 form1 = new Form1();
        Herni_postava postavicka = new Herni_postava();
        Hrac dan = new Hrac();

        //1
        [TestMethod]
        public void NameTest()
        {
            Assert.IsTrue(postavicka.getName().Length <= 10);
        }

        //2
        [TestMethod]
        public void LevelTest()
        {
            Assert.AreEqual(postavicka.getLevel(), 1);
        }

        //3
        [TestMethod]
        public void XTest()
        {
            Assert.AreEqual(postavicka.getX(), 0);
        }

        //4
        [TestMethod]
        public void YTest()
        {
            Assert.AreEqual(postavicka.getY(), 0);
        }

        //5
        [TestMethod]
        public void SpecializationTest()
        {
            Assert.IsTrue(
                   dan.getSpecialization() == "Kouzelník" 
                || dan.getSpecialization() == "Berserker"
                || dan.getSpecialization() == "Inženýr"
                || dan.getSpecialization() == "Cizák");
        }

        //6
        [TestMethod]
        public void FaceTest()
        {
            Assert.AreEqual(dan.getFace(), 0);
        }

        //7
        [TestMethod]
        public void HairTest()
        {
            Assert.AreEqual(dan.getHair(), 0);
        }

        //8
        [TestMethod]
        public void HairColorTest()
        {
            Assert.AreEqual(dan.getHairColor(), 0);
        }

        //9
        [TestMethod]
        public void XPTest()
        {
            Assert.AreEqual(dan.getXP(), 0);
        }

        //10
        [TestMethod]
        public void addXPTest()
        {
            Assert.AreEqual(dan.addXP(10,20), 30);
        }
    }
}
