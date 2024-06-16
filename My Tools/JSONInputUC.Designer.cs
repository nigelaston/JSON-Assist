namespace My_Tools
{
    partial class JSONInputUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            JSONInputNumberPanel = new Panel();
            JSONInputTextbox = new RichTextBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // JSONInputNumberPanel
            // 
            JSONInputNumberPanel.BackColor = Color.FromArgb(40, 40, 40);
            JSONInputNumberPanel.Dock = DockStyle.Left;
            JSONInputNumberPanel.Location = new Point(0, 0);
            JSONInputNumberPanel.Name = "JSONInputNumberPanel";
            JSONInputNumberPanel.Size = new Size(25, 465);
            JSONInputNumberPanel.TabIndex = 1;
            // 
            // JSONInputTextbox
            // 
            JSONInputTextbox.BackColor = Color.FromArgb(30, 30, 30);
            JSONInputTextbox.BorderStyle = BorderStyle.None;
            JSONInputTextbox.Dock = DockStyle.Fill;
            JSONInputTextbox.Font = new Font("Segoe UI", 10F);
            JSONInputTextbox.ForeColor = SystemColors.Control;
            JSONInputTextbox.Location = new Point(25, 0);
            JSONInputTextbox.Name = "JSONInputTextbox";
            JSONInputTextbox.Size = new Size(522, 465);
            JSONInputTextbox.TabIndex = 2;
            JSONInputTextbox.Text = "";
            // 
            // JSONInputUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(JSONInputTextbox);
            Controls.Add(JSONInputNumberPanel);
            Controls.Add(flowLayoutPanel1);
            Name = "JSONInputUC";
            Size = new Size(547, 465);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel JSONInputNumberPanel;
        private RichTextBox JSONInputTextbox;
    }
}
