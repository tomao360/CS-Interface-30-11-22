namespace Winforms_TheInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum BirthDay
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            string str = nameTextBox.Text + ", " + dayTextBox.Text + ", " + ageTextBox.Text + "\n";
            try
            {
                File.AppendAllText("Ex01.txt", str);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            nameTextBox.Text = "Enter Name";
            dayTextBox.Text = "Enter Day";
            ageTextBox.Text = "Enter Age";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Ex01.txt");
            try
            {
                while (sr.ReadLine() is string readLine)
                {
                    string[] lineArr = readLine.Split(',');

                    BirthDay birthDay = (BirthDay)Enum.Parse(typeof(BirthDay), lineArr[1]);
                    string dayFromFile = birthDay.ToString();

                    loadTextBox.Text += lineArr[0] + ", " + dayFromFile + ", " + lineArr[2] + ". ";
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            sr.Close();
        }

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Enter Name")
            {
                nameTextBox.Text = "";
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                nameTextBox.Text = "Enter Name";
            }
        }

        private void dayTextBox_Click(object sender, EventArgs e)
        {
            if (dayTextBox.Text == "Enter Day")
            {
                dayTextBox.Text = "";
            }
        }

        private void dayTextBox_Leave(object sender, EventArgs e)
        {
            if (dayTextBox.Text == "")
            {
                dayTextBox.Text = "Enter Day";
            }
        }

        private void ageTextBox_Click(object sender, EventArgs e)
        {
           if (ageTextBox.Text == "Enter Age")
            {
                ageTextBox.Text = "";
            }
        }

        private void ageTextBox_Leave(object sender, EventArgs e)
        {
            if (ageTextBox.Text == "")
            {
                ageTextBox.Text = "Enter Age";
            }
        }
    }
}