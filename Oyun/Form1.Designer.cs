namespace Oyun
{
    partial class gameForm
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
            this.playGround = new System.Windows.Forms.Panel();
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.hghpoints_lbl = new System.Windows.Forms.Label();
            this.points_lbl = new System.Windows.Forms.Label();
            this.hghscore_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playGround
            // 
            this.playGround.Controls.Add(this.gameover_lbl);
            this.playGround.Controls.Add(this.hghpoints_lbl);
            this.playGround.Controls.Add(this.points_lbl);
            this.playGround.Controls.Add(this.hghscore_lbl);
            this.playGround.Controls.Add(this.score_lbl);
            this.playGround.Controls.Add(this.ball);
            this.playGround.Controls.Add(this.racket);
            this.playGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playGround.Location = new System.Drawing.Point(0, 0);
            this.playGround.Name = "playGround";
            this.playGround.Size = new System.Drawing.Size(800, 450);
            this.playGround.TabIndex = 0;
            this.playGround.Paint += new System.Windows.Forms.PaintEventHandler(this.playground_Paint);
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameover_lbl.Location = new System.Drawing.Point(303, 52);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(373, 329);
            this.gameover_lbl.TabIndex = 4;
            this.gameover_lbl.Text = "Game Over!\r\n\r\nF1 - Restart Game\r\n\r\nF2 - Main Menu\r\n\r\nESC - Exit Game\r\n";
            this.gameover_lbl.Click += new System.EventHandler(this.gameover_lbl_Click);
            // 
            // hghpoints_lbl
            // 
            this.hghpoints_lbl.AutoSize = true;
            this.hghpoints_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hghpoints_lbl.Location = new System.Drawing.Point(266, 98);
            this.hghpoints_lbl.Name = "hghpoints_lbl";
            this.hghpoints_lbl.Size = new System.Drawing.Size(46, 51);
            this.hghpoints_lbl.TabIndex = 3;
            this.hghpoints_lbl.Text = "0";
            this.hghpoints_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hghpoints_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // points_lbl
            // 
            this.points_lbl.AutoSize = true;
            this.points_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.points_lbl.Location = new System.Drawing.Point(170, 47);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(46, 51);
            this.points_lbl.TabIndex = 3;
            this.points_lbl.Text = "0";
            this.points_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.points_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // hghscore_lbl
            // 
            this.hghscore_lbl.AutoSize = true;
            this.hghscore_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hghscore_lbl.Location = new System.Drawing.Point(29, 98);
            this.hghscore_lbl.Name = "hghscore_lbl";
            this.hghscore_lbl.Size = new System.Drawing.Size(247, 51);
            this.hghscore_lbl.TabIndex = 2;
            this.hghscore_lbl.Text = "High Score:";
            this.hghscore_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score_lbl.Location = new System.Drawing.Point(29, 47);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(147, 51);
            this.score_lbl.TabIndex = 2;
            this.score_lbl.Text = "Score:";
            this.score_lbl.Click += new System.EventHandler(this.label1_Click);
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
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(290, 361);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(300, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playGround);
            this.Name = "gameForm";
            this.Text = "Ping Pong Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyDown);
            this.playGround.ResumeLayout(false);
            this.playGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playGround;
        private System.Windows.Forms.Label points_lbl;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Label gameover_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label hghpoints_lbl;
        private System.Windows.Forms.Label hghscore_lbl;
    }
}

