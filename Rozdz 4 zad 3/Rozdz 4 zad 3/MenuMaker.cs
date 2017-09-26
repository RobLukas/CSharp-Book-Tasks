using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_4_zad_3
{
    class MenuMaker
    {
        public Random Randomize;

        string[] Meats = { "Szynka", "karkówka", "pierczona wołowina", "salami" };
        string[] Condiments = { "żółta musztarda", "brązowa musztarda", "majonez", "przyprawa", "sos francuski" };
        string[] Breads = { "chleb ryżowy", "chleb biały", "chleb zbożowy", "bułka", "chleb włoski" };

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomize.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomize.Next(Condiments.Length)];
            string randomBread = Breads[Randomize.Next(Breads.Length)];
            return randomMeat + ", " + randomCondiment + ", " + randomBread;
        }
    }
}
