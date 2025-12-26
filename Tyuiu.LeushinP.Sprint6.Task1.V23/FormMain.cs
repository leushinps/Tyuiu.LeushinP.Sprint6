using Tyuiu.LeushinP.Sprint6.Task1.V23.Lib;

namespace Tyuiu.LeushinP.Sprint6.Task1.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        DataService ds = new DataService();
        private void buttonExecute_SMA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
               

                int startStep = Convert.ToInt32(inputStart_LPS.Text);
                int stopStep = Convert.ToInt32(inputFinish_LPS.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textOutput_SMA.Text = "";
                textOutput_SMA.AppendText("+----------+----------+" + Environment.NewLine);
                textOutput_SMA.AppendText("|    X     +   f(x)   |" + Environment.NewLine);
                textOutput_SMA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   | ", startStep, valueArray[i]);
                    textOutput_SMA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textOutput_SMA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("ОК", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAbout_SMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы СМАРТБ-25-1 Леушин П.С", "Сообщение", MessageBoxButtons.OK);
        }

        private void inputStart_LPS_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void inputStart_LPS_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputFinish_LPS_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textOutput_LPS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}