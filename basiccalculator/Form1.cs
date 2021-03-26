using System;
using System.Windows.Forms;

namespace basiccalculator
{
    public partial class Calculator : Form
    {
        Double result = 0;
        String operation = "";
        bool enter_value = false;
        String firstnum, secondnum;
        public Calculator()
        {
            InitializeComponent();
        }

        private void textDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void numbers_only(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if ((textDisplay.Text == "0") || (enter_value))
                textDisplay.Text = "";
            enter_value = false;

            if (b.Text == ".")
            {
                if (!textDisplay.Text.Contains("."))
                    textDisplay.Text = textDisplay.Text + b.Text;

            }
            else
            {
                textDisplay.Text = textDisplay.Text + b.Text;
            }

        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (result != 0)
            {
                buttonEq.PerformClick();
                enter_value = true;
                operation = b.Text;
                lblShowOps.Text = System.Convert.ToString(result) + "  " + operation;

            }
            else
            {


                operation = b.Text;
                result = Double.Parse(textDisplay.Text);
                textDisplay.Text = "";
                lblShowOps.Text =System.Convert.ToString(result) + "  " + operation;
            }
            firstnum = lblShowOps.Text;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            result = 0;
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            secondnum = textDisplay.Text;
            lblShowOps.Text = "";
            switch (operation)
            {
                case "+":
                    textDisplay.Text = (result + Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "-":
                    textDisplay.Text = (result - Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "×":
                    textDisplay.Text = (result * Double.Parse(textDisplay.Text)).ToString();
                    break;
                case "÷":
                    textDisplay.Text = (result / Double.Parse(textDisplay.Text)).ToString();
                    break;
                default:
                    break;



            }
            result = Double.Parse(textDisplay.Text);
            operation = "";


            buttonTrash.Visible = true;
            rtbDisplayHistory.AppendText(firstnum + "   " + secondnum + " = " + "\n");
            rtbDisplayHistory.AppendText("\n\t" + textDisplay.Text + "\n\n");
            lblHistoryDisplay.Text = "";
        }

        private void buttonTrash_Click(object sender, EventArgs e)
        {
            rtbDisplayHistory.Clear();
            if(lblHistoryDisplay.Text == "")
            {
                lblHistoryDisplay.Text = "There's no history yet";

            }
            buttonTrash.Visible = false;
            rtbDisplayHistory.ScrollBars = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Name == "Node2")
            {
                lblTitle.Text = "Standard";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node4")
            {
                lblTitle.Text = "Scientific";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node6")
            {
                lblTitle.Text = "Graphing";
                treeView1.Visible = false;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1);
            }
            if (textDisplay.Text == "")
            {
                textDisplay.Text = "0";
            }
        }
    }
}

