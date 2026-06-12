using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приложение_для_зам_директора
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "У вас нет полномочий для доступа к архиву!",
                "Доступ запрещен",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
        }
        public static void SetLightTheme(Form form)
        {
            // Цвета для светлой темы
            form.BackColor = System.Drawing.Color.White;
            form.ForeColor = System.Drawing.Color.Black;

            // Проходим по всем элементам на форме
            foreach (Control control in form.Controls)
            {
                SetControlLightTheme(control);
            }
        }

        private static void SetControlLightTheme(Control control)
        {
            // Устанавливаем цвета для элемента
            control.BackColor = System.Drawing.Color.White;
            control.ForeColor = System.Drawing.Color.Black;

            // Для Panel, GroupBox и других контейнеров - заходим внутрь
            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    SetControlLightTheme(child);
                }
            }

            // Отдельная настройка для конкретных типов элементов
            if (control is Button btn)
            {
                btn.BackColor = System.Drawing.Color.LightGray;
                btn.FlatStyle = FlatStyle.Standard;
            }
            else if (control is TextBox txt)
            {
                txt.BackColor = System.Drawing.Color.White;
            }
            else if (control is ListBox list)
            {
                list.BackColor = System.Drawing.Color.White;
            }
            else if (control is ComboBox combo)
            {
                combo.BackColor = System.Drawing.Color.White;
            }
        }

        private void buttonLightTheme_Click(object sender, EventArgs e)
        {
            SetLightTheme(this); // применяем к текущей форме
            MessageBox.Show("Светлая тема применена!", "Тема", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

