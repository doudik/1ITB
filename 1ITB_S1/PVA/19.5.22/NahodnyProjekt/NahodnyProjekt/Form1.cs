using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NahodnyProjekt
{
    public partial class Form1 : Form
    {
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        int num = 0;
        int pointsPerClick = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Score: " + num;
            SpawnCube();
        }

        private void SpawnCube()
        {
            Random rnd = new Random();
            PictureBox pictureBox = new PictureBox(); //inicializace nového objektu
            pictureBox.Height = rnd.Next(10, 75); //výška
            pictureBox.Width = rnd.Next(10, 75); //šířka
            pictureBox.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            int x = rnd.Next(0, this.ClientSize.Width - pictureBox.Width);
            int y = rnd.Next(0, this.ClientSize.Height - pictureBox.Height);
            pictureBox.Location = new Point(x, y); //dá novou souřadnici
            pictureBox.BringToFront();
            pictureBoxes.Add(pictureBox); //přidá do listu picturebox
            pictureBox.Click += PictureBox_Click;
            this.Controls.Add(pictureBox); //přidá do okna nový picturebox

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox tmpPic = sender as PictureBox;
            pictureBoxes.Remove(tmpPic);
            this.Controls.Remove(tmpPic);
            num += pointsPerClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tmp = label1.Text.Substring(6);
            if(Int32.Parse(tmp) >= 10)
            {
                num -= 10;
                pointsPerClick++;
            }
        }
    }
}
