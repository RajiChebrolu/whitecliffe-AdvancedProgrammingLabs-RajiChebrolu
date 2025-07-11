namespace ExceptionHandlingWeek7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            performOperation("add");
        }       

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            performOperation("subtract");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            performOperation("multiply");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            performOperation("divide");
        }

        private void performOperation(string operationType)
        {
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double result = 0;

                switch (operationType)
                {
                    case "add":
                        result = num1 + num2;
                        break;
                    case "subtract":
                        result = num1 - num2;
                        break;
                    case "multiply":
                        result = num1 * num2;
                        break;
                    case "divide":
                        if (num2 == 0) 
                            throw new DivideByZeroException();
                        result = num1 / num2;
                        break;
                }
                lblResult.Text = "Result: " + result.ToString();
            }
            catch (FormatException)
            {
                lblResult.Text = "Error: Please enter a valid number.";
            }

            catch (DivideByZeroException)
            {
                lblResult.Text = "Error: A number cannot divide by zero. Please enter second number.";
            }

            catch (Exception ex)
            {
                lblResult.Text = "Unexpected Error: " + ex.Message;
            }
        }
    }
}
