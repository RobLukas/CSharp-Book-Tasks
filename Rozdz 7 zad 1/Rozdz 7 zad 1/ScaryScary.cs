using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_7_zad_1
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        private int numberOfScaryThings;
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
        public string ScaryThingIHave
        {
            get
            {
                return "Mam " + numberOfScaryThings + " pająków";
            }
        }
        public void ScareLittleChildren()
        {
            System.Windows.Forms.MessageBox.Show("Nie można mieć swojego " + this.funnyThingIHave);
        }
    }
}