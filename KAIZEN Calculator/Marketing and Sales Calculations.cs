using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAIZEN_Calculator
{
    internal class Marketing_and_Sales_Calculations
    {
        public double currentYearSales;
        public double previousYearSales;
        public double marketGrowthRate;


        public void getMarketGrowthRate()
        {
            marketGrowthRate = currentYearSales / previousYearSales;
        }
    }
}
