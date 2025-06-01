using Model.Data;

namespace DoodleJump
{
    public partial class Form1 : Form
    {
        private string folderPath;
        private string fileName;
        private string format;
        private string FullPath => Path.Combine(folderPath, fileName + $".{format}");

        private ISerializer serializer;
        public Form1()
        {
            InitializeComponent();
            serializer = new SerializerJSON();
            folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fileName = "save";
            format = "json";
            serializer.SetFilePath(FullPath);
            label2.Text = FullPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new GamePage(serializer)).Show();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    (new GamePage(serializer, true)).Show();
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderDialog.SelectedPath;
                label2.Text = FullPath;
                serializer.SetFilePath(FullPath);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            fileName = textBox2.Text;
            if (fileName == "") fileName = "save";
            serializer.SetFilePath(FullPath);
            label2.Text = FullPath;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            (new GamePage(serializer, true)).Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            format = (string) comboBox1.SelectedItem;
            label2.Text = FullPath;
            switch (format)
            {
                case "json":
                    serializer = new SerializerJSON();
                    break;
                case "xml":
                    serializer = new SerializerXML();
                    break;
            }
            serializer.SetFilePath(FullPath);
        }
    }
}
