using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3BException
{
    public partial class CustomExceptionTest : Form
    {
        public CustomExceptionTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CheckAge(Int32.Parse(textBox1.Text));
            }
            catch (InvalidUserInputException iuie)
            {
                MessageBox.Show("Message: " + iuie.Message);
            }
        }

        private void CheckAge(int age)
        {
            if (age == 0 || age < 18)
            {
                throw new InvalidUserInputException("Not in Legal Age!");
            }
            else
            {
                MessageBox.Show("Legal Age");
            }
        }
    }
}
