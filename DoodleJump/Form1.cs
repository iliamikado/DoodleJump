using Model.Data;
using System.Text;

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
            changePath();
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
                changePath();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                var c = textBox2.Text[i];
                if (char.IsDigit(c) || char.IsLetter(c))
                {
                    sb.Append(c);
                }
            }
            fileName = sb.ToString();
            textBox2.Text = sb.ToString();
            if (fileName == "") fileName = "save";
            changePath();
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
            changePath();
        }

        private void changePath()
        {
            var exist = serializer.SetFilePath(FullPath);
            label2.Text = FullPath;
            button2.Enabled = exist;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            changePath();
        }
    }
}
