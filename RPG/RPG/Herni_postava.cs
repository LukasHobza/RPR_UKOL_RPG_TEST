using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Herni_postava
    {
        public Herni_postava()
        {

        }

        public int addXP(int currentXP, int addXP)
        {

            //jeste by to melo pridavat level

            return addXP+currentXP;
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
    }
}
