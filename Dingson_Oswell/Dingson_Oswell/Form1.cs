using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dingson_Oswell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AHHH();
               
            


        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AHHH()
        {
         
            string FN = firstname.Text; 
            string LN = lastname.Text; 
            string MN = middlename.Text;
            string message = ""; 

            
            if (!string.IsNullOrWhiteSpace(FN))
            {
                message += "First Name: "+FN+"\n"; 
            }
            else
            {
                message += " \n"; 
            }

            
            if (!string.IsNullOrWhiteSpace(MN)) // this provide if hindi ka nag put ng letters it will not show the middle name
                // if gagawin syang if(MN == MN) it will show the Middle Name:______ if you dont put anything 
            {
                message += "Middle Name: "+ MN+"\n"; 
            }
            else
            {
                message += " "; 
            }
            if (!string.IsNullOrWhiteSpace(LN))
            {
                message += "Last Name: "+ LN +"\n"; 
            }
            else
            {
                message += " \n"; 
            }
            if(MALE.Checked)//this male.checked if i click male circle button it will put gender male n the output
            {
                message += "Gender: " + MALE.Text;
            }
            else
            {
                message += "\n";
            }
            if (FEMALE.Checked) {
                message += "Gender: " + FEMALE.Text + "\n";
            }
            else
            {
                message += " \n";
            }
            if (Day.SelectedItem != null )
            {

                string D = Day.SelectedItem.ToString();
                message += "Day: " + D + "\n";
            }
            else
            {
                message += " \n";
            }
            if (Month.SelectedItem != null)
            {

                string M = Month.SelectedItem.ToString();
                message += "Month: " + M + "\n";
            }
            else
            {
                message += " \n";
            }
            if (Year.SelectedItem != null)
            {

                string Y = Year.SelectedItem.ToString();//the selected year will be string if i don't put ToString() it will not show the selected year
                message += "Year: " + Y + "\n";
            }
            else
            {
                message += " \n";
            }
            if (Programs.SelectedItem != null)
            {

                string P = Programs.SelectedItem.ToString();
                message += "Program you choose: " + P + "\n";
            }
            else
            {
                message += " \n";
            }


            MessageBox.Show(message.Trim());
        }
    }
}
 
