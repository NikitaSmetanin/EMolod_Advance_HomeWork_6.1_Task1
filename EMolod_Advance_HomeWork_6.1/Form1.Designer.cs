namespace EMolod_Advance_HomeWork_6._1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drinkList = new System.Windows.Forms.ComboBox();
            this.choiceDrinkButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.choiceNumberButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.choiceDrinkButton);
            this.groupBox1.Controls.Add(this.drinkList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Обери свій напій на вечірку";
            // 
            // drinkList
            // 
            this.drinkList.FormattingEnabled = true;
            this.drinkList.Items.AddRange(new object[] {
            "Pepsi-Cola",
            "Яблучний сік",
            "Трав\'яний чай"});
            this.drinkList.Location = new System.Drawing.Point(7, 36);
            this.drinkList.Name = "drinkList";
            this.drinkList.Size = new System.Drawing.Size(207, 26);
            this.drinkList.TabIndex = 0;
            // 
            // choiceDrinkButton
            // 
            this.choiceDrinkButton.Location = new System.Drawing.Point(250, 36);
            this.choiceDrinkButton.Name = "choiceDrinkButton";
            this.choiceDrinkButton.Size = new System.Drawing.Size(122, 26);
            this.choiceDrinkButton.TabIndex = 1;
            this.choiceDrinkButton.Text = "Обрати";
            this.choiceDrinkButton.UseVisualStyleBackColor = true;
            this.choiceDrinkButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.choiceNumberButton);
            this.groupBox2.Controls.Add(this.numberTextBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 82);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Відгадай число";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(199, 37);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(33, 26);
            this.numberTextBox.TabIndex = 0;
            // 
            // choiceNumberButton
            // 
            this.choiceNumberButton.Location = new System.Drawing.Point(249, 36);
            this.choiceNumberButton.Name = "choiceNumberButton";
            this.choiceNumberButton.Size = new System.Drawing.Size(122, 26);
            this.choiceNumberButton.TabIndex = 1;
            this.choiceNumberButton.Text = "Відгадати";
            this.choiceNumberButton.UseVisualStyleBackColor = true;
            this.choiceNumberButton.Click += new System.EventHandler(this.choiceNumberButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введіть число від 1 до 10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 224);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Home Work 6.1 Task 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button choiceDrinkButton;
        private System.Windows.Forms.ComboBox drinkList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button choiceNumberButton;
        private System.Windows.Forms.Label label1;
    }
}

