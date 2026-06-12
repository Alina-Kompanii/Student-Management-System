namespace Приложение_для_зам_директора
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            listBoxAcademicLeave = new ListBox();
            button2 = new Button();
            buttonExpel = new Button();
            buttonReturn = new Button();
            buttonPrint = new Button();
            labelSearchInfo = new Label();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            SuspendLayout();
            // 
            // listBoxAcademicLeave
            // 
            listBoxAcademicLeave.FormattingEnabled = true;
            listBoxAcademicLeave.Location = new Point(12, 25);
            listBoxAcademicLeave.Name = "listBoxAcademicLeave";
            listBoxAcademicLeave.Size = new Size(489, 524);
            listBoxAcademicLeave.TabIndex = 2;
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
            button2.TabIndex = 14;
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
            buttonExpel.Location = new Point(657, 477);
            buttonExpel.Name = "buttonExpel";
            buttonExpel.Size = new Size(284, 72);
            buttonExpel.TabIndex = 16;
            buttonExpel.Text = "Отчислить.";
            buttonExpel.UseVisualStyleBackColor = false;
            // 
            // buttonReturn
            // 
            buttonReturn.BackColor = Color.Sienna;
            buttonReturn.Cursor = Cursors.Hand;
            buttonReturn.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonReturn.ForeColor = Color.Black;
            buttonReturn.Location = new Point(606, 390);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(398, 72);
            buttonReturn.TabIndex = 17;
            buttonReturn.Text = "Вернуть из академического отпуска";
            buttonReturn.UseVisualStyleBackColor = false;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonPrint
            // 
            buttonPrint.BackColor = Color.Sienna;
            buttonPrint.Cursor = Cursors.Hand;
            buttonPrint.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPrint.ForeColor = Color.Black;
            buttonPrint.Location = new Point(525, 25);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(217, 37);
            buttonPrint.TabIndex = 18;
            buttonPrint.Text = "Печать.";
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // labelSearchInfo
            // 
            labelSearchInfo.AutoSize = true;
            labelSearchInfo.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSearchInfo.ForeColor = Color.Tan;
            labelSearchInfo.Location = new Point(537, 80);
            labelSearchInfo.Name = "labelSearchInfo";
            labelSearchInfo.Size = new Size(180, 26);
            labelSearchInfo.TabIndex = 21;
            labelSearchInfo.Text = "Поиск студента.";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Sienna;
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSearch.ForeColor = Color.Black;
            buttonSearch.Location = new Point(657, 142);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(284, 37);
            buttonSearch.TabIndex = 20;
            buttonSearch.Text = "Найти студента.";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(657, 109);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(284, 27);
            textBoxSearch.TabIndex = 19;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1049, 619);
            Controls.Add(labelSearchInfo);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonPrint);
            Controls.Add(buttonReturn);
            Controls.Add(buttonExpel);
            Controls.Add(button2);
            Controls.Add(listBoxAcademicLeave);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Студенты в академическом отпуске";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAcademicLeave;
        private Button button2;
        private Button buttonExpel;
        private Button buttonReturn;
        private Button buttonPrint;
        private Label labelSearchInfo;
        private Button buttonSearch;
        private TextBox textBoxSearch;
    }
}