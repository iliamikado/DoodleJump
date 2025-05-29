using Model.Data;

namespace DoodleJump
{
    public partial class Form1 : Form
    {
        private string folderPath;
        private ISerializer serializer;
        public Form1()
        {
            InitializeComponent();
            serializer = new SerializerXML();
            folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            serializer.SetFilePath(Path.Combine(folderPath, "save.txt"));
            textBox1.Text = $"{folderPath}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new GamePage(serializer)).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new GamePage(serializer)).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderDialog.SelectedPath;
                textBox1.Text = $"{folderPath}";
                var filename = textBox2.Text + ".txt";
                serializer.SetFilePath(Path.Combine(folderPath, filename));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var filename = textBox2.Text + ".txt";
            serializer.SetFilePath(Path.Combine(folderPath, filename));
        }
    }
}
