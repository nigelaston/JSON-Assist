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
            label3 = new Label();
            label2 = new Label();
            mainPanel = new Panel();
            saveBtn = new Button();
            jsonInputuc1 = new JSONInputUC();
            jsonOutputuc1 = new JSONOutputUC();
            label1 = new Label();
            FilterPathValue = new TextBox();
            beautifyBtn = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            loadBtn = new Button();
            sidePanel.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(30, 30, 30);
            sidePanel.Controls.Add(label3);
            sidePanel.Controls.Add(label2);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.ForeColor = SystemColors.Control;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(200, 700);
            sidePanel.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(30, 190, 169);
            label3.Location = new Point(51, 134);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 7;
            label3.Text = "JSON Assist";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(30, 30, 30);
            label2.Font = new Font("Segoe UI", 80F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(30, 190, 169);
            label2.Location = new Point(26, -8);
            label2.Name = "label2";
            label2.Size = new Size(168, 142);
            label2.TabIndex = 7;
            label2.Text = "{ }";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(18, 18, 18);
            mainPanel.Controls.Add(loadBtn);
            mainPanel.Controls.Add(saveBtn);
            mainPanel.Controls.Add(jsonInputuc1);
            mainPanel.Controls.Add(jsonOutputuc1);
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(FilterPathValue);
            mainPanel.Controls.Add(beautifyBtn);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1097, 700);
            mainPanel.TabIndex = 1;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(30, 30, 30);
            saveBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            saveBtn.ForeColor = Color.FromArgb(30, 190, 169);
            saveBtn.Location = new Point(475, 190);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(150, 45);
            saveBtn.TabIndex = 7;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += button2_Click;
            // 
            // jsonInputuc1
            // 
            jsonInputuc1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            jsonInputuc1.BorderStyle = BorderStyle.Fixed3D;
            jsonInputuc1.Location = new Point(17, 139);
            jsonInputuc1.Name = "jsonInputuc1";
            jsonInputuc1.Size = new Size(452, 549);
            jsonInputuc1.TabIndex = 6;
            // 
            // jsonOutputuc1
            // 
            jsonOutputuc1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            jsonOutputuc1.BorderStyle = BorderStyle.Fixed3D;
            jsonOutputuc1.Location = new Point(632, 139);
            jsonOutputuc1.Name = "jsonOutputuc1";
            jsonOutputuc1.Size = new Size(452, 549);
            jsonOutputuc1.TabIndex = 5;
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
            // FilterPathValue
            // 
            FilterPathValue.BackColor = Color.FromArgb(30, 30, 30);
            FilterPathValue.Font = new Font("Segoe UI", 14F);
            FilterPathValue.ForeColor = SystemColors.Control;
            FilterPathValue.Location = new Point(17, 84);
            FilterPathValue.Name = "FilterPathValue";
            FilterPathValue.Size = new Size(1068, 32);
            FilterPathValue.TabIndex = 3;
            FilterPathValue.Text = "$";
            FilterPathValue.TextChanged += FilterPathValue_TextChanged;
            // 
            // beautifyBtn
            // 
            beautifyBtn.BackColor = Color.FromArgb(30, 30, 30);
            beautifyBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            beautifyBtn.ForeColor = Color.FromArgb(30, 190, 169);
            beautifyBtn.Location = new Point(476, 139);
            beautifyBtn.Name = "beautifyBtn";
            beautifyBtn.Size = new Size(150, 45);
            beautifyBtn.TabIndex = 2;
            beautifyBtn.Text = "Beautify";
            beautifyBtn.UseVisualStyleBackColor = false;
            beautifyBtn.Click += BeautifyJSON;
            // 
            // loadBtn
            // 
            loadBtn.BackColor = Color.FromArgb(30, 30, 30);
            loadBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            loadBtn.ForeColor = Color.FromArgb(30, 190, 169);
            loadBtn.Location = new Point(475, 241);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(150, 45);
            loadBtn.TabIndex = 8;
            loadBtn.Text = "Load";
            loadBtn.UseVisualStyleBackColor = false;
            loadBtn.Click += loadBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1297, 700);
            Controls.Add(mainPanel);
            Controls.Add(sidePanel);
            Font = new Font("Segoe UI", 14F);
            ForeColor = SystemColors.Control;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "JSON Assist";
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Panel mainPanel;
        private Button beautifyBtn;
        private Button saveBtn;
        private Button loadBtn;
        private Label label1;
        private TextBox FilterPathValue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private JSONOutputUC jsonOutputuc1;
        private JSONInputUC jsonInputuc1;
        private Label label2;
        private Label label3;
        
    }
}
