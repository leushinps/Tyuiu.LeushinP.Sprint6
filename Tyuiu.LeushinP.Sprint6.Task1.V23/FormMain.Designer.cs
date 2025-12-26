namespace Tyuiu.LeushinP.Sprint6.Task1.V23
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
            taskLabel_LPS = new Label();
            taskPicture_LPS = new PictureBox();
            labelInput_LPS = new Label();
            labelInputFinish_LPS = new Label();
            labelInputStart_LPS = new Label();
            inputFinish_LPS = new TextBox();
            inputStart_LPS = new TextBox();
            buttonAbout_LPS = new Button();
            buttonExecute_LPS = new Button();
            textOutput_LPS = new TextBox();
            labelOutput_LPS = new Label();
            labelResult_LPS = new Label();
            ((System.ComponentModel.ISupportInitialize)taskPicture_LPS).BeginInit();
            SuspendLayout();
            // 
            // taskLabel_LPS
            // 
            taskLabel_LPS.AutoSize = true;
            taskLabel_LPS.Location = new Point(12, 9);
            taskLabel_LPS.Name = "taskLabel_LPS";
            taskLabel_LPS.Size = new Size(53, 15);
            taskLabel_LPS.TabIndex = 0;
            taskLabel_LPS.Text = "Условие";
            // 
            // taskPicture_LPS
            // 
            taskPicture_LPS.Image = Properties.Resources.picture;
            taskPicture_LPS.Location = new Point(12, 27);
            taskPicture_LPS.Name = "taskPicture_LPS";
            taskPicture_LPS.Size = new Size(421, 136);
            taskPicture_LPS.SizeMode = PictureBoxSizeMode.Zoom;
            taskPicture_LPS.TabIndex = 3;
            taskPicture_LPS.TabStop = false;
            // 
            // labelInput_LPS
            // 
            labelInput_LPS.AutoSize = true;
            labelInput_LPS.Location = new Point(12, 180);
            labelInput_LPS.Name = "labelInput_LPS";
            labelInput_LPS.Size = new Size(77, 15);
            labelInput_LPS.TabIndex = 4;
            labelInput_LPS.Text = "Ввод данных";
            // 
            // labelInputFinish_LPS
            // 
            labelInputFinish_LPS.AutoSize = true;
            labelInputFinish_LPS.Location = new Point(121, 206);
            labelInputFinish_LPS.Name = "labelInputFinish_LPS";
            labelInputFinish_LPS.Size = new Size(75, 15);
            labelInputFinish_LPS.TabIndex = 5;
            labelInputFinish_LPS.Text = "Конец шага:";
            // 
            // labelInputStart_LPS
            // 
            labelInputStart_LPS.AutoSize = true;
            labelInputStart_LPS.Location = new Point(12, 206);
            labelInputStart_LPS.Name = "labelInputStart_LPS";
            labelInputStart_LPS.Size = new Size(72, 15);
            labelInputStart_LPS.TabIndex = 6;
            labelInputStart_LPS.Text = "Старт шага:";
            // 
            // inputFinish_LPS
            // 
            inputFinish_LPS.Location = new Point(121, 224);
            inputFinish_LPS.Name = "inputFinish_LPS";
            inputFinish_LPS.Size = new Size(75, 23);
            inputFinish_LPS.TabIndex = 7;
            inputFinish_LPS.KeyPress += inputFinish_LPS_KeyPress;
            // 
            // inputStart_LPS
            // 
            inputStart_LPS.Location = new Point(12, 224);
            inputStart_LPS.Name = "inputStart_LPS";
            inputStart_LPS.Size = new Size(77, 23);
            inputStart_LPS.TabIndex = 8;
            inputStart_LPS.TextChanged += inputStart_LPS_TextChanged;
            inputStart_LPS.KeyPress += inputStart_LPS_KeyPress;
            // 
            // buttonAbout_LPS
            // 
            buttonAbout_LPS.BackColor = Color.LightSeaGreen;
            buttonAbout_LPS.FlatStyle = FlatStyle.Flat;
            buttonAbout_LPS.Location = new Point(12, 263);
            buttonAbout_LPS.Name = "buttonAbout_LPS";
            buttonAbout_LPS.Size = new Size(163, 154);
            buttonAbout_LPS.TabIndex = 9;
            buttonAbout_LPS.Text = "Справка";
            buttonAbout_LPS.UseVisualStyleBackColor = false;
            buttonAbout_LPS.Click += buttonAbout_LPS_Click;
            // 
            // buttonExecute_LPS
            // 
            buttonExecute_LPS.BackColor = Color.Lime;
            buttonExecute_LPS.Location = new Point(181, 263);
            buttonExecute_LPS.Name = "buttonExecute_LPS";
            buttonExecute_LPS.Size = new Size(252, 154);
            buttonExecute_LPS.TabIndex = 10;
            buttonExecute_LPS.Text = "Выполнить";
            buttonExecute_LPS.UseVisualStyleBackColor = false;
            buttonExecute_LPS.Click += buttonExecute_LPS_Click;
            // 
            // textOutput_LPS
            // 
            textOutput_LPS.Location = new Point(453, 60);
            textOutput_LPS.Multiline = true;
            textOutput_LPS.Name = "textOutput_LPS";
            textOutput_LPS.ReadOnly = true;
            textOutput_LPS.Size = new Size(335, 357);
            textOutput_LPS.TabIndex = 11;
            textOutput_LPS.TextChanged += textOutput_LPS_TextChanged;
            // 
            // labelOutput_LPS
            // 
            labelOutput_LPS.AutoSize = true;
            labelOutput_LPS.Location = new Point(453, 27);
            labelOutput_LPS.Name = "labelOutput_LPS";
            labelOutput_LPS.Size = new Size(86, 15);
            labelOutput_LPS.TabIndex = 12;
            labelOutput_LPS.Text = "Вывод данных";
            // 
            // labelResult_LPS
            // 
            labelResult_LPS.AutoSize = true;
            labelResult_LPS.Location = new Point(453, 42);
            labelResult_LPS.Name = "labelResult_LPS";
            labelResult_LPS.Size = new Size(63, 15);
            labelResult_LPS.TabIndex = 13;
            labelResult_LPS.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult_LPS);
            Controls.Add(labelOutput_LPS);
            Controls.Add(textOutput_LPS);
            Controls.Add(buttonExecute_LPS);
            Controls.Add(buttonAbout_LPS);
            Controls.Add(inputStart_LPS);
            Controls.Add(inputFinish_LPS);
            Controls.Add(labelInputStart_LPS);
            Controls.Add(labelInputFinish_LPS);
            Controls.Add(labelInput_LPS);
            Controls.Add(taskPicture_LPS);
            Controls.Add(taskLabel_LPS);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 23 | Леушин П.С";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)taskPicture_LPS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label taskLabel_LPS;
        private PictureBox taskPicture_LPS;
        private Label labelInput_LPS;
        private Label labelInputFinish_LPS;
        private Label labelInputStart_LPS;
        private TextBox inputFinish_LPS;
        private TextBox inputStart_LPS;
        private Button buttonAbout_LPS;
        private Button buttonExecute_LPS;
        private TextBox textOutput_LPS;
        private Label labelOutput_LPS;
        private Label labelResult_LPS;
    }
}