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
            button1 = new Button();
            folderDialog = new FolderBrowserDialog();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(100, 86);
            button1.Name = "button1";
            button1.Size = new Size(200, 40);
            button1.TabIndex = 0;
            button1.Text = "Новая игра";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(100, 132);
            button2.Name = "button2";
            button2.Size = new Size(200, 40);
            button2.TabIndex = 1;
            button2.Text = "Продолжить игру";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(100, 178);
            button3.Name = "button3";
            button3.Size = new Size(200, 40);
            button3.TabIndex = 2;
            button3.Text = "Выбрать папку";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 224);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 553);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FolderBrowserDialog folderDialog;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
    }
}
