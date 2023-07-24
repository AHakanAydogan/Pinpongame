using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyun
{
    public partial class gameForm : Form
    {
        public int speed_left=1;
        public int speed_top=1;
        public int points = 0;
        public int highscore = 0;
        public char difficulties;
        public bool color;



        public gameForm()
        {
            
            InitializeComponent();
            points = 0;
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds=Screen.PrimaryScreen.Bounds;

            racket.Top = playGround.Bottom-(playGround.Bottom/15);
            racket.Left = playGround.Width/2-(racket.Width/2);
            TopRacket.Left=playGround.Width/2-(TopRacket.Width/2);
            TopRacket.Top = playGround.Top + (TopRacket.Height*2);
            gameover_lbl.Left=playGround.Width/2-(gameover_lbl.Width/2);
            gameover_lbl.Top=playGround.Height/2-(gameover_lbl.Height/2);
            gameover_lbl.Visible = false;
            hghpoints_lbl.Visible = false;
            hghscore_lbl.Visible=false;

        

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gameover_lbl_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (difficulties == 'e')
            {
                speed_left = 5;
                speed_top = 5;
                difficulties = 'x';
            }
            else if (difficulties == 'm')
            {
                speed_left = 8;
                speed_top = 8;
                difficulties = 'y';
            }
            else if (difficulties == 'h')
            {
                speed_left = 12;
                speed_top = 12;
                difficulties = 'z';
            }

            racket.Left=Cursor.Position.X-(racket.Width/2);
            ball.Left += speed_left;
            ball.Top += speed_top;


            if (ball.Left <= playGround.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= playGround.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top<= playGround.Top)
            {
                gameover_lbl.Visible = true;
                if (points > highscore)
                {
                    hghpoints_lbl.Text = points.ToString();
                    highscore = points;
                }
                hghpoints_lbl.Visible = true;
                hghscore_lbl.Visible = true;
                timer1.Enabled = false;
            }
            if (ball.Bottom>= playGround.Bottom)
            {
                gameover_lbl.Visible = true;
                if (points > highscore)
                {
                hghpoints_lbl.Text=points.ToString();
                    highscore = points;
                }
                hghpoints_lbl.Visible = true;
                hghscore_lbl.Visible = true;
                timer1.Enabled = false;

            }
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left>=racket.Left && ball.Right<=racket.Right) 
            {
                switch(difficulties)
                { 
                    case 'x':
                        speed_top += 1;
                        speed_left += 1;
                        break;
                    case 'y':
                        speed_left += 2;
                        speed_top += 2;
                        break;
                    case 'z':
                        speed_left += 3;
                        speed_top += 3;
                        break;

                }

                speed_top = -speed_top;

                points += 1;
                points_lbl.Text= points.ToString();

                if (color)
                {
                    Random r = new Random();
                    playGround.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
                }


            }
            if(ball.Top <= TopRacket.Bottom && ball.Top <= TopRacket.Bottom && ball.Left >= TopRacket.Left && ball.Right <= TopRacket.Right)
            {
                switch (difficulties)
                {
                    case 'x':
                        speed_top -= 1;
                        speed_left += 1;
                        break;
                    case 'y':
                        speed_left += 2;
                        speed_top -= 2;
                        break;
                    case 'z':
                        speed_left += 3;
                        speed_top -= 3;
                        break;

                }
                
                speed_top = -speed_top;

                points += 1;
                points_lbl.Text = points.ToString();

                if (color)
                {
                    Random r = new Random();
                    playGround.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
                }
            }
        }

        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                TopRacket.Left += 100;
            }
            if (e.KeyCode == Keys.A)
            {
                TopRacket.Left -= 100;
            }
            if (e.KeyCode == Keys.Escape) 
            {
            this.Close();
            }
            if(e.KeyCode == Keys.F1)
            {
                Random r = new Random();
                ball.Top = r.Next(300,600);
                ball.Left = r.Next(900, 1000);
                switch (difficulties)
                {
                    case 'x':
                        speed_left = 5;
                        speed_top = 5;
                        break;
                    case 'y':
                        speed_left = 8;
                        speed_top = 8;
                        break;
                    case 'z':
                        speed_left = 12;
                        speed_top = 12;
                        break;

                }
                
                points = 0;
                points_lbl.Text = "0";
                timer1.Enabled = true;
                gameover_lbl.Visible = false;
                hghpoints_lbl.Visible = false;
                hghscore_lbl.Visible = false;
                playGround.BackColor = Color.White;
            }
            if (e.KeyCode == Keys.F2)
            {
            Anasayfa anasayfa = new Anasayfa();
                anasayfa.ShowDialog();
                this.Close();
            
            }
        }

        private void playground_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
