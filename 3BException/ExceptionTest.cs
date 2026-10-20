using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3BException
{
    public partial class ExceptionTest : Form
    {
        private int num1, num2;
        public ExceptionTest()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);
                if (num1 == 0 || num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    MessageBox.Show("Total: " + GetQuotient(num1, num2));
                }
            }
            catch (DivideByZeroException dze)
            {
                MessageBox.Show("Exception: " +  dze.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Exception: " + fe.Message);
            }
        }

        private int GetQuotient(int x, int y) 
        {
            return x / y;
        }
    }
}
