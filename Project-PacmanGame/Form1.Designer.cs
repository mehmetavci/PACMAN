namespace Project_PacmanGame
{
    partial class FormPacman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPacman));
            this.timerPacmanDirection = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbPacman = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.imageListGhost = new System.Windows.Forms.ImageList(this.components);
            this.timerGhostDirection = new System.Windows.Forms.Timer(this.components);
            this.pbHak3 = new System.Windows.Forms.PictureBox();
            this.pbHak2 = new System.Windows.Forms.PictureBox();
            this.pbHak1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHak3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHak2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHak1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerPacmanDirection
            // 
            this.timerPacmanDirection.Tick += new System.EventHandler(this.timerPacmanDirection_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pacmanRight.png");
            this.imageList1.Images.SetKeyName(1, "pacmanLeft.png");
            this.imageList1.Images.SetKeyName(2, "pacmanDown.png");
            this.imageList1.Images.SetKeyName(3, "pacmanUp.png");
            // 
            // pbPacman
            // 
            this.pbPacman.BackColor = System.Drawing.Color.Transparent;
            this.pbPacman.BackgroundImage = global::Project_PacmanGame.Properties.Resources.Pacman;
            this.pbPacman.Location = new System.Drawing.Point(37, 37);
            this.pbPacman.Name = "pbPacman";
            this.pbPacman.Size = new System.Drawing.Size(50, 50);
            this.pbPacman.TabIndex = 0;
            this.pbPacman.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore.Location = new System.Drawing.Point(1148, 203);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 20);
            this.lblScore.TabIndex = 2;
            // 
            // imageListGhost
            // 
            this.imageListGhost.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListGhost.ImageStream")));
            this.imageListGhost.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListGhost.Images.SetKeyName(0, "Pacman-orange-c1lyde.sh.png");
            this.imageListGhost.Images.SetKeyName(1, "Pacman-orange-clyde.sh.png");
            this.imageListGhost.Images.SetKeyName(2, "GreenGhost.png");
            // 
            // timerGhostDirection
            // 
            this.timerGhostDirection.Tick += new System.EventHandler(this.timerGhostDirection_Tick);
            // 
            // pbHak3
            // 
            this.pbHak3.Image = global::Project_PacmanGame.Properties.Resources.Pacman;
            this.pbHak3.Location = new System.Drawing.Point(1131, 12);
            this.pbHak3.Name = "pbHak3";
            this.pbHak3.Size = new System.Drawing.Size(50, 50);
            this.pbHak3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHak3.TabIndex = 7;
            this.pbHak3.TabStop = false;
            // 
            // pbHak2
            // 
            this.pbHak2.Image = global::Project_PacmanGame.Properties.Resources.Pacman;
            this.pbHak2.Location = new System.Drawing.Point(1131, 68);
            this.pbHak2.Name = "pbHak2";
            this.pbHak2.Size = new System.Drawing.Size(50, 50);
            this.pbHak2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHak2.TabIndex = 8;
            this.pbHak2.TabStop = false;
            // 
            // pbHak1
            // 
            this.pbHak1.Image = global::Project_PacmanGame.Properties.Resources.Pacman;
            this.pbHak1.Location = new System.Drawing.Point(1131, 124);
            this.pbHak1.Name = "pbHak1";
            this.pbHak1.Size = new System.Drawing.Size(50, 50);
            this.pbHak1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHak1.TabIndex = 9;
            this.pbHak1.TabStop = false;
            // 
            // FormPacman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1203, 560);
            this.Controls.Add(this.pbHak1);
            this.Controls.Add(this.pbHak2);
            this.Controls.Add(this.pbHak3);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbPacman);
            this.Name = "FormPacman";
            this.Text = "Pacman";
            this.Load += new System.EventHandler(this.FormPacman_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPacman_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHak3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHak2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHak1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerPacmanDirection;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pbPacman;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ImageList imageListGhost;
        private System.Windows.Forms.Timer timerGhostDirection;
        private System.Windows.Forms.PictureBox pbHak3;
        private System.Windows.Forms.PictureBox pbHak2;
        private System.Windows.Forms.PictureBox pbHak1;
    }
}

