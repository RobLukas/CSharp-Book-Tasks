using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_5_zad_1
{
    public class Party
    {
        const int CostOfFoodPerPerson = 25;
        public decimal CostOfDecorations = 0;
        private bool fancyDecorations;
        private int numberOfPeople;

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
        }
        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        }

        public virtual decimal CalculateCost()
        {
            decimal totalCost = (NumberOfPeople * CostOfFoodPerPerson) + CostOfDecorations;
            if (NumberOfPeople > 12)
            {
                totalCost += 100;
            }
            return totalCost;
        }
        public virtual int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }
    }
}
