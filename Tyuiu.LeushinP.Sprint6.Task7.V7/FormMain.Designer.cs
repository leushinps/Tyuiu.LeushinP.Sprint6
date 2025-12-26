namespace Tyuiu.LeushinP.Sprint6.Task7.V7
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_LPS = new System.Windows.Forms.Panel();
            this.buttonHelp_LPS = new System.Windows.Forms.Button();
            this.buttonSaveFile_LPS = new System.Windows.Forms.Button();
            this.buttonDone_LPS = new System.Windows.Forms.Button();
            this.buttonOpenFile_LPS = new System.Windows.Forms.Button();
            this.panelCondition_LPS = new System.Windows.Forms.Panel();
            this.groupBoxCondition_LPS = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelInPut_LPS = new System.Windows.Forms.Panel();
            this.groupBoxInPut_LPS = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_LPS = new System.Windows.Forms.DataGridView();
            this.splitterInPut_LPS = new System.Windows.Forms.Splitter();
            this.panelOutPut_LPS = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_LPS = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_LPS = new System.Windows.Forms.DataGridView();
            this.splitterOutPut_LPS = new System.Windows.Forms.Splitter();
            this.toolTipButton_LPS = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_LPS = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTask7_LPS = new System.Windows.Forms.OpenFileDialog();
            this.panelButtons_LPS.SuspendLayout();
            this.panelCondition_LPS.SuspendLayout();
            this.groupBoxCondition_LPS.SuspendLayout();
            this.panelInPut_LPS.SuspendLayout();
            this.groupBoxInPut_LPS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_LPS)).BeginInit();
            this.panelOutPut_LPS.SuspendLayout();
            this.groupBoxOutPut_LPS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_LPS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_LPS
            // 
            this.panelButtons_LPS.BackColor = System.Drawing.Color.White;
            this.panelButtons_LPS.Controls.Add(this.buttonHelp_LPS);
            this.panelButtons_LPS.Controls.Add(this.buttonSaveFile_LPS);
            this.panelButtons_LPS.Controls.Add(this.buttonDone_LPS);
            this.panelButtons_LPS.Controls.Add(this.buttonOpenFile_LPS);
            this.panelButtons_LPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_LPS.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_LPS.Name = "panelButtons_LPS";
            this.panelButtons_LPS.Size = new System.Drawing.Size(1061, 94);
            this.panelButtons_LPS.TabIndex = 4;
            // 
            // buttonHelp_LPS
            // 
            this.buttonHelp_LPS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_LPS.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_LPS.Image")));
            this.buttonHelp_LPS.Location = new System.Drawing.Point(965, 12);
            this.buttonHelp_LPS.Name = "buttonHelp_LPS";
            this.buttonHelp_LPS.Size = new System.Drawing.Size(84, 76);
            this.buttonHelp_LPS.TabIndex = 3;
            this.toolTipButton_LPS.SetToolTip(this.buttonHelp_LPS, " О программе");
            this.buttonHelp_LPS.UseVisualStyleBackColor = true;
            this.buttonHelp_LPS.Click += new System.EventHandler(this.buttonHelp_LPS_Click);
            this.buttonHelp_LPS.MouseEnter += new System.EventHandler(this.buttonHelp_LPS_MouseEnter);
            // 
            // buttonSaveFile_LPS
            // 
            this.buttonSaveFile_LPS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveFile_LPS.Enabled = false;
            this.buttonSaveFile_LPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_LPS.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_LPS.Image")));
            this.buttonSaveFile_LPS.Location = new System.Drawing.Point(212, 12);
            this.buttonSaveFile_LPS.Name = "buttonSaveFile_LPS";
            this.buttonSaveFile_LPS.Size = new System.Drawing.Size(83, 76);
            this.buttonSaveFile_LPS.TabIndex = 2;
            this.toolTipButton_LPS.SetToolTip(this.buttonSaveFile_LPS, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSaveFile_LPS.UseVisualStyleBackColor = true;
            this.buttonSaveFile_LPS.Click += new System.EventHandler(this.buttonSaveFile_LPS_Click);
            this.buttonSaveFile_LPS.MouseEnter += new System.EventHandler(this.buttonSaveFile_LPS_MouseEnter);
            // 
            // buttonDone_LPS
            // 
            this.buttonDone_LPS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_LPS.Enabled = false;
            this.buttonDone_LPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_LPS.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_LPS.Image")));
            this.buttonDone_LPS.Location = new System.Drawing.Point(110, 12);
            this.buttonDone_LPS.Name = "buttonDone_LPS";
            this.buttonDone_LPS.Size = new System.Drawing.Size(86, 76);
            this.buttonDone_LPS.TabIndex = 1;
            this.toolTipButton_LPS.SetToolTip(this.buttonDone_LPS, "Выполнить обработку данных");
            this.buttonDone_LPS.UseVisualStyleBackColor = true;
            this.buttonDone_LPS.Click += new System.EventHandler(this.buttonDone_LPS_Click);
            this.buttonDone_LPS.MouseEnter += new System.EventHandler(this.buttonDone_LPS_MouseEnter);
            // 
            // buttonOpenFile_LPS
            // 
            this.buttonOpenFile_LPS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_LPS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_LPS.Image")));
            this.buttonOpenFile_LPS.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_LPS.Name = "buttonOpenFile_LPS";
            this.buttonOpenFile_LPS.Size = new System.Drawing.Size(83, 76);
            this.buttonOpenFile_LPS.TabIndex = 0;
            this.toolTipButton_LPS.SetToolTip(this.buttonOpenFile_LPS, "Открыть файл для обработки данных в формат СSV\r\n");
            this.buttonOpenFile_LPS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_LPS.Click += new System.EventHandler(this.buttonOpenFile_LPS_Click);
            this.buttonOpenFile_LPS.MouseEnter += new System.EventHandler(this.buttonOpenFile_LPS_MouseEnter);
            // 
            // panelCondition_LPS
            // 
            this.panelCondition_LPS.BackColor = System.Drawing.Color.White;
            this.panelCondition_LPS.Controls.Add(this.groupBoxCondition_LPS);
            this.panelCondition_LPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_LPS.Location = new System.Drawing.Point(0, 94);
            this.panelCondition_LPS.Name = "panelCondition_LPS";
            this.panelCondition_LPS.Size = new System.Drawing.Size(1061, 78);
            this.panelCondition_LPS.TabIndex = 5;
            // 
            // groupBoxCondition_LPS
            // 
            this.groupBoxCondition_LPS.Controls.Add(this.textBox1);
            this.groupBoxCondition_LPS.Location = new System.Drawing.Point(3, 7);
            this.groupBoxCondition_LPS.Name = "groupBoxCondition_LPS";
            this.groupBoxCondition_LPS.Size = new System.Drawing.Size(1055, 89);
            this.groupBoxCondition_LPS.TabIndex = 0;
            this.groupBoxCondition_LPS.TabStop = false;
            this.groupBoxCondition_LPS.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1055, 57);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelInPut_LPS
            // 
            this.panelInPut_LPS.BackColor = System.Drawing.Color.White;
            this.panelInPut_LPS.Controls.Add(this.groupBoxInPut_LPS);
            this.panelInPut_LPS.Controls.Add(this.splitterInPut_LPS);
            this.panelInPut_LPS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_LPS.Location = new System.Drawing.Point(0, 172);
            this.panelInPut_LPS.Name = "panelInPut_LPS";
            this.panelInPut_LPS.Size = new System.Drawing.Size(522, 449);
            this.panelInPut_LPS.TabIndex = 6;
            // 
            // groupBoxInPut_LPS
            // 
            this.groupBoxInPut_LPS.Controls.Add(this.dataGridViewInPut_LPS);
            this.groupBoxInPut_LPS.Location = new System.Drawing.Point(3, 6);
            this.groupBoxInPut_LPS.Name = "groupBoxInPut_LPS";
            this.groupBoxInPut_LPS.Size = new System.Drawing.Size(519, 440);
            this.groupBoxInPut_LPS.TabIndex = 1;
            this.groupBoxInPut_LPS.TabStop = false;
            this.groupBoxInPut_LPS.Text = "Ввод:";
            // 
            // dataGridViewInPut_LPS
            // 
            this.dataGridViewInPut_LPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_LPS.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewInPut_LPS.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewInPut_LPS.Name = "dataGridViewInPut_LPS";
            this.dataGridViewInPut_LPS.RowHeadersWidth = 51;
            this.dataGridViewInPut_LPS.RowTemplate.Height = 24;
            this.dataGridViewInPut_LPS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewInPut_LPS.Size = new System.Drawing.Size(513, 419);
            this.dataGridViewInPut_LPS.TabIndex = 0;
            // 
            // splitterInPut_LPS
            // 
            this.splitterInPut_LPS.Location = new System.Drawing.Point(0, 0);
            this.splitterInPut_LPS.Name = "splitterInPut_LPS";
            this.splitterInPut_LPS.Size = new System.Drawing.Size(3, 449);
            this.splitterInPut_LPS.TabIndex = 0;
            this.splitterInPut_LPS.TabStop = false;
            // 
            // panelOutPut_LPS
            // 
            this.panelOutPut_LPS.BackColor = System.Drawing.Color.White;
            this.panelOutPut_LPS.Controls.Add(this.groupBoxOutPut_LPS);
            this.panelOutPut_LPS.Controls.Add(this.splitterOutPut_LPS);
            this.panelOutPut_LPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_LPS.Location = new System.Drawing.Point(522, 172);
            this.panelOutPut_LPS.Name = "panelOutPut_LPS";
            this.panelOutPut_LPS.Size = new System.Drawing.Size(539, 449);
            this.panelOutPut_LPS.TabIndex = 7;
            // 
            // groupBoxOutPut_LPS
            // 
            this.groupBoxOutPut_LPS.Controls.Add(this.dataGridViewOutPut_LPS);
            this.groupBoxOutPut_LPS.Location = new System.Drawing.Point(6, 6);
            this.groupBoxOutPut_LPS.Name = "groupBoxOutPut_LPS";
            this.groupBoxOutPut_LPS.Size = new System.Drawing.Size(530, 440);
            this.groupBoxOutPut_LPS.TabIndex = 1;
            this.groupBoxOutPut_LPS.TabStop = false;
            this.groupBoxOutPut_LPS.Text = "Вывод:";
            // 
            // dataGridViewOutPut_LPS
            // 
            this.dataGridViewOutPut_LPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_LPS.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewOutPut_LPS.Location = new System.Drawing.Point(0, 18);
            this.dataGridViewOutPut_LPS.Name = "dataGridViewOutPut_LPS";
            this.dataGridViewOutPut_LPS.RowHeadersWidth = 51;
            this.dataGridViewOutPut_LPS.RowTemplate.Height = 24;
            this.dataGridViewOutPut_LPS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutPut_LPS.Size = new System.Drawing.Size(527, 419);
            this.dataGridViewOutPut_LPS.TabIndex = 0;
            // 
            // splitterOutPut_LPS
            // 
            this.splitterOutPut_LPS.Location = new System.Drawing.Point(0, 0);
            this.splitterOutPut_LPS.Name = "splitterOutPut_LPS";
            this.splitterOutPut_LPS.Size = new System.Drawing.Size(3, 449);
            this.splitterOutPut_LPS.TabIndex = 0;
            this.splitterOutPut_LPS.TabStop = false;
            // 
            // toolTipButton_LPS
            // 
            this.toolTipButton_LPS.IsBalloon = true;
            this.toolTipButton_LPS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // openFileDialogTask7_LPS
            // 
            this.openFileDialogTask7_LPS.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 621);
            this.Controls.Add(this.panelOutPut_LPS);
            this.Controls.Add(this.panelInPut_LPS);
            this.Controls.Add(this.panelCondition_LPS);
            this.Controls.Add(this.panelButtons_LPS);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 7 | Леушин П.С.";
            this.panelButtons_LPS.ResumeLayout(false);
            this.panelCondition_LPS.ResumeLayout(false);
            this.groupBoxCondition_LPS.ResumeLayout(false);
            this.groupBoxCondition_LPS.PerformLayout();
            this.panelInPut_LPS.ResumeLayout(false);
            this.groupBoxInPut_LPS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_LPS)).EndInit();
            this.panelOutPut_LPS.ResumeLayout(false);
            this.groupBoxOutPut_LPS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_LPS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_LPS;
        private System.Windows.Forms.Panel panelCondition_LPS;
        private System.Windows.Forms.Panel panelInPut_LPS;
        private System.Windows.Forms.Panel panelOutPut_LPS;
        private System.Windows.Forms.Button buttonOpenFile_LPS;
        private System.Windows.Forms.Button buttonSaveFile_LPS;
        private System.Windows.Forms.Button buttonDone_LPS;
        private System.Windows.Forms.Button buttonHelp_LPS;
        private System.Windows.Forms.GroupBox groupBoxCondition_LPS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxInPut_LPS;
        private System.Windows.Forms.DataGridView dataGridViewInPut_LPS;
        private System.Windows.Forms.Splitter splitterInPut_LPS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_LPS;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_LPS;
        private System.Windows.Forms.Splitter splitterOutPut_LPS;
        private System.Windows.Forms.ToolTip toolTipButton_LPS;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_LPS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask7_LPS;
    }
}