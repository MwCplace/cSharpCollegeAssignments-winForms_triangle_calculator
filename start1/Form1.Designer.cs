namespace start1
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
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            OK_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 21);
            label1.TabIndex = 0;
            label1.Text = "Размер треугольника";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(21, 21);
            label2.TabIndex = 1;
            label2.Text = "a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 126);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(21, 21);
            label3.TabIndex = 2;
            label3.Text = "b";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 164);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(20, 21);
            label4.TabIndex = 3;
            label4.Text = "c";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(605, 84);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 6;
            label7.Text = "P =";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(605, 123);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(47, 21);
            label8.TabIndex = 7;
            label8.Text = "S =";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 84);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 28);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(301, 123);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 28);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(301, 161);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 28);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Location = new Point(272, 215);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(301, 25);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "прямоугольный треугольник";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Click += label1_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Cursor = Cursors.Hand;
            checkBox2.Location = new Point(272, 247);
            checkBox2.Margin = new Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(319, 25);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "равносторонний треугольник";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Click += label5_Click;
            // 
            // OK_button
            // 
            OK_button.Cursor = Cursors.Hand;
            OK_button.FlatStyle = FlatStyle.Flat;
            OK_button.Location = new Point(301, 295);
            OK_button.Margin = new Padding(4, 3, 4, 3);
            OK_button.Name = "OK_button";
            OK_button.Size = new Size(185, 30);
            OK_button.TabIndex = 13;
            OK_button.Text = "OK";
            OK_button.UseVisualStyleBackColor = true;
            OK_button.Click += button1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 152, 151);
            BackgroundImage = Properties.Resources.Untitled1212_20240218224228;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1056, 358);
            Controls.Add(OK_button);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Simplex_IV25", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Калькулятор для треугольника";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button OK_button;
    }
}