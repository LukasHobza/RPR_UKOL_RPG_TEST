using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tedToBudeFungovat
{
    public class Hrac : HerniPostava
    {
        /*
        private Oblicej oblicej = Oblicej.VelkyNos;
        private Vlasy vlasy = Vlasy.Drdol;
        private BarvaVlasu barvaVlasu = BarvaVlasu.Kastanova;
        */

        private string specializace;
        public string hrac;

        public string Specializace {
            get { 
                return specializace;
            } 
            set { 
                if (value == "Kouzelník"  || value == "Berserker" || value == "Inženýr" || value == "Cizák"){
                    specializace = value;
                }
                else
                {
                    specializace = string.Empty;
                }
            } 
        }
        public int Xp { get; private set; } = 0;

        public Hrac(string name, string specializace) : base(name) { 
            Specializace = specializace;
        }
        
        public void PridejXP(int xp)
        {
            if (xp > 0) {
                Xp += xp;
                if (Xp >= Level * 100)
                {
                    Level++;
                    Xp = 0;
                }
            }
        }
    }
}
