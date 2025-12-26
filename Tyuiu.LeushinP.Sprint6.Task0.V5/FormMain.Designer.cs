using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using Tyuiu.LeushinP.Sprint6.Task0.V5.Lib;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
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
            // buttonHelp_LPS
            // 
            buttonHelp_LPS.FlatStyle = FlatStyle.Flat;
            buttonHelp_LPS.Font = new Font("Segoe UI", 14F);
            buttonHelp_LPS.Location = new Point(574, 390);
            buttonHelp_LPS.Name = "buttonHelp_LPS";
            buttonHelp_LPS.Size = new Size(50, 50);
            buttonHelp_LPS.TabIndex = 0;
            buttonHelp_LPS.Text = "?";
            buttonHelp_LPS.UseVisualStyleBackColor = true;
            buttonHelp_LPS.Click += buttonHelp_LPS_Click;
            // 
            // buttonResult_LPS
            // 
            buttonResult_LPS.BackColor = SystemColors.Control;
            buttonResult_LPS.Location = new Point(630, 390);
            buttonResult_LPS.Name = "buttonResult_LPS";
            buttonResult_LPS.Size = new Size(158, 48);
            buttonResult_LPS.TabIndex = 1;
            buttonResult_LPS.Text = "Выполнить";
            buttonResult_LPS.UseVisualStyleBackColor = false;
            buttonResult_LPS.Click += buttonResult_LPS_Click;
            // 
            // groupBoxTask_LPS
            // 
            groupBoxTask_LPS.Controls.Add(textBoxTask_LPS);
            groupBoxTask_LPS.Controls.Add(pictureBoxFarmula_LPS);
            groupBoxTask_LPS.Location = new Point(12, 12);
            groupBoxTask_LPS.Name = "groupBoxTask_LPS";
            groupBoxTask_LPS.Size = new Size(776, 263);
            groupBoxTask_LPS.TabIndex = 2;
            groupBoxTask_LPS.TabStop = false;
            groupBoxTask_LPS.Text = "Условие";
            // 
            // textBoxTask_LPS
            // 
            textBoxTask_LPS.BackColor = SystemColors.Control;
            textBoxTask_LPS.BorderStyle = BorderStyle.None;
            textBoxTask_LPS.Location = new Point(6, 22);
            textBoxTask_LPS.Multiline = true;
            textBoxTask_LPS.Name = "textBoxTask_LPS";
            textBoxTask_LPS.ReadOnly = true;
            textBoxTask_LPS.Size = new Size(461, 235);
            textBoxTask_LPS.TabIndex = 1;
            textBoxTask_LPS.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFarmula_LPS
            // 
            pictureBoxFarmula_LPS.BackColor = SystemColors.Window;
            pictureBoxFarmula_LPS.Image = (Image)resources.GetObject("pictureBoxFarmula_LPS.Image");
            pictureBoxFarmula_LPS.Location = new Point(473, 22);
            pictureBoxFarmula_LPS.Name = "pictureBoxFarmula_LPS";
            pictureBoxFarmula_LPS.Size = new Size(297, 39);
            pictureBoxFarmula_LPS.TabIndex = 0;
            pictureBoxFarmula_LPS.TabStop = false;
            // 
            // groupBoxInput_LPS
            // 
            groupBoxInput_LPS.Controls.Add(textBoxInputEnd_LPS);
            groupBoxInput_LPS.Controls.Add(textBoxInputStart_LPS);
            groupBoxInput_LPS.Location = new Point(12, 281);
            groupBoxInput_LPS.Name = "groupBoxInput_LPS";
            groupBoxInput_LPS.Size = new Size(558, 95);
            groupBoxInput_LPS.TabIndex = 3;
            groupBoxInput_LPS.TabStop = false;
            groupBoxInput_LPS.Text = "Ввод данных:";
            // 
            // textBoxInputEnd_LPS
            // 
            textBoxInputEnd_LPS.Font = new Font("Segoe UI", 16F);
            textBoxInputEnd_LPS.Location = new Point(6, 51);
            textBoxInputEnd_LPS.Name = "textBoxInputEnd_LPS";
            textBoxInputEnd_LPS.Size = new Size(546, 36);
            textBoxInputEnd_LPS.TabIndex = 1;
            textBoxInputEnd_LPS.KeyPress += textBoxInputEnd_LPS_KeyPress;
            // 
            // textBoxInputStart_LPS
            // 
            textBoxInputStart_LPS.BackColor = SystemColors.Control;
            textBoxInputStart_LPS.BorderStyle = BorderStyle.None;
            textBoxInputStart_LPS.Location = new Point(6, 29);
            textBoxInputStart_LPS.Name = "textBoxInputStart_LPS";
            textBoxInputStart_LPS.ReadOnly = true;
            textBoxInputStart_LPS.Size = new Size(100, 16);
            textBoxInputStart_LPS.TabIndex = 0;
            textBoxInputStart_LPS.Text = "Переменная X:";
            // 
            // groupBoxOutput_LPS
            // 
            groupBoxOutput_LPS.Controls.Add(textBoxOutputEnd_LPS);
            groupBoxOutput_LPS.Controls.Add(textBoxOutpunStart_LPS);
            groupBoxOutput_LPS.Location = new Point(576, 281);
            groupBoxOutput_LPS.Name = "groupBoxOutput_LPS";
            groupBoxOutput_LPS.Size = new Size(212, 95);
            groupBoxOutput_LPS.TabIndex = 4;
            groupBoxOutput_LPS.TabStop = false;
            groupBoxOutput_LPS.Text = "Вывод данных:";
            // 
            // textBoxOutputEnd_LPS
            // 
            textBoxOutputEnd_LPS.Font = new Font("Segoe UI", 16F);
            textBoxOutputEnd_LPS.Location = new Point(6, 51);
            textBoxOutputEnd_LPS.Name = "textBoxOutputEnd_LPS";
            textBoxOutputEnd_LPS.ReadOnly = true;
            textBoxOutputEnd_LPS.Size = new Size(182, 36);
            textBoxOutputEnd_LPS.TabIndex = 1;
            // 
            // textBoxOutpunStart_LPS
            // 
            textBoxOutpunStart_LPS.BackColor = SystemColors.Control;
            textBoxOutpunStart_LPS.BorderStyle = BorderStyle.None;
            textBoxOutpunStart_LPS.Location = new Point(6, 29);
            textBoxOutpunStart_LPS.Multiline = true;
            textBoxOutpunStart_LPS.Name = "textBoxOutpunStart_LPS";
            textBoxOutpunStart_LPS.ReadOnly = true;
            textBoxOutpunStart_LPS.Size = new Size(100, 16);
            textBoxOutpunStart_LPS.TabIndex = 0;
            textBoxOutpunStart_LPS.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutput_LPS);
            Controls.Add(groupBoxInput_LPS);
            Controls.Add(groupBoxTask_LPS);
            Controls.Add(buttonResult_LPS);
            Controls.Add(buttonHelp_LPS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 5 | Леушин П.С.";
            groupBoxTask_LPS.ResumeLayout(false);
            groupBoxTask_LPS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFarmula_LPS).EndInit();
            groupBoxInput_LPS.ResumeLayout(false);
            groupBoxInput_LPS.PerformLayout();
            groupBoxOutput_LPS.ResumeLayout(false);
            groupBoxOutput_LPS.PerformLayout();
            ResumeLayout(false);
        }

        private void textBoxInputEnd_LPS_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonHelp_LPS_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private TextBox textBoxOutpunStart_LPS;
    }
}