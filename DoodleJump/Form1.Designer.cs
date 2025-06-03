namespace DoodleJump
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            folderDialog = new FolderBrowserDialog();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            comboBox1 = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(101, 165);
            button1.Name = "button1";
            button1.Size = new Size(200, 40);
            button1.TabIndex = 0;
            button1.Text = "Новая игра";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(101, 211);
            button2.Name = "button2";
            button2.Size = new Size(200, 40);
            button2.TabIndex = 1;
            button2.Text = "Продолжить игру";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(101, 257);
            button3.Name = "button3";
            button3.Size = new Size(78, 61);
            button3.TabIndex = 2;
            button3.Text = "Выбрать папку";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 257);
            textBox2.MaxLength = 10;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter file name";
            textBox2.Size = new Size(116, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "json", "xml" });
            comboBox1.Location = new Point(185, 290);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(116, 28);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "json";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 321);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 553);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FolderBrowserDialog folderDialog;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBox1;
        private Label label2;
    }
}
