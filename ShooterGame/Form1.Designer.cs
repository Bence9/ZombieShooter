namespace ShooterGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbAmmo = new System.Windows.Forms.Label();
            this.lbKills = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbRestart = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAmmo
            // 
            this.lbAmmo.AutoSize = true;
            this.lbAmmo.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAmmo.ForeColor = System.Drawing.Color.White;
            this.lbAmmo.Location = new System.Drawing.Point(12, 39);
            this.lbAmmo.Name = "lbAmmo";
            this.lbAmmo.Size = new System.Drawing.Size(130, 36);
            this.lbAmmo.TabIndex = 0;
            this.lbAmmo.Text = "Ammo: 0";
            // 
            // lbKills
            // 
            this.lbKills.AutoSize = true;
            this.lbKills.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKills.ForeColor = System.Drawing.Color.White;
            this.lbKills.Location = new System.Drawing.Point(313, 39);
            this.lbKills.Name = "lbKills";
            this.lbKills.Size = new System.Drawing.Size(105, 36);
            this.lbKills.TabIndex = 1;
            this.lbKills.Text = "Kills: 0";
            // 
            // txtHealth
            // 
            this.txtHealth.AutoSize = true;
            this.txtHealth.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtHealth.ForeColor = System.Drawing.Color.White;
            this.txtHealth.Location = new System.Drawing.Point(1102, 39);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(109, 36);
            this.txtHealth.TabIndex = 2;
            this.txtHealth.Text = "Health:";
            // 
            // healthBar
            // 
            this.healthBar.BackColor = System.Drawing.Color.Gray;
            this.healthBar.Location = new System.Drawing.Point(1220, 40);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(253, 30);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::ShooterGame.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(754, 452);
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
            this.lbRestart.Font = new System.Drawing.Font("Franklin Gothic Demi", 26.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRestart.ForeColor = System.Drawing.Color.Transparent;
            this.lbRestart.Location = new System.Drawing.Point(475, 300);
            this.lbRestart.Name = "lbRestart";
            this.lbRestart.Size = new System.Drawing.Size(606, 51);
            this.lbRestart.TabIndex = 5;
            this.lbRestart.Text = "Press ENTER to restart game";
            this.lbRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbRestart.UseWaitCursor = true;
            this.lbRestart.Visible = false;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbScore.ForeColor = System.Drawing.Color.White;
            this.lbScore.Location = new System.Drawing.Point(586, 39);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(123, 36);
            this.lbScore.TabIndex = 6;
            this.lbScore.Text = "Score: 0";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(856, 39);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(170, 36);
            this.lbTime.TabIndex = 7;
            this.lbTime.Text = "Time: 00:00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackgroundColorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BackgroundColorToolStripMenuItem
            // 
            this.BackgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BlueToolStripMenuItem,
            this.GreenToolStripMenuItem,
            this.RedToolStripMenuItem,
            this.YellowToolStripMenuItem,
            this.greyToolStripMenuItem});
            this.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem";
            this.BackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.BackgroundColorToolStripMenuItem.Text = "Background Color";
            // 
            // BlueToolStripMenuItem
            // 
            this.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem";
            this.BlueToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.BlueToolStripMenuItem.Text = "Blue";
            this.BlueToolStripMenuItem.Click += new System.EventHandler(this.kékToolStripMenuItem_Click);
            // 
            // GreenToolStripMenuItem
            // 
            this.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem";
            this.GreenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.GreenToolStripMenuItem.Text = "Green";
            this.GreenToolStripMenuItem.Click += new System.EventHandler(this.zöldToolStripMenuItem_Click);
            // 
            // RedToolStripMenuItem
            // 
            this.RedToolStripMenuItem.Name = "RedToolStripMenuItem";
            this.RedToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.RedToolStripMenuItem.Text = "Red";
            this.RedToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.RedToolStripMenuItem.Click += new System.EventHandler(this.pirosToolStripMenuItem_Click);
            // 
            // YellowToolStripMenuItem
            // 
            this.YellowToolStripMenuItem.Name = "YellowToolStripMenuItem";
            this.YellowToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.YellowToolStripMenuItem.Text = "Yellow";
            this.YellowToolStripMenuItem.Click += new System.EventHandler(this.sárgaToolStripMenuItem_Click);
            // 
            // greyToolStripMenuItem
            // 
            this.greyToolStripMenuItem.Name = "greyToolStripMenuItem";
            this.greyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.greyToolStripMenuItem.Text = "Gray";
            this.greyToolStripMenuItem.Click += new System.EventHandler(this.greyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbRestart);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.lbKills);
            this.Controls.Add(this.lbAmmo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Zombie Shooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAmmo;
        private System.Windows.Forms.Label lbKills;
        private System.Windows.Forms.Label txtHealth;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lbRestart;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem YellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyToolStripMenuItem;
    }
}

