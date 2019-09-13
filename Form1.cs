using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        int sum = 0; // Håller reda på summa för uträknade tal
        int res = 0; // Håller reda på skillnad för uträknade tal
        string newNr = ""; //innehåller talet som användaren skriver just nu

        bool sumHasBeenPressed = false;

        private void AddDigit(string nr)
        {
            if (sumHasBeenPressed)
            {
                textBox1.Text = "";
                newNr = "";
                sum = 0;
                res = 0;
                sumHasBeenPressed = false; //Programmet upptäcker om man har tryckt på likamed tecken
            }

            textBox1.AppendText(nr); //Lägg till numret i textboxen
            newNr += nr; //Lägg till numret i talet som användaren skriver nu
        }

        private void Summarize()
        {
            /*sum = sum + Convert.ToInt32(newNr); //Räkna ut summan av alla tal
            newNr = ""; // Återställ så användaren kan skriva ett nytt tal
            textBox1.Text = Convert.ToString(sum); // Sätt textboxen rätt*/

            if (newNr != "")
            {
                sum = sum + Convert.ToInt32(newNr); // Räkna ut summa av alla tal
                newNr = ""; // Återställ så användaren kan skriva ett nytt tal
                textBox1.Text = Convert.ToString(sum); // Sätt textboxen rätt
            }
        }

        /*private void Minus()
        {
            /*res = res - Convert.ToInt32(newNr); // Räkna ut summa av alla tal
            newNr = ""; // Återställ så användaren kan skriva ett nytt tal
            textBox1.Text = Convert.ToString(res); // Sätt textboxen rätt

           if (newNr != "")
            {
                res = res - Convert.ToInt32(newNr); // Räkna ut summa av alla tal
                newNr = ""; // Återställ så användaren kan skriva ett nytt tal
                textBox1.Text = Convert.ToString(res); // Sätt textboxen rätt
            }
        }*/

        public Form1()
        {
            InitializeComponent();

            MessageBox.Show("Välkomen till kalkylatorn!");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddDigit("1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AddDigit("2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AddDigit("3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AddDigit("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            AddDigit("5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            AddDigit("6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            AddDigit("7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            AddDigit("8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            AddDigit("9");
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            AddDigit("0");
        }

        private void Buttonplus_Click(object sender, EventArgs e)
        {
            Summarize();
            textBox1.Text = sum + "+"; // Sätt textboxen rätt
        }

        private void Button_equals_Click(object sender, EventArgs e)
        {
            Summarize();
        }

        private void Button_C_Click(object sender, EventArgs e)
        {
            sum = 0;
            res = 0;
            newNr = "";
            textBox1.Text = "";
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            //Minus();
            if (newNr != "")
            {
                res = res - Convert.ToInt32(newNr); // Räkna ut summa av alla tal
                newNr = ""; // Återställ så användaren kan skriva ett nytt tal
                textBox1.Text = Convert.ToString(res); // Sätt textboxen rätt
            }
            //textBox1.Text = res + "-"; // Sätt textboxen rätt
        }
    }
}
