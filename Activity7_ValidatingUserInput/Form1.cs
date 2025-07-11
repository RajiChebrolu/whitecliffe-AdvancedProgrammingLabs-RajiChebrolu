namespace Activity7_ValidatingUserInput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            try
            {
                int age = int.Parse(txtAge.Text);
                if (age < 0)
                {
                    throw new NegativeAgeException("Age cannot be negative.");
                }

                if (age > 120)
                {
                    throw new AgeOutOfRangeException("Age is not realistic.");
                }

                lblMessage.Text = $"Age {age} submitted successfully.";
            }
            catch (FormatException)
            {
                lblMessage.Text = "Please enter a valid number.";
            }
            catch (NegativeAgeException ex)
            {
                lblMessage.Text = ex.Message;
            }
            catch (AgeOutOfRangeException ex)
            {
                lblMessage.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Unexpected error:" +ex.Message;
            }
        }
    }
}
