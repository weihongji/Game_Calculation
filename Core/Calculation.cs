using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public class Calculation
    {
        public int Left { get; set; }
        public int Right { get; set; }
        public int Result
        {
            get
            {
                switch (this.Operation)
                {
                    case Operation.Addition:
                        return this.Left + this.Right;
                    case Operation.Subtraction:
                        return this.Left - this.Right;
                    default:
                        break;
                }
                throw new ArgumentException("Invalid operation code " + (int)this.Operation);
            }
        }
        public Operation Operation { get; set; }

        public override string ToString()
        {
            return string.Format("{1} {0} {2} = ", this.Operation == Operation.Addition ? "+" : "-", this.Left, this.Right);
        }
    }

    public enum Operation
    {
        Addition = 1,
        Subtraction = 2
    }
}
