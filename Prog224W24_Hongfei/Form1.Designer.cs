namespace Prog224W24_Hongfei
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            label5 = new Label();
            button4 = new Button();
            listBox2 = new ListBox();
            label6 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(34, 44);
            button1.Name = "button1";
            button1.Size = new Size(258, 58);
            button1.TabIndex = 0;
            button1.Text = "Display Products";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 183);
            label1.Name = "label1";
            label1.Size = new Size(209, 41);
            label1.TabIndex = 1;
            label1.Text = "Product Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 296);
            label2.Name = "label2";
            label2.Size = new Size(194, 41);
            label2.TabIndex = 3;
            label2.Text = "Product Price";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(265, 290);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 47);
            textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Beverage", "Food", "Merchandise" });
            comboBox1.Location = new Point(35, 494);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(459, 49);
            comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 391);
            label3.Name = "label3";
            label3.Size = new Size(280, 41);
            label3.TabIndex = 6;
            label3.Text = "Select Product Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 597);
            label4.Name = "label4";
            label4.Size = new Size(288, 41);
            label4.TabIndex = 7;
            label4.Text = "Select Beverage Size";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(35, 677);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 45);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Small";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(179, 677);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(167, 45);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Medium";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(370, 677);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(129, 45);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "Large";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(34, 797);
            button2.Name = "button2";
            button2.Size = new Size(287, 58);
            button2.TabIndex = 11;
            button2.Text = "Add Product";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(34, 944);
            button3.Name = "button3";
            button3.Size = new Size(378, 58);
            button3.TabIndex = 12;
            button3.Text = "Ring Up Customer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 41;
            listBox1.Location = new Point(545, 130);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(465, 783);
            listBox1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(545, 53);
            label5.Name = "label5";
            label5.Size = new Size(187, 41);
            label5.TabIndex = 14;
            label5.Text = "Products List";
            // 
            // button4
            // 
            button4.Location = new Point(545, 944);
            button4.Name = "button4";
            button4.Size = new Size(205, 58);
            button4.TabIndex = 15;
            button4.Text = "Add to Order";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 41;
            listBox2.Location = new Point(1125, 130);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(443, 783);
            listBox2.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1125, 53);
            label6.Name = "label6";
            label6.Size = new Size(95, 41);
            label6.TabIndex = 17;
            label6.Text = "Order";
            // 
            // button5
            // 
            button5.Location = new Point(1365, 944);
            button5.Name = "button5";
            button5.Size = new Size(188, 58);
            button5.TabIndex = 18;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1695, 1042);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(listBox2);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private Label label5;
        private Button button4;
        private ListBox listBox2;
        private Label label6;
        private Button button5;
    }
}
