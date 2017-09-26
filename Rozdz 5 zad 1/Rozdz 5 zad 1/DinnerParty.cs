using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_5_zad_1
{
    public class DinnerParty : Party
    {
        public decimal CostOfBeveragesPerPerson;
        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthOption) : base(numberOfPeople, fancyDecorations)
        {
            SetHealthlyOption(healthOption);
            CalculateCostOfDecorations(fancyDecorations);
        }
        public void SetHealthlyOption(bool healtyOption)
        {
            if (healtyOption)
            {
                CostOfBeveragesPerPerson = 5M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20M;
            }
        }
        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = base.CalculateCost() + (NumberOfPeople * CostOfBeveragesPerPerson);
            if (healthyOption)
                return totalCost *= 0.95M;
            else
                return totalCost;
        }
    }
}
