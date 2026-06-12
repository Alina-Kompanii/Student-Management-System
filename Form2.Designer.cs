namespace Приложение_для_зам_директора
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            buttonLightTheme = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(34, 281);
            label1.Name = "label1";
            label1.Size = new Size(282, 84);
            label1.TabIndex = 1;
            label1.Text = "Сергеев\r\nИван Петрович";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(34, 365);
            label3.Name = "label3";
            label3.Size = new Size(252, 52);
            label3.TabIndex = 3;
            label3.Text = "Заместитель директора\r\nпо учебной работе\r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(426, 44);
            button1.Name = "button1";
            button1.Size = new Size(488, 72);
            button1.TabIndex = 6;
            button1.Text = "Списки студентов,\r\nобучающихся на очной форме.";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Sienna;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(426, 149);
            button2.Name = "button2";
            button2.Size = new Size(488, 72);
            button2.TabIndex = 7;
            button2.Text = "Списки студентов,\r\nобучающихся на заочной форме.\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Sienna;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(426, 265);
            button3.Name = "button3";
            button3.Size = new Size(488, 72);
            button3.TabIndex = 8;
            button3.Text = "Списки отчисленных.";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Sienna;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(426, 371);
            button4.Name = "button4";
            button4.Size = new Size(488, 72);
            button4.TabIndex = 9;
            button4.Text = "Студенты, ушедшие в академический отпуск.";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Sienna;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(426, 471);
            button5.Name = "button5";
            button5.Size = new Size(488, 72);
            button5.TabIndex = 10;
            button5.Text = "Дела студентов, перемещенные в архив.";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Sienna;
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(34, 543);
            button6.Name = "button6";
            button6.Size = new Size(185, 64);
            button6.TabIndex = 11;
            button6.Text = "Выйти.";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // buttonLightTheme
            // 
            buttonLightTheme.BackColor = Color.Sienna;
            buttonLightTheme.Cursor = Cursors.Hand;
            buttonLightTheme.Font = new Font("Sitka Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLightTheme.ForeColor = Color.Black;
            buttonLightTheme.Location = new Point(34, 471);
            buttonLightTheme.Name = "buttonLightTheme";
            buttonLightTheme.Size = new Size(185, 64);
            buttonLightTheme.TabIndex = 12;
            buttonLightTheme.Text = "Светлая тема.";
            buttonLightTheme.UseVisualStyleBackColor = false;
            buttonLightTheme.Click += buttonLightTheme_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1049, 619);
            Controls.Add(buttonLightTheme);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Студенты";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button buttonLightTheme;
    }
}