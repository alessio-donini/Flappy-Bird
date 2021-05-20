using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Floppy_bird
{
    public partial class Form1 : Form
    {

        int velocitaOstacoli = 10;
        int gravita = 10;
        int score = 0;
        int incrementotubi = 0;
        static string risultatiPartita = @"risultatiPartita.txt";
        static string percorsoFileRisultatiPartita = AppDomain.CurrentDomain.BaseDirectory + risultatiPartita;
        string nomeGiocatore;


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
                if (Ostacolosup.Location.X == 600)
                {
                    incrementotubi = 0;

                }

                if (flappy_bird.Bounds.IntersectsWith(Ostacoloinf.Bounds) ||
                    flappy_bird.Bounds.IntersectsWith(Ostacolosup.Bounds) ||
                    flappy_bird.Bounds.IntersectsWith(sfondo.Bounds) ||
                    flappy_bird.Bounds.IntersectsWith(soffitto.Bounds)
                    )
                {
                    endgame();
                }


                if (score % 2 == 0 && score > 5 && Ostacolosup.Location.X < 134 && incrementotubi == 0)
                {
                    velocitaOstacoli += 4;
                    incrementotubi++;




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

            if (startgame == true && playPressed == true)
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
          
            inseriscinickname.Visible = true;
            classifica.Visible = true;
            conferma.Visible = true;
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
            classifica.Visible = false;
            inseriscinickname.Visible = false;
            Controllonickname.Visible = false;
            conferma.Visible = false;
        }

        private void podium_Click(object sender, EventArgs e)
        {
            var Punteggi = File.ReadAllLines(percorsoFileRisultatiPartita);
            for (int i=0; i < Punteggi.ToArray().Length; i++)
            {
                string[] puntiClassifica = Punteggi[i].Split(',');
                string[] puntiClassifica2 = Punteggi[i+1].Split(',');
                string temp = "";
            
                if (Convert.ToInt32(puntiClassifica[1]) > Convert.ToInt32(puntiClassifica2[1]))
                {
                    temp = Punteggi[i];
                    Punteggi[i] = Punteggi[i + 1];
                    Punteggi[i + 1] = temp;
                }
            }
        }

        private void esistenzaFile()
        {
            if (!File.Exists(percorsoFileRisultatiPartita))
            {
                using (StreamWriter sv = File.CreateText(percorsoFileRisultatiPartita))
                {

                }
            }
        }
        private void controlloPunteggio()
        {
           
            if (nomeGiocatore != "")
            {
                var Punteggi = File.ReadAllLines(percorsoFileRisultatiPartita);
                if (Punteggi.ToArray().Length != 0)
                {
                    for (int i = 0; i < Punteggi.ToArray().Length; i++)
                    {
                        string[] dettagligiocatore = Punteggi[i].Split(',');
                        if (nomeGiocatore == dettagligiocatore[0])
                        {                        
                            if (score > Convert.ToInt32(dettagligiocatore[1]))
                            {
                                dettagligiocatore[1] = score.ToString();
                                Punteggi[i] = $"{dettagligiocatore[0]},{dettagligiocatore[1]}";
                                File.WriteAllLines(percorsoFileRisultatiPartita, Punteggi);
                                Controllonickname.Visible = false;
                            }

                        }
                        else
                        {                           
                            if (dettagligiocatore[0] != "")
                            {
                                nuovoGiocatore(Punteggi.ToArray());
                            }
                        }
                    }
                }
                else
                {
                    nuovoGiocatore(Punteggi.ToArray());
                }
               
            }
            else
            {
                Controllonickname.Visible = true;
            }
        }
        private void nuovoGiocatore(string [] punteggi )
        {
            Array.Resize(ref punteggi, punteggi.Length + 1);
            punteggi[punteggi.Length - 1] = $"{nomeGiocatore},{score}";
            File.WriteAllLines(percorsoFileRisultatiPartita, punteggi);
            Controllonickname.Visible = false;
        }

        private void conferma_Click(object sender, EventArgs e)
        {

            nomeGiocatore = classifica.Text;
            esistenzaFile();
            controlloPunteggio();
        }

    }
}