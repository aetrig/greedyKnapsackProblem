using Knapsack;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            bool correctData = true;
            if (Int32.TryParse(seedTextBox.Text, out int seed) && seed > 0)
            {
                seedTextBox.BackColor = Color.White;
            }
            else
            {
                seedTextBox.BackColor = Color.Red;
                correctData = false;
            }

            if (Int32.TryParse(itemsTextBox.Text, out int n) && n > 0)
            {
                itemsTextBox.BackColor = Color.White;
            }
            else
            {
                itemsTextBox.BackColor = Color.Red;
                correctData = false;
            }

            if (Int32.TryParse(capacityTextBox.Text, out int capacity) && capacity > 0)
            {
                capacityTextBox.BackColor = Color.White;
            }
            else
            {
                capacityTextBox.BackColor = Color.Red;
                correctData = false;
            }

            if (correctData)
            {
                Problem problem = new(n, seed);
                instanceTextBox.Text = problem.ToString().Replace("\n", "\r\n");

                Result result = problem.Solve(capacity);
                resultTextBox.Text = result.ToString().Replace("\n", "\r\n");
            }
            else
            {
                instanceTextBox.Text = "";
                resultTextBox.Text = "Please enter only positive natural numbers\r\n";
            }
        }
    }
}
