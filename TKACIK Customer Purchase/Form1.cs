using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//LOUIE TKACIK CUSTOMER PURCHASE ASSIGNMENT FOR C# 2  CPT_231_001_2019FA1
//STUDENT ID 0290449


//include both tax prices and raw price in the list box
//handlers:
//itemNameInput [textbox]
//itemPriceInput [textbox]
//clearEntryButton [button, clears entry before it's input]
//addPurchaseButton [button, adds item to list and calculations]
//purchasesListBox [List box, stores item name, raw price, federal tax, and state tax for each individual item]
//fedTaxOutput [label, displays total federal tax]
//stateTaxOutput [label, displays total state tax]
//beforeTaxesOutput [label, displays total BEFORE taxes]
//totalOutput [Label, displays the entire price]
//clearAllButton [button, clears ALL information]
//--------------
//Federal taxes as a decimal for 0.10 
//state taxes as a decimal for 0.035
//Taxes both taken from RAW number not cumulative






namespace TKACIK_Customer_Purchase
{
    public partial class CustomerPurchaseForm : Form
    {
        public CustomerPurchaseForm()
        {
            InitializeComponent();
        }
        double fedTax = 0;
        double stateTax = 0;
        double total = 0;
        double baseTotal = 0;

        double indFedTax = 0;
        double indStateTax = 0;

        private void CustomerPurchaseForm_Load(object sender, EventArgs e)
        {

        }

        private void clearEntryButton_Click(object sender, EventArgs e) 
        {
            //clears the two input boxes
            itemNameInput.Text = "";
            itemPriceInput.Text = "";
        }

        private void addPurchaseButton_Click(object sender, EventArgs e)
        {
            String item;
            double itemPrice;
            item = itemNameInput.Text;
            if (double.TryParse(itemPriceInput.Text, out itemPrice) == true)
            {
               
                addToList(item, itemPrice);
                addToPrices(itemPrice);
            }
            else
            {
                MessageBox.Show("Please enter a numeric value for the price.");
            }
            

            
        }
        public void addToList(string name, double prices)
        {
            //This adds the item and the individual prices/taxes to the list box
            calcTaxes(prices);

            purchasesListBox.Items.Add(name + "   Federal Tax: " + indFedTax.ToString("C") + "   State Tax:" + indStateTax.ToString("C"));
        }

        public void addToPrices(double prices)
        {
            //This adds to the running totals
            calcTaxes(prices);
            fedTax = fedTax + indFedTax;
            stateTax = stateTax + indStateTax;
            baseTotal = baseTotal + prices;
            total = baseTotal + fedTax + stateTax;

            fedTaxOutput.Text = fedTax.ToString("C");
            stateTaxOutput.Text = stateTax.ToString("C");
            beforeTaxesOutput.Text = baseTotal.ToString("C");
            totalOutput.Text = total.ToString("C");
        }

        public void calcTaxes(double prices)
        {
            //this saves the indTaxes into the public variables.  It doesn't TECHNICALLY return anything.  Technically.
            indFedTax = prices * (0.10);
            indStateTax = prices * (0.035);
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            fedTax = 0;
            stateTax = 0;
            total =0;
            baseTotal = 0;
            indFedTax = 0;
            indStateTax = 0;
            fedTaxOutput.Text = fedTax.ToString("C");
            stateTaxOutput.Text = stateTax.ToString("C");
            beforeTaxesOutput.Text = baseTotal.ToString("C");
            totalOutput.Text = total.ToString("C");

            purchasesListBox.Items.Clear();
            itemNameInput.Text = "";
            itemPriceInput.Text = "";
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
