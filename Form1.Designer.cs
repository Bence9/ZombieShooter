﻿namespace ShooterGame
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtAmmo = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbRestart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAmmo.ForeColor = System.Drawing.Color.White;
            this.txtAmmo.Location = new System.Drawing.Point(12, 12);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(114, 29);
            this.txtAmmo.TabIndex = 0;
            this.txtAmmo.Text = "Ammo: 0";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(392, 12);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(92, 29);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Kills: 0";
            // 
            // txtHealth
            // 
            this.txtHealth.AutoSize = true;
            this.txtHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtHealth.ForeColor = System.Drawing.Color.White;
            this.txtHealth.Location = new System.Drawing.Point(653, 12);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(95, 29);
            this.txtHealth.TabIndex = 2;
            this.txtHealth.Text = "Health:";
            // 
            // healthBar
            // 
            this.healthBar.BackColor = System.Drawing.Color.Gray;
            this.healthBar.Location = new System.Drawing.Point(754, 12);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(216, 29);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::ShooterGame.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(436, 318);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // lbRestart
            // 
            this.lbRestart.AutoSize = true;
            this.lbRestart.BackColor = System.Drawing.Color.Transparent;
            this.lbRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRestart.ForeColor = System.Drawing.Color.Transparent;
            this.lbRestart.Location = new System.Drawing.Point(322, 216);
            this.lbRestart.Name = "lbRestart";
            this.lbRestart.Size = new System.Drawing.Size(331, 29);
            this.lbRestart.TabIndex = 5;
            this.lbRestart.Text = "Press Enter to restart game";
            this.lbRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbRestart.UseWaitCursor = true;
            this.lbRestart.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.lbRestart);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.Name = "Form1";
            this.Text = "Zombie Shooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHealth;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lbRestart;
    }
}
