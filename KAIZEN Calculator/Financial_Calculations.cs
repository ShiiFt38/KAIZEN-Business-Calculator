using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAIZEN_Calculator
{
    internal class Financial_Calculations
    {
        public double salesRevenue { get; set; }
        public double totalCosts { get; set; }
        public double netProfit { get; set; }
        public double costOfGoods { get; set; }
        public double grossProfitMargin { get; set; }
        public void getNetProfit()
        {
            netProfit = salesRevenue - totalCosts;
        }

        public void getGrossProfitMargin() 
        {
            grossProfitMargin = ((salesRevenue - costOfGoods) / salesRevenue) * 100;
        }
    }
}
