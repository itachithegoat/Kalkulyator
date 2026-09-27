using System;
using System.Windows.Forms;

namespace numberKalkulyator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNumberOne.Text, out double a))
            {
                MessageBox.Show("Invalid input for Number one.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtNumberTwo.Text, out double b))
            {
                MessageBox.Show("Invalid input for Number two.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCommand.SelectedItem == null)
            {
                MessageBox.Show("Please select a command.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cmd = cmbCommand.SelectedItem.ToString();
            double result = 0;

            switch (cmd)
            {
                case "Addition":
                    result = a + b;
                    break;
                case "Subtraction":
                    result = a - b;
                    break;
                case "Multiplication":
                    result = a * b;
                    break;
                case "Division":
                    if (b == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.", "Math error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    result = a / b;
                    break;
                default:
                    MessageBox.Show("Unknown command.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            lblAnswerValue.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumberOne.Text = "0";
            txtNumberTwo.Text = "0";
            cmbCommand.SelectedIndex = -1;
            lblAnswerValue.Text = "0";
        }
    }
}
