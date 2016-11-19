using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PacmanGame
{
    public partial class FormPacman : Form
    {
        public FormPacman()
        {
            InitializeComponent();
        }

        List<PictureBox> ForageList = new List<PictureBox>();
        string[] directionsArray = { "Right", "Left", "Up", "Down" };
        Random rnd = new Random();
        string direction = "Right";
        int score, hak = 3;
        PictureBox ghost1, ghost2,ghost3;

        public void Win()
        {
            timerPacmanDirection.Stop();
            timerGhostDirection.Stop();
            DialogResult result = MessageBox.Show("Tebrikler !!!!" + "\n Tekrar Oynamak İster Misiniz?", "Pacman", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                ResetEverything();

            }
            else if (result == DialogResult.Cancel)
            {
                ApplicationExit();
            }

            pbPacman.Location = new Point(37, 37);
            pbPacman.BackgroundImage = imageList1.Images[0];
            pbPacman.BackColor = Color.Transparent;
            direction = "Right";
        }

        public void GoToReturn()
        {
            hak--;
            if (hak == 2)
            {
                pbHak1.Visible = false;
            }
            else if (hak == 1)
            {
                pbHak2.Visible = false;
            }
            else if (hak == 0)
            {
                pbHak3.Visible = false;
                timerPacmanDirection.Stop();
                timerGhostDirection.Stop();
                DialogResult result = MessageBox.Show("Puanınız=> " + score + "\n Tekrar Oynamak İster Misiniz?", "Pacman", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    ResetEverything();
                    
                }
                else if (result == DialogResult.Cancel)
                {
                    ApplicationExit();
                }
            }

            pbPacman.Location = new Point(37, 37);
            pbPacman.BackgroundImage = imageList1.Images[0];
            pbPacman.BackColor = Color.Transparent;
            direction = "Right";
        }

        public void ApplicationExit()
        {
            Application.Exit();
        }

        public void ResetEverything()
        {
            hak = 3;
            pbHak1.Visible = true;
            pbHak2.Visible = true;
            pbHak3.Visible = true;
            for (int i = 0; i <210; i++)
            {
                this.Controls.Remove(ForageList[i]);
               
            }
            ForageList.Clear();
            timerPacmanDirection.Start();
            CreateForage();
            timerGhostDirection.Start();
            ghost1.Location = new Point(390, 240);
            ghost3.Location = new Point(490, 240);
            ghost2.Location = new Point(590, 240);
            ghost1.BringToFront();
            ghost2.BringToFront();
            ghost3.BringToFront();
            score = 0;
            lblScore.Text = 0.ToString();
        }

        public void CreateForage()
        {
            for (int i = 50; i <= 1050; i += 50)
            {
                for (int j = 50; j <= 500; j += 50)
                {
                    PictureBox forage = new PictureBox();
                 
                    forage.Name = "forage" + i + j;
                    forage.Size = new Size(20, 20);
                    forage.Location = new Point(i, j);
                    forage.BackgroundImageLayout = ImageLayout.Stretch;
                    forage.BackColor = Color.Transparent;
                    forage.BackgroundImage = Properties.Resources.Forage;
                    forage.BackgroundImageLayout = ImageLayout.Stretch;
                    ForageList.Add(forage);
                    this.Controls.Add(forage);
                }
            }
            ForageList[0].Visible = false;
            this.Controls.Remove(ForageList[0]);
            this.Controls.Remove(ForageList[65]);
            this.Controls.Remove(ForageList[64]);
            this.Controls.Remove(ForageList[63]);
            this.Controls.Remove(ForageList[75]);
            this.Controls.Remove(ForageList[85]);
            this.Controls.Remove(ForageList[95]);
            this.Controls.Remove(ForageList[105]);
            this.Controls.Remove(ForageList[115]);
            this.Controls.Remove(ForageList[125]);
            this.Controls.Remove(ForageList[124]);
            this.Controls.Remove(ForageList[123]);
        }

        public void CreateWall()
        {
            for (int i = 0; i <= 1100; i += 20)
            {
                for (int j = 0; j <= 540; j += 20)
                {
                    if (i == 0 || j == 0 || i == 1100 || j == 540)
                    {
                        Label wall = new Label();
                        wall.Name = "Wall" + i + j;
                        wall.Size = new Size(15, 15);
                        wall.Location = new Point(i, j);
                        wall.BackColor = Color.Blue;
                        wall.BringToFront();
                        this.Controls.Add(wall);
                    }

                    if (((i >= 340 && i <= 360) && (j >= 200 && j <= 300)) || ((j >= 300 && j <= 320) && (i >= 340 && i <= 660)) || ((i >= 640 && i <= 660) && (j <= 300 && j >= 200)))
                    {
                        Label wall2 = new Label();
                        wall2.Name = "Wall2" + i + j;
                        wall2.Size = new Size(15, 15);
                        wall2.Location = new Point(i, j);
                        wall2.BackColor = Color.Blue;
                        wall2.BringToFront();
                        this.Controls.Add(wall2);
                    }

                }
            }

        }

        public void CreateGhost()
        {
            ghost1 = new PictureBox();
            ghost2 = new PictureBox();
            ghost3 = new PictureBox();

            ghost1.Location = new Point(390, 240);
            ghost1.BackgroundImage = imageListGhost.Images[0];
            ghost1.BackgroundImageLayout = ImageLayout.Zoom;
            ghost1.Size = new Size(45, 45);
            ghost1.BackColor = Color.Transparent;

            ghost2.Location = new Point(590, 240);
            ghost2.BackgroundImage = imageListGhost.Images[1];
            ghost2.BackgroundImageLayout = ImageLayout.Zoom;
            ghost2.Size = new Size(45, 45);
            ghost2.BackColor = Color.Transparent;

            ghost3.Location = new Point(490, 240);
            ghost3.BackgroundImage = imageListGhost.Images[2];
            ghost3.BackgroundImageLayout = ImageLayout.Zoom;
            ghost3.Size = new Size(45, 45);
            ghost3.BackColor = Color.Transparent;

            ghost1.BringToFront();
            ghost2.BringToFront();
            ghost3.BringToFront();
            this.Controls.Add(ghost1);
            this.Controls.Add(ghost2);
            this.Controls.Add(ghost3);
        }

        private void FormPacman_Load(object sender, EventArgs e)
        {
            timerPacmanDirection.Start();
            CreateForage();
            CreateWall();
            CreateGhost();
            timerGhostDirection.Start();
            ghost1.BringToFront();
            ghost2.BringToFront();
            ghost3.BringToFront();
        }

        private void timerPacmanDirection_Tick(object sender, EventArgs e)
        {
            timerPacmanDirection.Interval = 100;
            Movement();
            lblScore.Text = score.ToString();
        }

        private void FormPacman_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                direction = "Up";
                pbPacman.BackgroundImage = imageList1.Images[3];
                pbPacman.BackColor = Color.Transparent;
            }
            else if (e.KeyCode == Keys.Down)
            {
                direction = "Down";
                pbPacman.BackgroundImage = imageList1.Images[2];
                pbPacman.BackColor = Color.Transparent;
            }
            else if (e.KeyCode == Keys.Right)
            {
                direction = "Right";
                pbPacman.BackgroundImage = imageList1.Images[0];
                pbPacman.BackColor = Color.Transparent;
            }
            else if (e.KeyCode == Keys.Left)
            {
                direction = "Left";
                pbPacman.BackgroundImage = imageList1.Images[1];
                pbPacman.BackColor = Color.Transparent;
            }
        }

        public void Movement()
        {
            if(score == 198)
            {
                Win();
            }

            if (direction == "Up")
            {
                if (50 <= pbPacman.Top && !(pbPacman.Top == 337 && (pbPacman.Left == 337 || pbPacman.Left == 387 || pbPacman.Left == 437 || pbPacman.Left == 487 || pbPacman.Left == 537 || pbPacman.Left == 587 || pbPacman.Left == 637)))
                {
                    pbPacman.Top -= 50;
                    foreach (var item in this.ForageList)
                    {
                        if (pbPacman.Top < item.Bottom && pbPacman.Bottom > item.Top && pbPacman.Left <= item.Right && pbPacman.Right >= item.Left)
                        {
                            if (item.Visible == true)
                                score++;
                            Controls.Remove(item);
                            item.Visible = false;
                        }
                    }

                    if ((pbPacman.Top < ghost1.Bottom && pbPacman.Bottom > ghost1.Top && pbPacman.Left <= ghost1.Right && pbPacman.Right >= ghost1.Left) || (pbPacman.Top < ghost2.Bottom && pbPacman.Bottom > ghost2.Top && pbPacman.Left <= ghost2.Right && pbPacman.Right >= ghost2.Left) || (pbPacman.Top < ghost3.Bottom && pbPacman.Bottom > ghost3.Top && pbPacman.Left <= ghost3.Right && pbPacman.Right >= ghost3.Left))
                    {
                        GoToReturn();
                    }

                }
            }
            else if (direction == "Down")
            {

                if (this.ClientSize.Height - 30 >= pbPacman.Bottom && !(pbPacman.Top == 137 && (pbPacman.Left == 637 && pbPacman.Right == 687)) && !(pbPacman.Top == 137 && (pbPacman.Left == 337 && pbPacman.Right == 387)) && !(pbPacman.Top == 237 && (pbPacman.Left == 387 || pbPacman.Left == 437 || pbPacman.Left == 487 || pbPacman.Left == 537 || pbPacman.Left == 587)))
                {
                    pbPacman.Top += 50;
                    foreach (var item in this.ForageList)
                    {
                        if (pbPacman.Top < item.Bottom && pbPacman.Bottom > item.Top && pbPacman.Left <= item.Right && pbPacman.Right >= item.Left)
                        {

                            if (item.Visible == true)
                                score++;
                            Controls.Remove(item);
                            item.Visible = false;
                        }
                    }

                    if ((pbPacman.Top < ghost1.Bottom && pbPacman.Bottom > ghost1.Top && pbPacman.Left <= ghost1.Right && pbPacman.Right >= ghost1.Left) || (pbPacman.Top < ghost2.Bottom && pbPacman.Bottom > ghost2.Top && pbPacman.Left <= ghost2.Right && pbPacman.Right >= ghost2.Left) || (pbPacman.Top < ghost3.Bottom && pbPacman.Bottom > ghost3.Top && pbPacman.Left <= ghost3.Right && pbPacman.Right >= ghost3.Left))
                    {
                        GoToReturn();
                    }
                }

            }
            else if (direction == "Right")
            {
                if (1050 >= pbPacman.Right && !(pbPacman.Right == 337 && (pbPacman.Top == 187 || pbPacman.Top == 237 || pbPacman.Top == 287)) && !(pbPacman.Right == 637 && (pbPacman.Top == 187 || pbPacman.Top == 237)))
                {
                    pbPacman.Left += 50;


                    foreach (var item in this.ForageList)
                    {
                        if (pbPacman.Top <= item.Bottom && pbPacman.Bottom >= item.Top && pbPacman.Left < item.Right && pbPacman.Right > item.Left)
                        {
                            if (item.Visible == true)
                                score++;
                            Controls.Remove(item);
                            item.Visible = false;
                        }
                    }

                    if ((pbPacman.Top <= ghost1.Bottom && pbPacman.Bottom >= ghost1.Top && pbPacman.Left < ghost1.Right && pbPacman.Right > ghost1.Left) || (pbPacman.Top <= ghost2.Bottom && pbPacman.Bottom >= ghost2.Top && pbPacman.Left < ghost2.Right && pbPacman.Right > ghost2.Left) || (pbPacman.Top <= ghost3.Bottom && pbPacman.Bottom >= ghost3.Top && pbPacman.Left < ghost3.Right && pbPacman.Right > ghost3.Left))
                    {
                        GoToReturn();
                    }

                }

            }
            else if (direction == "Left")
            {
                if (50 <= pbPacman.Left && !(pbPacman.Right == 737 && (pbPacman.Top == 187 || pbPacman.Top == 237 || pbPacman.Top == 287)) && !(pbPacman.Right == 437 && (pbPacman.Top == 187 || pbPacman.Top == 237)))
                {
                    pbPacman.Left -= 50;
                    foreach (var item in this.ForageList)
                    {
                        if (pbPacman.Top <= item.Bottom && pbPacman.Bottom >= item.Top && pbPacman.Left < item.Right && pbPacman.Right > item.Left)
                        {
                            if (item.Visible == true)
                                score++;
                            Controls.Remove(item);
                            item.Visible = false;
                        }
                    }

                    if ((pbPacman.Top <= ghost1.Bottom && pbPacman.Bottom >= ghost1.Top && pbPacman.Left < ghost1.Right && pbPacman.Right > ghost1.Left) || (pbPacman.Top <= ghost2.Bottom && pbPacman.Bottom >= ghost2.Top && pbPacman.Left < ghost2.Right && pbPacman.Right > ghost2.Left) || (pbPacman.Top <= ghost3.Bottom && pbPacman.Bottom >= ghost3.Top && pbPacman.Left < ghost3.Right && pbPacman.Right > ghost3.Left))
                    {
                        GoToReturn();
                    }


                }

            }
        }

        private void timerGhostDirection_Tick(object sender, EventArgs e)
        {
            timerGhostDirection.Interval = 200;
            string ghost1Move = directionsArray[rnd.Next(0, 4)];
            string ghost2Move = directionsArray[rnd.Next(0, 4)];
            string ghost3Move = directionsArray[rnd.Next(0, 4)];
            GhostMove(ghost1Move, ghost1);
            GhostMove(ghost2Move, ghost2);
            GhostMove(ghost3Move, ghost3);
        }

        public void GhostMove(string directionGhost, PictureBox ghost)
        {

            if (directionGhost == "Up")
            {
                if (50 <= ghost.Top && !(ghost.Top == 340 && (ghost.Left == 340 || ghost.Left == 390 || ghost.Left == 440 || ghost.Left == 490 || ghost.Left == 540 || ghost.Left == 590 || ghost.Left == 640)))
                {
                    ghost.Top -= 50;

                    if (pbPacman.Top < ghost.Bottom && pbPacman.Bottom > ghost.Top && pbPacman.Left <= ghost.Right && pbPacman.Right >= ghost.Left)
                    {
                        GoToReturn();
                    }
                }
            }
            else if (directionGhost == "Down")
            {

                if (this.ClientSize.Height - 30 >= ghost.Bottom && !(ghost.Top == 140 && (ghost.Left == 640 && ghost.Right == 685)) && !(ghost.Top == 140 && (ghost.Left == 340 && ghost.Right == 385)) && !(ghost.Top == 240 && (ghost.Left == 390 || ghost.Left == 440 || ghost.Left == 490 || ghost.Left == 540 || ghost.Left == 590)))
                {
                    ghost.Top += 50;

                    if (pbPacman.Top < ghost.Bottom && pbPacman.Bottom > ghost.Top && pbPacman.Left <= ghost.Right && pbPacman.Right >= ghost.Left)
                    {
                        GoToReturn();
                    }
                }

            }
            else if (directionGhost == "Right")
            {
                if (1050 >= ghost.Right && !(ghost.Right == 335 && (ghost.Top == 190 || ghost.Top == 240 || ghost.Top == 290)) && !(ghost.Right == 635 && (ghost.Top == 190 || ghost.Top == 240)))
                {
                    ghost.Left += 50;

                    if (pbPacman.Top <= ghost.Bottom && pbPacman.Bottom >= ghost.Top && pbPacman.Left < ghost.Right && pbPacman.Right > ghost.Left)
                    {
                        GoToReturn();
                    }
                }

            }
            else if (directionGhost == "Left")
            {
                if (50 <= ghost.Left && !(ghost.Right == 735 && (ghost.Top == 190 || ghost.Top == 240 || ghost.Top == 290)) && !(ghost.Right == 435 && (ghost.Top == 190 || ghost.Top == 240)))
                {
                    ghost.Left -= 50;

                    if (pbPacman.Top <= ghost.Bottom && pbPacman.Bottom >= ghost.Top && pbPacman.Left < ghost.Right && pbPacman.Right > ghost.Left)
                    {
                        GoToReturn();
                    }

                }

            }

        }
    }
}
