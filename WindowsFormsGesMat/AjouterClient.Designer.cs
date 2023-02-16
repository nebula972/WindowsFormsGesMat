namespace WindowsFormsGesMat
{
    partial class AjouterClient
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
            this.textBoxNewClient = new System.Windows.Forms.TextBox();
            this.textBoxNewAdresse = new System.Windows.Forms.TextBox();
            this.textBoxNewTel = new System.Windows.Forms.TextBox();
            this.textBoxNewMail = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelAdressecli = new System.Windows.Forms.Label();
            this.labelTelcli = new System.Windows.Forms.Label();
            this.labelMailcli = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNewClient
            // 
            this.textBoxNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxNewClient.Location = new System.Drawing.Point(129, 42);
            this.textBoxNewClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNewClient.Name = "textBoxNewClient";
            this.textBoxNewClient.Size = new System.Drawing.Size(289, 39);
            this.textBoxNewClient.TabIndex = 0;
            // 
            // textBoxNewAdresse
            // 
            this.textBoxNewAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxNewAdresse.Location = new System.Drawing.Point(129, 101);
            this.textBoxNewAdresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNewAdresse.Name = "textBoxNewAdresse";
            this.textBoxNewAdresse.Size = new System.Drawing.Size(289, 39);
            this.textBoxNewAdresse.TabIndex = 1;
            // 
            // textBoxNewTel
            // 
            this.textBoxNewTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxNewTel.Location = new System.Drawing.Point(129, 161);
            this.textBoxNewTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNewTel.Name = "textBoxNewTel";
            this.textBoxNewTel.Size = new System.Drawing.Size(289, 39);
            this.textBoxNewTel.TabIndex = 2;
            // 
            // textBoxNewMail
            // 
            this.textBoxNewMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxNewMail.Location = new System.Drawing.Point(129, 218);
            this.textBoxNewMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNewMail.Name = "textBoxNewMail";
            this.textBoxNewMail.Size = new System.Drawing.Size(289, 39);
            this.textBoxNewMail.TabIndex = 3;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(55, 45);
            this.labelClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(57, 20);
            this.labelClient.TabIndex = 4;
            this.labelClient.Text = "Client :";
            // 
            // labelAdressecli
            // 
            this.labelAdressecli.AutoSize = true;
            this.labelAdressecli.Location = new System.Drawing.Point(36, 104);
            this.labelAdressecli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdressecli.Name = "labelAdressecli";
            this.labelAdressecli.Size = new System.Drawing.Size(76, 20);
            this.labelAdressecli.TabIndex = 5;
            this.labelAdressecli.Text = "Adresse :";
            // 
            // labelTelcli
            // 
            this.labelTelcli.AutoSize = true;
            this.labelTelcli.Location = new System.Drawing.Point(20, 164);
            this.labelTelcli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelcli.Name = "labelTelcli";
            this.labelTelcli.Size = new System.Drawing.Size(92, 20);
            this.labelTelcli.TabIndex = 6;
            this.labelTelcli.Text = "Telephone :";
            // 
            // labelMailcli
            // 
            this.labelMailcli.AutoSize = true;
            this.labelMailcli.Location = new System.Drawing.Point(67, 221);
            this.labelMailcli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMailcli.Name = "labelMailcli";
            this.labelMailcli.Size = new System.Drawing.Size(45, 20);
            this.labelMailcli.TabIndex = 7;
            this.labelMailcli.Text = "Mail :";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(129, 286);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(141, 58);
            this.buttonAjouter.TabIndex = 8;
            this.buttonAjouter.Text = "AJOUTER";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(277, 286);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(141, 58);
            this.buttonAnnuler.TabIndex = 9;
            this.buttonAnnuler.Text = "ANNULER";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // AjouterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAnnuler;
            this.ClientSize = new System.Drawing.Size(484, 374);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.labelMailcli);
            this.Controls.Add(this.labelTelcli);
            this.Controls.Add(this.labelAdressecli);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.textBoxNewMail);
            this.Controls.Add(this.textBoxNewTel);
            this.Controls.Add(this.textBoxNewAdresse);
            this.Controls.Add(this.textBoxNewClient);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AjouterClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter Client";
            this.Load += new System.EventHandler(this.AjouterClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewClient;
        private System.Windows.Forms.TextBox textBoxNewAdresse;
        private System.Windows.Forms.TextBox textBoxNewTel;
        private System.Windows.Forms.TextBox textBoxNewMail;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelAdressecli;
        private System.Windows.Forms.Label labelTelcli;
        private System.Windows.Forms.Label labelMailcli;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}

