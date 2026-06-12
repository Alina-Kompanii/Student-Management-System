namespace Приложение_для_зам_директора
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            listBoxExpelled = new ListBox();
            button2 = new Button();
            buttonToArchive = new Button();
            buttonPrint = new Button();
            labelSearchInfo = new Label();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            SuspendLayout();
            // 
            // listBoxExpelled
            // 
            listBoxExpelled.FormattingEnabled = true;
            listBoxExpelled.Location = new Point(12, 12);
            listBoxExpelled.Name = "listBoxExpelled";
            listBoxExpelled.Size = new Size(496, 544);
            listBoxExpelled.TabIndex = 3;
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
            button2.TabIndex = 13;
            button2.Text = "Вернутьзя назад.";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonToArchive
            // 
            buttonToArchive.BackColor = Color.Sienna;
            buttonToArchive.Cursor = Cursors.Hand;
            buttonToArchive.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonToArchive.ForeColor = Color.Black;
            buttonToArchive.Location = new Point(650, 484);
            buttonToArchive.Name = "buttonToArchive";
            buttonToArchive.Size = new Size(284, 72);
            buttonToArchive.TabIndex = 16;
            buttonToArchive.Text = "Перевести дело в архив.";
            buttonToArchive.UseVisualStyleBackColor = false;
            // 
            // buttonPrint
            // 
            buttonPrint.BackColor = Color.Sienna;
            buttonPrint.Cursor = Cursors.Hand;
            buttonPrint.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPrint.ForeColor = Color.Black;
            buttonPrint.Location = new Point(514, 12);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(217, 37);
            buttonPrint.TabIndex = 17;
            buttonPrint.Text = "Печать.";
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // labelSearchInfo
            // 
            labelSearchInfo.AutoSize = true;
            labelSearchInfo.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSearchInfo.ForeColor = Color.Tan;
            labelSearchInfo.Location = new Point(530, 92);
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
            buttonSearch.Location = new Point(650, 154);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(284, 37);
            buttonSearch.TabIndex = 19;
            buttonSearch.Text = "Найти студента.";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(650, 121);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(284, 27);
            textBoxSearch.TabIndex = 18;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1049, 619);
            Controls.Add(labelSearchInfo);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonPrint);
            Controls.Add(buttonToArchive);
            Controls.Add(button2);
            Controls.Add(listBoxExpelled);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отчисленные";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxExpelled;
        private Button button2;
        private Button buttonToArchive;
        private Button buttonPrint;
        private Label labelSearchInfo;
        private Button buttonSearch;
        private TextBox textBoxSearch;
    }
}