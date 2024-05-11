using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ShooterGame
{
    class Bullet
    {
        public string direction;
        public int bulletLeft; // vizszintes
        public int bulletTop; // függőleges

        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer(); // időzítő a mozgatáshoz

        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.Red;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();

            form.Controls.Add(bullet); //formshoz való hozzáadás

            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();

        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if(direction == "left")
            {
                bullet.Left -= speed;
            }

            if (direction == "right")
            {
                bullet.Left += speed;
            }

            if (direction == "up")
            {
                bullet.Top -= speed;
            }

            if (direction == "down")
            {
                bullet.Top += speed;
            }

            // Ha a lövedék elérte a határt
            if (bullet.Left < 10 || bullet.Left > 1500 || bullet.Top < 50 || bullet.Top > 800)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }


        } 

    }
}
