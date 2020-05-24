using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        ToolTip tip = new ToolTip();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblColor.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value);
            tip.SetToolTip(lblColor, "#" + trackRed.Value.ToString("X") + trackGreen.Value.ToString("X") + trackBlue.Value.ToString("X"));
        }

        private void trackRed_Scroll(object sender, EventArgs e)
        {
            lblValRed.Text = trackRed.Value.ToString();
            lblColor.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value);
        }

        private void trackGreen_Scroll(object sender, EventArgs e)
        {
            lblValGreen.Text = trackGreen.Value.ToString();
            lblColor.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value);
        }

        private void trackBlue_Scroll(object sender, EventArgs e)
        {
            lblValBlue.Text = trackBlue.Value.ToString();
            lblColor.BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value);
        }

        private void lblColor_MouseHover(object sender, EventArgs e)
        {
            tip.SetToolTip(lblColor, "#" + trackRed.Value.ToString("X") + trackGreen.Value.ToString("X") + trackBlue.Value.ToString("X"));
        }

        private void trackRed_MouseUp(object sender, MouseEventArgs e)
        {
            Clipboard.SetText("#" + trackRed.Value.ToString("X") + trackGreen.Value.ToString("X") + trackBlue.Value.ToString("X"));
        }

        private void trackGreen_MouseUp(object sender, MouseEventArgs e)
        {
            Clipboard.SetText("#" + trackRed.Value.ToString("X") + trackGreen.Value.ToString("X") + trackBlue.Value.ToString("X"));
        }

        private void trackBlue_MouseUp(object sender, MouseEventArgs e)
        {
            Clipboard.SetText("#" + trackRed.Value.ToString("X") + trackGreen.Value.ToString("X") + trackBlue.Value.ToString("X"));
        }
    }
}
