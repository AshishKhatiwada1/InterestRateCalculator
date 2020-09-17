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
    public partial class InsurancePlanCalculator : Form
    {
        public InsurancePlanCalculator()
        {
            InitializeComponent();

        }
        public double Rate { get; set; }
        public double Time { get; set; }
        public double NumberOfTimes { get; set; }
        public double Principal { get; set; }
        public double Interest { get; set; }
        private static int _sn;
        public int Serial {
            get { _sn= _sn + 1;
                return _sn;
            }
            set { _sn = value; } }
        public List<Interestdata> interestDatalist { get; set; }
        public Interestdata interestdata { get; set; }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Serial = 0;
            Converter converter = new Converter();
            int TotalYear = Convert.ToInt32(tbTotalYear.Text.Trim());
            CalcInterests calcInterests = new CalcInterests();

            double principlePerYear = converter.ToDouble(tbPrincipal.Text.Trim());
            double principaltotal = 0;
            double TimesPerYear = converter.ToDouble(tbTimesInYear.Text.Trim());
            //double smallYear = converter.ToDouble(tbYear.Text.Trim()) / TimesPerYear;
            double bigYear = converter.ToDouble(tbTotalYear.Text.Trim()) * TimesPerYear;
            double monthToPay = converter.ToDouble(tbYear.Text.Trim()) / 12 * TimesPerYear;
            
            for (int i = 0; i < bigYear; i++)
            {
                principaltotal = principaltotal + principlePerYear;
                Interest = calcInterests.CalculateCompoundInterest(principaltotal.ToString(), "0", monthToPay.ToString(), tbRate.Text.Trim().ToString(), tbNoOfTimes.Text.Trim().ToString());
                principaltotal = +CalculateCompoundInterest(principaltotal,Interest,TimesPerYear);
            }


        }
        public double CalculateCompoundInterest(double p = 0, double i = 0,double timesInYear=0)
        {
            Converter converter = new Converter();
            try
            {
                if (p == 0)
                {
                    Principal = converter.ToDouble(tbPrincipal.Text.Trim().ToString());
                }
                else
                {
                    Principal = p;
                }
                CalcInterests calcInterests = new CalcInterests();
                if (i == 0)
                {
                    Interest = calcInterests.CalculateCompoundInterest(Principal.ToString(), tbYear.Text.Trim().ToString(), tbMonth.Text.Trim().ToString(), tbRate.Text.Trim().ToString(), tbNoOfTimes.Text.Trim().ToString());

                }
                else
                {
                    Interest = i;
                }

                Rate = converter.ToDouble(tbRate.Text.Trim().ToString());
                Time = converter.ToDouble(tbYear.Text.Trim().ToString()) * 12 + converter.ToDouble(tbMonth.Text.Trim().ToString());
                Interest = Interest - Principal;
                Interestdata interestdata2 = new Interestdata();
                interestdata = interestdata2;
                interestdata.Interest = Interest;
                interestdata.SN = Serial;
                interestdata.Total = Interest + Principal;
                interestdata.Principal = Principal;
                interestdata.Rate = Rate;
                if (timesInYear==0)
                {
                    interestdata.Time_Month = Time; ;

                }
                else
                {
                    interestdata.Time_Month = timesInYear;
                }
                if (interestDatalist == null)
                {
                    List<Interestdata> list = new List<Interestdata>();
                    interestDatalist = list;

                }
                interestDatalist.Add(interestdata);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = interestDatalist;
                Label lb = new Label();
                lb.Location = new Point(251, 70);
                lb.Text = Interest.ToString();

                // Adding this label in the form 
                this.Controls.Add(lb);
                return interestdata.Total;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return interestdata.Total;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void InsurancePlanCalculator_Load(object sender, EventArgs e)
        {
            tbYear.Text = "1";
            tbNoOfTimes.Text = "12";
            tbRate.Text = "12";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            StartUpForm startUpForm = new StartUpForm();
            startUpForm.Show();
        }
    }
}
