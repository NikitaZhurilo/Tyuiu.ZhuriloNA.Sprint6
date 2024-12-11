namespace Tyuiu.ZhuriloNA.Sprint6.Task4.V11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 87);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(478, 38);
            label1.TabIndex = 0;
            label1.Text = "Написать программу, которая выводит таблицу значений функции.\r\n(произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(564, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 87);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 56);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 25);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 55);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 26);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(156, 34);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 1;
            label3.Text = "Конец шага";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(6, 33);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 0;
            label2.Text = "Старт шага";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(874, 23);
            button1.Name = "button1";
            button1.Size = new Size(90, 63);
            button1.TabIndex = 2;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Location = new Point(1066, 23);
            button2.Name = "button2";
            button2.Size = new Size(90, 63);
            button2.TabIndex = 3;
            button2.Text = "Справка";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.Location = new Point(970, 23);
            button3.Name = "button3";
            button3.Size = new Size(90, 63);
            button3.TabIndex = 4;
            button3.Text = "Сохранить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(12, 105);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(236, 421);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(224, 387);
            textBox1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(254, 115);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(902, 399);
            chart1.TabIndex = 6;
            chart1.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 538);
            Controls.Add(chart1);
            Controls.Add(groupBox3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
    }
}
