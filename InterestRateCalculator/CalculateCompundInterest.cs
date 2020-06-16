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
    public partial class CalculateCompundInterest : Form
    {
        public List<Interestdata> interestDatalist { get; set; }
        public CalculateCompundInterest()
        {
            InitializeComponent();
        }
        public double Rate { get; set; }
        public double Time { get; set; }
        public double NumberOfTimes { get; set; }
        public double Principal { get; set; }
        public double Interest { get; set; }
        
        public Interestdata interestdata { get; set; }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Converter converter = new Converter();
            try
            {
                CalcInterests calcInterests = new CalcInterests();
                Interest = calcInterests.CalculateCompoundInterest(tbPrincipal.Text.Trim().ToString(), tbYear.Text.Trim().ToString(), tbMonth.Text.Trim().ToString(), tbRate.Text.Trim().ToString(), tbNoOfTimes.Text.Trim().ToString());
                Principal = converter.ToDouble(tbPrincipal.Text.Trim().ToString());
                Rate = converter.ToDouble( tbRate.Text.Trim().ToString());
                Time = converter.ToDouble(tbYear.Text.Trim().ToString()) * 12 + converter.ToDouble(tbMonth.Text.Trim().ToString());
                Interest = Interest - Principal;
                Interestdata interestdata2 = new Interestdata();
                interestdata = interestdata2;
                interestdata.Interest = Interest;
                interestdata.Total = Interest + Principal;
                interestdata.Principal = Principal;
                interestdata.Rate = Rate;

                interestdata.Time_Month = Time; ;
                if (interestDatalist==null)
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
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StartUpForm startUpForm = new StartUpForm();
            this.Hide();
            startUpForm.ShowDialog();
            
        }

        private void tbNoOfTimes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbNoOfTimes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbRate.Focus();
                e.Handled = true;
            }
        }

        private void tbRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbYear.Focus();
                e.Handled = true;
            }
        }

        private void tbYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbMonth.Focus();
                e.Handled = true;
            }
        }

        private void tbMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPrincipal.Focus();
                e.Handled = true;
            }
        }

        private void tbPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPrincipal.Focus();
                btnCalculate.PerformClick();
                tbPrincipal.Focus();
                tbPrincipal.SelectAll();
                e.Handled = true;
            }
        }
    }
}
