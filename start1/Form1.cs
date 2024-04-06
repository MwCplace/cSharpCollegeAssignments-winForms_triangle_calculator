using System.Runtime.InteropServices;

namespace start1
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private double sideA = 0;
        private double sideB = 0;
        private double sideC = 0;
        double P, S;

        public Form1()
        {
            InitializeComponent();
            //label7.Text = "P =";
            //label8.Text = "S =";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(text: "Выбрана формула для прямоугольного треугольника");
            //label7.Text = "P = " + Int32.Parse(textBox1.Text) * 3;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(text: "Выбрана формула для равностороннего треугольника");
            //label8.Text = "S = " + Int32.Parse(textBox1.Text) * 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1(object sender, EventArgs e)
        {

            // проверка строк на пустоту и тип
            if (textBox1 == null || textBox2 == null || textBox3 == null) // если строка пуста
            {
                MessageBox.Show("Вы забыли задать число");
            }
            else if (sideA is double || sideB is double) // если строка число, как и надо
            {
                // выполнение кода здесь
                // вычисления по формуле прямоугольного треугольника
                if (checkBox1.Checked && checkBox2.Checked == false)
                {
                    P = (sideA + sideB + sideC);
                    S = 0.5 * sideA * sideB;

                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                }
                // вычисления по формуле равностороннего треугольника
                else if (checkBox2.Checked && checkBox1.Checked == false)
                {
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;

                    P = (sideA * 3);
                    S = (Math.Sqrt(3) / 4) * sideA;
                }
                // если выбрано несколько формул
                else if (checkBox1.Checked && checkBox2.Checked)
                {
                    MessageBox.Show("Можно выбрать только один пункт");
                }
                // вычисления по формуле обычного треугольника
                else
                {
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;

                    P = (sideA + sideB + sideC);
                    S = Math.Sqrt((P / 2) * ((P / 2 - sideA) * (P / 2 - sideB) * (P / 2 - sideC)));
                }
            }
            else // если строка не число
            {
                MessageBox.Show(text: $"Задайте число! {sideA}");
            }

            // если площадь треугольника не высчитывается
            if (S is double.NaN)
            {
                //MessageBox.Show("Такого треугольника не существует!");
                label7.Text = "Такого треугольника не существует!";
                label8.Text = " ";
            }
            else
            {
                // вывод результата
                label7.Text = "P = " + P;
                label8.Text = "S = " + S;
            }
        }

        // конвертация строк в числа
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sideA = double.Parse(textBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            sideB = double.Parse(textBox3.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sideC = double.Parse(textBox2.Text);
        }
    }
}