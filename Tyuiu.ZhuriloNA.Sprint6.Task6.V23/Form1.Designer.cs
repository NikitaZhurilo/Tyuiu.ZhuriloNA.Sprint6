namespace Tyuiu.ZhuriloNA.Sprint6.Task6.V23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(74, 58);
            button1.TabIndex = 0;
            button1.Text = "Открыть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(92, 12);
            button2.Name = "button2";
            button2.Size = new Size(81, 58);
            button2.TabIndex = 1;
            button2.Text = "Выполнить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(807, 12);
            button3.Name = "button3";
            button3.Size = new Size(74, 58);
            button3.TabIndex = 2;
            button3.Text = "Справка";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(735, 45);
            label1.TabIndex = 3;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 93);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Ввод:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(455, 93);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Вывод:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 111);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(434, 338);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(455, 111);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(429, 338);
            textBox2.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(2, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(890, 455);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 536);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox1;
    }
}
