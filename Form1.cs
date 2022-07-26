namespace CalculatriceAP2
{
    public partial class Form1 : Form
    {
        private string operande1 = "";
        private string operande2 = "";
        private string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void bouton0_Click(object sender, EventArgs e)
        {
            ecran.Text += "0";
        }

        private void bouton1_Click(object sender, EventArgs e)
        {
            ecran.Text += "1";
        }

        private void bouton2_Click(object sender, EventArgs e)
        {
            ecran.Text += "2";
        }

        private void bouton3_Click(object sender, EventArgs e)
        {
            ecran.Text += "3";
        }

        private void bouton4_Click(object sender, EventArgs e)
        {
            ecran.Text += "4";
        }

        private void bouton5_Click(object sender, EventArgs e)
        {
            ecran.Text += "5";
        }

        private void bouton6_Click(object sender, EventArgs e)
        {
            ecran.Text += "6";
        }

        private void bouton7_Click(object sender, EventArgs e)
        {
            ecran.Text += "7";
        }

        private void bouton8_Click(object sender, EventArgs e)
        {
            ecran.Text += "8";
        }

        private void bouton9_Click(object sender, EventArgs e)
        {
            ecran.Text += "9";
        }

        private void boutonVirgule_Click(object sender, EventArgs e)
        {
            ecran.Text += ",";
            boutonVirgule.Enabled = false;
        }

        private void boutonCls_Click(object sender, EventArgs e)
        {
            ecran.Text = "";
            boutonVirgule.Enabled = true;
        }

        private void boutonAddition_Click(object sender, EventArgs e)
        {
            operande1 = ecran.Text;
            operation = "addition";
            ecran.Text = "";
        }

        private void boutonDivision_Click(object sender, EventArgs e)
        {
            operande1 = ecran.Text;
            operation = "division";
            ecran.Text = "";
        }

        private void boutonSoustraction_Click(object sender, EventArgs e)
        {
            operande1 = ecran.Text;
            operation = "soustraction";
            ecran.Text = "";
        }

        private void boutonMultiplication_Click(object sender, EventArgs e)
        {
            operande1 = ecran.Text;
            operation = "multiplication";
            ecran.Text = "";
        }

        private void boutonPuissance_Click(object sender, EventArgs e)
        {
            operande1 = ecran.Text;
            operation = "puissance";
            ecran.Text = "";
        }

        private void boutonEgal_Click(object sender, EventArgs e)
        {
            operande2 = ecran.Text;

            double op1 = System.Convert.ToDouble(operande1);
            double op2 = System.Convert.ToDouble(operande2);

            switch (operation)
            {
                case "addition": 
                    {
                        ecran.Text = (op1 + op2).ToString();
                        break;
                    }
                case "soustraction":
                    {
                        ecran.Text = (op1 - op2).ToString();
                        break;
                    }
                case "multiplication":
                    {
                        ecran.Text = (op1 * op2).ToString();
                        break;
                    }
                case "division":
                    {
                        ecran.Text = (op1 / op2).ToString();
                        break;
                    }
                case "puissance":
                    { 
                        ecran.Text = (Math.Pow(op1, op2)).ToString();
                        break;
                    }
            }
        }
    }
}