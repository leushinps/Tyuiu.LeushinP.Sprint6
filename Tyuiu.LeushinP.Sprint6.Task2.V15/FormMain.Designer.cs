using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.LeushinP.Sprint6.Task2.V15.Lib;

namespace Tyuiu.LeushinP.Sprint6.Task2.V15
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
            this.dataGridViewResult_LPS = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDown_LPS = new System.Windows.Forms.Button();
            this.buttonQuestion_LPS = new System.Windows.Forms.Button();
            this.textBoxSV_LPS = new System.Windows.Forms.TextBox();
            this.textBoxStV_LPS = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_LPS = new System.Windows.Forms.TextBox();
            this.textBoxStopValue_LPS = new System.Windows.Forms.TextBox();
            this.textBoxCondition_LPS = new System.Windows.Forms.TextBox();
            this.textBoxCond_LPS = new System.Windows.Forms.TextBox();
            this.textBoxRes_LPS = new System.Windows.Forms.TextBox();
            this.textBoxInPut_LPS = new System.Windows.Forms.TextBox();
            this.textBoxOutPut_LPS = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_LPS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_LPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_LPS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResult_LPS
            // 
            this.dataGridViewResult_LPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_LPS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.fx});
            this.dataGridViewResult_LPS.Location = new System.Drawing.Point(611, 30);
            this.dataGridViewResult_LPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewResult_LPS.Name = "dataGridViewResult_LPS";
            this.dataGridViewResult_LPS.ReadOnly = true;
            this.dataGridViewResult_LPS.RowHeadersVisible = false;
            this.dataGridViewResult_LPS.RowHeadersWidth = 51;
            this.dataGridViewResult_LPS.Size = new System.Drawing.Size(177, 321);
            this.dataGridViewResult_LPS.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // fx
            // 
            this.fx.HeaderText = "f(x)";
            this.fx.MinimumWidth = 6;
            this.fx.Name = "fx";
            this.fx.ReadOnly = true;
            this.fx.Width = 125;
            // 
            // buttonDown_LPS
            // 
            this.buttonDown_LPS.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDown_LPS.Location = new System.Drawing.Point(408, 266);
            this.buttonDown_LPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDown_LPS.Name = "buttonDown_LPS";
            this.buttonDown_LPS.Size = new System.Drawing.Size(197, 84);
            this.buttonDown_LPS.TabIndex = 1;
            this.buttonDown_LPS.Text = "Вычислить";
            this.buttonDown_LPS.UseVisualStyleBackColor = false;
            // 
            // buttonQuestion_LPS
            // 
            this.buttonQuestion_LPS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonQuestion_LPS.Location = new System.Drawing.Point(319, 294);
            this.buttonQuestion_LPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuestion_LPS.Name = "buttonQuestion_LPS";
            this.buttonQuestion_LPS.Size = new System.Drawing.Size(83, 56);
            this.buttonQuestion_LPS.TabIndex = 2;
            this.buttonQuestion_LPS.Text = "Справка";
            this.buttonQuestion_LPS.UseVisualStyleBackColor = false;
            // 
            // textBoxSV_LPS
            // 
            this.textBoxSV_LPS.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSV_LPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSV_LPS.Location = new System.Drawing.Point(12, 298);
            this.textBoxSV_LPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSV_LPS.Name = "textBoxSV_LPS";
            this.textBoxSV_LPS.ReadOnly = true;
            this.textBoxSV_LPS.Size = new System.Drawing.Size(125, 15);
            this.textBoxSV_LPS.TabIndex = 3;
            this.textBoxSV_LPS.Text = "Начало шага:";
            // 
            // textBoxStV_LPS
            // 
            this.textBoxStV_LPS.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxStV_LPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStV_LPS.Location = new System.Drawing.Point(159, 298);
            this.textBoxStV_LPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStV_LPS.Name = "textBoxStV_LPS";
            this.textBoxStV_LPS.ReadOnly = true;
            this.textBoxStV_LPS.Size = new System.Drawing.Size(125, 15);
            this.textBoxStV_LPS.TabIndex = 4;
            this.textBoxStV_LPS.Text = "Конец шага:";
            // 
            // textBoxStartValue_LPS
            // 
            this.textBoxStartValue_LPS.Location = new System.Drawing.Point(12, 329);
            this.textBoxStartValue_LPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStartValue_LPS.Name = "textBoxStartValue_LPS";
            this.textBoxStartValue_LPS.Size = new System.Drawing.Size(125, 22);
            this.textBoxStartValue_LPS.TabIndex = 5;
            // 
            // textBoxStopValue_LPS
            // 
            this.textBoxStopValue_LPS.Location = new System.Drawing.Point(159, 329);
            this.textBoxStopValue_LPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStopValue_LPS.Name = "textBoxStopValue_LPS";
            this.textBoxStopValue_LPS.Size = new System.Drawing.Size(125, 22);
            this.textBoxStopValue_LPS.TabIndex = 6;
            // 
            // textBoxCondition_LPS
            // 
            this.textBoxCondition_LPS.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCondition_LPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_LPS.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCondition_LPS.Location = new System.Drawing.Point(12, 30);
            this.textBoxCondition_LPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCondition_LPS.Multiline = true;
            this.textBoxCondition_LPS.Name = "textBoxCondition_LPS";
            this.textBoxCondition_LPS.ReadOnly = true;
            this.textBoxCondition_LPS.Size = new System.Drawing.Size(404, 207);
            this.textBoxCondition_LPS.TabIndex = 7;
            this.textBoxCondition_LPS.Text = "Написать программу, которая выводит таблицу значений функции на заданном диапазон" +
    "е:";
            // 
            // textBoxCond_LPS
            // 
            this.textBoxCond_LPS.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCond_LPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCond_LPS.Location = new System.Drawing.Point(12, 9);
            this.textBoxCond_LPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCond_LPS.Name = "textBoxCond_LPS";
            this.textBoxCond_LPS.ReadOnly = true;
            this.textBoxCond_LPS.Size = new System.Drawing.Size(183, 15);
            this.textBoxCond_LPS.TabIndex = 8;
            this.textBoxCond_LPS.Text = "Условие";
            // 
            // textBoxRes_LPS
            // 
            this.textBoxRes_LPS.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxRes_LPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRes_LPS.Location = new System.Drawing.Point(611, 6);
            this.textBoxRes_LPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRes_LPS.Name = "textBoxRes_LPS";
            this.textBoxRes_LPS.ReadOnly = true;
            this.textBoxRes_LPS.Size = new System.Drawing.Size(177, 15);
            this.textBoxRes_LPS.TabIndex = 9;
            this.textBoxRes_LPS.Text = "Результат";
            // 
            // textBoxInPut_LPS
            // 
            this.textBoxInPut_LPS.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInPut_LPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInPut_LPS.Location = new System.Drawing.Point(12, 249);
            this.textBoxInPut_LPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInPut_LPS.Name = "textBoxInPut_LPS";
            this.textBoxInPut_LPS.ReadOnly = true;
            this.textBoxInPut_LPS.Size = new System.Drawing.Size(125, 15);
            this.textBoxInPut_LPS.TabIndex = 10;
            this.textBoxInPut_LPS.Text = "Ввод данных:";
            // 
            // textBoxOutPut_LPS
            // 
            this.textBoxOutPut_LPS.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOutPut_LPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutPut_LPS.Location = new System.Drawing.Point(480, 6);
            this.textBoxOutPut_LPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOutPut_LPS.Name = "textBoxOutPut_LPS";
            this.textBoxOutPut_LPS.ReadOnly = true;
            this.textBoxOutPut_LPS.Size = new System.Drawing.Size(125, 15);
            this.textBoxOutPut_LPS.TabIndex = 11;
            this.textBoxOutPut_LPS.Text = "Вывод данных:";
            // 
            // pictureBoxFormula_LPS
            // 
            this.pictureBoxFormula_LPS.Location = new System.Drawing.Point(12, 93);
            this.pictureBoxFormula_LPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFormula_LPS.Name = "pictureBoxFormula_LPS";
            this.pictureBoxFormula_LPS.Size = new System.Drawing.Size(358, 38);
            this.pictureBoxFormula_LPS.TabIndex = 12;
            this.pictureBoxFormula_LPS.TabStop = false;
            this.pictureBoxFormula_LPS.Click += new System.EventHandler(this.pictureBoxFormula_LPS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.pictureBoxFormula_LPS);
            this.Controls.Add(this.textBoxOutPut_LPS);
            this.Controls.Add(this.textBoxInPut_LPS);
            this.Controls.Add(this.textBoxRes_LPS);
            this.Controls.Add(this.textBoxCond_LPS);
            this.Controls.Add(this.textBoxCondition_LPS);
            this.Controls.Add(this.textBoxStopValue_LPS);
            this.Controls.Add(this.textBoxStartValue_LPS);
            this.Controls.Add(this.textBoxStV_LPS);
            this.Controls.Add(this.textBoxSV_LPS);
            this.Controls.Add(this.buttonQuestion_LPS);
            this.Controls.Add(this.buttonDown_LPS);
            this.Controls.Add(this.dataGridViewResult_LPS);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 15 | Леушин П.С";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_LPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_LPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonDown_LPS_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonQuestion_LPS_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridViewResult_LPS;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn fx;
        private Button buttonDown_LPS;
        private Button buttonQuestion_LPS;
        private TextBox textBoxSV_LPS;
        private TextBox textBoxStV_LPS;
        private TextBox textBoxStartValue_LPS;
        private TextBox textBoxStopValue_LPS;
        private TextBox textBoxCondition_LPS;
        private TextBox textBoxCond_LPS;
        private TextBox textBoxRes_LPS;
        private TextBox textBoxInPut_LPS;
        private TextBox textBoxOutPut_LPS;
        private PictureBox pictureBoxFormula_LPS;
    }
}