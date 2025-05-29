namespace DoodleJump
{
    public partial class Form1 : Form
    {
        private string folderPath;
        public Form1()
        {
            InitializeComponent();
            folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new GamePage()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new GamePage()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolder = folderDialog.SelectedPath;
                MessageBox.Show($"Выбрана папка: {selectedFolder}");
            }
        }
    }
}
