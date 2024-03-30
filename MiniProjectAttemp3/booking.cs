using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectAttemp3
{
    public partial class booking : Form
    {
        public booking()
        {
            InitializeComponent();
        }
        //Declare global variables
        int intParking = 150;
        int intHospitality = 1500;
        int intSuiteticketPrice = 2500;
        double dblGenPriceRate = 0.1;
        double dblBestinStandsRate = 0.5;
        
        
        
        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool blnValidformInput = true;
            //Declare variables to store the date
            DateTime nowDate= DateTime.Now;
            DateTime pickerDate = dateTimePickerDate.Value;
            TimeSpan tspan = pickerDate-DateTime.Now;

            //Declare local variables
            int daydifference=tspan.Days;
            double dblTotalCost = 0;
            double dblLowestPrice = arrayclass.LowestPrice[cmboMatch.SelectedIndex];

            double dblAdditionalCosts = 0;
            int intNumofPeople= Convert.ToInt16(numericUpDownNumOfPeople.Value);
            




            //Call method to validate form input
            blnValidformInput = ValidateFormInput(blnValidformInput, daydifference);
            
            //calculations
            if(blnValidformInput== true)
            {
            
                dblTotalCost = CalcTotalCost(dblTotalCost,dblLowestPrice,intNumofPeople);
                dblAdditionalCosts = CalcAdditions(dblAdditionalCosts,intNumofPeople);
                dblTotalCost = dblTotalCost + dblAdditionalCosts;
                string strDate = dateTimePickerDate.Value.ToString("ddd dd MMM yyyy");
                displayOutput(dblTotalCost,strDate);
            
            }
        }

        private void booking_Load(object sender, EventArgs e)
        {
            int intMatchCount;
            for (intMatchCount = 0; intMatchCount < arrayclass.Match.Length; ++intMatchCount)
            {
                cmboMatch.Items.Add(arrayclass.Match[intMatchCount]);
            }
        }

        private bool ValidateFormInput(bool blnValidformInput,int intdaydifference)
        {
            if (cmboMatch.SelectedItem == null)
            {
                blnValidformInput=false;
                MessageBox.Show("Please select a match");
            }
            if(numericUpDownNumOfPeople.Value < 1)
            {
                blnValidformInput = false;
                MessageBox.Show("Invalid Number of people");
            }
            if (intdaydifference < 7) 
            {
                blnValidformInput = false;
                MessageBox.Show("you can only book 7 days in advance");
            }
            if(radBehindStumps.Checked==false && radGeneralOpen.Checked==false && radBestInStands.Checked==false && radSuite.Checked == false)
            {
                blnValidformInput = false;
                MessageBox.Show("Please select a seating option");
            }
            if (chkFullHospitality.Checked==true && chkParking.Checked==true)
            {
                blnValidformInput = false;
                MessageBox.Show("You cant select parking and full hospitality at the same time");
            }

            return blnValidformInput;
           
        }
      

        private double CalcTotalCost(double dblTotalCost,double dblLowestPrice,int intNumofPeople)
        {
            if(radBestInStands.Checked == true)
            {
                dblTotalCost = (dblLowestPrice * dblBestinStandsRate) + dblLowestPrice;
            }
            else
               if(radBehindStumps.Checked == true)
            {
                dblTotalCost = dblLowestPrice;
            }
            else
                if(radSuite.Checked == true)
            {
                dblTotalCost = intSuiteticketPrice;
            }
            else
                if(radGeneralOpen.Checked == true)
            {
                dblTotalCost = (dblLowestPrice * dblGenPriceRate) + dblLowestPrice;
            }
            dblTotalCost = dblTotalCost * intNumofPeople;
        
            return dblTotalCost;
           
            
        }
        private double CalcAdditions(double dblAdditionalCosts,int intNumofPeople)
        {
            if (chkFullHospitality.Checked == true)
            {
                dblAdditionalCosts = intHospitality * intNumofPeople;
            }
            else
                if (chkParking.Checked == true) 
            {
                dblAdditionalCosts = intParking;
            }
            return dblAdditionalCosts;
        }
        
        private void displayOutput(double dblTotalCost,string strDate)
        {
            lblDate.Text = dateTimePickerDate.Value.ToShortDateString();
            lblNameOfMatch.Text= cmboMatch.SelectedItem.ToString();
            lblNoOftickets.Text = Convert.ToString(numericUpDownNumOfPeople.Value);
            lblTotalcost.Text = dblTotalCost.ToString("C2");

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmboMatch.Text= string.Empty;
            numericUpDownNumOfPeople.Value = 0;
            chkFullHospitality.Checked = false;
            chkParking.Checked = false;
            radBehindStumps.Checked = false;    
            radBestInStands.Checked = false;
            radGeneralOpen.Checked = false;
            radSuite.Checked = false;
            lblDate.Text = "";
            lblNameOfMatch.Text = "";
            lblNoOftickets.Text = "";
            lblTotalcost.Text = "";

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login f1 = new login();
            this.Visible = false;
            f1.ShowDialog();
        }
    }
}
