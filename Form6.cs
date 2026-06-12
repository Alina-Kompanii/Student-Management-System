using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приложение_для_зам_директора
{
    public partial class Form6 : Form
    {
        public static List<string> academicLeaveStudents = new List<string>();

        public Form6()
        {
            InitializeComponent();
            UpdateAcademicLeaveList();

            buttonExpel.Click += buttonExpel_Click;
            buttonReturn.Click += buttonReturn_Click;
        }

        public void UpdateAcademicLeaveList()
        {
            listBoxAcademicLeave.Items.Clear();
            foreach (string student in academicLeaveStudents)
            {
                listBoxAcademicLeave.Items.Add(student);
            }
        }
        private void buttonExpel_Click(object sender, EventArgs e)
        {
            if (listBoxAcademicLeave.SelectedItem == null)
            {
                MessageBox.Show("Выберите студента для отчисления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string student = listBoxAcademicLeave.SelectedItem.ToString();
            academicLeaveStudents.Remove(student);
            Form5.expelledStudents.Add(student);
            UpdateAcademicLeaveList();

            MessageBox.Show($"Студент {student}\nОТЧИСЛЕН ИЗ АКАДЕМИЧЕСКОГО ОТПУСКА!",
                "Отчисление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (listBoxAcademicLeave.SelectedItem == null)
            {
                MessageBox.Show("Выберите студента для возврата!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string student = listBoxAcademicLeave.SelectedItem.ToString();

            // Удаляем студента из списка академ отпуска
            academicLeaveStudents.Remove(student);

            // Обновляем список
            UpdateAcademicLeaveList();

            MessageBox.Show($"Студент {student}\nВОЗВРАЩЕН ИЗ АКАДЕМИЧЕСКОГО ОТПУСКА!\n\n" +
                "Чтобы восстановить студента в группу, добавьте его вручную в очную или заочную группу.",
                "Возврат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            UpdateAcademicLeaveList();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (listBoxAcademicLeave.Items.Count == 0)
            {
                MessageBox.Show("Нет студентов в академическом отпуске для печати!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDocument printDocument = new PrintDocument();

            printDocument.DefaultPageSettings.Landscape = false;

            string title = "СПИСОК СТУДЕНТОВ В АКАДЕМИЧЕСКОМ ОТПУСКЕ";

            StringBuilder textToPrint = new StringBuilder();
            textToPrint.AppendLine($"\t\t{title}");
            textToPrint.AppendLine(new string('=', 65));
            textToPrint.AppendLine();

            int counter = 1;
            foreach (var student in listBoxAcademicLeave.Items)
            {
                textToPrint.AppendLine($"{counter,3}. {student}");
                counter++;
            }

            textToPrint.AppendLine();
            textToPrint.AppendLine(new string('=', 65));
            textToPrint.AppendLine($"Всего студентов в академ. отпуске: {listBoxAcademicLeave.Items.Count}");
            textToPrint.AppendLine($"Дата формирования списка: {DateTime.Now:dd.MM.yyyy HH:mm}");

            string text = textToPrint.ToString();

            printDocument.PrintPage += (s, ev) =>
            {
                Font printFont = new Font("Times New Roman", 12);
                float yPos = ev.MarginBounds.Top;
                int count = 0;
                float leftMargin = ev.MarginBounds.Left;

                string[] lines = text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                while (count < lines.Length && yPos + printFont.GetHeight(ev.Graphics) < ev.MarginBounds.Bottom)
                {
                    ev.Graphics.DrawString(lines[count], printFont, Brushes.Black, leftMargin, yPos);
                    yPos += printFont.GetHeight(ev.Graphics);
                    count++;
                }

                if (count < lines.Length)
                {
                    ev.HasMorePages = true;
                }
                else
                {
                    ev.HasMorePages = false;
                }
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument.Print();
                    MessageBox.Show("Список студентов в академическом отпуске отправлен на печать!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка печати: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Введите фамилию или имя для поиска!", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (listBoxAcademicLeave.Items.Count == 0)
            {
                MessageBox.Show("Список студентов в академическом отпуске пуст!", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int foundIndex = -1;
            for (int i = 0; i < listBoxAcademicLeave.Items.Count; i++)
            {
                string student = listBoxAcademicLeave.Items[i].ToString();
                if (student.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    foundIndex = i;
                    break;
                }
            }

            if (foundIndex != -1)
            {
                listBoxAcademicLeave.SelectedIndex = foundIndex;
                listBoxAcademicLeave.TopIndex = foundIndex;
                labelSearchInfo.Text = $"Найден: {listBoxAcademicLeave.Items[foundIndex]}";
                labelSearchInfo.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelSearchInfo.Text = $"Студент с текстом \"{searchText}\" не найден в академе";
                labelSearchInfo.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show($"Студент, содержащий \"{searchText}\", не найден в списке академического отпуска!",
                    "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                labelSearchInfo.Text = "Введите фамилию или имя для поиска";
                labelSearchInfo.ForeColor = System.Drawing.Color.Gray;
                listBoxAcademicLeave.ClearSelected();
            }
        }
    }
}
    

