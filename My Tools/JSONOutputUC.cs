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
    public partial class JSONOutputUC : UserControl
    {
        public JSONOutputUC()
        {
            InitializeComponent();
            this.jsonOutputTextbox.VScroll += new EventHandler(JSONOutputTextbox_VScroll);
            this.jsonOutputTextbox.TextChanged += new EventHandler(JSONOutputTextbox_TextChanged);
            this.jsonOutputTextbox.Resize += new EventHandler(JSONOutputTextbox_Resize);
            this.jsonOutputNumberPanel.Paint += new PaintEventHandler(JSONOutputNumberPanel_Paint);
        }



        private void JSONOutputTextbox_VScroll(object sender, EventArgs e)
        {
            this.jsonOutputNumberPanel.Invalidate(); // Redraw the panel when scrolled
        }

        private void JSONOutputTextbox_TextChanged(object sender, EventArgs e)
        {
            this.jsonOutputNumberPanel.Invalidate(); // Redraw the panel when text changes
        }

        private void JSONOutputTextbox_Resize(object sender, EventArgs e)
        {
            this.jsonOutputNumberPanel.Invalidate(); // Redraw the panel when resized
        }

        private void JSONOutputNumberPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.jsonOutputNumberPanel.BackColor); // Clear previous drawings

            int firstIndex = this.jsonOutputTextbox.GetCharIndexFromPosition(new Point(0, 0));
            int firstLine = this.jsonOutputTextbox.GetLineFromCharIndex(firstIndex);

            int lastIndex = this.jsonOutputTextbox.GetCharIndexFromPosition(new Point(0, this.jsonOutputTextbox.ClientSize.Height));
            int lastLine = this.jsonOutputTextbox.GetLineFromCharIndex(lastIndex + 1);

            //Adjust the width of the panel for longer numbers
            if (lastLine > 99 & lastLine <= 999)
            {
                jsonOutputNumberPanel.Width = 34;
            }
            else if (lastLine >= 1000)
            {
                jsonOutputNumberPanel.Width = 40;
            }
            else if (lastLine >= 10000)
            {
                jsonOutputNumberPanel.Width = 46;
            }
            else
            {
                jsonOutputNumberPanel.Width = 25;
            }

            for (int i = firstLine; i <= lastLine; i++)
            {
                Point pt = this.jsonOutputTextbox.GetPositionFromCharIndex(this.jsonOutputTextbox.GetFirstCharIndexFromLine(i));
                e.Graphics.DrawString((i + 1).ToString(), this.jsonOutputTextbox.Font, Brushes.White, this.jsonOutputNumberPanel.ClientSize.Width - e.Graphics.MeasureString((i + 1).ToString(), this.jsonOutputTextbox.Font).Width, pt.Y);
            }
        }

        public string SetValue
        {
            set { jsonOutputTextbox.Text = value; }
        }
    }
}
