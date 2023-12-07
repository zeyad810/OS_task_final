namespace OS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            NameBox = new TextBox();
            AgeBox = new TextBox();
            gender = new Label();
            radioButton1 = new RadioButton();
            r2 = new RadioButton();
            combx = new ComboBox();
            label3 = new Label();
            chklst1 = new CheckedListBox();
            button_f1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 15, 255);
            label1.Location = new Point(59, 42);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Your Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 15, 255);
            label2.Location = new Point(59, 105);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter Your Age";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(208, 42);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(184, 27);
            NameBox.TabIndex = 2;
            // 
            // AgeBox
            // 
            AgeBox.Location = new Point(208, 105);
            AgeBox.Name = "AgeBox";
            AgeBox.Size = new Size(184, 27);
            AgeBox.TabIndex = 3;
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Location = new Point(59, 184);
            gender.Name = "gender";
            gender.Size = new Size(90, 20);
            gender.TabIndex = 4;
            gender.Text = "Your Gender";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(209, 184);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(78, 24);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            r2.AutoSize = true;
            r2.Location = new Point(372, 186);
            r2.Name = "r2";
            r2.Size = new Size(63, 24);
            r2.TabIndex = 6;
            r2.TabStop = true;
            r2.Text = "Male";
            r2.UseVisualStyleBackColor = true;
            // 
            // combx
            // 
            combx.FormattingEnabled = true;
            combx.Items.AddRange(new object[] { "Egypt ", "UAE", "UK", "USA" });
            combx.Location = new Point(71, 239);
            combx.Name = "combx";
            combx.Size = new Size(95, 28);
            combx.TabIndex = 7;
            combx.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 299);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 8;
            label3.Text = "Choose your Course";
            // 
            // chklst1
            // 
            chklst1.CheckOnClick = true;
            chklst1.FormattingEnabled = true;
            chklst1.Items.AddRange(new object[] { "HTML", "CSS", "JavaScript", "PHP" });
            chklst1.Location = new Point(272, 301);
            chklst1.Name = "chklst1";
            chklst1.Size = new Size(150, 114);
            chklst1.TabIndex = 9;
            // 
            // button_f1
            // 
            button_f1.Location = new Point(144, 445);
            button_f1.Name = "button_f1";
            button_f1.Size = new Size(143, 45);
            button_f1.TabIndex = 10;
            button_f1.Text = "Submit";
            button_f1.UseVisualStyleBackColor = true;
            button_f1.Click += button_f1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 525);
            Controls.Add(button_f1);
            Controls.Add(chklst1);
            Controls.Add(label3);
            Controls.Add(combx);
            Controls.Add(r2);
            Controls.Add(radioButton1);
            Controls.Add(gender);
            Controls.Add(AgeBox);
            Controls.Add(NameBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NameBox;
        private TextBox AgeBox;
        private Label gender;
        private RadioButton radioButton1;
        private RadioButton r2;
        private ComboBox combx;
        private Label label3;
        private CheckedListBox chklst1;
        private Button button_f1;
    }
}