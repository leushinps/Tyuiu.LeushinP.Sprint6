using Tyuiu.LeushinP.Sprint6.Task2.V15.Lib;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.LeushinP.Sprint6.Task2.V15;
{
   public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDown_LPS_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_LPS.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_LPS.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] res = ds.GetMassFunction(startValue, stopValue);
                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewResult_LPS.Rows.Add(Convert.ToString(startValue), Convert.ToString(res[i]));
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Неправильно", "Ок", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonQuestion_LPS_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы СМАРТБ - 25 - 1 Леушин П.С");
      }

   }
}