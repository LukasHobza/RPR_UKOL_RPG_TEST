﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RPG;
using System.IO.Pipes;

namespace Testy
{
    [TestClass]
    public class UnitTest1
    {
        Form1 form1 = new Form1();
        Herni_postava postavicka = new Herni_postava("Lukas");
        Hrac dan = new Hrac("Dan");
        NPC daniel = new NPC("daniel",true,"prace");

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
        //11
        [TestMethod]
        public void ToStringTest()
        {
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
