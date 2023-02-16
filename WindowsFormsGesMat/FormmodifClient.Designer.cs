namespace WindowsFormsGesMat
{
    partial class FormmodifClient
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
            this.buttonmodifAnnuler = new System.Windows.Forms.Button();
            this.buttonmodifAjouter = new System.Windows.Forms.Button();
            this.labelMailcli = new System.Windows.Forms.Label();
            this.labelTelcli = new System.Windows.Forms.Label();
            this.labelAdressecli = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.textBoxmodifMail = new System.Windows.Forms.TextBox();
            this.textBoxmodifTel = new System.Windows.Forms.TextBox();
            this.textBoxmodifAdresse = new System.Windows.Forms.TextBox();
            this.textBoxmodifClient = new System.Windows.Forms.TextBox();
            this.listBoxmodifClient = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonmodifAnnuler
            // 
            this.buttonmodifAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonmodifAnnuler.Location = new System.Drawing.Point(265, 279);
            this.buttonmodifAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonmodifAnnuler.Name = "buttonmodifAnnuler";
            this.buttonmodifAnnuler.Size = new System.Drawing.Size(141, 58);
            this.buttonmodifAnnuler.TabIndex = 19;
            this.buttonmodifAnnuler.Text = "ANNULER";
            this.buttonmodifAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonmodifAjouter
            // 
            this.buttonmodifAjouter.Location = new System.Drawing.Point(117, 279);
            this.buttonmodifAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonmodifAjouter.Name = "buttonmodifAjouter";
            this.buttonmodifAjouter.Size = new System.Drawing.Size(141, 58);
            this.buttonmodifAjouter.TabIndex = 18;
            this.buttonmodifAjouter.Text = "MODIFIER";
            this.buttonmodifAjouter.UseVisualStyleBackColor = true;
            this.buttonmodifAjouter.Click += new System.EventHandler(this.buttonmodifAjouter_Click);
            // 
            // labelMailcli
            // 
            this.labelMailcli.AutoSize = true;
            this.labelMailcli.Location = new System.Drawing.Point(55, 214);
            this.labelMailcli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMailcli.Name = "labelMailcli";
            this.labelMailcli.Size = new System.Drawing.Size(45, 20);
            this.labelMailcli.TabIndex = 17;
            this.labelMailcli.Text = "Mail :";
            // 
            // labelTelcli
            // 
            this.labelTelcli.AutoSize = true;
            this.labelTelcli.Location = new System.Drawing.Point(8, 157);
            this.labelTelcli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelcli.Name = "labelTelcli";
            this.labelTelcli.Size = new System.Drawing.Size(92, 20);
            this.labelTelcli.TabIndex = 16;
            this.labelTelcli.Text = "Telephone :";
            // 
            // labelAdressecli
            // 
            this.labelAdressecli.AutoSize = true;
            this.labelAdressecli.Location = new System.Drawing.Point(24, 97);
            this.labelAdressecli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdressecli.Name = "labelAdressecli";
            this.labelAdressecli.Size = new System.Drawing.Size(76, 20);
            this.labelAdressecli.TabIndex = 15;
            this.labelAdressecli.Text = "Adresse :";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(43, 38);
            this.labelClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(57, 20);
            this.labelClient.TabIndex = 14;
            this.labelClient.Text = "Client :";
            // 
            // textBoxmodifMail
            // 
            this.textBoxmodifMail.Location = new System.Drawing.Point(117, 211);
            this.textBoxmodifMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxmodifMail.Multiline = true;
            this.textBoxmodifMail.Name = "textBoxmodifMail";
            this.textBoxmodifMail.Size = new System.Drawing.Size(289, 38);
            this.textBoxmodifMail.TabIndex = 13;
            // 
            // textBoxmodifTel
            // 
            this.textBoxmodifTel.Location = new System.Drawing.Point(117, 154);
            this.textBoxmodifTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxmodifTel.Multiline = true;
            this.textBoxmodifTel.Name = "textBoxmodifTel";
            this.textBoxmodifTel.Size = new System.Drawing.Size(289, 38);
            this.textBoxmodifTel.TabIndex = 12;
            // 
            // textBoxmodifAdresse
            // 
            this.textBoxmodifAdresse.Location = new System.Drawing.Point(117, 94);
            this.textBoxmodifAdresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxmodifAdresse.Multiline = true;
            this.textBoxmodifAdresse.Name = "textBoxmodifAdresse";
            this.textBoxmodifAdresse.Size = new System.Drawing.Size(289, 39);
            this.textBoxmodifAdresse.TabIndex = 11;
            // 
            // textBoxmodifClient
            // 
            this.textBoxmodifClient.Location = new System.Drawing.Point(117, 35);
            this.textBoxmodifClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxmodifClient.Multiline = true;
            this.textBoxmodifClient.Name = "textBoxmodifClient";
            this.textBoxmodifClient.Size = new System.Drawing.Size(289, 39);
            this.textBoxmodifClient.TabIndex = 10;
            // 
            // listBoxmodifClient
            // 
            this.listBoxmodifClient.FormattingEnabled = true;
            this.listBoxmodifClient.ItemHeight = 20;
            this.listBoxmodifClient.Location = new System.Drawing.Point(432, 35);
            this.listBoxmodifClient.Name = "listBoxmodifClient";
            this.listBoxmodifClient.Size = new System.Drawing.Size(374, 304);
            this.listBoxmodifClient.TabIndex = 20;
            this.listBoxmodifClient.SelectedIndexChanged += new System.EventHandler(this.listBoxmodifClient_SelectedIndexChanged);
            // 
            // FormmodifClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 390);
            this.Controls.Add(this.listBoxmodifClient);
            this.Controls.Add(this.buttonmodifAnnuler);
            this.Controls.Add(this.buttonmodifAjouter);
            this.Controls.Add(this.labelMailcli);
            this.Controls.Add(this.labelTelcli);
            this.Controls.Add(this.labelAdressecli);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.textBoxmodifMail);
            this.Controls.Add(this.textBoxmodifTel);
            this.Controls.Add(this.textBoxmodifAdresse);
            this.Controls.Add(this.textBoxmodifClient);
            this.Name = "FormmodifClient";
            this.Text = "FormmodifClient";
            this.Load += new System.EventHandler(this.FormmodifClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonmodifAnnuler;
        private System.Windows.Forms.Button buttonmodifAjouter;
        private System.Windows.Forms.Label labelMailcli;
        private System.Windows.Forms.Label labelTelcli;
        private System.Windows.Forms.Label labelAdressecli;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox textBoxmodifMail;
        private System.Windows.Forms.TextBox textBoxmodifTel;
        private System.Windows.Forms.TextBox textBoxmodifAdresse;
        private System.Windows.Forms.TextBox textBoxmodifClient;
        private System.Windows.Forms.ListBox listBoxmodifClient;
    }
}