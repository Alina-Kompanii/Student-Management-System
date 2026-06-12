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
    public partial class Form5 : Form
    {
        public static List<string> expelledStudents = new List<string>();

        public Form5()
        {
            InitializeComponent();
            UpdateExpelledList();

            buttonToArchive.Click += buttonToArchive_Click;
        }

        public void UpdateExpelledList()
        {
            listBoxExpelled.Items.Clear();
            foreach (string student in expelledStudents)
            {
                listBoxExpelled.Items.Add(student);
            }
        }

        private void buttonToArchive_Click(object sender, EventArgs e)
        {
            if (listBoxExpelled.SelectedItem == null)
            {
                MessageBox.Show("Выберите студента для перемещения в архив!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string student = listBoxExpelled.SelectedItem.ToString();

            // Удаляем студента из списка отчисленных
            expelledStudents.Remove(student);

            // Обновляем список
            UpdateExpelledList();

            MessageBox.Show($"Студент {student}\nПЕРЕНЕСЕН В АРХИВ!",
                "Перемещение в архив", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            UpdateExpelledList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (listBoxExpelled.Items.Count == 0)
            {
                MessageBox.Show("Нет отчисленных студентов для печати!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDocument printDocument = new PrintDocument();

            printDocument.DefaultPageSettings.Landscape = false;

            string title = "СПИСОК ОТЧИСЛЕННЫХ СТУДЕНТОВ";

            StringBuilder textToPrint = new StringBuilder();
            textToPrint.AppendLine($"\t\t{title}");
            textToPrint.AppendLine(new string('=', 60));
            textToPrint.AppendLine();

            int counter = 1;
            foreach (var student in listBoxExpelled.Items)
            {
                textToPrint.AppendLine($"{counter,3}. {student}");
                counter++;
            }

            textToPrint.AppendLine();
            textToPrint.AppendLine(new string('=', 60));
            textToPrint.AppendLine($"Всего отчисленных: {listBoxExpelled.Items.Count}");
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
                    MessageBox.Show("Список отчисленных отправлен на печать!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (listBoxExpelled.Items.Count == 0)
            {
                MessageBox.Show("Список отчисленных пуст!", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int foundIndex = -1;
            for (int i = 0; i < listBoxExpelled.Items.Count; i++)
            {
                string student = listBoxExpelled.Items[i].ToString();
                if (student.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    foundIndex = i;
                    break;
                }
            }

            if (foundIndex != -1)
            {
                listBoxExpelled.SelectedIndex = foundIndex;
                listBoxExpelled.TopIndex = foundIndex;
                labelSearchInfo.Text = $"Найден: {listBoxExpelled.Items[foundIndex]}";
                labelSearchInfo.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelSearchInfo.Text = $"Студент с текстом \"{searchText}\" не найден";
                labelSearchInfo.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show($"Студент, содержащий \"{searchText}\", не найден в списке отчисленных!",
                    "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                labelSearchInfo.Text = "Введите фамилию или имя для поиска";
                labelSearchInfo.ForeColor = System.Drawing.Color.Gray;
                listBoxExpelled.ClearSelected();
            }
        }
    }
}
