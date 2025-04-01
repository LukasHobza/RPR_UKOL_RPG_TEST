using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tedToBudeFungovat
{
    public class HerniPostava
    {
        public int PoziceX = 0;
        public int PoziceY = 0;
        private string jmeno;
        
        public string Jmeno
        {
            get { return jmeno; }
            set
            {
                if (value.Length > 10)
                {

                    jmeno = string.Empty;
                }
                else
                {
                    jmeno = value;
                }

            }
        }
        public int Level = 1;

        public HerniPostava(string name)
        {
            Jmeno = name;
        }

        public void ZmenaPozice(int x, int y)
        {

        }

        public override string ToString()
        {
            return "Jméno: "+ jmeno +", Level: " + Level + ", Pozice: ("+PoziceX+", "+PoziceY + ")";
        }
    }
}
