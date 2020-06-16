using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestRateCalculator
{
    public class Converter
    {
        public double ToDouble(string stringValue)
        {
            double ConvertedValue = 0;
            bool isConvertable = false ;
            if (stringValue==null || stringValue=="")
            {
                return 0;
            }
            isConvertable = double.TryParse(stringValue, out ConvertedValue);
            if (!isConvertable)
            {
                MessageBox.Show("Value Cannot be Converted");
            }
            return ConvertedValue;
        }
    }
}
