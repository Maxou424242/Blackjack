namespace Code_MS_BlackJack
{
    partial class FormPseudo
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
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
            this.TextBoxPseudo = new System.Windows.Forms.TextBox();
            this.BoutonOkPseudo = new System.Windows.Forms.Button();
            this.AfficheInfo1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxPseudo
            // 
            this.TextBoxPseudo.Location = new System.Drawing.Point(19, 92);
            this.TextBoxPseudo.Name = "TextBoxPseudo";
            this.TextBoxPseudo.Size = new System.Drawing.Size(363, 22);
            this.TextBoxPseudo.TabIndex = 0;
            this.TextBoxPseudo.TextChanged += new System.EventHandler(this.TextBoxPseudo_TextChanged);
            // 
            // BoutonOkPseudo
            // 
            this.BoutonOkPseudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoutonOkPseudo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BoutonOkPseudo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoutonOkPseudo.Location = new System.Drawing.Point(381, 173);
            this.BoutonOkPseudo.Name = "BoutonOkPseudo";
            this.BoutonOkPseudo.Size = new System.Drawing.Size(75, 23);
            this.BoutonOkPseudo.TabIndex = 1;
            this.BoutonOkPseudo.Text = "OK";
            this.BoutonOkPseudo.UseVisualStyleBackColor = true;
            this.BoutonOkPseudo.Click += new System.EventHandler(this.BoutonOkPseudo_Click);
            // 
            // AfficheInfo1
            // 
            this.AfficheInfo1.AutoSize = true;
            this.AfficheInfo1.Font = new System.Drawing.Font("NSimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfficheInfo1.Location = new System.Drawing.Point(15, 31);
            this.AfficheInfo1.Name = "AfficheInfo1";
            this.AfficheInfo1.Size = new System.Drawing.Size(346, 23);
            this.AfficheInfo1.TabIndex = 2;
            this.AfficheInfo1.Text = "Veuillez saisir votre pseudo";
            // 
            // FormPseudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 210);
            this.Controls.Add(this.AfficheInfo1);
            this.Controls.Add(this.BoutonOkPseudo);
            this.Controls.Add(this.TextBoxPseudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPseudo";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormPseudo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BoutonOkPseudo;
        private System.Windows.Forms.Label AfficheInfo1;
        public System.Windows.Forms.TextBox TextBoxPseudo;
    }
}
