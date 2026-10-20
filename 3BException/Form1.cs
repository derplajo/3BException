namespace _3BException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnException_Click(object sender, EventArgs e)
        {
            ExceptionTest et = new ExceptionTest();
            et.ShowDialog();
        }

        private void btnCustomException_Click(object sender, EventArgs e)
        {
            CustomExceptionTest cet = new CustomExceptionTest();
            cet.ShowDialog();
        }
    }
}
