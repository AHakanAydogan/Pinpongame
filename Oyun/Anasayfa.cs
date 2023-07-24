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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
            KeyPreview = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds=Screen.PrimaryScreen.Bounds;

            EasyNoColorButton.Top = (playground.Height/ EasyNoColorButton.Height)* 20;
            EasyNoColorButton.Left = (playground.Width / EasyNoColorButton.Width) * 90;
            MedNoColorButton.Top = (playground.Height / MedNoColorButton.Height) * 30;
            MedNoColorButton.Left = (playground.Width / MedNoColorButton.Width) * 90;
            HardNoColorButton.Top = (playground.Height / HardNoColorButton.Height) * 40;
            HardNoColorButton.Left = (playground.Width / HardNoColorButton.Width) * 90;
            EasyButton.Top = (playground.Height / EasyButton.Height) * 20;
            EasyButton.Left = (playground.Width / EasyButton.Width) * 50;
            MedButton.Top = (playground.Height / MedButton.Height) * 30;
            MedButton.Left = (playground.Width / MedButton.Width) * 50;
            HardButton.Top = (playground.Height / HardButton.Height) * 40;
            HardButton.Left = (playground.Width / HardButton.Width) * 50;
            WoColorChange_lbl.Left = (playground.Width / WoColorChange_lbl.Width) * 117;
            WoColorChange_lbl.Top = (playground.Height / WoColorChange_lbl.Height) * 5;
            ColorChange_lbl.Left = (playground.Width / ColorChange_lbl.Width) * 59;
            ColorChange_lbl.Top = (playground.Height / ColorChange_lbl.Height) * 5;
            
        }


        private void Anasayfa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) 
            {
                this.Close();
            }
        }

        private void EasyNoColorButton_Click(object sender, EventArgs e)
        {
            GameForm EasyGameNoColorForm = new GameForm();
            EasyGameNoColorForm.difficulties = 'e';
            EasyGameNoColorForm.color = false;
            EasyGameNoColorForm.ShowDialog();
            this.Close();
        }

        private void MedNoColorButton_Click(object sender, EventArgs e)
        {
            GameForm MedGameNoColorForm = new GameForm();
            MedGameNoColorForm.difficulties = 'm';
            MedGameNoColorForm.color = false;
            MedGameNoColorForm.ShowDialog();
            this.Close();
        }

        private void HardNoColorButton_Click(object sender, EventArgs e)
        {
            GameForm HardGameNoColorForm = new GameForm();
            HardGameNoColorForm.difficulties = 'h';
            HardGameNoColorForm.color = false;
            HardGameNoColorForm.ShowDialog();
            this.Close();
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            GameForm EasyGameForm2 = new GameForm();
            EasyGameForm2.difficulties = 'e';
            EasyGameForm2.color = true;
            EasyGameForm2.ShowDialog();
            this.Close();
        }

        private void MedButton_Click(object sender, EventArgs e)
        {
            GameForm MediumGameForm = new GameForm();
            MediumGameForm.difficulties = 'm';
            MediumGameForm.color = true;
            MediumGameForm.ShowDialog();
            this.Close();
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            GameForm HardGameForm = new GameForm();
            HardGameForm.difficulties = 'h';
            HardGameForm.color = true;
            HardGameForm.ShowDialog();
            this.Close();
        }

    }
}
