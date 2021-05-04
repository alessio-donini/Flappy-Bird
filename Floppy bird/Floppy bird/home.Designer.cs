namespace Floppy_bird
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.Scoretext = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flappy_bird = new System.Windows.Forms.PictureBox();
            this.Ostacolosup = new System.Windows.Forms.PictureBox();
            this.sfondo = new System.Windows.Forms.PictureBox();
            this.Ostacoloinf = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ostacolosup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ostacoloinf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.Scoretext.TabIndex = 8;
            this.Scoretext.Text = "Score: 0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Floppy_bird.Properties.Resources.podium;
            this.pictureBox2.Location = new System.Drawing.Point(457, 398);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Floppy_bird.Properties.Resources.play_button;
            this.pictureBox1.Location = new System.Drawing.Point(214, 398);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flappy_bird
            // 
            this.flappy_bird.Image = ((System.Drawing.Image)(resources.GetObject("flappy_bird.Image")));
            this.flappy_bird.Location = new System.Drawing.Point(134, 281);
            this.flappy_bird.Name = "flappy_bird";
            this.flappy_bird.Size = new System.Drawing.Size(78, 60);
            this.flappy_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappy_bird.TabIndex = 7;
            this.flappy_bird.TabStop = false;
            // 
            // Ostacolosup
            // 
            this.Ostacolosup.Image = ((System.Drawing.Image)(resources.GetObject("Ostacolosup.Image")));
            this.Ostacolosup.Location = new System.Drawing.Point(590, -125);
            this.Ostacolosup.Name = "Ostacolosup";
            this.Ostacolosup.Size = new System.Drawing.Size(105, 388);
            this.Ostacolosup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ostacolosup.TabIndex = 6;
            this.Ostacolosup.TabStop = false;
            // 
            // sfondo
            // 
            this.sfondo.Image = ((System.Drawing.Image)(resources.GetObject("sfondo.Image")));
            this.sfondo.Location = new System.Drawing.Point(-18, 649);
            this.sfondo.Name = "sfondo";
            this.sfondo.Size = new System.Drawing.Size(918, 125);
            this.sfondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sfondo.TabIndex = 4;
            this.sfondo.TabStop = false;
            // 
            // Ostacoloinf
            // 
            this.Ostacoloinf.Image = ((System.Drawing.Image)(resources.GetObject("Ostacoloinf.Image")));
            this.Ostacoloinf.Location = new System.Drawing.Point(590, 398);
            this.Ostacoloinf.Name = "Ostacoloinf";
            this.Ostacoloinf.Size = new System.Drawing.Size(105, 443);
            this.Ostacoloinf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ostacoloinf.TabIndex = 5;
            this.Ostacoloinf.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Floppy_bird.Properties.Resources.flappy_bird_logo;
            this.pictureBox3.Location = new System.Drawing.Point(236, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(346, 182);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(803, 767);
            this.Controls.Add(this.Ostacolosup);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Scoretext);
            this.Controls.Add(this.flappy_bird);
            this.Controls.Add(this.sfondo);
            this.Controls.Add(this.Ostacoloinf);
            this.Name = "home";
            this.Text = "Flappy Bird";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ostacolosup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ostacoloinf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sfondo;
        private System.Windows.Forms.PictureBox Ostacoloinf;
        private System.Windows.Forms.PictureBox Ostacolosup;
        private System.Windows.Forms.PictureBox flappy_bird;
        private System.Windows.Forms.Label Scoretext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}