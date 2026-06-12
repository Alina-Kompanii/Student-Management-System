namespace Приложение_для_зам_директора
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            comboBoxGroups = new ComboBox();
            listBoxStudents = new ListBox();
            button1 = new Button();
            comboBoxExtramural = new ComboBox();
            buttonTransfer = new Button();
            label3 = new Label();
            label1 = new Label();
            buttonAcademicLeave = new Button();
            buttonExpel = new Button();
            buttonPrint = new Button();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            labelSearchInfo = new Label();
            SuspendLayout();
            // 
            // comboBoxGroups
            // 
            comboBoxGroups.FormattingEnabled = true;
            comboBoxGroups.Location = new Point(12, 41);
            comboBoxGroups.Name = "comboBoxGroups";
            comboBoxGroups.Size = new Size(217, 28);
            comboBoxGroups.TabIndex = 0;
            // 
            // listBoxStudents
            // 
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.Location = new Point(12, 86);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(460, 464);
            listBoxStudents.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 566);
            button1.Name = "button1";
            button1.Size = new Size(217, 41);
            button1.TabIndex = 7;
            button1.Text = "Вернутьзя назад.";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBoxExtramural
            // 
            comboBoxExtramural.FormattingEnabled = true;
            comboBoxExtramural.Location = new Point(623, 256);
            comboBoxExtramural.Name = "comboBoxExtramural";
            comboBoxExtramural.Size = new Size(284, 28);
            comboBoxExtramural.TabIndex = 8;
            // 
            // buttonTransfer
            // 
            buttonTransfer.BackColor = Color.Sienna;
            buttonTransfer.Cursor = Cursors.Hand;
            buttonTransfer.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonTransfer.ForeColor = Color.Black;
            buttonTransfer.Location = new Point(623, 290);
            buttonTransfer.Name = "buttonTransfer";
            buttonTransfer.Size = new Size(284, 72);
            buttonTransfer.TabIndex = 9;
            buttonTransfer.Text = "Перевести на \r\nзаочную форму обучения.";
            buttonTransfer.UseVisualStyleBackColor = false;
            buttonTransfer.Click += buttonTransfer_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(21, 12);
            label3.Name = "label3";
            label3.Size = new Size(198, 26);
            label3.TabIndex = 10;
            label3.Text = "Выберите группу.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(666, 227);
            label1.Name = "label1";
            label1.Size = new Size(198, 26);
            label1.TabIndex = 11;
            label1.Text = "Выберите группу.";
            // 
            // buttonAcademicLeave
            // 
            buttonAcademicLeave.BackColor = Color.Sienna;
            buttonAcademicLeave.Cursor = Cursors.Hand;
            buttonAcademicLeave.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAcademicLeave.ForeColor = Color.Black;
            buttonAcademicLeave.Location = new Point(623, 400);
            buttonAcademicLeave.Name = "buttonAcademicLeave";
            buttonAcademicLeave.Size = new Size(284, 72);
            buttonAcademicLeave.TabIndex = 12;
            buttonAcademicLeave.Text = "Перевести в\r\nакадемический отпуск.";
            buttonAcademicLeave.UseVisualStyleBackColor = false;
            // 
            // buttonExpel
            // 
            buttonExpel.BackColor = Color.Sienna;
            buttonExpel.Cursor = Cursors.Hand;
            buttonExpel.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonExpel.ForeColor = Color.Black;
            buttonExpel.Location = new Point(623, 478);
            buttonExpel.Name = "buttonExpel";
            buttonExpel.Size = new Size(284, 72);
            buttonExpel.TabIndex = 13;
            buttonExpel.Text = "Отчислить.";
            buttonExpel.UseVisualStyleBackColor = false;
            // 
            // buttonPrint
            // 
            buttonPrint.BackColor = Color.Sienna;
            buttonPrint.Cursor = Cursors.Hand;
            buttonPrint.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPrint.ForeColor = Color.Black;
            buttonPrint.Location = new Point(274, 32);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(217, 37);
            buttonPrint.TabIndex = 14;
            buttonPrint.Text = "Печать.";
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += buttonPrint_Click_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(623, 112);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(284, 27);
            textBoxSearch.TabIndex = 15;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Sienna;
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSearch.ForeColor = Color.Black;
            buttonSearch.Location = new Point(623, 145);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(284, 37);
            buttonSearch.TabIndex = 16;
            buttonSearch.Text = "Найти студента.";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelSearchInfo
            // 
            labelSearchInfo.AutoSize = true;
            labelSearchInfo.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSearchInfo.ForeColor = Color.Tan;
            labelSearchInfo.Location = new Point(503, 83);
            labelSearchInfo.Name = "labelSearchInfo";
            labelSearchInfo.Size = new Size(180, 26);
            labelSearchInfo.TabIndex = 17;
            labelSearchInfo.Text = "Поиск студента.";
            // 
            // Form3
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
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(buttonTransfer);
            Controls.Add(comboBoxExtramural);
            Controls.Add(button1);
            Controls.Add(listBoxStudents);
            Controls.Add(comboBoxGroups);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Студенты очной формы обучения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGroups;
        private ListBox listBoxStudents;
        private Button button1;
        private ComboBox comboBoxExtramural;
        private Button buttonTransfer;
        private Label label3;
        private Label label1;
        private Button buttonAcademicLeave;
        private Button buttonExpel;
        private Button buttonPrint;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Label labelSearchInfo;
    }
}