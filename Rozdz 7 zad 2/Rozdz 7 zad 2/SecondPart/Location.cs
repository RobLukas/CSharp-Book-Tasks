using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPart
{
    abstract class Location
    {
        private string name;
        public Location[] Exits;

        public Location(string name)
        {
            this.name = name;
        }

        public virtual string Description
        {
            get
            {
                string description = "Stoisz w: " + name + ". Widzisz wyjścia do następujących lokalizacji: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                    {
                        description += ",";
                    }
                }
                description += ".";
                return description;
            }
        }
        public string Name
        {
            get => name;
        }
    }
}