﻿using System;
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
    public partial class gameFormMedWo : Form
    {
        public int speed_left = 8;
        public int speed_top = 8;
        public int points = 0;
        public int highscore = 0;
        public gameFormMedWo()
        {
            InitializeComponent();
            points = 0;
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            racket.Top = playGround.Bottom - (playGround.Bottom / 15);
            racket.Left = playGround.Width / 2 - (racket.Width / 2);
            gameover_lbl.Left = playGround.Width / 2 - (gameover_lbl.Width / 2);
            gameover_lbl.Top = playGround.Height / 2 - (gameover_lbl.Height / 2);
            gameover_lbl.Visible = false;
            hghpoints_lbl.Visible = false;
            hghscore_lbl.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
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
            if (ball.Top <= playGround.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= playGround.Bottom)
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
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_top += 3;
                speed_left += 3;
                speed_top = -speed_top;

                points += 1;
                points_lbl.Text = points.ToString();
            }
        }

        private void gameFormMedWo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F1)
            {
                Random r = new Random();
                ball.Top = r.Next(300, 600);
                ball.Left = r.Next(300, 600);
                speed_left = 8;
                speed_top = 8;
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
    }
}
