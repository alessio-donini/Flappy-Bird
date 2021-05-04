namespace Floppy_bird
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Scoretext = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.game_over = new System.Windows.Forms.Label();
            this.taptapbox = new System.Windows.Forms.PictureBox();
            this.podium = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            this.flappy_bird = new System.Windows.Forms.PictureBox();
            this.sfondo = new System.Windows.Forms.PictureBox();
            this.Ostacoloinf = new System.Windows.Forms.PictureBox();
            this.Ostacolosup = new System.Windows.Forms.PictureBox();
            this.soffitto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.taptapbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ostacoloinf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ostacolosup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soffitto)).BeginInit();
            this.SuspendLayout();
            // 
            // Scoretext
            // 
            this.Scoretext.AutoSize = true;
            this.Scoretext.BackColor = System.Drawing.Color.BurlyWood;
            this.Scoretext.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoretext.Location = new System.Drawing.Point(3, 721);
            this.Scoretext.Name = "Scoretext";
            this.Scoretext.Size = new System.Drawing.Size(144, 37);
            this.Scoretext.TabIndex = 4;
            this.Scoretext.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // game_over
            // 
            this.game_over.AutoSize = true;
            this.game_over.BackColor = System.Drawing.Color.Transparent;
            this.game_over.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_over.ForeColor = System.Drawing.Color.Red;
            this.game_over.Location = new System.Drawing.Point(224, 152);
            this.game_over.Name = "game_over";
            this.game_over.Size = new System.Drawing.Size(370, 85);
            this.game_over.TabIndex = 12;
            this.game_over.Text = "Game Over";
            this.game_over.Visible = false;
            // 
            // taptapbox
            // 
            this.taptapbox.ErrorImage = null;
            this.taptapbox.Image = global::Floppy_bird.Properties.Resources.logo;
            this.taptapbox.Location = new System.Drawing.Point(272, 263);
            this.taptapbox.Name = "taptapbox";
            this.taptapbox.Size = new System.Drawing.Size(274, 129);
            this.taptapbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.taptapbox.TabIndex = 13;
            this.taptapbox.TabStop = false;
            // 
            // podium
            // 
            this.podium.Image = global::Floppy_bird.Properties.Resources.podium;
            this.podium.Location = new System.Drawing.Point(458, 452);
            this.podium.Name = "podium";
            this.podium.Size = new System.Drawing.Size(114, 93);
            this.podium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.podium.TabIndex = 11;
            this.podium.TabStop = false;
            this.podium.Visible = false;
            // 
            // play
            // 
            this.play.Image = global::Floppy_bird.Properties.Resources.play_button;
            this.play.Location = new System.Drawing.Point(225, 452);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(111, 93);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.play.TabIndex = 10;
            this.play.TabStop = false;
            this.play.Visible = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // flappy_bird
            // 
            this.flappy_bird.Image = ((System.Drawing.Image)(resources.GetObject("flappy_bird.Image")));
            this.flappy_bird.Location = new System.Drawing.Point(134, 281);
            this.flappy_bird.Name = "flappy_bird";
            this.flappy_bird.Size = new System.Drawing.Size(78, 60);
            this.flappy_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappy_bird.TabIndex = 2;
            this.flappy_bird.TabStop = false;
            // 
            // sfondo
            // 
            this.sfondo.Image = ((System.Drawing.Image)(resources.GetObject("sfondo.Image")));
            this.sfondo.Location = new System.Drawing.Point(-10, 654);
            this.sfondo.Name = "sfondo";
            this.sfondo.Size = new System.Drawing.Size(918, 125);
            this.sfondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sfondo.TabIndex = 3;
            this.sfondo.TabStop = false;
            // 
            // Ostacoloinf
            // 
            this.Ostacoloinf.Image = ((System.Drawing.Image)(resources.GetObject("Ostacoloinf.Image")));
            this.Ostacoloinf.Location = new System.Drawing.Point(492, 398);
            this.Ostacoloinf.Name = "Ostacoloinf";
            this.Ostacoloinf.Size = new System.Drawing.Size(105, 500);
            this.Ostacoloinf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ostacoloinf.TabIndex = 1;
            this.Ostacoloinf.TabStop = false;
            // 
            // Ostacolosup
            // 
            this.Ostacolosup.Image = ((System.Drawing.Image)(resources.GetObject("Ostacolosup.Image")));
            this.Ostacolosup.Location = new System.Drawing.Point(492, -131);
            this.Ostacolosup.Name = "Ostacolosup";
            this.Ostacolosup.Size = new System.Drawing.Size(105, 388);
            this.Ostacolosup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ostacolosup.TabIndex = 0;
            this.Ostacolosup.TabStop = false;
            // 
            // soffitto
            // 
            this.soffitto.Location = new System.Drawing.Point(-1, -11);
            this.soffitto.Name = "soffitto";
            this.soffitto.Size = new System.Drawing.Size(811, 13);
            this.soffitto.TabIndex = 5;
            this.soffitto.TabStop = false;
            this.soffitto.Click += new System.EventHandler(this.soffitto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(803, 767);
            this.Controls.Add(this.taptapbox);
            this.Controls.Add(this.game_over);
            this.Controls.Add(this.podium);
            this.Controls.Add(this.play);
            this.Controls.Add(this.Scoretext);
            this.Controls.Add(this.flappy_bird);
            this.Controls.Add(this.sfondo);
            this.Controls.Add(this.Ostacoloinf);
            this.Controls.Add(this.Ostacolosup);
            this.Controls.Add(this.soffitto);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Flappy  Bird ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekaydawn);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekayup);
            ((System.ComponentModel.ISupportInitialize)(this.taptapbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ostacoloinf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ostacolosup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soffitto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ostacolosup;
        private System.Windows.Forms.PictureBox Ostacoloinf;
        private System.Windows.Forms.PictureBox flappy_bird;
        private System.Windows.Forms.PictureBox sfondo;
        private System.Windows.Forms.Label Scoretext;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox soffitto;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox podium;
        private System.Windows.Forms.Label game_over;
        private System.Windows.Forms.PictureBox taptapbox;
    }
}

