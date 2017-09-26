using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_7_zad_1
{
    public class FunnyFunny : IClown
    {
        protected string funnyThingIHave;
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        public string FunnyThingIHave
        {
            get
            {
                return "Kwa Kwa! Mam " + funnyThingIHave;
            }
        }
        public void Honk()
        {
            System.Windows.Forms.MessageBox.Show(this.FunnyThingIHave);
        }
    }
}
