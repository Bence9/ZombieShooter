﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;

namespace ShooterGame
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, goDown, goUp, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int kill = 0;
        int score = 0;
        int zombieSpeed = 4;
        int actualTime = 1;
        Random randNum = new Random();

        // Lista a játékban szereplő zombikat tartalmazó PictureBoxok tárolására
        List<PictureBox> zombiesList = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.dead;
                player.SendToBack(); // A játékos képét hátra küldjük, hogy látható legyen a játék vége üzenet
                GameTimer.Stop();
                lbRestart.Visible = true;
                timer.Stop(); //időt jelző leállítása
            }

            lbAmmo.Text = "Ammo: " + ammo;
            lbKills.Text = "Kills: " + kill;
            lbScore.Text = "Score: " + score;
            
            // játékos mozgásának kezelése
            if(goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }
            if (goUp == true && player.Top > 60)
            {
                player.Top -= speed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }


            foreach(Control x in this.Controls)
            {
                // Ha a picturebox az Ammo
                if(x is PictureBox && (string)x.Tag == "ammo")
                {
                    // Ha a játékos érintkezik az ammo-val (x)
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x); // eltávolítjuk a pBoxt
                        ((PictureBox)x).Dispose(); // felszabadítjuk a pBoxot
                        ammo += 5;
                        score += 5;
                    }
                }

                // Ha a pBox az zombie
                if (x is PictureBox && (string)x.Tag == "zombie")
                {

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }

                    // A zombie követi a játékost
                    if(x.Left > player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }

                }


                foreach(Control j in this.Controls)
                {
                    // Ha a pBox az lövedék , az x pBox meg zombie 
                    if(j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            kill++;
                            score += 10;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove(((PictureBox)x)); //a zombieListből eltávolítjuk a pBoxot
                            MakeZombies(); //zombie csinálás
                        }
                    }
                }


            }


        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (gameOver == true)
            {
                return;
            }

            // irányítás
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }

            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }

            if(e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }

            if(e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            // lövés
            if( e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);

                if(ammo == 3 || ammo == 1)
                {
                    DropAmmo();
                }
            }

            if(e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }


        }

        //idő mérése
        private void timer_Tick(object sender, EventArgs e)
        {
            if (actualTime >= 0)
            {
                int min = actualTime / 60;
                int sec = actualTime % 60;
                actualTime++;

                lbTime.Text = "Time: " + min.ToString("00") + ":" + sec.ToString("00");
            }

        }

        private void kékToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CornflowerBlue;
        }

        private void zöldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Olive;
        }

        private void pirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.IndianRed;
        }

        private void sárgaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Goldenrod;
        }

        private void greyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width /2);
            shootBullet.bulletTop = player.Top + (player.Height /2);

            // Meghívjuk a lövedék létrehozásáért felelős metódust a lövedék objektumon
            shootBullet.MakeBullet(this);
        }

        //Zombie létrehozás
        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = randNum.Next(0,1500);
            zombie.Top = randNum.Next(0,1000);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombie.BackColor = Color.Transparent;
            zombiesList.Add(zombie);
            this.Controls.Add(zombie); //zombie vezérlő hozzáadása a boxhoz
            player.BringToFront();

        }

        //Ammo létrehozás
        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width); //vízszintes pozíció
            ammo.Top = randNum.Next(50, this.ClientSize.Height - ammo.Height); //függőleges pozíció
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);

            ammo.BringToFront();
            player.BringToFront();

        }
        


        private void RestartGame()
        {
            player.Image = Properties.Resources.up;

            foreach(PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }

            zombiesList.Clear();

            for(int i = 0; i < 3; i++)
            {
                MakeZombies();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;

            gameOver = false;
            lbRestart.Visible = false;
            lbRestart.BringToFront();

            playerHealth = 100;
            kill = 0;
            score = 0;
            ammo = 10;

            actualTime = 1;
            timer.Start();
            GameTimer.Start();

        }

    }
}
