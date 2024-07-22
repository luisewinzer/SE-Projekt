using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L_R_Screen
{
    public partial class InfoWindow : Form
    {
        public InfoWindow(string info)
        {
            InitializeComponent();
            this.Text = "Information";
            this.Size = new Size(250, 150);

            RichTextBox rtbInfo = new RichTextBox
            {
                Dock = DockStyle.Fill,
                Text = info,
                ReadOnly = true,
                ScrollBars = RichTextBoxScrollBars.Vertical,
                WordWrap = true
            };

            this.Controls.Add(rtbInfo);
        }
    }
}
