using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_7_zad_1
{
    public interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }
}
