using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Safe
    {
        private Jewels contents = new Jewels();
        private string safeCimbination = "12345";

        public Jewels Open(string combination)
        {
            if (combination == safeCimbination)
            {
                return contents;
            }
            else
            {
                return null;
            }
        }
        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.WriteDownCombination(safeCimbination);
        }
    }
}
