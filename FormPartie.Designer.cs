namespace Code_MS_BlackJack
{
    partial class FormPartie
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPartie));
            this.Qs = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Qs)).BeginInit();
            this.SuspendLayout();
            // 
            // Qs
            // 
            this.Qs.BackgroundImage = global::Code_MS_BlackJack.Properties.Resources.Qs;
            this.Qs.Location = new System.Drawing.Point(71, 42);
            this.Qs.Name = "Qs";
            this.Qs.Size = new System.Drawing.Size(72, 96);
            this.Qs.TabIndex = 0;
            this.Qs.TabStop = false;
            // 
            // FormPartie
            // 
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(785, 483);
            this.Controls.Add(this.Qs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPartie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MS BlackJack";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPartie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Qs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Qs;
    }
}
