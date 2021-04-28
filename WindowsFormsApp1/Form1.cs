using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox1.Text); //Внес на коефициентот а
            double b = Double.Parse(textBox2.Text); // Внес на коефициентот б
            double c = Double.Parse(textBox3.Text); // Внес на коефициентот ц
            double x1; // првото решение
            double x2; // второто решение
            double D; // дискриминантата

            if (a >= -999 && a <= 999 && b >= -999 && b <= 999 && c >= -999 && c <= 999) // Коефицентите да се помеѓу (-999 и 999)
            {

                D = b * b - 4 * a * c; // ја пресметува дискриминантата
                if (D > 0) //проверува дали дискриминантата е поголема од 0
                {
                    if (a != 0) // проверува дали а е различна од нула
                    {



                        D = Math.Sqrt(D); //пресметка на квадратен корен на дискриминантата
                        x1 = (-b + D) / (2 * a); //пресметка на x1
                        x2 = (-b - D) / (2 * a); //пресметка на x2
                        textBox4.Text = x1.ToString(); //прикажување на x1 во полето
                        textBox5.Text = x2.ToString(); // прикажување на x2 vo полето
                        textBox6.Visible = false; // полето станува невидливо
                        textBox7.Visible = false; // полето станува невидливо
                        label8.Visible = false; // ознаката станува невидлива
                        label9.Visible = false; // ознаката станува невидлива
                    }
                    else
                    {

                        MessageBox.Show("Коефициентот а треба да е различен од 0"); // се покајувува порака ако коефициентот е еднаков на нула

                    }

                }
                if (D == 0) // проверува дали дискриминантата е еднаква на нула
                {
                    if (a != 0)
                    {
                        D = Math.Sqrt(D);
                        x1 = (-b + D) / (2 * a);
                        x2 = (-b - D) / (2 * a);
                        textBox4.Text = x1.ToString();
                        textBox5.Text = x2.ToString();
                        textBox6.Visible = false;
                        textBox7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;


                    }
                    else
                    {
                        MessageBox.Show("Коефициентот а треба да е различен од 0");
                    }
                }
                if (D < 0) // проверува дали дискриминантата е помала од нула
                {
                    if (a != 0)
                    {

                        double Realen = (-b / (2 * a)); // го пресметува реалниот дел
                        double Img = ((Math.Sqrt((D * (-1.00))) / (2 * a))); // го пресметува имагинарниот
                        string Real = Convert.ToString(Realen); // го конвертира во стринг
                        string Imaginaren = Convert.ToString(Img); // го конвертура во стринг
                        textBox6.Text = "" + Real + "+" + Imaginaren; // го прикажува реалниот и имагинарниот дел во полето
                        textBox7.Text = "" + Real + "-" + Imaginaren;




                    }
                    else
                    {
                        MessageBox.Show("Коефициентот а треба да е различен од 0");
                    }
                }

            }

            else
            {
                MessageBox.Show("Внесете целобројни коефициенти меѓу (-999 и 999)"); // се појавува порака ако коефциентите се помали од -999 или поголеми од 999
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear(); //се бришат внесените вредности
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Visible = true; // станува видливо 
            textBox7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
        }
    }
}
