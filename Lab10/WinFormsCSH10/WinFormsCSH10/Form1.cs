using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Text;

namespace WinFormsCSH10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.DarkSeaGreen;
            this.Width = 565;
            this.Height = 570;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //�������� �� ������������ ��������� ������
            try
            {
                //���������� ��������������� ���������� �������� ������
                double x1 = Convert.ToDouble(textBox1.Text);
                double x2 = Convert.ToDouble(textBox2.Text);
                double x3 = Convert.ToDouble(textBox3.Text);
                double x4 = Convert.ToDouble(textBox4.Text);
                double x5 = Convert.ToDouble(textBox5.Text);

                double results = Math.Round((x1 - x2 + Math.Abs(Math.Cos(x3) + Math.Sqrt(Math.Abs(x4)))) /
                    (Math.Pow(x1, x5) - Math.Log(x2)), 3);
                // ����� ����������
                // ��������� ������ ������ �� �����
                if (radioButton2.Checked)
                {
                    // �������� �� �����
                    if (checkBox1.Checked)
                    {
                        // ����� �� ��������
                        listBox1.Items.Add("arg01 = " + textBox1.Text +
                            "  | arg02 = " + textBox2.Text +
                            "  | arg03 = " + textBox3.Text +
                            "  | arg04 = " + textBox4.Text +
                            "  | arg05 = " + textBox5.Text +
                            "  |  ��������� = " + results.ToString());
                    }
                    if (checkBox2.Checked)
                    {
                        // ����� � ����
                        string str = "arg01 = " + textBox1.Text +
                            "  | arg02 = " + textBox2.Text +
                            "  | arg03 = " + textBox3.Text +
                            "  | arg04 = " + textBox4.Text +
                            "  | arg05 = " + textBox5.Text +
                            "  |  ��������� = " + results.ToString() + Environment.NewLine;

                        StreamWriter SW = new StreamWriter(textBox7.Text, true); // ��������� ���� �� ��������
                        SW.Write(str); //���������� ������
                        SW.Close(); //��������� ����
                    }
                }
            }
            catch (FormatException)
            {
                listBox1.Items.Add("������� ������� ������!");
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}