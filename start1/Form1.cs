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
            //MessageBox.Show(text: "������� ������� ��� �������������� ������������");
            //label7.Text = "P = " + Int32.Parse(textBox1.Text) * 3;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(text: "������� ������� ��� ��������������� ������������");
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

            // �������� ����� �� ������� � ���
            if (textBox1 == null || textBox2 == null || textBox3 == null) // ���� ������ �����
            {
                MessageBox.Show("�� ������ ������ �����");
            }
            else if (sideA is double || sideB is double) // ���� ������ �����, ��� � ����
            {
                // ���������� ���� �����
                // ���������� �� ������� �������������� ������������
                if (checkBox1.Checked && checkBox2.Checked == false)
                {
                    P = (sideA + sideB + sideC);
                    S = 0.5 * sideA * sideB;

                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                }
                // ���������� �� ������� ��������������� ������������
                else if (checkBox2.Checked && checkBox1.Checked == false)
                {
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;

                    P = (sideA * 3);
                    S = (Math.Sqrt(3) / 4) * sideA;
                }
                // ���� ������� ��������� ������
                else if (checkBox1.Checked && checkBox2.Checked)
                {
                    MessageBox.Show("����� ������� ������ ���� �����");
                }
                // ���������� �� ������� �������� ������������
                else
                {
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;

                    P = (sideA + sideB + sideC);
                    S = Math.Sqrt((P / 2) * ((P / 2 - sideA) * (P / 2 - sideB) * (P / 2 - sideC)));
                }
            }
            else // ���� ������ �� �����
            {
                MessageBox.Show(text: $"������� �����! {sideA}");
            }

            // ���� ������� ������������ �� �������������
            if (S is double.NaN)
            {
                //MessageBox.Show("������ ������������ �� ����������!");
                label7.Text = "������ ������������ �� ����������!";
                label8.Text = " ";
            }
            else
            {
                // ����� ����������
                label7.Text = "P = " + P;
                label8.Text = "S = " + S;
            }
        }

        // ����������� ����� � �����
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