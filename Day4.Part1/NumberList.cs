using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Part1
{
    public abstract class NumberList
    {
        public List<int> Numbers = new();
        public int Id { get; set; }

        public NumberList(int lineId, int number1, int number2, int number3, int number4, int number5)
        {
            Numbers.Add(number1);
            Numbers.Add(number2);
            Numbers.Add(number3);
            Numbers.Add(number4);
            Numbers.Add(number5);
            Id = lineId;
        }

        internal List<int> GetNumbers()
        {
            return Numbers;
        }
    }
}
