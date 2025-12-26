using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.LeushinP.Sprint6.Task4.V24.Lib;
namespace Tyuiu.LeushinP.Sprint6.Task4.V24

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            buttonDone_LPS = new Button();
            buttonSave_LPS = new Button();
            button2 = new Button();
            chartFunction_LPS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxStartStep_LPS = new TextBox();
            textBoxStopStep_LPS = new TextBox();
            groupBox_LPS = new GroupBox();
            panelTop_LPS = new Panel();
            buttonHelp_LPS = new Button();
            groupBoxTerm_LPS = new GroupBox();
            textBoxTerm_LPS = new TextBox();
            panelLeft_LPS = new Panel();
            groupBoxResult_LPS = new GroupBox();
            textBoxResult_LPS = new TextBox();
            panelRight_LPS = new Panel();
            ((System.ComponentModel.ISupportInitialize)chartFunction_LPS).BeginInit();
            groupBox_LPS.SuspendLayout();
            panelTop_LPS.SuspendLayout();
            groupBoxTerm_LPS.SuspendLayout();
            panelLeft_LPS.SuspendLayout();
            groupBoxResult_LPS.SuspendLayout();
            panelRight_LPS.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_LPS
            // 
            buttonDone_LPS.BackColor = Color.Green;
            buttonDone_LPS.Location = new Point(581, 22);
            buttonDone_LPS.Name = "buttonDone_LPS";
            buttonDone_LPS.Size = new Size(103, 58);
            buttonDone_LPS.TabIndex = 0;
            buttonDone_LPS.Text = "Выполнить";
            buttonDone_LPS.UseVisualStyleBackColor = false;
            buttonDone_LPS.Click += buttonDone_LPS_Click;
            // 
            // buttonSave_LPS
            // 
            buttonSave_LPS.BackColor = Color.Blue;
            buttonSave_LPS.Location = new Point(697, 22);
            buttonSave_LPS.Name = "buttonSave_LPS";
            buttonSave_LPS.Size = new Size(103, 58);
            buttonSave_LPS.TabIndex = 1;
            buttonSave_LPS.Text = "Сохранить";
            buttonSave_LPS.UseVisualStyleBackColor = false;
            buttonSave_LPS.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            // 
            // chartFunction_LPS
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction_LPS.ChartAreas.Add(chartArea2);
            chartFunction_LPS.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartFunction_LPS.Legends.Add(legend2);
            chartFunction_LPS.Location = new Point(5, 5);
            chartFunction_LPS.Name = "chartFunction_LPS";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction_LPS.Series.Add(series2);
            chartFunction_LPS.Size = new Size(658, 411);
            chartFunction_LPS.TabIndex = 3;
            chartFunction_LPS.Text = "chart1";
            title2.BackColor = Color.White;
            title2.BorderColor = Color.White;
            title2.ForeColor = Color.Blue;
            title2.Name = "TitleFunction_LPS";
            title2.Text = "График функции F(x)";
            chartFunction_LPS.Titles.Add(title2);
            // 
            // textBoxStartStep_LPS
            // 
            textBoxStartStep_LPS.Location = new Point(6, 26);
            textBoxStartStep_LPS.Name = "textBoxStartStep_LPS";
            textBoxStartStep_LPS.Size = new Size(125, 27);
            textBoxStartStep_LPS.TabIndex = 4;
            textBoxStartStep_LPS.Text = "-5";
            // 
            // textBoxStopStep_LPS
            // 
            textBoxStopStep_LPS.Location = new Point(147, 26);
            textBoxStopStep_LPS.Name = "textBoxStopStep_LPS";
            textBoxStopStep_LPS.Size = new Size(125, 27);
            textBoxStopStep_LPS.TabIndex = 5;
            textBoxStopStep_LPS.Text = "5";
            // 
            // groupBox_LPS
            // 
            groupBox_LPS.Controls.Add(textBoxStartStep_LPS);
            groupBox_LPS.Controls.Add(textBoxStopStep_LPS);
            groupBox_LPS.Location = new Point(284, 12);
            groupBox_LPS.Name = "groupBox_LPS";
            groupBox_LPS.Size = new Size(278, 70);
            groupBox_LPS.TabIndex = 7;
            groupBox_LPS.TabStop = false;
            groupBox_LPS.Text = "Ввод данных";
            // 
            // panelTop_LPS
            // 
            panelTop_LPS.Controls.Add(buttonHelp_LPS);
            panelTop_LPS.Controls.Add(groupBoxTerm_LPS);
            panelTop_LPS.Controls.Add(groupBox_LPS);
            panelTop_LPS.Controls.Add(buttonDone_LPS);
            panelTop_LPS.Controls.Add(button2);
            panelTop_LPS.Controls.Add(buttonSave_LPS);
            panelTop_LPS.Dock = DockStyle.Top;
            panelTop_LPS.Location = new Point(0, 0);
            panelTop_LPS.Name = "panelTop_LPS";
            panelTop_LPS.Size = new Size(912, 93);
            panelTop_LPS.TabIndex = 8;
            // 
            // buttonHelp_LPS
            // 
            buttonHelp_LPS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_LPS.BackColor = Color.Blue;
            buttonHelp_LPS.Location = new Point(808, 22);
            buttonHelp_LPS.Name = "buttonHelp_LPS";
            buttonHelp_LPS.Size = new Size(101, 58);
            buttonHelp_LPS.TabIndex = 10;
            buttonHelp_LPS.Text = "Справка";
            buttonHelp_LPS.UseVisualStyleBackColor = false;
            buttonHelp_LPS.Click += buttonHelp_LPS_Click_1;
            // 
            // groupBoxTerm_LPS
            // 
            groupBoxTerm_LPS.Controls.Add(textBoxTerm_LPS);
            groupBoxTerm_LPS.Dock = DockStyle.Left;
            groupBoxTerm_LPS.Location = new Point(0, 0);
            groupBoxTerm_LPS.Name = "groupBoxTerm_LPS";
            groupBoxTerm_LPS.Size = new Size(247, 93);
            groupBoxTerm_LPS.TabIndex = 10;
            groupBoxTerm_LPS.TabStop = false;
            groupBoxTerm_LPS.Text = "Условие";
            // 
            // textBoxTerm_LPS
            // 
            textBoxTerm_LPS.Dock = DockStyle.Fill;
            textBoxTerm_LPS.Location = new Point(3, 23);
            textBoxTerm_LPS.Multiline = true;
            textBoxTerm_LPS.Name = "textBoxTerm_LPS";
            textBoxTerm_LPS.ScrollBars = ScrollBars.Vertical;
            textBoxTerm_LPS.Size = new Size(241, 67);
            textBoxTerm_LPS.TabIndex = 0;
            textBoxTerm_LPS.Text = "Протабулировать функцию F(x) на заданном диапазоне от -5 до 5.\r\nРезультат вывести в textBox, построить график функции и сохранить в файл\r\nOutPutFileTask4V24.txt по нажатию кнопки.";
            // 
            // panelLeft_LPS
            // 
            panelLeft_LPS.Controls.Add(groupBoxResult_LPS);
            panelLeft_LPS.Dock = DockStyle.Left;
            panelLeft_LPS.Location = new Point(0, 93);
            panelLeft_LPS.Name = "panelLeft_LPS";
            panelLeft_LPS.Size = new Size(229, 421);
            panelLeft_LPS.TabIndex = 9;
            // 
            // groupBoxResult_LPS
            // 
            groupBoxResult_LPS.Controls.Add(textBoxResult_LPS);
            groupBoxResult_LPS.Dock = DockStyle.Fill;
            groupBoxResult_LPS.Location = new Point(0, 0);
            groupBoxResult_LPS.Name = "groupBoxResult_LPS";
            groupBoxResult_LPS.Padding = new Padding(5);
            groupBoxResult_LPS.Size = new Size(229, 421);
            groupBoxResult_LPS.TabIndex = 0;
            groupBoxResult_LPS.TabStop = false;
            groupBoxResult_LPS.Text = "Вывод данных";
            // 
            // textBoxResult_LPS
            // 
            textBoxResult_LPS.Dock = DockStyle.Fill;
            textBoxResult_LPS.Location = new Point(5, 25);
            textBoxResult_LPS.Multiline = true;
            textBoxResult_LPS.Name = "textBoxResult_LPS";
            textBoxResult_LPS.Size = new Size(219, 391);
            textBoxResult_LPS.TabIndex = 0;
            // 
            // panelRight_LPS
            // 
            panelRight_LPS.Controls.Add(chartFunction_LPS);
            panelRight_LPS.Dock = DockStyle.Right;
            panelRight_LPS.Location = new Point(244, 93);
            panelRight_LPS.Name = "panelRight_LPS";
            panelRight_LPS.Padding = new Padding(5);
            panelRight_LPS.Size = new Size(668, 421);
            panelRight_LPS.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 514);
            Controls.Add(panelRight_LPS);
            Controls.Add(panelLeft_LPS);
            Controls.Add(panelTop_LPS);
            MaximumSize = new Size(930, 561);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 24 | Леушин П.С.";
            ((System.ComponentModel.ISupportInitialize)chartFunction_LPS).EndInit();
            groupBox_LPS.ResumeLayout(false);
            groupBox_LPS.PerformLayout();
            panelTop_LPS.ResumeLayout(false);
            groupBoxTerm_LPS.ResumeLayout(false);
            groupBoxTerm_LPS.PerformLayout();
            panelLeft_LPS.ResumeLayout(false);
            groupBoxResult_LPS.ResumeLayout(false);
            groupBoxResult_LPS.PerformLayout();
            panelRight_LPS.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_LPS;
        private Button buttonSave_LPS;
        private Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_LPS;
        private TextBox textBoxStartStep_LPS;
        private TextBox textBoxStopStep_LPS;
        private GroupBox groupBox_LPS;
        private Panel panelTop_LPS;
        private Panel panelLeft_LPS;
        private GroupBox groupBoxResult_LPS;
        private Panel panelRight_LPS;
        private GroupBox groupBoxTerm_LPS;
        private TextBox textBoxTerm_LPS;
        private TextBox textBoxResult_LPS;
        private Button buttonHelp_LPS;
    }
}