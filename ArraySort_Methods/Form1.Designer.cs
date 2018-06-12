namespace ArraySort_Methods
{
    partial class Form1
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
            this.countUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.fillButton = new System.Windows.Forms.Button();
            this.ShowCheckBox = new System.Windows.Forms.CheckBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.BFillButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.BListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ShowBCheckBox = new System.Windows.Forms.CheckBox();
            this.read1Button = new System.Windows.Forms.Button();
            this.read2Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // countUpDown
            // 
            this.countUpDown.Location = new System.Drawing.Point(353, 74);
            this.countUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.countUpDown.Name = "countUpDown";
            this.countUpDown.Size = new System.Drawing.Size(120, 20);
            this.countUpDown.TabIndex = 0;
            this.countUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кількість елементів:";
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(353, 100);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(75, 23);
            this.fillButton.TabIndex = 2;
            this.fillButton.Text = "Заповнити";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // ShowCheckBox
            // 
            this.ShowCheckBox.AutoSize = true;
            this.ShowCheckBox.Checked = true;
            this.ShowCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowCheckBox.Location = new System.Drawing.Point(13, 37);
            this.ShowCheckBox.Name = "ShowCheckBox";
            this.ShowCheckBox.Size = new System.Drawing.Size(121, 17);
            this.ShowCheckBox.TabIndex = 3;
            this.ShowCheckBox.Text = "Показувати масив";
            this.ShowCheckBox.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Enabled = false;
            this.sortButton.Location = new System.Drawing.Point(13, 174);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 5;
            this.sortButton.Text = "Сортувати";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Масив:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Методи сотрування:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 8;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Швидке",
            "Вставками",
            "Злиття",
            "Вибіркове",
            "Шелла"});
            this.checkedListBox1.Location = new System.Drawing.Point(194, 74);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 9;
            // 
            // confirmButton
            // 
            this.confirmButton.Enabled = false;
            this.confirmButton.Location = new System.Drawing.Point(194, 174);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 10;
            this.confirmButton.Text = "ОК";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Час роботи(ms):";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(14, 383);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Відсортований масив:";
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(14, 262);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(120, 95);
            this.resultListBox.TabIndex = 11;
            // 
            // BFillButton
            // 
            this.BFillButton.Location = new System.Drawing.Point(194, 290);
            this.BFillButton.Name = "BFillButton";
            this.BFillButton.Size = new System.Drawing.Size(75, 23);
            this.BFillButton.TabIndex = 17;
            this.BFillButton.Text = "Заповнити";
            this.BFillButton.UseVisualStyleBackColor = true;
            this.BFillButton.Visible = false;
            this.BFillButton.Click += new System.EventHandler(this.BFillButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Кількість елементів масиву В:";
            this.label6.Visible = false;
            // 
            // BCountUpDown
            // 
            this.BCountUpDown.Location = new System.Drawing.Point(194, 264);
            this.BCountUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.BCountUpDown.Name = "BCountUpDown";
            this.BCountUpDown.Size = new System.Drawing.Size(120, 20);
            this.BCountUpDown.TabIndex = 15;
            this.BCountUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.BCountUpDown.Visible = false;
            // 
            // BListBox
            // 
            this.BListBox.FormattingEnabled = true;
            this.BListBox.Location = new System.Drawing.Point(194, 385);
            this.BListBox.Name = "BListBox";
            this.BListBox.Size = new System.Drawing.Size(120, 95);
            this.BListBox.TabIndex = 19;
            this.BListBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Масив B:";
            this.label7.Visible = false;
            // 
            // ShowBCheckBox
            // 
            this.ShowBCheckBox.AutoSize = true;
            this.ShowBCheckBox.Checked = true;
            this.ShowBCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowBCheckBox.Location = new System.Drawing.Point(194, 348);
            this.ShowBCheckBox.Name = "ShowBCheckBox";
            this.ShowBCheckBox.Size = new System.Drawing.Size(131, 17);
            this.ShowBCheckBox.TabIndex = 20;
            this.ShowBCheckBox.Text = "Показувати масив B";
            this.ShowBCheckBox.UseVisualStyleBackColor = true;
            this.ShowBCheckBox.Visible = false;
            // 
            // read1Button
            // 
            this.read1Button.Location = new System.Drawing.Point(353, 129);
            this.read1Button.Name = "read1Button";
            this.read1Button.Size = new System.Drawing.Size(75, 23);
            this.read1Button.TabIndex = 21;
            this.read1Button.Text = "Зчитати";
            this.read1Button.UseVisualStyleBackColor = true;
            this.read1Button.Click += new System.EventHandler(this.read1Button_Click);
            // 
            // read2Button
            // 
            this.read2Button.Location = new System.Drawing.Point(194, 319);
            this.read2Button.Name = "read2Button";
            this.read2Button.Size = new System.Drawing.Size(75, 23);
            this.read2Button.TabIndex = 22;
            this.read2Button.Text = "Зчитати";
            this.read2Button.UseVisualStyleBackColor = true;
            this.read2Button.Visible = false;
            this.read2Button.Click += new System.EventHandler(this.read2Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 492);
            this.Controls.Add(this.read2Button);
            this.Controls.Add(this.read1Button);
            this.Controls.Add(this.ShowBCheckBox);
            this.Controls.Add(this.BListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BFillButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BCountUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.ShowCheckBox);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countUpDown);
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown countUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.CheckBox ShowCheckBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Button BFillButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown BCountUpDown;
        private System.Windows.Forms.ListBox BListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ShowBCheckBox;
        private System.Windows.Forms.Button read1Button;
        private System.Windows.Forms.Button read2Button;
    }
}

