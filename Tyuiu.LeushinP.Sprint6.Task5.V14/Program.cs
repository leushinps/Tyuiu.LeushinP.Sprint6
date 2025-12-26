using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.LeushinP.Sprint6.Task5.V14.Lib;

namespace Tyuiu.LeushinP.Sprint6.Task5.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutFileTask5V14.txt";

        private void buttonDone_LPS_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewInPut_LPS.ColumnCount = 2;
                dataGridViewInPut_LPS.Columns[0].Width = 20;
                dataGridViewInPut_LPS.Columns[1].Width = 50;

                this.chartInPut_LPS.ChartAreas[0].AxisX.Title = "ÎÑü X";
                this.chartInPut_LPS.ChartAreas[0].AxisY.Title = "ÎÑü Y";

                chartInPut_LPS.Series[0].Points.Clear();

                double[] numsMass = new double[ds.len];

                numsMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewInPut_LPS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                    chartInPut_LPS.Series[0].Points.AddXY(i, numsMass[i]);
                }
            }
            catch
            {
                MessageBox.Show("Îøèáêà ÷òåíèÿ ôàéëà", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpen_AVV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void InitializeComponent()
        {

        }

        private void buttonInfo_AVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Âûïîëíèë ñòóäåíò ãðóïïû ÑÌÀÐÒÁ - 25 - 1 Ëåóøèí Ï.Ñ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}