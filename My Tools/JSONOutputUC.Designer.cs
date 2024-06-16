namespace My_Tools
{
    partial class JSONOutputUC
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
            jsonOutputNumberPanel = new Panel();
            jsonOutputTextbox = new RichTextBox();
            SuspendLayout();
            // 
            // jsonOutputNumberPanel
            // 
            jsonOutputNumberPanel.BackColor = Color.FromArgb(40, 40, 40);
            jsonOutputNumberPanel.Dock = DockStyle.Left;
            jsonOutputNumberPanel.Location = new Point(0, 0);
            jsonOutputNumberPanel.Name = "jsonOutputNumberPanel";
            jsonOutputNumberPanel.Size = new Size(25, 465);
            jsonOutputNumberPanel.TabIndex = 0;
            // 
            // jsonOutputTextbox
            // 
            jsonOutputTextbox.BackColor = Color.FromArgb(30, 30, 30);
            jsonOutputTextbox.BorderStyle = BorderStyle.None;
            jsonOutputTextbox.Dock = DockStyle.Fill;
            jsonOutputTextbox.Font = new Font("Segoe UI", 10F);
            jsonOutputTextbox.ForeColor = SystemColors.Control;
            jsonOutputTextbox.Location = new Point(25, 0);
            jsonOutputTextbox.Name = "jsonOutputTextbox";
            jsonOutputTextbox.Size = new Size(522, 465);
            jsonOutputTextbox.TabIndex = 0;
            jsonOutputTextbox.Text = "";
            // 
            // JSONOutputUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(jsonOutputTextbox);
            Controls.Add(jsonOutputNumberPanel);
            Name = "JSONOutputUC";
            Size = new Size(547, 465);
            ResumeLayout(false);
        }

        #endregion

        private Panel jsonOutputNumberPanel;
        private RichTextBox jsonOutputTextbox;
    }
}
