using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.LeushinP.Sprint6.Task0.V5
{
    partial class FormMain
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
            buttonHelp_LPS = new Button();
            buttonResult_LPS = new Button();
            groupBoxTask_LPS = new GroupBox();
            textBoxTask_LPS = new TextBox();
            pictureBoxFarmula_LPS = new PictureBox();
            groupBoxInput_LPS = new GroupBox();
            textBoxInputEnd_LPS = new TextBox();
            textBoxInputStart_LPS = new TextBox();
            groupBoxOutput_LPS = new GroupBox();
            textBoxOutputEnd_LPS = new TextBox();
            textBoxOutpunStart_LPS = new TextBox();
            groupBoxTask_LPS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFarmula_LPS).BeginInit();
            groupBoxInput_LPS.SuspendLayout();
            groupBoxOutput_LPS.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelp_MSM
            // 
            buttonHelp_LPS.FlatStyle = FlatStyle.Flat;
            buttonHelp_LPS.Font = new Font("Segoe UI", 14F);
            buttonHelp_LPS.Location = new Point(656, 520);
            buttonHelp_LPS.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_LPS.Name = "buttonHelp_MSM";
            buttonHelp_LPS.Size = new Size(57, 67);
            buttonHelp_LPS.TabIndex = 0;
            buttonHelp_LPS.Text = "?";
            buttonHelp_LPS.UseVisualStyleBackColor = true;
            buttonHelp_LPS.Click += buttonHelp_LPS_Click;
            // 
            // buttonResult_MSM
            // 
            buttonResult_LPS.BackColor = SystemColors.Control;
            buttonResult_LPS.Location = new Point(720, 520);
            buttonResult_LPS.Margin = new Padding(3, 4, 3, 4);
            buttonResult_LPS.Name = "buttonResult_MSM";
            buttonResult_LPS.Size = new Size(181, 64);
            buttonResult_LPS.TabIndex = 1;
            buttonResult_LPS.Text = "Выполнить";
            buttonResult_LPS.UseVisualStyleBackColor = false;
            buttonResult_LPS.Click += buttonResult_LPS_Click;
            // 
            // groupBoxTask_MSM
            // 
            groupBoxTask_LPS.Controls.Add(textBoxTask_MSM);
            groupBoxTask_LPS.Controls.Add(pictureBoxFarmula_MSM);
            groupBoxTask_LPS.Location = new Point(14, 16);
            groupBoxTask_LPS.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_LPS.Name = "groupBoxTask_MSM";
            groupBoxTask_LPS.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_LPS.Size = new Size(887, 351);
            groupBoxTask_LPS.TabIndex = 2;
            groupBoxTask_LPS.TabStop = false;
            groupBoxTask_LPS.Text = "Условие";
            // 
            // textBoxTask_MSM
            // 
            textBoxTask_LPS.BackColor = SystemColors.Control;
            textBoxTask_LPS.BorderStyle = BorderStyle.None;
            textBoxTask_LPS.Location = new Point(7, 29);
            textBoxTask_LPS.Margin = new Padding(3, 4, 3, 4);
            textBoxTask_LPS.Multiline = true;
            textBoxTask_LPS.Name = "textBoxTask_LPS";
            textBoxTask_LPS.ReadOnly = true;
            textBoxTask_LPS.Size = new Size(527, 313);
            textBoxTask_LPS.TabIndex = 1;
            textBoxTask_LPS.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFarmula_MSM
            // 
            pictureBoxFarmula_LPS.BackColor = SystemColors.Window;
            pictureBoxFarmula_LPS.Location = new Point(541, 29);
            pictureBoxFarmula_LPS.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFarmula_LPS.Name = "pictureBoxFarmula_LPS";
            pictureBoxFarmula_LPS.Size = new Size(339, 52);
            pictureBoxFarmula_LPS.TabIndex = 0;
            pictureBoxFarmula_LPS.TabStop = false;
            pictureBoxFarmula_LPS.Click += this.pictureBoxFarmula_LPS_Click;
            // 
            // groupBoxInput_MSM
            // 
            groupBoxInput_LPS.Controls.Add(textBoxInputEnd_LPS);
            groupBoxInput_LPS.Controls.Add(textBoxInputStart_LPS);
            groupBoxInput_LPS.Location = new Point(14, 375);
            groupBoxInput_LPS.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput_LPS.Name = "groupBoxInput_MSM";
            groupBoxInput_LPS.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput_LPS.Size = new Size(638, 127);
            groupBoxInput_LPS.TabIndex = 3;
            groupBoxInput_LPS.TabStop = false;
            groupBoxInput_LPS.Text = "Ввод данных:";
            // 
            // textBoxInputEnd_MSM
            // 
            textBoxInputEnd_LPS.Font = new Font("Segoe UI", 16F);
            textBoxInputEnd_LPS.Location = new Point(7, 68);
            textBoxInputEnd_LPS.Margin = new Padding(3, 4, 3, 4);
            textBoxInputEnd_LPS.Name = "textBoxInputEnd_LPS";
            textBoxInputEnd_LPS.Size = new Size(623, 43);
            textBoxInputEnd_LPS.TabIndex = 1;
            textBoxInputEnd_LPS.KeyPress += textBoxInputEnd_MSM_KeyPress;
            // 
            // textBoxInputStart_MSM
            // 
            textBoxInputStart_LPS.BackColor = SystemColors.Control;
            textBoxInputStart_LPS.BorderStyle = BorderStyle.None;
            textBoxInputStart_LPS.Location = new Point(7, 39);
            textBoxInputStart_LPS.Margin = new Padding(3, 4, 3, 4);
            textBoxInputStart_LPS.Name = "textBoxInputStart_LPS";
            textBoxInputStart_LPS.ReadOnly = true;
            textBoxInputStart_LPS.Size = new Size(114, 20);
            textBoxInputStart_LPS.TabIndex = 0;
            textBoxInputStart_LPS.Text = "Переменная X:";
            // 
            // groupBoxOutput_MSM
            // 
            groupBoxOutput_LPS.Controls.Add(textBoxOutputEnd_PPE);
            groupBoxOutput_LPS.Controls.Add(textBoxOutpunStart_PPE);
            groupBoxOutput_LPS.Location = new Point(658, 375);
            groupBoxOutput_LPS.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput_LPS.Name = "groupBoxOutput_PPE";
            groupBoxOutput_LPS Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput_LPS.Size = new Size(242, 127);
            groupBoxOutput_LPS.TabIndex = 4;
            groupBoxOutput_LPS.TabStop = false;
            groupBoxOutput_LPS.Text = "Вывод данных:";
            // 
            // textBoxOutputEnd_MSM
            // 
            groupBoxOutput_LPS.Font = new Font("Segoe UI", 16F);
            groupBoxOutput_LPS.Location = new Point(7, 68);
            groupBoxOutput_LPS.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput_LPS.Name = "textBoxOutputEnd_LPS";
            groupBoxOutput_LPS.ReadOnly = true;
            groupBoxOutput_LPS.Size = new Size(207, 43);
            groupBoxOutput_LPS.TabIndex = 1;
            // 
            // textBoxOutpunStart_MSM
            // 
            textBoxOutpunStart_LPS.BackColor = SystemColors.Control;
            textBoxOutpunStart_LPS.BorderStyle = BorderStyle.None;
            textBoxOutpunStart_LPS.Location = new Point(7, 39);
            textBoxOutpunStart_LPS.Margin = new Padding(3, 4, 3, 4);
            textBoxOutpunStart_LPS.Multiline = true;
            textBoxOutpunStart_LPS.Name = "textBoxOutpunStart_LPS";
            textBoxOutpunStart_LPS.ReadOnly = true;
            textBoxOutpunStart_LPS.Size = new Size(114, 21);
            textBoxOutpunStart_LPS.TabIndex = 0;
            textBoxOutpunStart_LPS.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 655);
            Controls.Add(groupBoxOutput_LPS);
            Controls.Add(groupBoxInput_LPS);
            Controls.Add(groupBoxTask_LPS);
            Controls.Add(buttonResult_LPS);
            Controls.Add(buttonHelp_LPS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 5 |Леушин Павел Сергеевич.";
            groupBoxTask_LPS.ResumeLayout(false);
            groupBoxTask_LPS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFarmula_LPS).EndInit();
            groupBoxInput_LPS.ResumeLayout(false);
            groupBoxInput_LPS.PerformLayout();
            groupBoxOutput_LPS.ResumeLayout(false);
            groupBoxOutput_LPS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp_LPS;
        private Button buttonResult_LPS;
        private GroupBox groupBoxTask_LPS;
        private TextBox textBoxTask_LPS;
        private PictureBox pictureBoxFarmula_LPS;
        private GroupBox groupBoxInput_LPS;
        private TextBox textBoxInputEnd_LPS;
        private TextBox textBoxInputStart_LPS;
        private GroupBox groupBoxOutput_LPS;
        private TextBox textBoxOutputEnd_LPS;
        private TextBox textBoxOutpunStartLPS;
    }
}
