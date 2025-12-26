using Tyuiu.LeushinP.Sprint6.Task0.V5.Lib;

namespace Tyuiu.LeushinP.Sprint6.Task0.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_LPS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOutputEnd_LPS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInputEnd_LPS.Text)));
            }
            catch
            {
                MessageBox.Show("-", "-", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxInputEnd_LPS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8)) e.Handled = true;
        }
        private void buttonHelp_LPS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы СМАРТБ-25-1 Леушин П.С", "Сообщение");
        }

    }
}