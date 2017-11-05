using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Rozdz_8_zad_8
{
    class Lumberjack
    {
        private string name;
        public string Name { get => name; }
        private Stack<Flapjack> meal;
        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }
        public int FlapjackCount { get => meal.Count; }
        public void TakeFlapjacks(Flapjack food, int HowMany)
        {
            for (int i = 0; i < HowMany; i++)
                meal.Push(food);
        }
        public void EatFlapjacks()
        {
            WriteLine(Name + " je naleśnika");
            while (FlapjackCount > 0)
                WriteLine(Name + " zjadł " + meal.Pop().ToString().ToLower() + " naleśnika");
        }
    }
    public enum Flapjack
    {
        Chrupkiego,
        Wilgotnego,
        Rumianego,
        Bananowego
    }
}
