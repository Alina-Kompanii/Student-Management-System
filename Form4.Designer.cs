namespace Приложение_для_зам_директора
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            comboBoxExtramuralGroups = new ComboBox();
            listBoxExtramuralStudents = new ListBox();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            buttonExpel = new Button();
            buttonAcademicLeave = new Button();
            buttonPrint = new Button();
            labelSearchInfo = new Label();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            SuspendLayout();
            // 
            // comboBoxExtramuralGroups
            // 
            comboBoxExtramuralGroups.FormattingEnabled = true;
            comboBoxExtramuralGroups.Location = new Point(12, 38);
            comboBoxExtramuralGroups.Name = "comboBoxExtramuralGroups";
            comboBoxExtramuralGroups.Size = new Size(252, 28);
            comboBoxExtramuralGroups.TabIndex = 1;
            // 
            // listBoxExtramuralStudents
            // 
            listBoxExtramuralStudents.FormattingEnabled = true;
            listBoxExtramuralStudents.Location = new Point(12, 72);
            listBoxExtramuralStudents.Name = "listBoxExtramuralStudents";
            listBoxExtramuralStudents.Size = new Size(502, 484);
            listBoxExtramuralStudents.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(1067, 666);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(198, 26);
            label3.TabIndex = 11;
            label3.Text = "Выберите группу.";
            // 
            // button2
            // 
            button2.BackColor = Color.Sienna;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(12, 566);
            button2.Name = "button2";
            button2.Size = new Size(217, 41);
            button2.TabIndex = 12;
            button2.Text = "Вернутьзя назад.";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonExpel
            // 
            buttonExpel.BackColor = Color.Sienna;
            buttonExpel.Cursor = Cursors.Hand;
            buttonExpel.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonExpel.ForeColor = Color.Black;
            buttonExpel.Location = new Point(650, 489);
            buttonExpel.Name = "buttonExpel";
            buttonExpel.Size = new Size(284, 72);
            buttonExpel.TabIndex = 15;
            buttonExpel.Text = "Отчислить.";
            buttonExpel.UseVisualStyleBackColor = false;
            // 
            // buttonAcademicLeave
            // 
            buttonAcademicLeave.BackColor = Color.Sienna;
            buttonAcademicLeave.Cursor = Cursors.Hand;
            buttonAcademicLeave.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAcademicLeave.ForeColor = Color.Black;
            buttonAcademicLeave.Location = new Point(650, 411);
            buttonAcademicLeave.Name = "buttonAcademicLeave";
            buttonAcademicLeave.Size = new Size(284, 72);
            buttonAcademicLeave.TabIndex = 14;
            buttonAcademicLeave.Text = "Перевести в\r\nакадемический отпуск.";
            buttonAcademicLeave.UseVisualStyleBackColor = false;
            // 
            // buttonPrint
            // 
            buttonPrint.BackColor = Color.Sienna;
            buttonPrint.Cursor = Cursors.Hand;
            buttonPrint.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPrint.ForeColor = Color.Black;
            buttonPrint.Location = new Point(321, 29);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(217, 37);
            buttonPrint.TabIndex = 16;
            buttonPrint.Text = "Печать.";
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // labelSearchInfo
            // 
            labelSearchInfo.AutoSize = true;
            labelSearchInfo.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSearchInfo.ForeColor = Color.Tan;
            labelSearchInfo.Location = new Point(530, 71);
            labelSearchInfo.Name = "labelSearchInfo";
            labelSearchInfo.Size = new Size(180, 26);
            labelSearchInfo.TabIndex = 20;
            labelSearchInfo.Text = "Поиск студента.";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Sienna;
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSearch.ForeColor = Color.Black;
            buttonSearch.Location = new Point(650, 133);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(284, 37);
            buttonSearch.TabIndex = 19;
            buttonSearch.Text = "Найти студента.";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(650, 100);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(284, 27);
            textBoxSearch.TabIndex = 18;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1049, 619);
            Controls.Add(labelSearchInfo);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonPrint);
            Controls.Add(buttonExpel);
            Controls.Add(buttonAcademicLeave);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(listBoxExtramuralStudents);
            Controls.Add(comboBoxExtramuralGroups);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Студенты на заочной форме обучения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxExtramuralGroups;
        private ListBox listBoxExtramuralStudents;
        private Button button1;
        private Label label3;
        private Button button2;
        private Button buttonExpel;
        private Button buttonAcademicLeave;
        private Button buttonPrint;
        private Label labelSearchInfo;
        private Button buttonSearch;
        private TextBox textBoxSearch;
    }
}