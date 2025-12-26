

using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.LeushinP.Sprint6.Task5.V14.Lib;

namespace Tyuiu.LeushinP.Sprint6.Task5.V14
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
            this.panelTop_LPS = new System.Windows.Forms.Panel();
            this.panelLeft_LPS = new System.Windows.Forms.Panel();
            this.panelFill_LPS = new System.Windows.Forms.Panel();
            this.groupBoxUsl_LPS = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOpen_LPS = new System.Windows.Forms.Button();
            this.buttonInfo_LPS = new System.Windows.Forms.Button();
            this.buttonDone_LPS = new System.Windows.Forms.Button();
            this.groupBoxInPut_LPS = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_LPS = new System.Windows.Forms.DataGridView();
            this.chartInPut_LPS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_LPS.SuspendLayout();
            this.panelLeft_LPS.SuspendLayout();
            this.panelFill_LPS.SuspendLayout();
            this.groupBoxUsl_LPS.SuspendLayout();
            this.groupBoxInPut_LPS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_LPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInPut_LPS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_LPS
            // 
            this.panelTop_LPS.Controls.Add(this.buttonInfo_LPS);
            this.panelTop_LPS.Controls.Add(this.buttonDone_LPS);
            this.panelTop_LPS.Controls.Add(this.buttonOpen_LPS);
            this.panelTop_LPS.Controls.Add(this.groupBoxUsl_LPS);
            this.panelTop_LPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_LPS.Location = new System.Drawing.Point(0, 0);
            this.panelTop_LPS.Name = "panelTop_LPS";
            this.panelTop_LPS.Size = new System.Drawing.Size(872, 116);
            this.panelTop_LPS.TabIndex = 0;
            // 
            // panelLeft_LPS
            // 
            this.panelLeft_LPS.Controls.Add(this.groupBoxInPut_LPS);
            this.panelLeft_LPS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_LPS.Location = new System.Drawing.Point(0, 116);
            this.panelLeft_LPS.Name = "panelLeft_LPS";
            this.panelLeft_LPS.Size = new System.Drawing.Size(201, 412);
            this.panelLeft_LPS.TabIndex = 1;
            // 
            // panelFill_LPS
            // 
            this.panelFill_LPS.Controls.Add(this.chartInPut_LPS);
            this.panelFill_LPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_LPS.Location = new System.Drawing.Point(201, 116);
            this.panelFill_LPS.Name = "panelFill_LPS";
            this.panelFill_LPS.Size = new System.Drawing.Size(671, 412);
            this.panelFill_LPS.TabIndex = 2;
            // 
            // groupBoxUsl_LPS
            // 
            this.groupBoxUsl_LPS.Controls.Add(this.textBox1);
            this.groupBoxUsl_LPS.Location = new System.Drawing.Point(4, 4);
            this.groupBoxUsl_LPS.Name = "groupBoxUsl_LPS";
            this.groupBoxUsl_LPS.Size = new System.Drawing.Size(473, 101);
            this.groupBoxUsl_LPS.TabIndex = 0;
            this.groupBoxUsl_LPS.TabStop = false;
            this.groupBoxUsl_LPS.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(458, 73);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла InPutFileTask5V14.txt. Вывести в datagridView числа, бо" +
        "льше или равные 10. Построить диаграмму по этим значениям.";
            // 
            // buttonOpen_LPS
            // 
            this.buttonOpen_LPS.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonOpen_LPS.Location = new System.Drawing.Point(615, 12);
            this.buttonOpen_LPS.Name = "buttonOpen_LPS";
            this.buttonOpen_LPS.Size = new System.Drawing.Size(113, 92);
            this.buttonOpen_LPS.TabIndex = 2;
            this.buttonOpen_LPS.Text = "Открыть файл";
            this.buttonOpen_LPS.UseVisualStyleBackColor = false;
            this.buttonOpen_LPS.Click += new System.EventHandler(this.buttonOpen_LPS_Click);
            // 
            // buttonInfo_LPS
            // 
            this.buttonInfo_LPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_LPS.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonInfo_LPS.Location = new System.Drawing.Point(747, 12);
            this.buttonInfo_LPS.Name = "buttonInfo_LPS";
            this.buttonInfo_LPS.Size = new System.Drawing.Size(113, 92);
            this.buttonInfo_LPS.TabIndex = 2;
            this.buttonInfo_LPS.Text = "Справка";
            this.buttonInfo_LPS.UseVisualStyleBackColor = false;
            this.buttonInfo_LPS.Click += new System.EventHandler(this.buttonInfo_LPS_Click);
            // 
            // buttonDone_LPS
            // 
            this.buttonDone_LPS.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonDone_LPS.Location = new System.Drawing.Point(496, 12);
            this.buttonDone_LPS.Name = "buttonDone_LPS";
            this.buttonDone_LPS.Size = new System.Drawing.Size(113, 92);
            this.buttonDone_LPS.TabIndex = 2;
            this.buttonDone_LPS.Text = "Выполнить";
            this.buttonDone_LPS.UseVisualStyleBackColor = false;
            this.buttonDone_LPS.Click += new System.EventHandler(this.buttonDone_LPS_Click);
            // 
            // groupBoxInPut_LPS
            // 
            this.groupBoxInPut_LPS.Controls.Add(this.dataGridViewInPut_LPS);
            this.groupBoxInPut_LPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_LPS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_LPS.Name = "groupBoxInPut_LPS";
            this.groupBoxInPut_LPS.Size = new System.Drawing.Size(201, 412);
            this.groupBoxInPut_LPS.TabIndex = 0;
            this.groupBoxInPut_LPS.TabStop = false;
            this.groupBoxInPut_LPS.Text = "Вывод данных";
            // 
            // dataGridViewInPut_LPS
            // 
            this.dataGridViewInPut_LPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_LPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_LPS.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewInPut_LPS.Name = "dataGridViewInPut_LPS";
            this.dataGridViewInPut_LPS.RowHeadersWidth = 51;
            this.dataGridViewInPut_LPS.RowTemplate.Height = 24;
            this.dataGridViewInPut_LPS.Size = new System.Drawing.Size(195, 391);
            this.dataGridViewInPut_LPS.TabIndex = 0;
            // 
            // chartInPut_LPS
            // 
            chartArea2.Name = "ChartArea1";
            this.chartInPut_LPS.ChartAreas.Add(chartArea2);
            this.chartInPut_LPS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartInPut_LPS.Legends.Add(legend2);
            this.chartInPut_LPS.Location = new System.Drawing.Point(0, 0);
            this.chartInPut_LPS.Name = "chartInPut_LPS";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartInPut_LPS.Series.Add(series2);
            this.chartInPut_LPS.Size = new System.Drawing.Size(671, 412);
            this.chartInPut_LPS.TabIndex = 0;
            this.chartInPut_LPS.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 528);
            this.Controls.Add(this.panelFill_LPS);
            this.Controls.Add(this.panelLeft_LPS);
            this.Controls.Add(this.panelTop_LPS);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Таск 5  | Вариант 14  | Леушин П.С.";
            this.panelTop_LPS.ResumeLayout(false);
            this.panelLeft_LPS.ResumeLayout(false);
            this.panelFill_LPS.ResumeLayout(false);
            this.groupBoxUsl_LPS.ResumeLayout(false);
            this.groupBoxUsl_LPS.PerformLayout();
            this.groupBoxInPut_LPS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_LPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInPut_LPS)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop_LPS;
        private System.Windows.Forms.Button buttonInfo_LPS;
        private System.Windows.Forms.Button buttonDone_LPS;
        private System.Windows.Forms.Button buttonOpen_LPS;
        private System.Windows.Forms.GroupBox groupBoxUsl_LPS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelLeft_LPS;
        private System.Windows.Forms.GroupBox groupBoxInPut_LPS;
        private System.Windows.Forms.DataGridView dataGridViewInPut_LPS;
        private System.Windows.Forms.Panel panelFill_LPS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInPut_LPS;
    }
}