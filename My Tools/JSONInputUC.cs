using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace My_Tools
{
    public partial class JSONInputUC : UserControl
    {
        public JSONInputUC()
        {
            InitializeComponent();
            this.JSONInputTextbox.VScroll += new EventHandler(JSONInputTextbox_VScroll);
            this.JSONInputTextbox.TextChanged += new EventHandler(JSONInputTextbox_TextChanged);
            this.JSONInputTextbox.Resize += new EventHandler(JSONInputTextbox_Resize);
            this.JSONInputNumberPanel.Paint += new PaintEventHandler(JSONInputNumberPanel_Paint);
        }

        private void JSONInputTextbox_VScroll(object sender, EventArgs e)
        {
            this.JSONInputNumberPanel.Invalidate(); // Redraw the panel when scrolled
        }

        private void JSONInputTextbox_TextChanged(object sender, EventArgs e)
        {
            this.JSONInputNumberPanel.Invalidate(); // Redraw the panel when text changes
        }

        private void JSONInputTextbox_Resize(object sender, EventArgs e)
        {
            this.JSONInputNumberPanel.Invalidate(); // Redraw the panel when resized
        }

        private void JSONInputNumberPanel_Paint(object sender, PaintEventArgs e)
        {
            
            e.Graphics.Clear(this.JSONInputNumberPanel.BackColor); // Clear previous drawings

            int firstIndex = this.JSONInputTextbox.GetCharIndexFromPosition(new Point(0, 0));
            int firstLine = this.JSONInputTextbox.GetLineFromCharIndex(firstIndex);

            int lastIndex = this.JSONInputTextbox.GetCharIndexFromPosition(new Point(0, this.JSONInputTextbox.ClientSize.Height));
            int lastLine = this.JSONInputTextbox.GetLineFromCharIndex(lastIndex + 1);

            //Adjust the width of the panel for longer numbers
            if (lastLine > 99 & lastLine <= 999)
            {
                JSONInputNumberPanel.Width = 34;
            }
            else if (lastLine >= 1000)
            {
                JSONInputNumberPanel.Width = 40;
            }
            else if (lastLine >= 10000)
            {
                JSONInputNumberPanel.Width = 46;
            }
            else
            {
                JSONInputNumberPanel.Width = 25;
            }

            //paint the numbers to the side panel
            for (int i = firstLine; i <= lastLine; i++)
            {
                Point pt = this.JSONInputTextbox.GetPositionFromCharIndex(this.JSONInputTextbox.GetFirstCharIndexFromLine(i));

                e.Graphics.DrawString(
                    (i + 1).ToString(), 
                    this.JSONInputTextbox.Font,
                    Brushes.White,
                    this.JSONInputNumberPanel.ClientSize.Width - e.Graphics.MeasureString((i + 1).ToString(),
                    this.JSONInputTextbox.Font).Width, pt.Y);
            }
        }

        public string GetValues
        {
            get { return JSONInputTextbox.Text; }
        }

        public string SetValue
        {
            set { JSONInputTextbox.Text = value; }
        }
    }
}
