using System.Security.Policy;

namespace Andriylab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Завдання 1
            label1.Text = "x = ";
            label2.Text = "y = ";
            label3.Text = "Результат:";
            btnOK.Text = "Порахувати";
            lblResult.Text = "";

            //Завдання 2
            label4.Text = "A = ";
            label5.Text = "B = ";
            label6.Text = "C = ";
            label7.Text = "Кути трикутника в радіанах:";
            label11.Text = "Кути трикутника в градусах:";
            btnOK2.Text = "Порахувати";

            //Завдання 3
            label8.Text = "N = ";
            label9.Text = "Результат:";
            btnOK3.Text = "Порахувати";
            lblResult3.Text = "";

            //Завдання 4
            label10.Text = "Введіть вартість книги:";
            label12.Text = "Введіть суму грошей, внесену покупцем:";
            label13.Text = "Результат:";
            btnOK4.Text = "Порахувати";
            lblResult4.Text = "";

            //Завдання 5
            label14.Text = "M = ";
            label15.Text = "N = ";
            label16.Text = "Результат:";
            btnOK5.Text = "Порахувати";
            lblResult5.Text = "";

            //Завдання 6
            label17.Text = "n = ";
            label18.Text = "k = ";
            label19.Text = "Результат:";
            btnOK6.Text = "Порахувати";
            lblResult6.Text = "";

            //Завдання 7
            label20.Text = "Введіть текст: ";
            label21.Text = "Найкоротше слово має довжину: ";
            label22.Text = "Найдовше слово має довжину:";
            btnOK7.Text = "Порахувати";
            lblBig.Text = "";
            lblMini.Text = "";

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtX.Text) ||
                string.IsNullOrWhiteSpace(txtY.Text))
            {
                MessageBox.Show("Будьласка, заповніть всі текстові поля");
                return;
            }

            double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);

            double result = (3 - Math.Pow(Math.E, y - 1)) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x)));

            lblResult.Text = result.ToString();
        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtA.Text) ||
                string.IsNullOrWhiteSpace(txtB.Text) ||
                string.IsNullOrWhiteSpace(txtC.Text))
            {
                MessageBox.Show("Будьласка, заповніть всі текстові поля");
                return;
            }

            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double c = Convert.ToDouble(txtC.Text);

            double angleA = Math.Acos((b * b + c * c - a * a) / (2 * b * c));
            double angleB = Math.Acos((a * a + c * c - b * b) / (2 * a * c));
            double angleC = Math.Acos((a * a + b * b - c * c) / (2 * a * b));

            double angleAInDegrees = angleA * (180.0 / Math.PI);
            double angleBInDegrees = angleB * (180.0 / Math.PI);
            double angleCInDegrees = angleC * (180.0 / Math.PI);

            lblAngleA.Text = angleA.ToString();
            lblAngleB.Text = angleB.ToString();
            lblAngleC.Text = angleC.ToString();

            lblkytA.Text = angleAInDegrees.ToString();
            lblkytB.Text = angleBInDegrees.ToString();
            lblkytC.Text = angleCInDegrees.ToString();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void btnOK3_Click(object sender, EventArgs e)
        {
            double N = Convert.ToDouble(txtN.Text);

            bool isTwoDigit = (N >= 10 && N <= 99);
            bool isEven = (N % 2 == 0);
            bool isEvenTwoDigit = isTwoDigit && isEven;

            lblResult3.Text = isEvenTwoDigit.ToString();
        }

        private void btnOK4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtSum.Text))
            {
                MessageBox.Show("Будьласка, заповніть всі текстові поля");
                return;
            }
            double Price = Convert.ToDouble(txtPrice.Text);
            double Sum = Convert.ToDouble(txtSum.Text);

            if (Sum == Price)
            {
                lblResult4.Text = ("Дякую!");
            }
            else if (Sum > Price)
            {
                double change = Sum - Price;
                lblResult4.Text = ("Візьміть решту: " + change);
            }
            else
            {
                double remaining = Price - Sum;
                lblResult4.Text = ("Невистачає: " + remaining);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void btnOK5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtM.Text) ||
                string.IsNullOrWhiteSpace(txtNN.Text))
            {
                MessageBox.Show("Будьласка, заповніть всі текстові поля");
                return;
            }
            int M = Convert.ToInt32(txtM.Text);
            int N = Convert.ToInt32(txtNN.Text);

            string result = PrintPerfectNumbers(N);
            lblResult5.Text = result;
        }

        private bool IsPerfectNumber(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum == num;
        }

        private string PrintPerfectNumbers(int N)
        {
            string result = "";
            for (int i = 2; i < N; i++)
            {
                if (IsPerfectNumber(i))
                {
                    result += i.ToString() + "\n";
                }
            }
            return result;
        }

        private void txtM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtNN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void btnOK6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMas.Text) ||
                string.IsNullOrWhiteSpace(txtK.Text))
            {
                MessageBox.Show("Будьласка, заповніть всі текстові поля");
                return;
            }
            int[] array = Array.ConvertAll(txtMas.Text.Split(','), int.Parse);
            int k = int.Parse(txtK.Text);
            int[] filteredArray = FilterByLastDigit(array, k);
            lblResult6.Text = string.Join(", ", filteredArray);
        }

        private int[] FilterByLastDigit(int[] array, int k)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num % 10 == k)
                {
                    count++;
                }
            }
            int[] resultArray = new int[count];
            int index = 0;

            foreach (int num in array)
            {
                if (num % 10 == k)
                {
                    resultArray[index] = num;
                    index++;
                }
            }
            return resultArray;
        }

        private void txtMas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == ',' || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == ',' || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void btnOK7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTEXT.Text))
            {
                MessageBox.Show("Будьласка, напишіть текст");
                return;
            }
            string text = txtTEXT.Text;
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int shortestLength = int.MaxValue;
            int longestLength = 0;
            foreach (string word in words)
            {
                if (word.Length < shortestLength)
                {
                    shortestLength = word.Length;
                }
                if (word.Length > longestLength)
                {
                    longestLength = word.Length;
                }
            }
            lblBig.Text = longestLength.ToString();
            lblMini.Text = shortestLength.ToString();
        }
    }
}

