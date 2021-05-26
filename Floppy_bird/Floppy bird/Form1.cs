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
        DataTable table = new DataTable();
        int velocitaOstacoli = 10;//dichiarazione variabile per la velocità degli ostacoli
        int gravita = 10;//dichiarazione variabile per far muovere su o giù il flappy
        int score = 0;//dichiarazione variabile che tiene il conto del punteggio di gioco
        int incrementotubi = 0;//dichiarazione variabile per l'incremento dei tubi
        
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)//funzione svolgimento codice di gioco  
        {
            ScoreboardDGW.Visible = false;

            if (startgame == true && playPressed == true)
            {
                taptapbox.Visible = false;
                flappy_bird.Top += gravita;// Serve per far scendere il flappy
                Ostacoloinf.Left -= velocitaOstacoli; //per spostare gli ostacoli
                Ostacolosup.Left -= velocitaOstacoli;//per spostare gli ostacoli
                Scoretext.Text = "score: " + score;// per tener conto del punteggio della partita
                int numerogenerato = 0;
                Random randomtuboup = new Random();// generatore random per il tubo superiore 
                Random randomtuboinf = new Random();// generatore random per il tubo superiore

                if (Ostacolosup.Left < -100)// serve per controllare lo spawn nei tubi
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

                if (Ostacolosup.Location.X == 600)// serve per far apparire il tubo ad una distanza di 600 uno dall'altro
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

                if (score % 2 == 0 && score > 3 && Ostacolosup.Location.X < 134 && incrementotubi == 0)//serve a far aumentare la velocità dei tubi dopo il 3 ostacolo
                {
                    velocitaOstacoli += 4;
                    incrementotubi++;
                }
            }
        }

        bool startgame = false;
        private void gamekaydawn(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)//se l'utente clicca sulla barraszaziatrice il gioco inizia
            {
                startgame = true;
            }
            if (startgame == true && playPressed == true) // se l'utente ha cliccato sulla barra spaziatrice ed ha avviato il gioco correttamente allora il gioco si avvia 
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

        private void gamekayup(object sender, KeyEventArgs e)// funzione per il controllo del movimento del flappy
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
            gameTimer.Stop();//una volta terminata la pertita il timer si ferma
            gameTimer.Enabled = false;
            podium.Visible = true;
            play.Visible = true;
            game_over.Visible = true;
            playPressed = false;
            inseriscinickname.Visible = true;
            utente.Visible = true;
            conferma.Visible = true;
            utente.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Nome Utente", typeof(string));// viene creata la colonna del DGW dove apparirà il nickname
            table.Columns.Add("Punteggio", typeof(int));// viene creata la colonna del DGW dove apparirà il punteggio
            ScoreboardDGW.DataSource = table;
        }

        private void soffitto_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public bool playPressed = false;

        private void play_Click(object sender, EventArgs e)// funzione che regola il tasto per ricominciare a giocare
        {
            ricominciaGioco();
        }

        private void ricominciaGioco()
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
            utente.Visible = false;
            inseriscinickname.Visible = false;            
            conferma.Visible = false;
        }

        private void podium_Click(object sender, EventArgs e)
        {
            ScoreboardDGW.Visible = true;
            ScoreboardDGW.Enabled = true;
            utente.Visible = false;
            conferma.Visible = false;
            inseriscinickname.Visible = false;
        }

        private void conferma_Click(object sender, EventArgs e)
        { 
            conferma.Visible = false;
            utente.Visible = false;
            inseriscinickname.Visible = false;         
            if (String.IsNullOrEmpty(utente.Text))//controllo se il giocatore ha inserito un nome, in caso contrario chiedo di rifarlo
            {
                MessageBox.Show("ERRORE nickname non inserito!!!");
                inseriscinickname.Visible = true;
                utente.Visible = true;
                conferma.Visible = true;
            }
            else
            {
                table.Clear();
               
                string file = "score.txt";// crea il file in cui vengono salvati i punteggi
                string percorso = AppDomain.CurrentDomain.BaseDirectory + file;// percorso del file
                StreamWriter punteggi = new StreamWriter("score.txt", true);// scrivono nel file il nickname e il punteggio
                punteggi.WriteLine(utente.Text + " - " + score);
                punteggi.Close();
                MessageBox.Show("Punteggio salvato!!!\nOra guarda la classifica");
                StreamReader classifica = new StreamReader(percorso);    
                string[] linee = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + file);
                string[] values;
                for (int i = 0; i < linee.Length; i++)// trascrive tutte le righe in values
                {
                    values = linee[i].ToString().Split('-');
                    string[] righe = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        righe[j] = values[j].Trim();
                    }
                    table.Rows.Add(righe);
                }
                classifica.Close();
            }
        }

        private void Controllonickname_Click(object sender, EventArgs e)
        {
            inseriscinickname.Visible = true;
            conferma.Visible = true;
            utente.Visible = true;
        }

        private void game_over_Click(object sender, EventArgs e)
        {

        }
    }
}

