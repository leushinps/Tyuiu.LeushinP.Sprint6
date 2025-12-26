
namespace Tyuiu.LeushinP.Sprint6.Task6.V17
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
            this.buttonInfo_LPS = new System.Windows.Forms.Button();
            this.buttonDone_LPS = new System.Windows.Forms.Button();
            this.buttonOpenFile_LPS = new System.Windows.Forms.Button();
            this.panelTask_LPS = new System.Windows.Forms.Panel();
            this.groupBoxTask_LPS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_LPS = new System.Windows.Forms.TextBox();
            this.panelLoadFromFile_LPS = new System.Windows.Forms.Panel();
            this.groupBoxLoadFile_LPS = new System.Windows.Forms.GroupBox();
            this.textBoxLoadFile_LPS = new System.Windows.Forms.TextBox();
            this.panelResult_LPS = new System.Windows.Forms.Panel();
            this.groupBoxResult_LPS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_LPS = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_LPS = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButtons_LPS = new System.Windows.Forms.ToolTip(this.components);
            this.splitterBetweenInputAndOutput_LPS = new System.Windows.Forms.Splitter();
            this.panelButtons_LPS.SuspendLayout();
            this.panelTask_LPS.SuspendLayout();
            this.groupBoxTask_LPS.SuspendLayout();
            this.panelLoadFromFile_LPS.SuspendLayout();
            this.groupBoxLoadFile_LPS.SuspendLayout();
            this.panelResult_LPS.SuspendLayout();
            this.groupBoxResult_LPS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_LPS
            // 
            this.panelButtons_LPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons_LPS.Controls.Add(this.buttonInfo_LPS);
            this.panelButtons_LPS.Controls.Add(this.buttonDone_LPS);
            this.panelButtons_LPS.Controls.Add(this.buttonOpenFile_LPS);
            this.panelButtons_LPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_LPS.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_LPS.Name = "panelButtons_LPS";
            this.panelButtons_LPS.Size = new System.Drawing.Size(884, 66);
            this.panelButtons_LPS.TabIndex = 0;
            // 
            // buttonInfo_LPS
            // 
            this.buttonInfo_LPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_LPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonInfo_LPS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_LPS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInfo_LPS.Location = new System.Drawing.Point(804, 4);
            this.buttonInfo_LPS.Name = "buttonInfo_LPS";
            this.buttonInfo_LPS.Size = new System.Drawing.Size(75, 55);
            this.buttonInfo_LPS.TabIndex = 2;
            this.buttonInfo_LPS.TabStop = false;
            this.toolTipButtons_LPS.SetToolTip(this.buttonInfo_LPS, "Сведения о программе");
            this.buttonInfo_LPS.UseVisualStyleBackColor = true;
            this.buttonInfo_LPS.Click += new System.EventHandler(this.buttonInfo_LPS_Click);
            this.buttonInfo_LPS.MouseEnter += new System.EventHandler(this.buttonInfo_LPS_MouseEnter);
            // 
            // buttonDone_LPS
            // 
            this.buttonDone_LPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDone_LPS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_LPS.Enabled = false;
            this.buttonDone_LPS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone_LPS.Location = new System.Drawing.Point(86, 4);
            this.buttonDone_LPS.Name = "buttonDone_LPS";
            this.buttonDone_LPS.Size = new System.Drawing.Size(75, 55);
            this.buttonDone_LPS.TabIndex = 1;
            this.buttonDone_LPS.TabStop = false;
            this.toolTipButtons_LPS.SetToolTip(this.buttonDone_LPS, "Находит третье слово в каждой строчке и\r\nобъединяет эти слова в одну строчку");
            this.buttonDone_LPS.UseVisualStyleBackColor = true;
            this.buttonDone_LPS.Click += new System.EventHandler(this.buttonDone_LPS_Click);
            this.buttonDone_LPS.MouseEnter += new System.EventHandler(this.buttonDone_LPS_MouseEnter);
            // 
            // buttonOpenFile_LPS
            // 
            this.buttonOpenFile_LPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenFile_LPS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_LPS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenFile_LPS.Location = new System.Drawing.Point(4, 4);
            this.buttonOpenFile_LPS.Name = "buttonOpenFile_LPS";
            this.buttonOpenFile_LPS.Size = new System.Drawing.Size(75, 55);
            this.buttonOpenFile_LPS.TabIndex = 0;
            this.buttonOpenFile_LPS.TabStop = false;
            this.toolTipButtons_LPS.SetToolTip(this.buttonOpenFile_LPS, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_LPS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_LPS.Click += new System.EventHandler(this.buttonOpenFile_LPS_Click);
            this.buttonOpenFile_LPS.MouseEnter += new System.EventHandler(this.buttonOpenFile_LPS_MouseEnter);
            // 
            // panelTask_LPS
            // 
            this.panelTask_LPS.Controls.Add(this.groupBoxTask_LPS);
            this.panelTask_LPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_LPS.Location = new System.Drawing.Point(0, 66);
            this.panelTask_LPS.Name = "panelTask_LPS";
            this.panelTask_LPS.Padding = new System.Windows.Forms.Padding(5);
            this.panelTask_LPS.Size = new System.Drawing.Size(884, 68);
            this.panelTask_LPS.TabIndex = 1;
            // 
            // groupBoxTask_LPS
            // 
            this.groupBoxTask_LPS.Controls.Add(this.textBoxTask_LPS);
            this.groupBoxTask_LPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_LPS.Location = new System.Drawing.Point(5, 5);
            this.groupBoxTask_LPS.Name = "groupBoxTask_LPS";
            this.groupBoxTask_LPS.Size = new System.Drawing.Size(874, 58);
            this.groupBoxTask_LPS.TabIndex = 0;
            this.groupBoxTask_LPS.TabStop = false;
            this.groupBoxTask_LPS.Text = "Условие:";
            // 
            // textBoxTask_LPS
            // 
            this.textBoxTask_LPS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask_LPS.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_LPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_LPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_LPS.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_LPS.Multiline = true;
            this.textBoxTask_LPS.Name = "textBoxTask_LPS";
            this.textBoxTask_LPS.ReadOnly = true;
            this.textBoxTask_LPS.Size = new System.Drawing.Size(861, 32);
            this.textBoxTask_LPS.TabIndex = 0;
            this.textBoxTask_LPS.TabStop = false;
            this.textBoxTask_LPS.Text = resources.GetString("textBoxTask_LPS.Text");
            // 
            // panelLoadFromFile_LPS
            // 
            this.panelLoadFromFile_LPS.Controls.Add(this.groupBoxLoadFile_LPS);
            this.panelLoadFromFile_LPS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLoadFromFile_LPS.Location = new System.Drawing.Point(0, 134);
            this.panelLoadFromFile_LPS.Name = "panelLoadFromFile_LPS";
            this.panelLoadFromFile_LPS.Padding = new System.Windows.Forms.Padding(5);
            this.panelLoadFromFile_LPS.Size = new System.Drawing.Size(442, 377);
            this.panelLoadFromFile_LPS.TabIndex = 2;
            // 
            // groupBoxLoadFile_LPS
            // 
            this.groupBoxLoadFile_LPS.Controls.Add(this.textBoxLoadFile_LPS);
            this.groupBoxLoadFile_LPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLoadFile_LPS.Location = new System.Drawing.Point(5, 5);
            this.groupBoxLoadFile_LPS.Name = "groupBoxLoadFile_LPS";
            this.groupBoxLoadFile_LPS.Size = new System.Drawing.Size(432, 367);
            this.groupBoxLoadFile_LPS.TabIndex = 0;
            this.groupBoxLoadFile_LPS.TabStop = false;
            this.groupBoxLoadFile_LPS.Text = "Ввод:";
            // 
            // textBoxLoadFile_LPS
            // 
            this.textBoxLoadFile_LPS.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLoadFile_LPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadFile_LPS.Location = new System.Drawing.Point(3, 16);
            this.textBoxLoadFile_LPS.Multiline = true;
            this.textBoxLoadFile_LPS.Name = "textBoxLoadFile_LPS";
            this.textBoxLoadFile_LPS.ReadOnly = true;
            this.textBoxLoadFile_LPS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLoadFile_LPS.Size = new System.Drawing.Size(426, 348);
            this.textBoxLoadFile_LPS.TabIndex = 0;
            this.textBoxLoadFile_LPS.TabStop = false;
            // 
            // panelResult_LPS
            // 
            this.panelResult_LPS.Controls.Add(this.groupBoxResult_LPS);
            this.panelResult_LPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult_LPS.Location = new System.Drawing.Point(442, 134);
            this.panelResult_LPS.Name = "panelResult_LPS";
            this.panelResult_LPS.Padding = new System.Windows.Forms.Padding(5);
            this.panelResult_LPS.Size = new System.Drawing.Size(442, 377);
            this.panelResult_LPS.TabIndex = 3;
            // 
            // groupBoxResult_LPS
            // 
            this.groupBoxResult_LPS.Controls.Add(this.textBoxResult_LPS);
            this.groupBoxResult_LPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_LPS.Location = new System.Drawing.Point(5, 5);
            this.groupBoxResult_LPS.Name = "groupBoxResult_LPS";
            this.groupBoxResult_LPS.Size = new System.Drawing.Size(432, 367);
            this.groupBoxResult_LPS.TabIndex = 0;
            this.groupBoxResult_LPS.TabStop = false;
            this.groupBoxResult_LPS.Text = "Вывод:";
            // 
            // textBoxResult_LPS
            // 
            this.textBoxResult_LPS.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResult_LPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_LPS.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_LPS.Multiline = true;
            this.textBoxResult_LPS.Name = "textBoxResult_LPS";
            this.textBoxResult_LPS.ReadOnly = true;
            this.textBoxResult_LPS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_LPS.Size = new System.Drawing.Size(426, 348);
            this.textBoxResult_LPS.TabIndex = 0;
            this.textBoxResult_LPS.TabStop = false;
            // 
            // openFileDialogTask_LPS
            // 
            this.openFileDialogTask_LPS.FileName = "openFileDialogTask_LPS";
            // 
            // toolTipButtons_LPS
            // 
            this.toolTipButtons_LPS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButtons_LPS.ToolTipTitle = "Подсказка";
            // 
            // splitterBetweenInputAndOutput_LPS
            // 
            this.splitterBetweenInputAndOutput_LPS.Location = new System.Drawing.Point(442, 134);
            this.splitterBetweenInputAndOutput_LPS.Name = "splitterBetweenInputAndOutput_LPS";
            this.splitterBetweenInputAndOutput_LPS.Size = new System.Drawing.Size(3, 377);
            this.splitterBetweenInputAndOutput_LPS.TabIndex = 4;
            this.splitterBetweenInputAndOutput_LPS.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.splitterBetweenInputAndOutput_LPS);
            this.Controls.Add(this.panelResult_LPS);
            this.Controls.Add(this.panelLoadFromFile_LPS);
            this.Controls.Add(this.panelTask_LPS);
            this.Controls.Add(this.panelButtons_LPS);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 17 | Леушин П.С.";
            this.panelButtons_LPS.ResumeLayout(false);
            this.panelTask_LPS.ResumeLayout(false);
            this.groupBoxTask_LPS.ResumeLayout(false);
            this.groupBoxTask_LPS.PerformLayout();
            this.panelLoadFromFile_LPS.ResumeLayout(false);
            this.groupBoxLoadFile_LPS.ResumeLayout(false);
            this.groupBoxLoadFile_LPS.PerformLayout();
            this.panelResult_LPS.ResumeLayout(false);
            this.groupBoxResult_LPS.ResumeLayout(false);
            this.groupBoxResult_LPS.PerformLayout();
            this.ResumeLayout(false);

        }

        private void buttonOpenFile_LPS_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_LPS;
        private System.Windows.Forms.Panel panelTask_LPS;
        private System.Windows.Forms.Button buttonDone_LPS;
        private System.Windows.Forms.Button buttonOpenFile_LPS;
        private System.Windows.Forms.Button buttonInfo_LPS;
        private System.Windows.Forms.Panel panelLoadFromFile_LPS;
        private System.Windows.Forms.Panel panelResult_LPS;
        private System.Windows.Forms.GroupBox groupBoxTask_LPS;
        private System.Windows.Forms.TextBox textBoxTask_LPS;
        private System.Windows.Forms.GroupBox groupBoxLoadFile_LPS;
        private System.Windows.Forms.TextBox textBoxLoadFile_LPS;
        private System.Windows.Forms.GroupBox groupBoxResult_LPS;
        private System.Windows.Forms.TextBox textBoxResult_LPS;
        private System.Windows.Forms.ToolTip toolTipButtons_LPS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_LPS;
        private System.Windows.Forms.Splitter splitterBetweenInputAndOutput_LPS;
    }
}