using System.Data;
using System.Globalization;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Digit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tbx.Text += btn.Text;
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;
            num1 = Convert.ToDouble(tbx.Text);
            tbx.Clear();
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(tbx.Text);
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "×":
                    result = num1 * num2;
                    break;
                case "%":
                    result = (num1 * num2) / 100;
                    break;
                case "÷":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        MessageBox.Show("Division by zero error!");
                    break;
            }
            tbx.Text = result.ToString();

        }
        private void Clear_Click(object sender, EventArgs e)
        {
            tbx.Clear();
            num1 = 0;
            num2 = 0;
            operation = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void zerobtn_Click(object sender, EventArgs e)
        {
            Digit_Click(sender, e);
        }

        private void onebtn_Click(object sender, EventArgs e)
        {
            Digit_Click(sender, e);
        }

        private void twobtn_Click(object sender, EventArgs e)
        {
            Digit_Click(sender, e);
        }

        private void threebtn_Click(object sender, EventArgs e)
        {
            Digit_Click(sender, e);
        }

        private void fourbtn_Click(object sender, EventArgs e)
        {
            Digit_Click(sender, e);
        }

        private void fivebtn_Click(object sender, EventArgs e)
        {
            Digit_Click(sender, e);
        }

        private void sixbtn_Click(object sender, EventArgs e)
        {
            Digit_Click(sender, e);
        }

        private void sevenbtn_Click(object sender, EventArgs e)
        {
            Digit_Click(sender, e);
        }

        private void eightbtn_Click(object sender, EventArgs e)
        {
            Digit_Click(sender, e);
        }

        private void ninebtn_Click(object sender, EventArgs e)
        {
            Digit_Click(sender, e);
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            Clear_Click(sender, e);
        }

        private void equalsbtn_Click(object sender, EventArgs e)
        {
            Equal_Click(sender, e);
        }


        private void decimalbtn_Click(object sender, EventArgs e)
        {
            if (!tbx.Text.Contains(","))
            {
                if (tbx.Text.Length == 0)
                    tbx.Text = "0,";
                else
                    tbx.Text += ",";
            }
        }

        private void additionbtn_Click(object sender, EventArgs e)
        {
            Operation_Click(sender, e);
        }

        private void subtractionbtn_Click(object sender, EventArgs e)
        {
            Operation_Click(sender, e);
        }
        private void multiplicationbtn_Click(object sender, EventArgs e)
        {
            Operation_Click(sender, e);
        }
        private void divisionbtn_Click(object sender, EventArgs e)
        {
            Operation_Click(sender, e);
        }
        private void percentagebtn_Click(object sender, EventArgs e)
        {
            Operation_Click(sender, e);
        }
        private void tbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
                e.Handled = false;
            else
                e.Handled = true;

        }
    }
}
