using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy2Utest
{
 

    public partial class Form1 : Form
    {
        //global variables
        
        decimal LocConvertedMoney;
        List<Transaction> transaction = new List<Transaction>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logs_btn_Click(object sender, EventArgs e)
        {
            log_panel.Visible = true;
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            double LocExchangeRate = 0.00;
            string currencyTag = "";
            //Radio button 
            if(usd_rdoBtn.Checked)
            {
                LocExchangeRate = 1.16;
                currencyTag = "USD";
            }
            else if (aud_rdoBtn.Checked)
            {
                LocExchangeRate = 2.09;
                currencyTag = "AUD";
            }
            else if(eur_rdoBtn.Checked)
            {
                LocExchangeRate = 1.08;
                currencyTag = "EUR";
            }

            //conversion
            if (decimal.TryParse(input_txtbox.Text, out LocConvertedMoney))
            {
                LocConvertedMoney = LocConvertedMoney * Convert.ToDecimal(LocExchangeRate);
                LocConvertedMoney = Math.Round(LocConvertedMoney, 2, MidpointRounding.AwayFromZero);

                if(LocConvertedMoney < 0)
                {
                    MessageBox.Show("please enter a number greater than 0");
                    LocConvertedMoney = 0;
                    input_txtbox.Clear();
                }else
                {
                   
                    transaction.Add(new Transaction() {
                        ExchangeRate = LocExchangeRate,
                        ConvertedMoney = LocConvertedMoney,
                        Currency = currencyTag, Date = DateTime.Now });
                }
            }
            else
            {
                MessageBox.Show("invalid input please check your input and try again");
            }

            //display result
            result_txtbox.Text = LocConvertedMoney.ToString();
            input_txtbox.Text = "";

        }

        private void query_btn_Click(object sender, EventArgs e)
        {
            List<Transaction> QueryTransaction = new List<Transaction>();
            DateTime MinDateSearch;
            DateTime MaxDateSearch;

            if (DateTime.TryParse(MinDateQuery_txtbox.Text, out MinDateSearch) &&
                DateTime.TryParse(MaxDateQuery_txtbox.Text, out MaxDateSearch))
            {
                for(int i=0; i< transaction.Count;i++)
                {
                    if(transaction[i].Date.Date >= MinDateSearch &&
                       transaction[i].Date.Date <= MaxDateSearch)
                    {
                        QueryTransaction.Add(transaction[i]);
                    }
                }
                log_dataGridView.DataSource = QueryTransaction;
            }
            else
            {
                MessageBox.Show("incorrect date format please use dd/mm/yyyy");
                MinDateQuery_txtbox.Text = "";
                MaxDateQuery_txtbox.Text = "";
            }
            
            //log_dataGridView.DataSource = transaction;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
