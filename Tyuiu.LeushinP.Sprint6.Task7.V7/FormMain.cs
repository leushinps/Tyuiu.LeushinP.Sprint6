using System.ComponentModel;
using Tyuiu.LeushinP.Sprint6.Task7.V7.Lib;

namespace Tyuiu.LeushinP.Sprint6.Task7.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask7_LPS.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_LPS.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }


        private void buttonHelp_LPS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonOpenFile_LPS_Click(object sender, EventArgs e)
        {
            openFileDialogTask7_LPS.ShowDialog();
            openFilePath = openFileDialogTask7_LPS.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_LPS.ColumnCount = columns;
            dataGridViewInPut_LPS.RowCount = rows;
            dataGridViewOutPut_LPS.ColumnCount = columns;
            dataGridViewOutPut_LPS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_LPS.Columns[i].Width = 25;
                dataGridViewOutPut_LPS.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_LPS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_LPS.Enabled = true;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_LPS.ColumnCount = 50;
            dataGridViewOutPut_LPS.ColumnCount = 50;

            dataGridViewOutPut_LPS.RowCount = 50;
            dataGridViewInPut_LPS.RowCount = 50;

            panelInPut_LPS.Width = this.Width / 2;
            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_LPS.Columns[i].Width = 25;
                dataGridViewOutPut_LPS.Columns[i].Width = 25;
            }
        }
        private void buttonDone_LPS_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_LPS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_LPS.Enabled = true;
        }
        private void buttonSaveFile_LPS_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_LPS.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_LPS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_LPS.ShowDialog();

            string path = saveFileDialogMatrix_LPS.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_LPS.RowCount;
            int columns = dataGridViewOutPut_LPS.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_LPS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_LPS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonOpenFile_LPS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_LPS.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_LPS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_LPS.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_LPS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_LPS.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_LPS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_LPS.ToolTipTitle = "Справка";
        }

        private void openFileDialogTask7_LPS_FileOk(object sender, CancelEventArgs e)
        {

        }


    }
}