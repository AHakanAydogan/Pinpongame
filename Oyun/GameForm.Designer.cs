namespace Oyun
{
    partial class GameForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlayGround = new System.Windows.Forms.Panel();
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.hghpoints_lbl = new System.Windows.Forms.Label();
            this.points_lbl = new System.Windows.Forms.Label();
            this.hghscore_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.TopRacket = new System.Windows.Forms.PictureBox();
            this.Racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayGround
            // 
            this.PlayGround.Controls.Add(this.gameover_lbl);
            this.PlayGround.Controls.Add(this.hghpoints_lbl);
            this.PlayGround.Controls.Add(this.points_lbl);
            this.PlayGround.Controls.Add(this.hghscore_lbl);
            this.PlayGround.Controls.Add(this.score_lbl);
            this.PlayGround.Controls.Add(this.ball);
            this.PlayGround.Controls.Add(this.TopRacket);
            this.PlayGround.Controls.Add(this.Racket);
            this.PlayGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayGround.Location = new System.Drawing.Point(0, 0);
            this.PlayGround.Name = "PlayGround";
            this.PlayGround.Size = new System.Drawing.Size(800, 450);
            this.PlayGround.TabIndex = 0;
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameover_lbl.Location = new System.Drawing.Point(303, 52);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(373, 329);
            this.gameover_lbl.TabIndex = 4;
            this.gameover_lbl.Text = "Game Over!\r\n\r\nF1 - Restart Game\r\n\r\nF2 - Main Menu\r\n\r\nESC - Exit Game\r\n";
            // 
            // hghpoints_lbl
            // 
            this.hghpoints_lbl.AutoSize = true;
            this.hghpoints_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hghpoints_lbl.Location = new System.Drawing.Point(249, 211);
            this.hghpoints_lbl.Name = "hghpoints_lbl";
            this.hghpoints_lbl.Size = new System.Drawing.Size(46, 51);
            this.hghpoints_lbl.TabIndex = 3;
            this.hghpoints_lbl.Text = "0";
            this.hghpoints_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // points_lbl
            // 
            this.points_lbl.AutoSize = true;
            this.points_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.points_lbl.Location = new System.Drawing.Point(153, 160);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(46, 51);
            this.points_lbl.TabIndex = 3;
            this.points_lbl.Text = "0";
            this.points_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hghscore_lbl
            // 
            this.hghscore_lbl.AutoSize = true;
            this.hghscore_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hghscore_lbl.Location = new System.Drawing.Point(12, 211);
            this.hghscore_lbl.Name = "hghscore_lbl";
            this.hghscore_lbl.Size = new System.Drawing.Size(247, 51);
            this.hghscore_lbl.TabIndex = 2;
            this.hghscore_lbl.Text = "High Score:";
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score_lbl.Location = new System.Drawing.Point(12, 160);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(147, 51);
            this.score_lbl.TabIndex = 2;
            this.score_lbl.Text = "Score:";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(261, 274);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // TopRacket
            // 
            this.TopRacket.BackColor = System.Drawing.Color.Black;
            this.TopRacket.Location = new System.Drawing.Point(275, 12);
            this.TopRacket.Name = "TopRacket";
            this.TopRacket.Size = new System.Drawing.Size(300, 20);
            this.TopRacket.TabIndex = 0;
            this.TopRacket.TabStop = false;
            // 
            // Racket
            // 
            this.Racket.BackColor = System.Drawing.Color.Black;
            this.Racket.Location = new System.Drawing.Point(290, 361);
            this.Racket.Name = "Racket";
            this.Racket.Size = new System.Drawing.Size(300, 20);
            this.Racket.TabIndex = 0;
            this.Racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayGround);
            this.Name = "GameForm";
            this.Text = "Ping Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.PlayGround.ResumeLayout(false);
            this.PlayGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlayGround;
        private System.Windows.Forms.Label points_lbl;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox Racket;
        private System.Windows.Forms.Label gameover_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label hghpoints_lbl;
        private System.Windows.Forms.Label hghscore_lbl;
        private System.Windows.Forms.PictureBox TopRacket;
    }
}

