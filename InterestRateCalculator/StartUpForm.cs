using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestRateCalculator
{
    public partial class StartUpForm : Form
    {
        public StartUpForm()
        {
            InitializeComponent();
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            CalculateInterest calculateInterest = new CalculateInterest();
            this.Hide();
            calculateInterest.ShowDialog();
        }

        private void btnCompound_Click(object sender, EventArgs e)
        {
            CalculateCompundInterest calculateCompundInterest = new CalculateCompundInterest();
            this.Hide();
            calculateCompundInterest.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsurancePlanCalculator insurancePlanCalculator = new InsurancePlanCalculator();
            this.Hide();
            insurancePlanCalculator.ShowDialog();
        }
    }
}
