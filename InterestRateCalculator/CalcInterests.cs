using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterestRateCalculator
{
    public class CalcInterests
    {
        public double Rate { get; set; }
        public double Time { get; set; }
        public double Principal { get; set; }
        public double Interest { get; set; }
        public double Year { get; set; }
        public double Month { get; set; }
        public double NumberOfTimes { get; set; }
       public double CalculateSimpleInterest(string principalStr,string yearStr, string monthStr, string rateStr)
        {
            double Interest = 0;
            Converter converter = new Converter();
            Rate = converter.ToDouble(rateStr);
            Principal = converter.ToDouble(principalStr);
            Year = converter.ToDouble(yearStr);
            Month = converter.ToDouble(monthStr);
            Time = Year + (Month / 12);
            Interest = (Rate * Time * Principal) / 100;
            return Interest;
        }
        public double CalculateCompoundInterest(string principalStr, string yearStr, string monthStr, string rateStr,string numberOfTimeStr)
        {
            double Interest = 0;
            double PowerNumber = 0;
            double BaseNumber = 0;
            Converter converter = new Converter();
            Rate = converter.ToDouble(rateStr);
            Principal = converter.ToDouble(principalStr);
            Year = converter.ToDouble(yearStr);
            Month = converter.ToDouble(monthStr);
            NumberOfTimes = converter.ToDouble(numberOfTimeStr);
            Rate = Rate / 100;
            Time = Year + (Month / 12);
            BaseNumber = 1 + (Rate / NumberOfTimes);
            PowerNumber = Time * NumberOfTimes;
            Interest = Math.Pow(BaseNumber, PowerNumber);

            Interest = Principal * Interest;
            return Interest;
        }
    }
}
