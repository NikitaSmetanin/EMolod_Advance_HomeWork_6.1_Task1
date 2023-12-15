using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EMolod_Advance_HomeWork_6._1
{
    public partial class Form1 : Form
    {
        int hiddenNumber;
        Random random = new Random(DateTime.Now.Millisecond);

        public Form1()
        {
            hiddenNumber = random.Next(1, 11);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(drinkList.Text, "Твій вибір");
        }

        private void choiceNumberButton_Click(object sender, EventArgs e)
        {
            int userNumber = 0;

            try
            {
                userNumber = Convert.ToInt32(numberTextBox.Text);
                if (userNumber < 1 || userNumber > 10) { throw new InvalidCastException(); }
            } catch (Exception ex) when (ex is FormatException || ex is InvalidCastException)
            {
                MessageBox.Show("Треба ввести число від 1 до 10", "Помилка");
                numberTextBox.Text = "";
                return;
            }                      

            if (userNumber == hiddenNumber) {
                this.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                MessageBox.Show("Вітаю! Ви вгадали число! Спробуйте ще раз.", "Перемога");
                hiddenNumber = random.Next(1, 11);
                numberTextBox.Text = "";
            }
            else if (userNumber < hiddenNumber)
            {
                MessageBox.Show("Загадане число більше за введене. Спробуйте ще раз.", "Повідомлення");                
            } else {
                MessageBox.Show("Загадане число менше за введене. Спробуйте ще раз.", "Повідомлення");               
            }
        }
    }
}
