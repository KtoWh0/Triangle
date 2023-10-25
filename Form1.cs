using System.Drawing;

namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double side1 = Convert.ToDouble(textBox1.Text);
                double side2 = Convert.ToDouble(textBox2.Text);
                double side3 = Convert.ToDouble(textBox3.Text);
                if (side1 + side2 >= side3 && side2 + side3 >= side1 && side1 + side3 >= side2)
                {
                    if (side1 == side2 && side2 == side3 && side1 == side3)
                    {
                        MessageBox.Show("����������� ��������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        MessageBox.Show("����������� ��������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("����������� ��������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("������������ �� ����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("������� �������� �������� ������ ������������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}