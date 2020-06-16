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
    public partial class CalculateInterest : Form
    {
        public double Rate { get; set; }
        public double Time { get; set; }
        public double Principal { get; set; }
        public double Interest { get; set; }
        public double Year { get; set; }
        public double Month { get; set; }
        public List<Interestdata> interestDatalist { get; set; }
        public CalculateInterest()
        {
            InitializeComponent();
        }
        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            CalcInterests calcInterests = new CalcInterests();
            Interest=    calcInterests.CalculateSimpleInterest(tbPrincipal.Text.Trim().ToString(),tbYear.Text.Trim().ToString(),tbMonth.Text.Trim().ToString(),tbRate.Text.Trim().ToString());
            Converter converter = new Converter();
            Principal = converter.ToDouble(tbPrincipal.Text.Trim().ToString());
            Interestdata interestdata = new Interestdata
            {
                Interest = Interest,
                Total = Interest + Principal,
                Principal = Principal,
                Rate = converter.ToDouble(tbRate.Text.Trim().ToString()),
                Time_Month=(converter.ToDouble(tbYear.Text.Trim().ToString()) *12)+converter.ToDouble(tbMonth.Text.Trim().ToString()),

            };
            if (interestDatalist==null)
            {
                List<Interestdata> list = new List<Interestdata>();
                interestDatalist = list;
            }
            interestDatalist.Add(interestdata);
            Label lb = new Label();
            lb.Location = new Point(251, 70);
            lb.Text = Interest.ToString();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = interestDatalist;
            // Adding this label in the form 
            this.Controls.Add(lb);
            //richTextBox1.Document.Blocks.Add(new Paragraph(new Run("Text")));
        }

        private void CalculateInterest_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StartUpForm startUpForm = new StartUpForm();
            this.Hide();
            startUpForm.ShowDialog();
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
