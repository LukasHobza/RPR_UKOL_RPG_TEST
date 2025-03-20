using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Herni_postava
    {
        public Herni_postava(string Name)
        {
            this.name = Name;
        }
        private string name;

        public int addXP(int currentXP, int addXP)
        {

            //jeste by to melo pridavat level

            return addXP+currentXP;
        }

        public int addLvl(int level)
        {

            return level + 1;
        }

        public int xpToNextLvl(int level)
        {

            return level * 100;
        }

        public string getName()
        {
            return "jmeno";
        }

        public int getLevel()
        {
            return 2;
        }

        public int getX()
        {
            return 2;
        }

        public int getY()
        {
            return 0;
        }

        public override string ToString()
        {
            return getName() + ", " + getLevel() + ", " + getX() + ", " + getY();
        }


    }
}
