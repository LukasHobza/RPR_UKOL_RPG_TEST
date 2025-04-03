using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Reflection.Emit;
using tedToBudeFungovat;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        HerniPostava postava = new HerniPostava("Kamca");
        Hrac hrac = new Hrac("Lubos","Kouzelník");
        NPC npc = new NPC("Milada",Prace.obchodník,true);

        //1 EZ FUNGUJE
        [TestMethod]
        public void T01est_InitialPozice_ShouldBeZero()
        {

            Assert.AreEqual(0, postava.PoziceX);
            Assert.AreEqual(0, postava.PoziceY);
        }
        //2 Snad funguje, nejde pustit test
        [TestMethod]
        public void T02est_ZmenaPozice_ShouldUpdatePosition()
        {

            postava.ZmenaPozice(5, 10);
            Assert.AreEqual(5, postava.PoziceX);
            Assert.AreEqual(10, postava.PoziceY);
        }
        //3 EZ FUNGUJE
        [TestMethod]
        public void T03est_ToString_ShouldReturnCorrectFormat()
        {

            string result = postava.ToString();
            Assert.AreEqual("Jméno: Kamca, Level: 1, Pozice: (0, 0)", result);
        }
        //4 EZ FUNGUJE
        [TestMethod]
        public void T04est_SetJmeno_TooLong_ThrowsException()
        {
            /* TOHLE JSME TU MELY PUVODNE
            var exception = Assert.Throws<Exception>(() => new HerniPostava());
            Assert.AreEqual("Příliš dlouhé jméno!", exception.Message);*/


            postava.Jmeno = "PřílišDlouhéJméno";
            Assert.AreNotEqual("PřílišDlouhéJméno", postava.Jmeno);
        }
        //5 EZ FUNGUJE
        [TestMethod]
        public void T05est_SetJmeno_Valid()
        {

            postava.Jmeno = "Krátké";
            Assert.AreEqual("Krátké", postava.Jmeno);
        }
        //6 EZ FUNGUJE
        [TestMethod]
        public void T06est_PridejXP_ShouldIncreaseLevel()
        {

            hrac.PridejXP(150); // Přičteme 150 XP (pro level 2)
            Assert.AreEqual(2, hrac.Level);  // Hráč by měl být na levelu 2
        }
        //7 EZ FUNGUJE
        [TestMethod]
        public void T07est_PridejXP_ShouldNotIncreaseLevel()
        {
            /* TOHLE JSME TU MELY PUVODNE
            var hrac = new HerniPostava();
            hrac.PridejXP(50); // Přičteme 50 XP (nejsme ještě na hranici pro level up)
            Assert.AreEqual(1, hrac.Level);  // Level by měl zůstat na 1
            */

            hrac.PridejXP(50);
            Assert.AreEqual(1, hrac.Level);

        }
        //8 EZ FUNGUJE
        [TestMethod]
        public void T08est_SetPrace_ShouldBeCorrect()
        {

            Assert.AreEqual("obchodník", npc.Prace.ToString());
        }
        //9 Snad funguje, nejde pustit test
        [TestMethod]
        public void T09est_StaticPozice_CannotChangeOnceSet()
        {

            npc.ZmenaPozice(10, 20); // Nastavení pozice
            Assert.AreEqual(10, npc.PoziceX);
            Assert.AreEqual(20, npc.PoziceY);

            npc.ZmenaPozice(30, 40); // Pokus o změnu pozice
            Assert.AreEqual(10, npc.PoziceX);  // Pozice by měla zůstat původní
            Assert.AreEqual(20, npc.PoziceY);
        }
        //10 EZ FUNGUJE
        [TestMethod]
        public void T10est_SetSpecializace_Valid()
        {

            Assert.AreEqual("Kouzelník", hrac.Specializace);
        }
        //11 EZ FUNGUJE
        [TestMethod]
        public void T11est_SetSpecializace_Invalid_ThrowsException()
        {
            /* TOHLE JSME TU MELY PUVODNE
            var exception = Assert.Throws<ArgumentException>(() => new Hrac("Hrac", "InvalidSpecializace"));
            Assert.AreEqual("Nevalidní specializace!", exception.Message);
            */

            hrac.Specializace = "Předdělička";
            Assert.AreEqual(string.Empty, hrac.Specializace);
        }
        /*
        TOHLE BYLO POSLEDNÍ CO JSME MELY, TYHLE POD TÍM JSEM PRIDALA
         */
        //12 EZ FUNGUJE
        [TestMethod]
        public void T12est_SetXP_NegativeValue_ShouldNotChange()
        {

            hrac.PridejXP(-50);
            Assert.AreEqual(0, hrac.Xp);
        }
        //13 EZ FUNGUJE
        [TestMethod]
        public void T13est_NPC_IsBoss_ShouldBeTrue()
        {

            Assert.IsTrue(npc.Sila);
        }
        //14 EZ FUNGUJE
        [TestMethod]
        public void T14est_NPC_IsBoss_ShouldBeFalse()
        {

            Assert.IsFalse(npc.Sila);
        }
        //15 EZ FUNGUJE
        [TestMethod]
        public void T15est_Hrac_ToString_ShouldReturnCorrectFormat()
        {

            string expectedOutput = "Jméno: " + hrac.Jmeno + ", Level: " + hrac.Level + ", XP: " + hrac.Xp + ", Specializace: " + hrac.Specializace;
            Assert.AreEqual(expectedOutput, hrac.ToString());
        }
        //16 EZ FUNGUJE
        [TestMethod]
        public void T16est_NPC_ToString_ShouldReturnCorrectFormat()
        {

            string expectedOutput = "Jméno: " + npc.Jmeno + ", Level: " + npc.Level + ", Pozice: (" + npc.PoziceX + ", " + npc.PoziceY + "), Práce: " + npc.prace + ", Boss: " + npc.Sila;
            Assert.AreEqual(expectedOutput, npc.ToString());
        }
        //17 EZ FUNGUJE
        [TestMethod]
        public void T17est_Hrac_InitialXP_ShouldBeZero()
        {

            Assert.AreEqual(0, hrac.Xp);
        }
        //18 EZ FUNGUJE
        [TestMethod]
        public void T18est_Hrac_LevelUp_MultipleTimes()
        {

            hrac.PridejXP(300);
            Assert.AreEqual(3, hrac.Level);
        }
        //19 TOHLE JE 14 WTF ???
        [TestMethod]
        public void T19est_NPC_DefaultBossValue_ShouldBeFalse()
        {

            Assert.IsFalse(npc.Sila);
        }
        //20 EZ FUNGUJE
        [TestMethod]
        public void T20est_Hrac_SpecializaceChange_ShouldNotAllowInvalid()
        {

            hrac.Specializace = "Rytíř";
            Assert.AreNotEqual("Rytíř", hrac.Specializace);
        }
    }
}
