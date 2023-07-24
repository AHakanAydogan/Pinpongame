namespace Oyun
{
    partial class Anasayfa
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
            this.playground = new System.Windows.Forms.Panel();
            this.esclabel = new System.Windows.Forms.Label();
            this.WoColorChange_lbl = new System.Windows.Forms.Label();
            this.ColorChange_lbl = new System.Windows.Forms.Label();
            this.HardButton = new System.Windows.Forms.Button();
            this.HardNoColorButton = new System.Windows.Forms.Button();
            this.MedButton = new System.Windows.Forms.Button();
            this.MedNoColorButton = new System.Windows.Forms.Button();
            this.EasyButton = new System.Windows.Forms.Button();
            this.EasyNoColorButton = new System.Windows.Forms.Button();
            this.playground.SuspendLayout();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.esclabel);
            this.playground.Controls.Add(this.WoColorChange_lbl);
            this.playground.Controls.Add(this.ColorChange_lbl);
            this.playground.Controls.Add(this.HardButton);
            this.playground.Controls.Add(this.HardNoColorButton);
            this.playground.Controls.Add(this.MedButton);
            this.playground.Controls.Add(this.MedNoColorButton);
            this.playground.Controls.Add(this.EasyButton);
            this.playground.Controls.Add(this.EasyNoColorButton);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(800, 450);
            this.playground.TabIndex = 0;
            // 
            // esclabel
            // 
            this.esclabel.AutoSize = true;
            this.esclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esclabel.Location = new System.Drawing.Point(3, 1);
            this.esclabel.Name = "esclabel";
            this.esclabel.Size = new System.Drawing.Size(255, 31);
            this.esclabel.TabIndex = 4;
            this.esclabel.Text = "ESC - EXIT GAME";
            // 
            // WoColorChange_lbl
            // 
            this.WoColorChange_lbl.AutoSize = true;
            this.WoColorChange_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WoColorChange_lbl.Location = new System.Drawing.Point(437, 32);
            this.WoColorChange_lbl.Name = "WoColorChange_lbl";
            this.WoColorChange_lbl.Size = new System.Drawing.Size(206, 25);
            this.WoColorChange_lbl.TabIndex = 3;
            this.WoColorChange_lbl.Text = "Without Color Change";
            // 
            // ColorChange_lbl
            // 
            this.ColorChange_lbl.AutoSize = true;
            this.ColorChange_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ColorChange_lbl.Location = new System.Drawing.Point(178, 32);
            this.ColorChange_lbl.Name = "ColorChange_lbl";
            this.ColorChange_lbl.Size = new System.Drawing.Size(179, 25);
            this.ColorChange_lbl.TabIndex = 3;
            this.ColorChange_lbl.Text = "With Color Change";
            // 
            // HardButton
            // 
            this.HardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HardButton.Location = new System.Drawing.Point(194, 276);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(150, 75);
            this.HardButton.TabIndex = 2;
            this.HardButton.Text = "HARD";
            this.HardButton.UseVisualStyleBackColor = true;
            this.HardButton.Click += new System.EventHandler(this.HardButton_Click);
            // 
            // HardNoColorButton
            // 
            this.HardNoColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HardNoColorButton.Location = new System.Drawing.Point(468, 276);
            this.HardNoColorButton.Name = "HardNoColorButton";
            this.HardNoColorButton.Size = new System.Drawing.Size(150, 75);
            this.HardNoColorButton.TabIndex = 2;
            this.HardNoColorButton.Text = "HARD";
            this.HardNoColorButton.UseVisualStyleBackColor = true;
            this.HardNoColorButton.Click += new System.EventHandler(this.HardNoColorButton_Click);
            // 
            // MedButton
            // 
            this.MedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MedButton.Location = new System.Drawing.Point(194, 171);
            this.MedButton.Name = "MedButton";
            this.MedButton.Size = new System.Drawing.Size(150, 75);
            this.MedButton.TabIndex = 1;
            this.MedButton.Text = "MEDIUM";
            this.MedButton.UseVisualStyleBackColor = true;
            this.MedButton.Click += new System.EventHandler(this.MedButton_Click);
            // 
            // MedNoColorButton
            // 
            this.MedNoColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MedNoColorButton.Location = new System.Drawing.Point(468, 171);
            this.MedNoColorButton.Name = "MedNoColorButton";
            this.MedNoColorButton.Size = new System.Drawing.Size(150, 75);
            this.MedNoColorButton.TabIndex = 1;
            this.MedNoColorButton.Text = "MEDIUM";
            this.MedNoColorButton.UseVisualStyleBackColor = true;
            this.MedNoColorButton.Click += new System.EventHandler(this.MedNoColorButton_Click);
            // 
            // EasyButton
            // 
            this.EasyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EasyButton.Location = new System.Drawing.Point(194, 72);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(150, 75);
            this.EasyButton.TabIndex = 0;
            this.EasyButton.Text = "EASY";
            this.EasyButton.UseVisualStyleBackColor = true;
            this.EasyButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // EasyNoColorButton
            // 
            this.EasyNoColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EasyNoColorButton.Location = new System.Drawing.Point(468, 72);
            this.EasyNoColorButton.Name = "EasyNoColorButton";
            this.EasyNoColorButton.Size = new System.Drawing.Size(150, 75);
            this.EasyNoColorButton.TabIndex = 0;
            this.EasyNoColorButton.Text = "EASY";
            this.EasyNoColorButton.UseVisualStyleBackColor = true;
            this.EasyNoColorButton.Click += new System.EventHandler(this.EasyNoColorButton_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playground);
            this.Name = "Anasayfa";
            this.Text = "Oyun";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Anasayfa_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Button HardNoColorButton;
        private System.Windows.Forms.Button MedNoColorButton;
        private System.Windows.Forms.Button EasyNoColorButton;
        private System.Windows.Forms.Button HardButton;
        private System.Windows.Forms.Button MedButton;
        private System.Windows.Forms.Button EasyButton;
        private System.Windows.Forms.Label WoColorChange_lbl;
        private System.Windows.Forms.Label ColorChange_lbl;
        private System.Windows.Forms.Label esclabel;
    }
}