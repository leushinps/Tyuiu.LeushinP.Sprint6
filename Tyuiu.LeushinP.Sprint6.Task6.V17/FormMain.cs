
using Tyuiu.LeushinP.Sprint6.Task6.V17.Lib;

namespace Tyuiu.LeushinP.Sprint6.Task6.V17

{
    public partial class FormMain : Form
    { 
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonDone_LPS_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_LPS.FlatStyle = FlatStyle.Flat;
            buttonDone_LPS.FlatAppearance.BorderColor = Color.DarkGray;
            buttonDone_LPS.FlatAppearance.BorderSize = 2;
        }

        private void buttonOpenFile_LPS_MouseEnter(object sender, EventArgs e)
        {
            buttonOpenFile_LPS.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_LPS.FlatAppearance.BorderColor = Color.DarkGray;
            buttonOpenFile_LPS.FlatAppearance.BorderSize = 2;
        }

        private void buttonInfo_LPS_MouseEnter(object sender, EventArgs e)
        {
            buttonInfo_LPS.FlatStyle = FlatStyle.Flat;
            buttonInfo_LPS.FlatAppearance.BorderColor = Color.DarkGray;
            buttonInfo_LPS.FlatAppearance.BorderSize = 2;
        }

        private void buttonOpenFile_LPSA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_LPS.ShowDialog();
            openFilePath = openFileDialogTask_LPS.FileName;
            textBoxLoadFile_LPS.Text = File.ReadAllText(openFilePath);
            groupBoxLoadFile_LPS.Text = groupBoxLoadFile_LPS.Text + " " + openFileDialogTask_LPS.FileName;
            buttonDone_LPS.Enabled = true;
        }

        private void buttonDone_LPS_Click(object sender, EventArgs e)
        {
            textBoxResult_LPS.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_LPS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}