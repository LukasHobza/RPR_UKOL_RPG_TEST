using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RPG;
using System.IO.Pipes;

namespace Testy
{
    [TestClass]
    public class UnitTest1
    {
        Form1 form1 = new Form1();
        NPC daniel = new NPC("daniel",true,"prace");

        //1
        [TestMethod]
        public void NameTest()
        {
            Herni_postava postavicka = new Herni_postava("LukasLukasLukas");
            Assert.AreNotEqual(postavicka.getName(), "LukasLukasLukas");
        }

        //2
        [TestMethod]
        public void LevelTest()
        {
            Herni_postava postavicka = new Herni_postava("Lukas");
            Assert.AreEqual(postavicka.getLevel(), 1);
        }

        //3
        [TestMethod]
        public void XTest()
        {
            Herni_postava postavicka = new Herni_postava("Lukas");
            Assert.AreEqual(postavicka.getX(), 0);
        }

        //4
        [TestMethod]
        public void YTest()
        {
            Herni_postava postavicka = new Herni_postava("Lukas");
            Assert.AreEqual(postavicka.getY(), 0);
        }

        //5
        [TestMethod]
        public void SpecializationTest()
        {
            Hrac dan = new Hrac("Dan");
            dan.Specializace = "ABCD";
            Assert.IsFalse(
                   dan.getSpecialization() == "Kouzelník" 
                || dan.getSpecialization() == "Berserker"
                || dan.getSpecialization() == "Inženýr"
                || dan.getSpecialization() == "Cizák");
        }

        //6
        [TestMethod]
        public void FaceTest()
        {
            Hrac dan = new Hrac("Dan");
            Assert.AreEqual(dan.getFace(), 0);
        }

        //7
        [TestMethod]
        public void HairTest()
        {
            Hrac dan = new Hrac("Dan");
            Assert.AreEqual(dan.getHair(), 0);
        }

        //8
        [TestMethod]
        public void HairColorTest()
        {
            Hrac dan = new Hrac("Dan");
            Assert.AreEqual(dan.getHairColor(), 0);
        }

        //9
        [TestMethod]
        public void XPTest()
        {
            Hrac dan = new Hrac("Dan");
            Assert.AreEqual(dan.getXP(), 0);
        }

        //10
        [TestMethod]
        public void addXPTest()
        {
            Hrac dan = new Hrac("Dan");
            Assert.AreEqual(dan.addXP(10,20), 30);
        }
        //11
        [TestMethod]
        public void ToStringTest()
        {
            Hrac dan = new Hrac("Dan");
            string result = dan.ToString();

            
            StringAssert.Contains("Postava", result);
            StringAssert.Contains("1", result);
            StringAssert.Contains("0", result);
            StringAssert.Contains("0", result);
        }
        //12
        [TestMethod]
        public void KonstruktorTest()
        {
            Herni_postava postavicka = new Herni_postava("Lukas");
            Assert.IsNotNull(postavicka);
            Assert.AreEqual("Lukas", postavicka.getName());
        }
        //13
        [TestMethod]
        public void PraceTest()
        {
            Assert.IsTrue(
                  daniel.getPrace() == "Obchodník"
               || daniel.getPrace() == "Nepřítel"
               || daniel.getPrace() == "Obyvatel");
        }
        //14
        [TestMethod]
        public void BossTest()
        {
            Assert.IsTrue(daniel.getStrenght());
        }
        //15
        public void Konstruktor2Test()
        {
            Assert.IsNotNull(daniel);
            Assert.AreEqual("daniel", daniel.getName());
            Assert.AreEqual(true, daniel.getStrenght());
            Assert.AreEqual("prace", daniel.getPrace());
        }

        //idkidkidkidkidkidkidkidkidkidkidkidkidkidkidkidkidkidkidkidkidkidkidkidkidk

        //16
        [TestMethod]
        public void AddLvlTest()
        {
            Assert.AreEqual(daniel.addLvl(2), 3);
        }

        //17
        [TestMethod]
        public void xptonextlvltest()
        {
            Assert.AreEqual(daniel.xpToNextLvl(2), 200);
        }

    ////18
    //[TestMethod]
    //public void ()
    //{
    //    Assert.
    //}

    ////19
    //[TestMethod]
    //public void ()
    //{
    //    Assert.
    //}

    ////20
    //[TestMethod]
    //public void BossTes()
    //{
    //    Assert.
    //}
}
}
