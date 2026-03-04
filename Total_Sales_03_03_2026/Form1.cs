namespace Total_Sales_03_03_2026
{
    public partial class frmTotalSales : Form
    {
        public frmTotalSales()
        {
            InitializeComponent();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            // Implement try-catch
            try
            {
                // Create a One-Dimensional Array that will read from the text file
                string[] allLines = File.ReadAllLines("TotalSales.txt");

                double[] totalSales = new double[allLines.Length];

                double sum = 0;

                int counter = 0;


                // Create a foreach loop that converts and calculates
                foreach (string line in allLines)


                {
                    totalSales[counter] = Convert.ToDouble(line);


                    // Calculate the sum
                    sum += totalSales[counter];    // sum = sum + totalSales[counter]


                    // Display the current value in the list box
                    listDisplay.Items.Add(totalSales[counter]);    


                    // Increment Counter
                     counter++;

                }

                // Display the totalSales in the list Box
                listDisplay.Items.Add($"Total Sales: {sum:C}");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}
