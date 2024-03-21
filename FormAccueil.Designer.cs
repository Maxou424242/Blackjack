namespace Code_MS_BlackJack
{
    partial class FormAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
            this.BoutonJouer = new System.Windows.Forms.Button();
            this.TextAccueil = new System.Windows.Forms.TextBox();
            this.BoutonPseudo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BoutonJetons = new System.Windows.Forms.Button();
            this.PictureBackGround = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BoutonJouer
            // 
            this.BoutonJouer.BackColor = System.Drawing.Color.Green;
            this.BoutonJouer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoutonJouer.Font = new System.Drawing.Font("Microsoft YaHei", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoutonJouer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BoutonJouer.Location = new System.Drawing.Point(792, 767);
            this.BoutonJouer.Name = "BoutonJouer";
            this.BoutonJouer.Size = new System.Drawing.Size(491, 177);
            this.BoutonJouer.TabIndex = 2;
            this.BoutonJouer.Text = "Jouer";
            this.BoutonJouer.UseVisualStyleBackColor = false;
            this.BoutonJouer.Click += new System.EventHandler(this.BoutonJouer_click);
            // 
            // TextAccueil
            // 
            this.TextAccueil.BackColor = System.Drawing.Color.ForestGreen;
            this.TextAccueil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextAccueil.Font = new System.Drawing.Font("Modern No. 20", 79.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAccueil.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TextAccueil.Location = new System.Drawing.Point(568, 12);
            this.TextAccueil.Name = "TextAccueil";
            this.TextAccueil.Size = new System.Drawing.Size(897, 143);
            this.TextAccueil.TabIndex = 3;
            this.TextAccueil.Text = "MS BlackJack";
            this.TextAccueil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextAccueil.TextChanged += new System.EventHandler(this.TextAccueil_TextChanged);
            // 
            // BoutonPseudo
            // 
            this.BoutonPseudo.BackColor = System.Drawing.Color.ForestGreen;
            this.BoutonPseudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoutonPseudo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BoutonPseudo.FlatAppearance.BorderSize = 0;
            this.BoutonPseudo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BoutonPseudo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.BoutonPseudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoutonPseudo.Font = new System.Drawing.Font("Imprint MT Shadow", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoutonPseudo.Location = new System.Drawing.Point(0, 0);
            this.BoutonPseudo.Name = "BoutonPseudo";
            this.BoutonPseudo.Size = new System.Drawing.Size(427, 50);
            this.BoutonPseudo.TabIndex = 4;
            this.BoutonPseudo.Text = "Pseudo";
            this.BoutonPseudo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BoutonPseudo.UseVisualStyleBackColor = false;
            this.BoutonPseudo.Click += new System.EventHandler(this.BoutonPseudo_click);
            // 
            // BoutonJetons
            // 
            this.BoutonJetons.BackColor = System.Drawing.Color.ForestGreen;
            this.BoutonJetons.FlatAppearance.BorderSize = 0;
            this.BoutonJetons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoutonJetons.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoutonJetons.Location = new System.Drawing.Point(1525, 0);
            this.BoutonJetons.Name = "BoutonJetons";
            this.BoutonJetons.Size = new System.Drawing.Size(331, 63);
            this.BoutonJetons.TabIndex = 5;
            this.BoutonJetons.Text = "Jetons";
            this.BoutonJetons.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BoutonJetons.UseVisualStyleBackColor = false;
            this.BoutonJetons.Click += new System.EventHandler(this.BoutonJetons_click);
            // 
            // PictureBackGround
            // 
            this.PictureBackGround.BackgroundImage = global::Code_MS_BlackJack.Properties.Resources.blackjack;
            this.PictureBackGround.Location = new System.Drawing.Point(0, 180);
            this.PictureBackGround.Name = "PictureBackGround";
            this.PictureBackGround.Size = new System.Drawing.Size(1941, 559);
            this.PictureBackGround.TabIndex = 1;
            this.PictureBackGround.TabStop = false;
            this.PictureBackGround.Click += new System.EventHandler(this.PictureBoxBackGround_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.BoutonJetons);
            this.Controls.Add(this.BoutonPseudo);
            this.Controls.Add(this.TextAccueil);
            this.Controls.Add(this.BoutonJouer);
            this.Controls.Add(this.PictureBackGround);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MS BlackJack";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAccueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PictureBackGround;
        private System.Windows.Forms.Button BoutonJouer;
        private System.Windows.Forms.TextBox TextAccueil;
        private System.Windows.Forms.Button BoutonPseudo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BoutonJetons;
    }
}

