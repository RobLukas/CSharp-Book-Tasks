using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPart
{
    class Outside : Location
    {
        private bool hot;
        public Outside(string location, bool hot) : base(location)
        {
            this.hot = hot;
        }
        public override string Description
        {
            get
            {
                string newDescription = base.Description;
                if (hot)
                {
                    newDescription += " Tutaj jest bardzo gorąco";
                }
                return newDescription;
            }
        }
        public bool Hot
        {
            get => hot;
        }
    }
}