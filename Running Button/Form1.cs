using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        int xRatio;
        int yRatio;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseMove += new MouseEventHandler(OnMouseMove);
            xRatio = button1.Location.X * 100 / this.Width;
            yRatio = button1.Location.Y * 100 / this.Height;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            int btnWidth2 = button1.Width / 2;
            int btnHeight2 = button1.Height / 2;
            int centerX = button1.Location.X + btnWidth2;
            int centerY = button1.Location.Y + btnHeight2;
            if (Math.Abs(centerX - e.X) < 80 && Math.Abs(centerY - e.Y) < 55)
            {
                int newX = centerX - (e.X - centerX);
                int newY = centerY - (e.Y - centerY);
                
                if(newX < button1.Width)
                {
                    newX = this.Width - button1.Width - 20;
                }
                if(newX > this.Width - button1.Width - 20)
                {
                    newX = button1.Width;
                }
                if (newY < button1.Height)
                {
                    newY = this.Height - button1.Height -40;
                }
                if (newY > this.Height - button1.Height - 20)
                {
                    newY = button1.Height;
                }

                xRatio = newX * 100 / this.Width;
                yRatio = newY * 100 / this.Height;

                button1.Location = new Point(newX - btnWidth2, newY - btnHeight2);

            }
            this.Update();
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли нажать на кнопку!");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            button1.Location = new Point(this.Width * xRatio / 100, this.Height * yRatio / 100);
        }
    }
}
