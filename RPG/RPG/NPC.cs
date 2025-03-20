using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class NPC : Herni_postava
    {

        private string name;
        private bool strenght;
        private string prace;
        public NPC(string Name, bool strenght, string prace) : base(Name)
        {
            this.name = Name;
            this.strenght = strenght;
            this.prace = prace;
        }

        public string getPrace()
        {
            return "prace";
        }

        public bool getStrenght()
        {
            return false;
        }
    }
}
