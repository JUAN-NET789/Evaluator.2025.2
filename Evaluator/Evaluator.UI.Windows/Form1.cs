using Evaluator.Core;

namespace Evaluator.UI.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += ".";
        }

        private void btnopenparentesis_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "(";
        }

        private void btncloseparentesis_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += ")";
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "*";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "/";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "+";
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "-";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text.Substring(0, txtdisplay.Text.Length - 1);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = string.Empty;
        }

        private void btnpow_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "^";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += $"={ExpressionEvaluator.Evaluate(txtdisplay.Text)}";
        }
    }
}
