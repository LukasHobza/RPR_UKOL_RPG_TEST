﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Hrac : Herni_postava
    {
        private string name;
        public Hrac(string Name) : base(Name)
        { 
            this.name = Name;
        }
        public string getSpecialization()
        {
            return "specializace";
        }

        public int getFace()
        {
            return 0;
        }

        public int getHair()
        {
            return 0;
        }

        public int getHairColor()
        {
            return 0;
        }

        public int getXP()
        {
            return 0;
        }
    }
}
