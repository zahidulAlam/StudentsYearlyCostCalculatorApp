using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YearlyCostCalculator
{
    public partial class yearlyCostCalculatorUI : Form
    {
        public yearlyCostCalculatorUI()
        {
            InitializeComponent();
        }

        private void yearlyCostCalculatorUI_Load(object sender, EventArgs e)
        {
            classComboBox.Items.Add("Class 1");
            classComboBox.Items.Add("Class 2");
            classComboBox.Items.Add("Class 3");
            classComboBox.Items.Add("Class 4");
            classComboBox.Items.Add("Class 5");
            classComboBox.Items.Add("Class 6");
            classComboBox.Items.Add("Class 7");
            classComboBox.Items.Add("Class 8");
            classComboBox.Items.Add("Class 9");
            classComboBox.Items.Add("Class 10");
            classComboBox.Items.Add("Class 11");
            classComboBox.Items.Add("Class 12");
        }

        private void calculateTotalAmountButton_Click(object sender, EventArgs e)
        {
            string classSelect = classComboBox.Text;
            if (classSelect == "Class 1" || classSelect == "Class 2" || classSelect == "Class 3" ||
                classSelect == "Class 4" || classSelect == "Class 5")
            {
                double totalAmount = classSelectedFromOneToFive(classSelect);
                if (discountCheckBox.Checked == true)
                {
                    double discount = (totalAmount*.05);
                    totalAmount -= discount;
                  
                    MessageBox.Show("Total Amount is : " + totalAmount + " Tk");
                }
                else
                {
                    MessageBox.Show("Total Amount is : " + totalAmount + " Tk");
                }

            }
            else if (classSelect == "Class 6" || classSelect == "Class 7" || classSelect == "Class 8")
            {
                double totalAmount = classSelectedFromSixToEight(classSelect);
                if (discountCheckBox.Checked == true)
                {
                    double discount = (totalAmount*.05);
                    totalAmount -= discount;
                    MessageBox.Show("Total Amount is : " + totalAmount + " Tk");
                }
                else
                {
                    MessageBox.Show("Total Amount is : " + totalAmount + " Tk");
                }
            }
            else
            {
                double totalAmount = classSelectedFromNineToTewelve(classSelect);
                if (discountCheckBox.Checked == true)
                {
                    double discount = (totalAmount * .05);
                    totalAmount -= discount;
                    MessageBox.Show("Total Amount is : " + totalAmount + " Tk");
                }
                else
                {
                    MessageBox.Show("Total Amount is : " + totalAmount + " Tk");
                }
            }
        }

        static double classSelectedFromOneToFive(string classType)
        {
            if (classType == "Class 1" || classType == "Class 2")
            {
                return 10000.0 + (12.0*500.0);
            }
            else
            {
                return 10000.0 + (12.0 * 1000.0);   
            }
        }

        static double classSelectedFromSixToEight(string classType)
        {
            return 12000.0 + (12.0 * 1500.0);
        }

        static double classSelectedFromNineToTewelve(string classType)
        {
            if (classType == "Class 9" || classType == "Class 10")
            {
                return 15000.0 + (12.0 * 2000.0);
            }
            else
            {
                return 15000.0 + (12.0 * 2700.0);
            }
        }



    
    }
}
