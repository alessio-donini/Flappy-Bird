using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floppy_bird
{
    public partial class Form1 : Form
    {

        int velocitaOstacoli = 8;
        int gravita = 10;
        int score = 0;
       
       
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            if (startgame == true && playPressed == true)
            {
                taptapbox.Visible = false;
                flappy_bird.Top += gravita;

                Ostacoloinf.Left -= velocitaOstacoli;
                Ostacolosup.Left -= velocitaOstacoli;
                Scoretext.Text = "score: " + score;

                int numerogenerato = 0;

                Random randomtuboup = new Random();
                Random randomtuboinf = new Random();
                if (Ostacolosup.Left < -100)
                {
                    Ostacolosup.Left = 600;


                    numerogenerato = randomtuboup.Next(-300, 15);



                    Ostacolosup.Location = new Point(600, numerogenerato);
                }
                if (Ostacoloinf.Left < -100)
                {
                    Ostacoloinf.Left = 600;
                    score++;

                    numerogenerato = randomtuboinf.Next(350, 700);

                    Ostacoloinf.Location = new Point(600, numerogenerato - 144);

                }


                if (flappy_bird.Bounds.IntersectsWith(Ostacoloinf.Bounds) ||
                    flappy_bird.Bounds.IntersectsWith(Ostacolosup.Bounds) ||
                    flappy_bird.Bounds.IntersectsWith(sfondo.Bounds) ||
                    flappy_bird.Bounds.IntersectsWith(soffitto.Bounds)
                    )
                {
                    endgame();
                }

                if (score > 5)
                {
                    velocitaOstacoli = 25;
                }



            }
       

        }



        bool startgame = false;
        private void gamekaydawn(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                startgame = true;


            }


            if (startgame == true && playPressed == true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    gameTimer.Enabled = true;
                    if (flappy_bird.Top >= 0)
                    {
                        gravita = -10;
                    }
                }
            }
       


        }

        private void gamekayup(object sender, KeyEventArgs e)
        {
     
            if (startgame == true&&playPressed==true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    gameTimer.Enabled = true;
                    if (flappy_bird.Top >= 0)
                    {
                        gravita = 10;
                    }
                }
            } 




        }

        private void endgame()
        {
             gameTimer.Stop();
          
            gameTimer.Enabled = false;
            podium.Visible = true;
            play.Visible = true;
            game_over.Visible = true;
            playPressed = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void soffitto_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public bool playPressed = false;
        private void play_Click(object sender, EventArgs e)
        {
            taptapbox.Visible = true;
            play.Visible = false;
            startgame = false;
            game_over.Visible = false;
            podium.Visible = false;
            gameTimer.Enabled = true;
            playPressed = true;
            velocitaOstacoli = 8;
            gravita = 10;
            score = 0;
            Ostacolosup.Location = new Point(492, -131); 
            Ostacoloinf.Location = new Point(492, 398);
            flappy_bird.Location = new Point(134, 281);
        }

      
    }
}
