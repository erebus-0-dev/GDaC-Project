
namespace GDK_Project
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
            this.numberA = new System.Windows.Forms.Panel();
            this.imaginativeA = new System.Windows.Forms.TextBox();
            this.realA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.operationSelection = new System.Windows.Forms.ComboBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imaginativeC = new System.Windows.Forms.TextBox();
            this.realC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imaginativeB = new System.Windows.Forms.TextBox();
            this.realB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.historyPanel = new System.Windows.Forms.Panel();
            this.clearHistoryButton = new System.Windows.Forms.Button();
            this.saveHistoryToFileCheckbox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.calculationHistory = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numberA.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.historyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberA
            // 
            this.numberA.Controls.Add(this.imaginativeA);
            this.numberA.Controls.Add(this.realA);
            this.numberA.Controls.Add(this.label2);
            this.numberA.Controls.Add(this.label1);
            this.numberA.Location = new System.Drawing.Point(55, 27);
            this.numberA.Name = "numberA";
            this.numberA.Size = new System.Drawing.Size(438, 37);
            this.numberA.TabIndex = 0;
            // 
            // imaginativeA
            // 
            this.imaginativeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imaginativeA.Location = new System.Drawing.Point(204, 3);
            this.imaginativeA.Name = "imaginativeA";
            this.imaginativeA.Size = new System.Drawing.Size(180, 31);
            this.imaginativeA.TabIndex = 1;
            // 
            // realA
            // 
            this.realA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realA.Location = new System.Drawing.Point(3, 3);
            this.realA.Name = "realA";
            this.realA.Size = new System.Drawing.Size(180, 31);
            this.realA.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(381, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "i";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(179, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // operationSelection
            // 
            this.operationSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operationSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationSelection.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operationSelection.Location = new System.Drawing.Point(5, 49);
            this.operationSelection.Name = "operationSelection";
            this.operationSelection.Size = new System.Drawing.Size(44, 33);
            this.operationSelection.TabIndex = 5;
            this.operationSelection.Tag = "";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.calculateButton);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.operationSelection);
            this.mainPanel.Controls.Add(this.numberA);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(454, 205);
            this.mainPanel.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Калькулятор комплексных чисел";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(55, 163);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(251, 35);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Перенести реузльтат во ввод";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.imaginativeC);
            this.panel3.Controls.Add(this.realC);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(55, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 37);
            this.panel3.TabIndex = 8;
            // 
            // imaginativeC
            // 
            this.imaginativeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imaginativeC.Location = new System.Drawing.Point(204, 3);
            this.imaginativeC.Name = "imaginativeC";
            this.imaginativeC.Size = new System.Drawing.Size(180, 31);
            this.imaginativeC.TabIndex = 1;
            // 
            // realC
            // 
            this.realC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realC.Location = new System.Drawing.Point(3, 3);
            this.realC.Name = "realC";
            this.realC.Size = new System.Drawing.Size(180, 31);
            this.realC.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(381, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "i";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(179, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "+";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(55, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 4);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imaginativeB);
            this.panel1.Controls.Add(this.realB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(55, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 37);
            this.panel1.TabIndex = 7;
            // 
            // imaginativeB
            // 
            this.imaginativeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imaginativeB.Location = new System.Drawing.Point(204, 3);
            this.imaginativeB.Name = "imaginativeB";
            this.imaginativeB.Size = new System.Drawing.Size(180, 31);
            this.imaginativeB.TabIndex = 1;
            // 
            // realB
            // 
            this.realB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realB.Location = new System.Drawing.Point(3, 3);
            this.realB.Name = "realB";
            this.realB.Size = new System.Drawing.Size(180, 31);
            this.realB.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(381, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "i";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(179, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "+";
            // 
            // historyPanel
            // 
            this.historyPanel.Controls.Add(this.clearHistoryButton);
            this.historyPanel.Controls.Add(this.saveHistoryToFileCheckbox);
            this.historyPanel.Controls.Add(this.label7);
            this.historyPanel.Controls.Add(this.calculationHistory);
            this.historyPanel.Location = new System.Drawing.Point(12, 223);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(454, 278);
            this.historyPanel.TabIndex = 9;
            // 
            // clearHistoryButton
            // 
            this.clearHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearHistoryButton.Location = new System.Drawing.Point(312, 249);
            this.clearHistoryButton.Name = "clearHistoryButton";
            this.clearHistoryButton.Size = new System.Drawing.Size(137, 24);
            this.clearHistoryButton.TabIndex = 11;
            this.clearHistoryButton.Text = "Очистить историю";
            this.clearHistoryButton.UseVisualStyleBackColor = true;
            // 
            // saveHistoryToFileCheckbox
            // 
            this.saveHistoryToFileCheckbox.AutoSize = true;
            this.saveHistoryToFileCheckbox.Location = new System.Drawing.Point(7, 254);
            this.saveHistoryToFileCheckbox.Name = "saveHistoryToFileCheckbox";
            this.saveHistoryToFileCheckbox.Size = new System.Drawing.Size(163, 17);
            this.saveHistoryToFileCheckbox.TabIndex = 11;
            this.saveHistoryToFileCheckbox.Text = "Сохранять историю в файл";
            this.saveHistoryToFileCheckbox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "История вычислений";
            // 
            // calculationHistory
            // 
            this.calculationHistory.Location = new System.Drawing.Point(7, 27);
            this.calculationHistory.Name = "calculationHistory";
            this.calculationHistory.Size = new System.Drawing.Size(442, 221);
            this.calculationHistory.TabIndex = 0;
            this.calculationHistory.Text = "<история вычислений>";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(312, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 511);
            this.Controls.Add(this.historyPanel);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор комплексных чисел";
            this.numberA.ResumeLayout(false);
            this.numberA.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.historyPanel.ResumeLayout(false);
            this.historyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel numberA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imaginativeA;
        private System.Windows.Forms.TextBox realA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox operationSelection;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox imaginativeB;
        private System.Windows.Forms.TextBox realB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox imaginativeC;
        private System.Windows.Forms.TextBox realC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Panel historyPanel;
        private System.Windows.Forms.Button clearHistoryButton;
        private System.Windows.Forms.CheckBox saveHistoryToFileCheckbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox calculationHistory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

