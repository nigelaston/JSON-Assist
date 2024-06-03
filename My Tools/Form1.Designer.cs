namespace My_Tools
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
            sidePanel = new Panel();
            mainPanel = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(30, 30, 30);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.ForeColor = SystemColors.Control;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(200, 639);
            sidePanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(18, 18, 18);
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(textBox1);
            mainPanel.Controls.Add(button1);
            mainPanel.Controls.Add(richTextBox2);
            mainPanel.Controls.Add(richTextBox1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1097, 639);
            mainPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 56);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 4;
            label1.Text = "JSON Filter Path:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.Location = new Point(17, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1068, 32);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 190, 169);
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(30, 30, 30);
            button1.Location = new Point(476, 139);
            button1.Name = "button1";
            button1.Size = new Size(150, 45);
            button1.TabIndex = 2;
            button1.Text = "Beautify";
            button1.UseVisualStyleBackColor = false;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(30, 30, 30);
            richTextBox2.Location = new Point(632, 139);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(453, 475);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(30, 30, 30);
            richTextBox1.ForeColor = SystemColors.Control;
            richTextBox1.Location = new Point(17, 139);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(453, 475);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 639);
            Controls.Add(mainPanel);
            Controls.Add(sidePanel);
            Font = new Font("Segoe UI", 14F);
            ForeColor = SystemColors.Control;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "My Tools";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Panel mainPanel;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
    }
}
