namespace Tyuiu.ZhuriloNA.Sprint6.Task0.V9
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
            groupBoxOne_ZNA = new GroupBox();
            labelСondition_ZNA = new Label();
            pictureBoxCondition_ZNA = new PictureBox();
            groupBoxTwo_ZNA = new GroupBox();
            labelVariableX_ZNA = new Label();
            textBoxInputX_ZNA = new TextBox();
            groupBoxThree_ZNA = new GroupBox();
            textBoxConclusion_ZNA = new TextBox();
            labelResult_ZNA = new Label();
            buttonHelp_ZNA = new Button();
            buttonPerform_ZNA = new Button();
            groupBoxOne_ZNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_ZNA).BeginInit();
            groupBoxTwo_ZNA.SuspendLayout();
            groupBoxThree_ZNA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOne_ZNA
            // 
            groupBoxOne_ZNA.Controls.Add(labelСondition_ZNA);
            groupBoxOne_ZNA.Controls.Add(pictureBoxCondition_ZNA);
            groupBoxOne_ZNA.Font = new Font("Segoe UI", 12F);
            groupBoxOne_ZNA.Location = new Point(12, 12);
            groupBoxOne_ZNA.Name = "groupBoxOne_ZNA";
            groupBoxOne_ZNA.Size = new Size(776, 250);
            groupBoxOne_ZNA.TabIndex = 0;
            groupBoxOne_ZNA.TabStop = false;
            groupBoxOne_ZNA.Text = "Условие";
            // 
            // labelСondition_ZNA
            // 
            labelСondition_ZNA.AutoSize = true;
            labelСondition_ZNA.Location = new Point(6, 35);
            labelСondition_ZNA.Name = "labelСondition_ZNA";
            labelСondition_ZNA.Size = new Size(263, 21);
            labelСondition_ZNA.TabIndex = 2;
            labelСondition_ZNA.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxCondition_ZNA
            // 
            pictureBoxCondition_ZNA.ImageLocation = "C:\\DataSprint5\\Untitled.png";
            pictureBoxCondition_ZNA.Location = new Point(639, 22);
            pictureBoxCondition_ZNA.Name = "pictureBoxCondition_ZNA";
            pictureBoxCondition_ZNA.Size = new Size(106, 62);
            pictureBoxCondition_ZNA.TabIndex = 1;
            pictureBoxCondition_ZNA.TabStop = false;
            // 
            // groupBoxTwo_ZNA
            // 
            groupBoxTwo_ZNA.Controls.Add(labelVariableX_ZNA);
            groupBoxTwo_ZNA.Controls.Add(textBoxInputX_ZNA);
            groupBoxTwo_ZNA.Font = new Font("Segoe UI", 12F);
            groupBoxTwo_ZNA.Location = new Point(12, 268);
            groupBoxTwo_ZNA.Name = "groupBoxTwo_ZNA";
            groupBoxTwo_ZNA.Size = new Size(384, 125);
            groupBoxTwo_ZNA.TabIndex = 1;
            groupBoxTwo_ZNA.TabStop = false;
            groupBoxTwo_ZNA.Text = "Ввод данных";
            // 
            // labelVariableX_ZNA
            // 
            labelVariableX_ZNA.AutoSize = true;
            labelVariableX_ZNA.Font = new Font("Segoe UI", 14F);
            labelVariableX_ZNA.Location = new Point(114, 56);
            labelVariableX_ZNA.Name = "labelVariableX_ZNA";
            labelVariableX_ZNA.Size = new Size(142, 25);
            labelVariableX_ZNA.TabIndex = 7;
            labelVariableX_ZNA.Text = "Переменная X:";
            // 
            // textBoxInputX_ZNA
            // 
            textBoxInputX_ZNA.BorderStyle = BorderStyle.None;
            textBoxInputX_ZNA.Location = new Point(114, 84);
            textBoxInputX_ZNA.Name = "textBoxInputX_ZNA";
            textBoxInputX_ZNA.Size = new Size(142, 22);
            textBoxInputX_ZNA.TabIndex = 4;
            textBoxInputX_ZNA.KeyPress += textBoxInputX_ZNA_KeyPress;
            // 
            // groupBoxThree_ZNA
            // 
            groupBoxThree_ZNA.Controls.Add(textBoxConclusion_ZNA);
            groupBoxThree_ZNA.Controls.Add(labelResult_ZNA);
            groupBoxThree_ZNA.Font = new Font("Segoe UI", 12F);
            groupBoxThree_ZNA.Location = new Point(402, 268);
            groupBoxThree_ZNA.Name = "groupBoxThree_ZNA";
            groupBoxThree_ZNA.Size = new Size(386, 125);
            groupBoxThree_ZNA.TabIndex = 2;
            groupBoxThree_ZNA.TabStop = false;
            groupBoxThree_ZNA.Text = "Вывод данных";
            // 
            // textBoxConclusion_ZNA
            // 
            textBoxConclusion_ZNA.BackColor = SystemColors.ControlLight;
            textBoxConclusion_ZNA.BorderStyle = BorderStyle.None;
            textBoxConclusion_ZNA.Location = new Point(6, 84);
            textBoxConclusion_ZNA.Multiline = true;
            textBoxConclusion_ZNA.Name = "textBoxConclusion_ZNA";
            textBoxConclusion_ZNA.Size = new Size(374, 22);
            textBoxConclusion_ZNA.TabIndex = 1;
            // 
            // labelResult_ZNA
            // 
            labelResult_ZNA.AutoSize = true;
            labelResult_ZNA.Font = new Font("Segoe UI", 14F);
            labelResult_ZNA.Location = new Point(6, 56);
            labelResult_ZNA.Name = "labelResult_ZNA";
            labelResult_ZNA.Size = new Size(100, 25);
            labelResult_ZNA.TabIndex = 0;
            labelResult_ZNA.Text = "Результат:";
            // 
            // buttonHelp_ZNA
            // 
            buttonHelp_ZNA.BackColor = SystemColors.Control;
            buttonHelp_ZNA.Font = new Font("Segoe UI", 15F);
            buttonHelp_ZNA.Location = new Point(546, 399);
            buttonHelp_ZNA.Name = "buttonHelp_ZNA";
            buttonHelp_ZNA.Size = new Size(45, 39);
            buttonHelp_ZNA.TabIndex = 3;
            buttonHelp_ZNA.Text = "?";
            buttonHelp_ZNA.TextAlign = ContentAlignment.TopCenter;
            buttonHelp_ZNA.UseVisualStyleBackColor = false;
            buttonHelp_ZNA.Click += buttonHelp_ZNA_Click;
            // 
            // buttonPerform_ZNA
            // 
            buttonPerform_ZNA.Font = new Font("Segoe UI", 12F);
            buttonPerform_ZNA.Location = new Point(597, 399);
            buttonPerform_ZNA.Name = "buttonPerform_ZNA";
            buttonPerform_ZNA.Size = new Size(191, 39);
            buttonPerform_ZNA.TabIndex = 4;
            buttonPerform_ZNA.Text = "Выполнить";
            buttonPerform_ZNA.UseVisualStyleBackColor = true;
            buttonPerform_ZNA.Click += buttonPerform_ZNA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPerform_ZNA);
            Controls.Add(buttonHelp_ZNA);
            Controls.Add(groupBoxThree_ZNA);
            Controls.Add(groupBoxTwo_ZNA);
            Controls.Add(groupBoxOne_ZNA);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            groupBoxOne_ZNA.ResumeLayout(false);
            groupBoxOne_ZNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_ZNA).EndInit();
            groupBoxTwo_ZNA.ResumeLayout(false);
            groupBoxTwo_ZNA.PerformLayout();
            groupBoxThree_ZNA.ResumeLayout(false);
            groupBoxThree_ZNA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOne_ZNA;
        private PictureBox pictureBoxCondition_ZNA;
        private GroupBox groupBoxTwo_ZNA;
        private Label labelСondition_ZNA;
        private Label labelVariableX_ZNA;
        private TextBox textBoxInputX_ZNA;
        private GroupBox groupBoxThree_ZNA;
        private Label labelResult_ZNA;
        private TextBox textBoxConclusion_ZNA;
        private Button buttonHelp_ZNA;
        private Button buttonPerform_ZNA;
    }
}
