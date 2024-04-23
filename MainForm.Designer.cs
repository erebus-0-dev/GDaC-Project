
namespace GDK_Project
{
    partial class MainForm
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
            this.imagA = new System.Windows.Forms.TextBox();
            this.realA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OperationSelection = new System.Windows.Forms.ComboBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SaveToHistory = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ResultToInput = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imagC = new System.Windows.Forms.TextBox();
            this.realC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imagB = new System.Windows.Forms.TextBox();
            this.realB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HistoryPanel = new System.Windows.Forms.Panel();
            this.ClearHistory = new System.Windows.Forms.Button();
            this.SaveHistoryToFile = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CalculationHistory = new System.Windows.Forms.RichTextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.OpenSaveDirectory = new System.Windows.Forms.Button();
            this.numberA.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.HistoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberA
            // 
            this.numberA.Controls.Add(this.imagA);
            this.numberA.Controls.Add(this.realA);
            this.numberA.Controls.Add(this.label2);
            this.numberA.Controls.Add(this.label1);
            this.numberA.Location = new System.Drawing.Point(77, 27);
            this.numberA.Name = "numberA";
            this.numberA.Size = new System.Drawing.Size(520, 37);
            this.numberA.TabIndex = 0;
            // 
            // imagA
            // 
            this.imagA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imagA.Location = new System.Drawing.Point(263, 3);
            this.imagA.Name = "imagA";
            this.imagA.Size = new System.Drawing.Size(240, 31);
            this.imagA.TabIndex = 1;
            this.imagA.TextChanged += new System.EventHandler(this.InputTextChanged);
            this.imagA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // realA
            // 
            this.realA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realA.Location = new System.Drawing.Point(3, 3);
            this.realA.Name = "realA";
            this.realA.Size = new System.Drawing.Size(240, 31);
            this.realA.TabIndex = 0;
            this.realA.TextChanged += new System.EventHandler(this.InputTextChanged);
            this.realA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(500, 3);
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
            this.label1.Location = new System.Drawing.Point(239, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // OperationSelection
            // 
            this.OperationSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperationSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperationSelection.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "^",
            "√",
            "rad",
            "cos",
            "sin",
            "tg",
            "ctg",
            "cosh",
            "sinh",
            "tgh",
            "ctgh"});
            this.OperationSelection.Location = new System.Drawing.Point(7, 50);
            this.OperationSelection.MaxDropDownItems = 24;
            this.OperationSelection.Name = "OperationSelection";
            this.OperationSelection.Size = new System.Drawing.Size(64, 32);
            this.OperationSelection.TabIndex = 5;
            this.OperationSelection.Tag = "";
            this.OperationSelection.SelectedIndexChanged += new System.EventHandler(this.OperationSelection_SelectedIndexChanged);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Reset);
            this.MainPanel.Controls.Add(this.SaveToHistory);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.ResultToInput);
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.OperationSelection);
            this.MainPanel.Controls.Add(this.numberA);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(600, 205);
            this.MainPanel.TabIndex = 6;
            // 
            // SaveToHistory
            // 
            this.SaveToHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveToHistory.Location = new System.Drawing.Point(494, 163);
            this.SaveToHistory.Name = "SaveToHistory";
            this.SaveToHistory.Size = new System.Drawing.Size(103, 35);
            this.SaveToHistory.TabIndex = 13;
            this.SaveToHistory.Text = "Сохранить";
            this.SaveToHistory.UseVisualStyleBackColor = true;
            this.SaveToHistory.Click += new System.EventHandler(this.SaveToHistory_Click);
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
            // ResultToInput
            // 
            this.ResultToInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultToInput.Location = new System.Drawing.Point(223, 163);
            this.ResultToInput.Name = "ResultToInput";
            this.ResultToInput.Size = new System.Drawing.Size(265, 35);
            this.ResultToInput.TabIndex = 10;
            this.ResultToInput.Text = "Скопировать результат во ввод";
            this.ResultToInput.UseVisualStyleBackColor = true;
            this.ResultToInput.Click += new System.EventHandler(this.ResultToInput_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.imagC);
            this.panel3.Controls.Add(this.realC);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(77, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 37);
            this.panel3.TabIndex = 8;
            // 
            // imagC
            // 
            this.imagC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imagC.Location = new System.Drawing.Point(263, 3);
            this.imagC.Name = "imagC";
            this.imagC.ReadOnly = true;
            this.imagC.Size = new System.Drawing.Size(240, 31);
            this.imagC.TabIndex = 1;
            this.imagC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // realC
            // 
            this.realC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realC.Location = new System.Drawing.Point(3, 3);
            this.realC.Name = "realC";
            this.realC.ReadOnly = true;
            this.realC.Size = new System.Drawing.Size(240, 31);
            this.realC.TabIndex = 0;
            this.realC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(500, 3);
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
            this.label6.Location = new System.Drawing.Point(239, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "+";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(77, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 4);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imagB);
            this.panel1.Controls.Add(this.realB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(77, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 37);
            this.panel1.TabIndex = 7;
            // 
            // imagB
            // 
            this.imagB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imagB.Location = new System.Drawing.Point(263, 3);
            this.imagB.Name = "imagB";
            this.imagB.Size = new System.Drawing.Size(240, 31);
            this.imagB.TabIndex = 1;
            this.imagB.TextChanged += new System.EventHandler(this.InputTextChanged);
            this.imagB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // realB
            // 
            this.realB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.realB.Location = new System.Drawing.Point(3, 3);
            this.realB.Name = "realB";
            this.realB.Size = new System.Drawing.Size(240, 31);
            this.realB.TabIndex = 0;
            this.realB.TextChanged += new System.EventHandler(this.InputTextChanged);
            this.realB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(500, 3);
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
            this.label4.Location = new System.Drawing.Point(239, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "+";
            // 
            // HistoryPanel
            // 
            this.HistoryPanel.Controls.Add(this.OpenSaveDirectory);
            this.HistoryPanel.Controls.Add(this.ClearHistory);
            this.HistoryPanel.Controls.Add(this.SaveHistoryToFile);
            this.HistoryPanel.Controls.Add(this.label7);
            this.HistoryPanel.Controls.Add(this.CalculationHistory);
            this.HistoryPanel.Location = new System.Drawing.Point(12, 223);
            this.HistoryPanel.Name = "HistoryPanel";
            this.HistoryPanel.Size = new System.Drawing.Size(600, 446);
            this.HistoryPanel.TabIndex = 9;
            // 
            // ClearHistory
            // 
            this.ClearHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearHistory.Location = new System.Drawing.Point(499, 414);
            this.ClearHistory.Name = "ClearHistory";
            this.ClearHistory.Size = new System.Drawing.Size(98, 29);
            this.ClearHistory.TabIndex = 11;
            this.ClearHistory.Text = "Очистить историю";
            this.ClearHistory.UseVisualStyleBackColor = true;
            this.ClearHistory.Click += new System.EventHandler(this.ClearHistory_Click);
            // 
            // SaveHistoryToFile
            // 
            this.SaveHistoryToFile.AutoSize = true;
            this.SaveHistoryToFile.Checked = true;
            this.SaveHistoryToFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveHistoryToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveHistoryToFile.Location = new System.Drawing.Point(394, 5);
            this.SaveHistoryToFile.Name = "SaveHistoryToFile";
            this.SaveHistoryToFile.Size = new System.Drawing.Size(203, 20);
            this.SaveHistoryToFile.TabIndex = 11;
            this.SaveHistoryToFile.Text = "Сохранять историю в файл";
            this.SaveHistoryToFile.UseVisualStyleBackColor = true;
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
            // CalculationHistory
            // 
            this.CalculationHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculationHistory.Location = new System.Drawing.Point(7, 27);
            this.CalculationHistory.Name = "CalculationHistory";
            this.CalculationHistory.Size = new System.Drawing.Size(590, 381);
            this.CalculationHistory.TabIndex = 0;
            this.CalculationHistory.Text = "";
            this.CalculationHistory.TextChanged += new System.EventHandler(this.CalculationHistory_TextChanged);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reset.Location = new System.Drawing.Point(80, 163);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(137, 35);
            this.Reset.TabIndex = 14;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // OpenSaveDirectory
            // 
            this.OpenSaveDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenSaveDirectory.Location = new System.Drawing.Point(203, 414);
            this.OpenSaveDirectory.Name = "OpenSaveDirectory";
            this.OpenSaveDirectory.Size = new System.Drawing.Size(290, 29);
            this.OpenSaveDirectory.TabIndex = 12;
            this.OpenSaveDirectory.Text = "Открыть расположение сохранения";
            this.OpenSaveDirectory.UseVisualStyleBackColor = true;
            this.OpenSaveDirectory.Click += new System.EventHandler(this.OpenSaveDirectory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 681);
            this.Controls.Add(this.HistoryPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор комплексных чисел";
            this.numberA.ResumeLayout(false);
            this.numberA.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.HistoryPanel.ResumeLayout(false);
            this.HistoryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel numberA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imagA;
        private System.Windows.Forms.TextBox realA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox OperationSelection;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox imagB;
        private System.Windows.Forms.TextBox realB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox imagC;
        private System.Windows.Forms.TextBox realC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ResultToInput;
        private System.Windows.Forms.Panel HistoryPanel;
        private System.Windows.Forms.Button ClearHistory;
        private System.Windows.Forms.CheckBox SaveHistoryToFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox CalculationHistory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SaveToHistory;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button OpenSaveDirectory;
    }
}

