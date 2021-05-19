using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace _2DArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
            GetWeeklyTotals();
        }

        private int[,] tableValues = new int[4, 6];
        private string[] weekDays = new string[6];
        private string[] salesPeople = new string[4];
        private float[] commissionPerDay = new float[6];
        private float[] commissionPerSalesPerson = new float[4];
        int[] totalWeeklySales = new int[4];


        // 1) Gets the data from files and displays it as a table in the text box
        private void BtnLoadTable_Click(object sender, EventArgs e) => DisplayData();
        private void LoadData()
        {
            TxtDisplay.Text = "";
            string path = Application.StartupPath;
            const string TABLEVALUES_PATH = @"\table_values.txt";
            const string WEEKDAYS_PATH = @"\daysOfTheWeek.txt";
            const string SALESPEOPLE_PATH = @"\salesPeople.txt";
            const string COMMISSION_PATH = @"\commission_weighting.txt";

            // fills the tableValues Array
            using (StreamReader reader = new StreamReader(path + TABLEVALUES_PATH))
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        tableValues[i, j] = Convert.ToInt32(reader.ReadLine());
                    }
                }
                reader.Close();
            }

            // fills the weekDays Array
            using (StreamReader reader = new StreamReader(path + WEEKDAYS_PATH))
            {
                for (int i = 0; i < weekDays.Length; i++)
                {
                    weekDays[i] = reader.ReadLine();
                }
                reader.Close();
            }

            // fills the salesPeople Array
            using (StreamReader reader = new StreamReader(path + SALESPEOPLE_PATH))
            {
                for (int i = 0; i < salesPeople.Length; i++)
                {
                    salesPeople[i] = reader.ReadLine();
                }
                reader.Close();
            }

            // fills the commission array
            using (StreamReader reader = new StreamReader(path + COMMISSION_PATH))
            {
                for (int i = 0; i < commissionPerDay.Length; i++)
                {
                    commissionPerDay[i] = float.Parse(reader.ReadLine(), CultureInfo.InvariantCulture);
                }
                reader.Close();
            }
        }
        private void DisplayData()
        {
            // Display the table in TxtDisplay
            TxtDisplay.Text += "\t";

            // set the days of the week/ columns
            for (int i = 0; i < weekDays.Length; i++)
            {
                TxtDisplay.Text += weekDays[i].ToString() + "\t";
            }

            TxtDisplay.Text += Environment.NewLine;

            // set the rows (salesPeople), to go underneath the columns (weekdays), then drop down to the next row
            for (int i = 0; i < 4; i++)
            {
                TxtDisplay.Text += salesPeople[i] + "\t";

                for (int j = 0; j < 6; j++)
                {
                    TxtDisplay.Text += tableValues[i, j] + "\t";
                }

                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;
        }

        // 2) Changes franks sales on Thursday to 1500
        private void BtnChangeFranksSales_Click(object sender, EventArgs e)
        {
            tableValues[2, 3] = 1500;
            DisplayData();
        }

        // 3) Copy Lucy's sales for Thursday ({1, 2] = 900) into Karen's sales ([3, 0] = 1080) for Wednesday
        private void Button1_Click(object sender, EventArgs e)
        {
            tableValues[3, 0] = tableValues[1, 2];
            DisplayData();
        }

        // 4) Add 10 to all the sales.
        private void BtnAdd10ToAll_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += Environment.NewLine + "Added 10 to all table values" + Environment.NewLine;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    tableValues[i, j] += 10;
                }
            }

            DisplayData();
        }

        // 5) Display the names of all salespeople and dates for which sales were below 1000.
        private void Button3_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += Environment.NewLine + "All people who had sales lower than 1000:" + Environment.NewLine;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (tableValues[i, j] < 1000)
                    {
                        TxtDisplay.Text += salesPeople[i] + "\t" + weekDays[j] + Environment.NewLine;
                    }
                }
            }
        }

        // 6) Display the largest sales amount and the corresponding salesperson’s name and date.
        private void Button4_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += Environment.NewLine + "Largest sales amount and salesperson’s name and date." + Environment.NewLine;

            int largestSalesAmount = -1;
            string largestSalesName = "";
            string largestWeekName = "";

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (tableValues[i, j] > largestSalesAmount)
                    {
                        largestSalesAmount = tableValues[i, j];
                        largestSalesName = salesPeople[i];
                        largestWeekName = weekDays[j];
                    }
                }
            }

            TxtDisplay.Text += "Top sales person: " + largestSalesName + "\t" + "Top sales amount: " + largestSalesAmount + "\t" + "Achieved on " + largestWeekName + Environment.NewLine;
        }

        // 7) Determine the weekly sales totals for each salesperson. Make sure you store each total in a one dimensional array called WeeklySales.
        private void Button2_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += Environment.NewLine + "Sales Person Total Sales:" + Environment.NewLine;


            for (int i = 0; i < 4; i++)
            {
                TxtDisplay.Text += "Sales person: " + salesPeople[i] + "\t\tWeekly Total: R " + totalWeeklySales[i] + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;
        }
        private void GetWeeklyTotals()
        {
            int weeklyTotal = 0;

            TxtDisplay.Text += Environment.NewLine;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    weeklyTotal += tableValues[i, j];
                    totalWeeklySales[i] = weeklyTotal;
                }
            }
        }

        // 8) which sales person had the greatest weekly sales from the calculations.
        private void Button5_Click(object sender, EventArgs e)
        {
            int weeklyTotal = 0;
            string weeklyName = "";

            for (int i = 0; i < 4; i++)
            {
                if (totalWeeklySales[i] > weeklyTotal)
                {
                    weeklyTotal = totalWeeklySales[i];
                    weeklyName = salesPeople[i];
                }
            }

            TxtDisplay.Text += Environment.NewLine + "Highest Sales person: " + weeklyName + "\tHighest Weekly Total: R " + weeklyTotal + Environment.NewLine;
        }

        /* 9) All salespeople are paid by commission. The store has determined through many years of
         * study that some days it is easier to make sales than others, and thus, uses different
         * commission rates for different days.
         * Mon - 12%
         * Tues - 11.23%
         * Wed - 10.08%
         * Thurs - 8.5%
         * Fri - 8%
         * Sat - 7.64%
         * Determine the weeks pay for each salesperson*/
        private void button6_Click(object sender, EventArgs e) => GetSalesPersonSalary();
        private void GetSalesPersonSalary()
        {
            // Loop 
            for (int i = 0; i < 4; i++)
            {
                // 
                for (int j = 0; j < 6; j++)
                {
                    commissionPerSalesPerson[i] += tableValues[i, j] * commissionPerDay[i];
                }
            }

            TxtDisplay.Text += Environment.NewLine + "Sales Person Weekly Salary:" + Environment.NewLine;

            for (int i = 0; i < 4; i++)
            {
                TxtDisplay.Text += "Sales person: " + salesPeople[i] + "\t\tWeekly Pay: R " + Math.Round(commissionPerSalesPerson[i], 2) + Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;
        }

        // Clears the text box
        private void button7_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "";
        }
    }
}
