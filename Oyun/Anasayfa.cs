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
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds=Screen.PrimaryScreen.Bounds;

            button1.Top = (playground.Height/ button1.Height)* 20;
            button1.Left = (playground.Width / button1.Width) * 90;
            button2.Top = (playground.Height / button2.Height) * 30;
            button2.Left = (playground.Width / button2.Width) * 90;
            button3.Top = (playground.Height / button3.Height) * 40;
            button3.Left = (playground.Width / button3.Width) * 90;
            button4.Top = (playground.Height / button4.Height) * 20;
            button4.Left = (playground.Width / button4.Width) * 50;
            button5.Top = (playground.Height / button5.Height) * 30;
            button5.Left = (playground.Width / button5.Width) * 50;
            button6.Top = (playground.Height / button6.Height) * 40;
            button6.Left = (playground.Width / button6.Width) * 50;
            wocolorchange_lbl.Left = (playground.Width / wocolorchange_lbl.Width) * 117;
            wocolorchange_lbl.Top = (playground.Height / wocolorchange_lbl.Height) * 5;
            colorchange_lbl.Left = (playground.Width / colorchange_lbl.Width) * 59;
            colorchange_lbl.Top = (playground.Height / colorchange_lbl.Height) * 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            gameForm EasyGameForm2 = new gameForm();
            EasyGameForm2.difficulties='e';
            EasyGameForm2.color = true;
            EasyGameForm2.ShowDialog();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            gameForm MediumGameForm= new gameForm();
            MediumGameForm.difficulties = 'm';
            MediumGameForm.color = true;
            MediumGameForm.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gameForm HardGameForm=new gameForm();
            HardGameForm.difficulties = 'h';
            HardGameForm.color = true;
            HardGameForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameForm EasyGameNoColorForm=new gameForm();
            EasyGameNoColorForm.difficulties = 'e';
            EasyGameNoColorForm.color = false;
            EasyGameNoColorForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameForm MedGameNoColorForm= new gameForm();
            MedGameNoColorForm.difficulties = 'm';
            MedGameNoColorForm.color = false;
            MedGameNoColorForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gameForm HardGameNoColorForm = new gameForm();
            HardGameNoColorForm.difficulties = 'h';
            HardGameNoColorForm.color = false;
            HardGameNoColorForm.ShowDialog();
            this.Close();
        }
    }
}
