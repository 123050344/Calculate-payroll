using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_payroll
{
    public class payroll
    {
        private int worked_days;

        public int Worked_days { get; set; }

        //Method
        public double calculation (int worked_days_, double day_value)
        {
            double total = worked_days_ * day_value;
            return total;
        }
    }
}
