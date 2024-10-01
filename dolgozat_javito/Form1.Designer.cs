namespace dolgozat_javito
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
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            richTextBox1 = new RichTextBox();
            tabPage2 = new TabPage();
            checkBox1 = new CheckBox();
            richTextBox2 = new RichTextBox();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(17, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Select File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 7);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Filename:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(162, 7);
            label2.Name = "label2";
            label2.Size = new Size(180, 15);
            label2.TabIndex = 3;
            label2.Text = "none";
            // 
            // button2
            // 
            button2.Location = new Point(17, 32);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Futtatás";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 32);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Paraméterek";
            textBox2.Size = new Size(244, 23);
            textBox2.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 7);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(371, 448);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(363, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Compiler";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(17, 61);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(325, 340);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(checkBox1);
            tabPage2.Controls.Add(richTextBox2);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(363, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "UnZip";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(112, 35);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(197, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Remove zip files after extracting.";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(17, 61);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(325, 340);
            richTextBox2.TabIndex = 12;
            richTextBox2.Text = "";
            // 
            // button3
            // 
            button3.Location = new Point(17, 3);
            button3.Name = "button3";
            button3.Size = new Size(89, 23);
            button3.TabIndex = 7;
            button3.Text = "Select Folder";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(17, 32);
            button4.Name = "button4";
            button4.Size = new Size(79, 23);
            button4.TabIndex = 10;
            button4.Text = "Kicsomagol";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.Location = new Point(112, 7);
            label4.Name = "label4";
            label4.Size = new Size(230, 15);
            label4.TabIndex = 9;
            label4.Text = "none";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 457);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Canvas Helper";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label2;
        private Button button2;
        private TextBox textBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox richTextBox1;
        private CheckBox checkBox1;
        private RichTextBox richTextBox2;
        private Button button3;
        private Button button4;
        private Label label4;
    }
}
