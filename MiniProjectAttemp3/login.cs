using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectAttemp3
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        //Declare global variables
        int intIncorrectPassword = 0;


        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare local variables
            string strPassword = Convert.ToString(txtPassword.Text);
           
            //PROCESS
            if (comboLogin.SelectedItem.ToString() == "admin" && strPassword == "June1994")
            {
                // switch to admin form
                admin f1 = new admin();
                this.Visible = false;
                f1.ShowDialog();
            }
            else
              if (comboLogin.SelectedItem.ToString() == "fan" && strPassword == "Pasta!")
            {
                //switch to booking form
                booking f1 = new booking();
                this.Visible = false;
                f1.ShowDialog();
            }
            else
            {
                //Exit application if there are 3 incorrect attempts
          
                intIncorrectPassword++;
                if (intIncorrectPassword >= 3)
                {
                  MessageBox.Show("Too many incorrect attempts,closing the application");
                  Application.Exit();
                }
                //count for incorrect attempt
                else
                {
                    MessageBox.Show("incorrect username or password");
                }
                
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboLogin.Items.Clear();
            txtPassword.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
}

