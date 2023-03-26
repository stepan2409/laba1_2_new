using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace laba1_2
{
    public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
  
    private void button2_Click(object sender, EventArgs e)
    {
            double a, b;
            a = Math.Ceiling((double)this.numericUpDown1.Value);
            b = Math.Floor((double)this.numericUpDown2.Value);
            string result = "";
            for (int i = (int)a; i <=b; i++)
            {
                if (i % 3 == 0)
                {
                    result += i.ToString() + " ";
                }
            }
            this.label6.Text = result;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.Close();
    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.comboBox1.SelectedIndex)
            {
                case 0: this.task3ResultLabel.Text = "Понедельник:\nКеримов Руслан: 11:00 - 14:00 \nТаирова Назифе: 14:30 - 19:00"; break;
                case 1: this.task3ResultLabel.Text = "Вторник:\nКозаева Вильяна: 07:30 - 12:00 \nОмаров Саламбег: 10:45 - 16:00"; break;
                case 2: this.task3ResultLabel.Text = "Среда:\nКеримов Руслан: 10:00 - 15:00 \nОмаров Саламбег: 15:15 - 18:00 "; break;
                case 3: this.task3ResultLabel.Text = "Четверг:\nРуденко Людмила: 08:30 - 12:00 \nКозаева Вильяна: 10:30 - 17:00"; break;
                case 4: this.task3ResultLabel.Text = "Пятница:\nКеримов Руслан: 06:00 - 11:00 \nОмаров Саламбег: 11:00 - 14:00 \nРуденко Людмила: 14:30 - 19:00"; break;
                case 5: this.task3ResultLabel.Text = "Суббота:\nТаирова Назифе: 12:00 - 16:00"; break;
                case 6: this.task3ResultLabel.Text = "Воскресенье:\nВЫХОДНОЙ"; break;
                default: break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown8.Value;
            string Result = "";
            for (int i = n+1; i>0; i--)
            {
                for (int j = 0; j<i; j++)
                {
                    Result += j.ToString() + "   ";
                }
                Result += "\r\n";
            }
            textBox4.Text = Result;
        }

     

       

        private void button5_Click(object sender, EventArgs e)
        {
            double X = (double)numericUpDown6.Value;
            double Y = (double)numericUpDown7.Value;
            if (X*X + Y*Y - 225 < 0 && Y - Math.Abs(X) > 0)
            {
                label14.Text = "Точка внутри фигуры";
            } else if (X*X + Y*Y - 225 == 0 && Y - Math.Abs(X) >= 0 || X * X + Y * Y - 225 <= 0 && Y - Math.Abs(X) == 0)
            {
                label14.Text = "Точка на границе фигуры";
            } else
            {
                label14.Text = "Точка вне фигуры";
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double x))
            {
                if (x > 1)
                {
                    double y = Math.Log(x - 1);
                    label16.Text = y.ToString();
                }
                else
                {
                    label16.Text = ("Введите число больше 1");
                }
            }
            else
            {

                label16.Text = ("Вы ввели не число");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = (double)numericUpDown3.Value;
            double b = (double)numericUpDown4.Value;
            double h = (double)numericUpDown5.Value;

            if (a >= b)
            {
                var mab = MessageBox.Show("Ошибка ввода: A должно быть МЕНЬШЕ чем B", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = "  #|         x|      f(x)\r\n" + "".PadRight(25, '-') + "\r\n";
            double x = a;
            for (int lineNume = 1; x <= b; x += h, lineNume++)
            {
                double y;
                if (x * x - 5 * x < 0)
                {
                    y = a + b;
                }
                else if (x * x - 5 * x >= 0 && x * x - 5 * x < 10)
                {
                    y = a - b;
                }
                else
                {
                    y = a * b;
                }
                result += lineNume.ToString().PadLeft(3, ' ') + "|";
                result += String.Format("{0:0.###}", x).PadLeft(10, ' ') + "|";
                result += String.Format("{0:0.###}", y).PadLeft(10, ' ') + "\r\n";
                result += "".PadRight(25, '-') + "\r\n";
            }
            textBox1.Text = result;
        }

        private void task3ResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
