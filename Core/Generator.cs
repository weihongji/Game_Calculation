using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class Generator
    {
        public int Bottom { get; set; }
        public int Top { get; set; }

        public Generator()
            : this(1, 100)
        {

        }

        public Generator(int bottom, int top)
        {
            this.Bottom = bottom;
            this.Top = top;
        }

        public List<Calculation> GetAdditions(int count)
        {
            return GetAdditions(count, this.Bottom, this.Top);
        }

        public List<Calculation> GetAdditions(int count, int bottom, int top)
        {
            var random = new System.Random();
            var range = top - bottom;
            var additions = new List<Calculation>(count);
            int i = 0;
            while (i < count)
            {
                var result = (int)(random.NextDouble() * range);
                var left = random.Next(bottom, result);
                var calculation = new Calculation()
                {
                    Operation = Operation.Addition,
                    Left = left,
                    Right = result - left
                };
                var s = calculation.ToString();
                if (additions.All(x => x.ToString() != s))
                {
                    additions.Add(calculation);
                    i++;
                }
            }
            return additions;
        }

        public List<Calculation> GetSubtractions(int count)
        {
            return GetSubtractions(count, this.Bottom, this.Top);
        }

        public List<Calculation> GetSubtractions(int count, int bottom, int top)
        {
            var random = new System.Random();
            var range = top - bottom;
            var subtractions = new List<Calculation>(count);
            int i = 0;
            while (i < count)
            {
                var left = (int)(random.NextDouble() * range);
                var right = random.Next(bottom, left);
                var calculation = new Calculation()
                {
                    Operation = Operation.Subtraction,
                    Left = left,
                    Right = right
                };
                var s = calculation.ToString();
                if (subtractions.All(x => x.ToString() != s))
                {
                    subtractions.Add(calculation);
                    i++;
                }
            }
            return subtractions;
        }
    }
}
