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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            comboBoxExtramuralGroups.Items.AddRange(new string[] { "635з", "922з", "1411з", "1227з" });
            comboBoxExtramuralGroups.SelectedIndex = 0;
            comboBoxExtramuralGroups.SelectedIndexChanged += (s, e) => UpdateList();

            buttonExpel.Click += buttonExpel_Click;
            buttonAcademicLeave.Click += buttonAcademicLeave_Click;

            UpdateList();
        }

        private void UpdateList()
        {
            listBoxExtramuralStudents.Items.Clear();
            string group = comboBoxExtramuralGroups.SelectedItem.ToString();

            if (Form3.extramuralStudents.ContainsKey(group))
            {
                foreach (string student in Form3.extramuralStudents[group])
                {
                    listBoxExtramuralStudents.Items.Add(student);
                }
            }
        }

        private void buttonExpel_Click(object sender, EventArgs e)
        {
            if (listBoxExtramuralStudents.SelectedItem == null)
            {
                MessageBox.Show("Выберите студента для отчисления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string student = listBoxExtramuralStudents.SelectedItem.ToString();
            string currentGroup = comboBoxExtramuralGroups.SelectedItem.ToString();

            Form3.extramuralStudents[currentGroup].Remove(student);
            Form5.expelledStudents.Add(student);

            UpdateList();

            MessageBox.Show($"Студент {student}\nОТЧИСЛЕН!",
                "Отчисление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonAcademicLeave_Click(object sender, EventArgs e)
        {
            if (listBoxExtramuralStudents.SelectedItem == null)
            {
                MessageBox.Show("Выберите студента для отправки в академический отпуск!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string student = listBoxExtramuralStudents.SelectedItem.ToString();
            string currentGroup = comboBoxExtramuralGroups.SelectedItem.ToString();

            Form3.extramuralStudents[currentGroup].Remove(student);

            Form6.academicLeaveStudents.Add(student);

            UpdateList();

            MessageBox.Show($"Студент {student}\nОТПРАВЛЕН В АКАДЕМИЧЕСКИЙ ОТПУСК!",
                "Академический отпуск", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            UpdateList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (listBoxExtramuralStudents.Items.Count == 0)
            {
                MessageBox.Show("Нет студентов для печати!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDocument printDocument = new PrintDocument();

            printDocument.DefaultPageSettings.Landscape = false;

            string title = "СПИСОК СТУДЕНТОВ ЗАОЧНОГО ОТДЕЛЕНИЯ";
            string groupName = comboBoxExtramuralGroups.SelectedItem?.ToString() ?? "Группа не выбрана";

            StringBuilder textToPrint = new StringBuilder();
            textToPrint.AppendLine($"\t\t{title}");
            textToPrint.AppendLine($"\t\tГруппа: {groupName}");
            textToPrint.AppendLine(new string('=', 60));
            textToPrint.AppendLine();

            int counter = 1;
            foreach (var student in listBoxExtramuralStudents.Items)
            {
                textToPrint.AppendLine($"{counter,3}. {student}");
                counter++;
            }

            textToPrint.AppendLine();
            textToPrint.AppendLine(new string('=', 60));
            textToPrint.AppendLine($"Всего студентов: {listBoxExtramuralStudents.Items.Count}");
            textToPrint.AppendLine($"Форма обучения: заочная");
            textToPrint.AppendLine($"Дата печати: {DateTime.Now:dd.MM.yyyy HH:mm}");

            string text = textToPrint.ToString();

            // Обработчик события печати
            printDocument.PrintPage += (s, ev) =>
            {
                Font printFont = new Font("Times New Roman", 12);
                float linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
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

            // Показываем диалог выбора принтера
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument.Print();
                    MessageBox.Show("Документ отправлен на печать!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (listBoxExtramuralStudents.Items.Count == 0)
            {
                MessageBox.Show("Список студентов пуст!", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int foundIndex = -1;
            for (int i = 0; i < listBoxExtramuralStudents.Items.Count; i++)
            {
                string student = listBoxExtramuralStudents.Items[i].ToString();
                if (student.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    foundIndex = i;
                    break;
                }
            }

            if (foundIndex != -1)
            {
                listBoxExtramuralStudents.SelectedIndex = foundIndex;
                listBoxExtramuralStudents.TopIndex = foundIndex;
                labelSearchInfo.Text = $"Найден: {listBoxExtramuralStudents.Items[foundIndex]}";
                labelSearchInfo.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelSearchInfo.Text = $"Студент с текстом \"{searchText}\" не найден";
                labelSearchInfo.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show($"Студент, содержащий \"{searchText}\", не найден!", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                labelSearchInfo.Text = "Введите фамилию или имя для поиска";
                labelSearchInfo.ForeColor = System.Drawing.Color.Gray;
                listBoxExtramuralStudents.ClearSelected();
            }
        }
    }
}
