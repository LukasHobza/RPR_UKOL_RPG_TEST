using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tedToBudeFungovat
{
    public enum Prace
    {
        obchodník,
        nepřítel,
        obyvatel,
        triTecky
    }
    public class NPC : HerniPostava
    {
        
        public string Npc;
        public Prace prace;
        public bool sila;
        public bool Sila { get { return sila; }}
        public Prace Prace { get { return prace; }}

        public NPC(string name, Prace prace, bool sila) : base(name) { 
            this.prace = prace;
            this.sila = sila;
        }
        //PRIDALA JSEM JA
        public override string ToString()
        {
            return "Jméno: " + Jmeno + ", Level: " +Level +", Pozice: (" + PoziceX + ", " + PoziceY + "), Práce: " + prace + ", Boss: " + Sila;
        }
    }
    
}
