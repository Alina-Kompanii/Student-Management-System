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
    public partial class Form3 : Form
    {
        private Dictionary<string, List<string>> studentsByGroup;
        public static Dictionary<string, List<string>> extramuralStudents = new Dictionary<string, List<string>>();

        public Form3()
        {
            InitializeComponent();
            buttonTransfer.Click += buttonTransfer_Click;
            buttonExpel.Click += buttonExpel_Click;
            buttonAcademicLeave.Click += buttonAcademicLeave_Click;

            studentsByGroup = new Dictionary<string, List<string>>
            {
                ["141"] = new List<string>
                {
                    "Александров Илья Дмитриевич",
                    "Белова Анастасия Сергеевна",
                    "Васильев Максим Андреевич",
                    "Григорьева Екатерина Павловна",
                    "Дмитриев Артём Алексеевич",
                    "Егорова Полина Владимировна",
                    "Жуков Никита Олегович",
                    "Зайцева Варвара Игоревна",
                    "Иванов Данила Романович",
                    "Кузнецова Алина Евгеньевна",
                    "Лаврентьев Тимофей Денисович",
                    "Михайлова Софья Кирилловна"
                },
                ["1233"] = new List<string>
                {
                    "Новиков Арсений Андреевич",
                    "Орлова Вероника Максимовна",
                    "Павлов Глеб Евгеньевич",
                    "Петрова Мария Алексеевна",
                    "Романов Егор Дмитриевич",
                    "Семёнова Ульяна Борисовна",
                    "Тимофеев Константин Вадимович",
                    "Ушакова Ярослава Сергеевна",
                    "Федотов Михаил Петрович",
                    "Харитонова Алиса Андреевна",
                    "Цветков Денис Павлович",
                    "Чернышёва Василиса Ильинична"
                },
                ["534"] = new List<string>
                {
                    "Шаров Владислав Эдуардович",
                    "Щербакова Марианна Олеговна",
                    "Анисимов Лев Николаевич",
                    "Артемьева Агата Руслановна",
                    "Баранов Захар Тимурович",
                    "Волкова Амелия Денисовна",
                    "Гаврилов Мирон Вячеславович",
                    "Давыдова Алиса Романовна",
                    "Емельянов Святослав Игоревич",
                    "Ермакова Виктория Витальевна",
                    "Золотарев Руслан Алексеевич",
                    "Игнатьева Таисия Григорьевна"
                },
                ["912"] = new List<string>
                {
                    "Карасев Добрыня Станиславович",
                    "Князева Элина Федоровна",
                    "Крылов Елисей Андреевич",
                    "Ларина Мирослава Данииловна",
                    "Мамонтов Гордей Максимович",
                    "Морозова Серафима Владимировна",
                    "Наумов Илларион Анатольевич",
                    "Никитина Эмилия Павловна",
                    "Одинцов Богдан Сергеевич",
                    "Пономарева Лукерья Артемовна",
                    "Русаков Назар Петрович",
                    "Савина Злата Кирилловна"
                },
                ["1211"] = new List<string>
                {
                    "Сафонов Леонид Романович",
                    "Соловьева Вероника Александровна",
                    "Титов Марк Васильевич",
                    "Трофимова Есения Дмитриевна",
                    "Фролов Платон Викторович",
                    "Чеснокова Стефания Михайловна",
                    "Шестаков Корней Алексеевич",
                    "Ширяева Линда Эдуардовна",
                    "Юдин Радомир Оскарович",
                    "Яковлева Майя Тимуровна",
                    "Андреев Виктор Сергеевич",
                    "Богданова Арина Максимовна"
                }
            };

            extramuralStudents["635з"] = new List<string>
            {
                "Соколов Дмитрий Алексеевич",
                "Козлова Екатерина Владимировна",
                "Медведев Павел Сергеевич",
                "Николаева Анна Игоревна",
                "Орлов Максим Денисович",
                "Тарасова Ольга Петровна"
            };

            extramuralStudents["922з"] = new List<string>
            {
                "Борисов Андрей Викторович",
                "Гусева Татьяна Романовна",
                "Зуев Константин Эдуардович",
                "Исаева Наталья Юрьевна",
                "Комаров Сергей Николаевич",
                "Логинова Елена Александровна"
            };

            extramuralStudents["1411з"] = new List<string>
            {
                "Михайлов Артем Павлович",
                "Носова Юлия Дмитриевна",
                "Панкратов Илья Станиславович",
                "Рожкова Ксения Витальевна",
                "Степанов Вадим Михайлович",
                "Титова Алина Андреевна"
            };

            extramuralStudents["1227з"] = new List<string>
            {
                "Устинов Даниил Максимович",
                "Филиппова Вероника Сергеевна",
                "Хромов Евгений Валентинович",
                "Царева Лариса Геннадьевна",
                "Чернов Антон Владимирович",
                "Шульгина Марина Юрьевна"
            };

            comboBoxGroups.Items.AddRange(new string[] { "141", "1233", "534", "912", "1211" });
            comboBoxGroups.SelectedIndex = 0;
            comboBoxGroups.SelectedIndexChanged += (s, e) =>
            {
                string group = comboBoxGroups.SelectedItem.ToString();
                listBoxStudents.Items.Clear();
                foreach (var student in studentsByGroup[group])
                    listBoxStudents.Items.Add(student);
            };

            comboBoxExtramural.Items.AddRange(new string[] { "635з", "922з", "1411з", "1227з" });
            comboBoxExtramural.SelectedIndex = 0;

            listBoxStudents.Items.Clear();
            foreach (var student in studentsByGroup["141"])
                listBoxStudents.Items.Add(student);
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem == null)
            {
                MessageBox.Show("Выберите студента!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxExtramural.SelectedItem == null)
            {
                MessageBox.Show("Выберите заочную группу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string student = listBoxStudents.SelectedItem.ToString();
            string currentGroup = comboBoxGroups.SelectedItem.ToString();
            string targetGroup = comboBoxExtramural.SelectedItem.ToString();

            studentsByGroup[currentGroup].Remove(student);
            extramuralStudents[targetGroup].Add(student);

            listBoxStudents.Items.Clear();
            foreach (var s in studentsByGroup[currentGroup])
                listBoxStudents.Items.Add(s);

            MessageBox.Show($"Студент {student}\nПереведен в заочную группу {targetGroup}!",
                "Перевод выполнен", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExpel_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem == null)
            {
                MessageBox.Show("Выберите студента для отчисления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string student = listBoxStudents.SelectedItem.ToString();
            string currentGroup = comboBoxGroups.SelectedItem.ToString();

            studentsByGroup[currentGroup].Remove(student);
            Form5.expelledStudents.Add(student);

            listBoxStudents.Items.Clear();
            foreach (var s in studentsByGroup[currentGroup])
                listBoxStudents.Items.Add(s);

            MessageBox.Show($"Студент {student}\nОТЧИСЛЕН!",
                "Отчисление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonAcademicLeave_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem == null)
            {
                MessageBox.Show("Выберите студента для отправки в академический отпуск!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string student = listBoxStudents.SelectedItem.ToString();
            string currentGroup = comboBoxGroups.SelectedItem.ToString();

            // Удаляем студента из очной группы
            studentsByGroup[currentGroup].Remove(student);

            // Добавляем в список академ отпуска
            Form6.academicLeaveStudents.Add(student);

            // Обновляем список очников
            listBoxStudents.Items.Clear();
            foreach (var s in studentsByGroup[currentGroup])
                listBoxStudents.Items.Add(s);

            MessageBox.Show($"Студент {student}\nОТПРАВЛЕН В АКАДЕМИЧЕСКИЙ ОТПУСК!",
                "Академический отпуск", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void buttonTransfer_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonPrint_Click_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.Items.Count == 0)
            {
                MessageBox.Show("Нет данных для печати!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDocument printDocument = new PrintDocument();

            printDocument.DefaultPageSettings.Landscape = false;

            string title = "Список студентов";
            string groupName = comboBoxGroups.SelectedItem?.ToString() ?? "Группа не выбрана";

            StringBuilder textToPrint = new StringBuilder();
            textToPrint.AppendLine($"        {title}");
            textToPrint.AppendLine($"        Группа: {groupName}");
            textToPrint.AppendLine(new string('-', 50));

            int counter = 1;
            foreach (var student in listBoxStudents.Items)
            {
                textToPrint.AppendLine($"{counter,3}. {student}");
                counter++;
            }

            textToPrint.AppendLine(new string('-', 50));
            textToPrint.AppendLine($"Всего студентов: {listBoxStudents.Items.Count}");
            textToPrint.AppendLine($"\nДата печати: {DateTime.Now:dd.MM.yyyy HH:mm}");

            string text = textToPrint.ToString();

            printDocument.PrintPage += (s, ev) =>
            {
                Font printFont = new Font("Arial", 10);
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

            if (listBoxStudents.Items.Count == 0)
            {
                MessageBox.Show("Список студентов пуст!", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int foundIndex = -1;
            for (int i = 0; i < listBoxStudents.Items.Count; i++)
            {
                string student = listBoxStudents.Items[i].ToString();
                // Проверяем, содержит ли ФИО искомый текст
                if (student.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    foundIndex = i;
                    break;
                }
            }

            if (foundIndex != -1)
            { listBoxStudents.SelectedIndex = foundIndex;
                listBoxStudents.TopIndex = foundIndex; 
                labelSearchInfo.Text = $"Найден: {listBoxStudents.Items[foundIndex]}";
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
                listBoxStudents.ClearSelected();
            }
        }
    }
}
