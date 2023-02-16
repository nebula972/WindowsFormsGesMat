namespace WindowsFormsGesMat
{
    partial class Clients
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
            this.components = new System.ComponentModel.Container();
            this.tabPageIntervention = new System.Windows.Forms.TabPage();
            this.tabPageMateriel = new System.Windows.Forms.TabPage();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gMDataSet = new WindowsFormsGesMat.GMDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerDateIns = new System.Windows.Forms.DateTimePicker();
            this.buttonActualiserMat = new System.Windows.Forms.Button();
            this.buttonSuppmat = new System.Windows.Forms.Button();
            this.buttonModifmat = new System.Windows.Forms.Button();
            this.buttonAjoumat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNoSerie = new System.Windows.Forms.TextBox();
            this.textBoxMTBF = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxMarque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxMateriel = new System.Windows.Forms.ListBox();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.buttonActualiser = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.labelTel = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.cLIENTTableAdapter = new WindowsFormsGesMat.GMDataSetTableAdapters.CLIENTTableAdapter();
            this.gMDataSet2 = new WindowsFormsGesMat.GMDataSet2();
            this.cLIENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTTableAdapter1 = new WindowsFormsGesMat.GMDataSet2TableAdapters.CLIENTTableAdapter();
            this.tabPageMateriel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMDataSet)).BeginInit();
            this.tabPageClient.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageIntervention
            // 
            this.tabPageIntervention.Location = new System.Drawing.Point(4, 29);
            this.tabPageIntervention.Name = "tabPageIntervention";
            this.tabPageIntervention.Size = new System.Drawing.Size(816, 375);
            this.tabPageIntervention.TabIndex = 3;
            this.tabPageIntervention.Text = "Intervention";
            this.tabPageIntervention.UseVisualStyleBackColor = true;
            // 
            // tabPageMateriel
            // 
            this.tabPageMateriel.Controls.Add(this.comboBoxClient);
            this.tabPageMateriel.Controls.Add(this.label6);
            this.tabPageMateriel.Controls.Add(this.dateTimePickerDateIns);
            this.tabPageMateriel.Controls.Add(this.buttonActualiserMat);
            this.tabPageMateriel.Controls.Add(this.buttonSuppmat);
            this.tabPageMateriel.Controls.Add(this.buttonModifmat);
            this.tabPageMateriel.Controls.Add(this.buttonAjoumat);
            this.tabPageMateriel.Controls.Add(this.label4);
            this.tabPageMateriel.Controls.Add(this.textBoxNoSerie);
            this.tabPageMateriel.Controls.Add(this.textBoxMTBF);
            this.tabPageMateriel.Controls.Add(this.textBoxType);
            this.tabPageMateriel.Controls.Add(this.textBoxMarque);
            this.tabPageMateriel.Controls.Add(this.label5);
            this.tabPageMateriel.Controls.Add(this.label1);
            this.tabPageMateriel.Controls.Add(this.label2);
            this.tabPageMateriel.Controls.Add(this.label3);
            this.tabPageMateriel.Controls.Add(this.listBoxMateriel);
            this.tabPageMateriel.Location = new System.Drawing.Point(4, 29);
            this.tabPageMateriel.Name = "tabPageMateriel";
            this.tabPageMateriel.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageMateriel.Size = new System.Drawing.Size(816, 375);
            this.tabPageMateriel.TabIndex = 1;
            this.tabPageMateriel.Text = "Matériel";
            this.tabPageMateriel.UseVisualStyleBackColor = true;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DataSource = this.cLIENTBindingSource;
            this.comboBoxClient.DisplayMember = "Nom";
            this.comboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClient.Enabled = false;
            this.comboBoxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(423, 341);
            this.comboBoxClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(233, 33);
            this.comboBoxClient.TabIndex = 31;
            this.comboBoxClient.ValueMember = "ID_CLIENT";
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.gMDataSet;
            // 
            // gMDataSet
            // 
            this.gMDataSet.DataSetName = "GMDataSet";
            this.gMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Client :";
            // 
            // dateTimePickerDateIns
            // 
            this.dateTimePickerDateIns.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerDateIns.Enabled = false;
            this.dateTimePickerDateIns.Location = new System.Drawing.Point(421, 211);
            this.dateTimePickerDateIns.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerDateIns.Name = "dateTimePickerDateIns";
            this.dateTimePickerDateIns.Size = new System.Drawing.Size(233, 26);
            this.dateTimePickerDateIns.TabIndex = 28;
            // 
            // buttonActualiserMat
            // 
            this.buttonActualiserMat.Location = new System.Drawing.Point(693, 248);
            this.buttonActualiserMat.Name = "buttonActualiserMat";
            this.buttonActualiserMat.Size = new System.Drawing.Size(120, 48);
            this.buttonActualiserMat.TabIndex = 27;
            this.buttonActualiserMat.Text = "ACTUALISER";
            this.buttonActualiserMat.UseVisualStyleBackColor = true;
            this.buttonActualiserMat.Click += new System.EventHandler(this.buttonActualiserMat_Click);
            // 
            // buttonSuppmat
            // 
            this.buttonSuppmat.Location = new System.Drawing.Point(693, 138);
            this.buttonSuppmat.Name = "buttonSuppmat";
            this.buttonSuppmat.Size = new System.Drawing.Size(120, 48);
            this.buttonSuppmat.TabIndex = 25;
            this.buttonSuppmat.Text = "SUPPRIMER";
            this.buttonSuppmat.UseVisualStyleBackColor = true;
            this.buttonSuppmat.Click += new System.EventHandler(this.buttonSuppmat_Click);
            // 
            // buttonModifmat
            // 
            this.buttonModifmat.Location = new System.Drawing.Point(693, 193);
            this.buttonModifmat.Name = "buttonModifmat";
            this.buttonModifmat.Size = new System.Drawing.Size(120, 48);
            this.buttonModifmat.TabIndex = 26;
            this.buttonModifmat.Text = "MODIFIER";
            this.buttonModifmat.UseVisualStyleBackColor = true;
            this.buttonModifmat.Click += new System.EventHandler(this.buttonModifmat_Click);
            // 
            // buttonAjoumat
            // 
            this.buttonAjoumat.Location = new System.Drawing.Point(693, 84);
            this.buttonAjoumat.Name = "buttonAjoumat";
            this.buttonAjoumat.Size = new System.Drawing.Size(120, 48);
            this.buttonAjoumat.TabIndex = 24;
            this.buttonAjoumat.Text = "AJOUTER";
            this.buttonAjoumat.UseVisualStyleBackColor = true;
            this.buttonAjoumat.Click += new System.EventHandler(this.buttonAjoumat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Date Installation :";
            // 
            // textBoxNoSerie
            // 
            this.textBoxNoSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxNoSerie.Location = new System.Drawing.Point(421, 146);
            this.textBoxNoSerie.Name = "textBoxNoSerie";
            this.textBoxNoSerie.ReadOnly = true;
            this.textBoxNoSerie.Size = new System.Drawing.Size(233, 32);
            this.textBoxNoSerie.TabIndex = 21;
            // 
            // textBoxMTBF
            // 
            this.textBoxMTBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxMTBF.Location = new System.Drawing.Point(421, 276);
            this.textBoxMTBF.Name = "textBoxMTBF";
            this.textBoxMTBF.ReadOnly = true;
            this.textBoxMTBF.Size = new System.Drawing.Size(233, 32);
            this.textBoxMTBF.TabIndex = 16;
            // 
            // textBoxType
            // 
            this.textBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxType.Location = new System.Drawing.Point(421, 29);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.ReadOnly = true;
            this.textBoxType.Size = new System.Drawing.Size(233, 32);
            this.textBoxType.TabIndex = 14;
            // 
            // textBoxMarque
            // 
            this.textBoxMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxMarque.Location = new System.Drawing.Point(421, 87);
            this.textBoxMarque.Name = "textBoxMarque";
            this.textBoxMarque.ReadOnly = true;
            this.textBoxMarque.Size = new System.Drawing.Size(233, 32);
            this.textBoxMarque.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Numéro de série :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "MTBF :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Marque :";
            // 
            // listBoxMateriel
            // 
            this.listBoxMateriel.FormattingEnabled = true;
            this.listBoxMateriel.ItemHeight = 20;
            this.listBoxMateriel.Location = new System.Drawing.Point(5, 9);
            this.listBoxMateriel.Name = "listBoxMateriel";
            this.listBoxMateriel.Size = new System.Drawing.Size(415, 344);
            this.listBoxMateriel.TabIndex = 13;
            this.listBoxMateriel.SelectedIndexChanged += new System.EventHandler(this.listBoxMateriel_SelectedIndexChanged);
            // 
            // tabPageClient
            // 
            this.tabPageClient.BackColor = System.Drawing.Color.White;
            this.tabPageClient.Controls.Add(this.buttonActualiser);
            this.tabPageClient.Controls.Add(this.labelEmail);
            this.tabPageClient.Controls.Add(this.textBoxAdresse);
            this.tabPageClient.Controls.Add(this.textBoxEmail);
            this.tabPageClient.Controls.Add(this.textBoxTel);
            this.tabPageClient.Controls.Add(this.labelAdresse);
            this.tabPageClient.Controls.Add(this.buttonSupprimer);
            this.tabPageClient.Controls.Add(this.buttonModifier);
            this.tabPageClient.Controls.Add(this.labelTel);
            this.tabPageClient.Controls.Add(this.buttonAjouter);
            this.tabPageClient.Controls.Add(this.listBoxClients);
            this.tabPageClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageClient.Location = new System.Drawing.Point(4, 29);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageClient.Size = new System.Drawing.Size(816, 375);
            this.tabPageClient.TabIndex = 0;
            this.tabPageClient.Text = "Client";
            // 
            // buttonActualiser
            // 
            this.buttonActualiser.Location = new System.Drawing.Point(693, 248);
            this.buttonActualiser.Name = "buttonActualiser";
            this.buttonActualiser.Size = new System.Drawing.Size(120, 48);
            this.buttonActualiser.TabIndex = 13;
            this.buttonActualiser.Text = "ACTUALISER";
            this.buttonActualiser.UseVisualStyleBackColor = true;
            this.buttonActualiser.Click += new System.EventHandler(this.buttonActualiser_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(425, 64);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(50, 17);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email :";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxAdresse.Location = new System.Drawing.Point(425, 213);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.ReadOnly = true;
            this.textBoxAdresse.Size = new System.Drawing.Size(233, 32);
            this.textBoxAdresse.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxEmail.Location = new System.Drawing.Point(425, 84);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(233, 32);
            this.textBoxEmail.TabIndex = 7;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxTel.Location = new System.Drawing.Point(425, 148);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.ReadOnly = true;
            this.textBoxTel.Size = new System.Drawing.Size(233, 32);
            this.textBoxTel.TabIndex = 8;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresse.Location = new System.Drawing.Point(425, 193);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(68, 17);
            this.labelAdresse.TabIndex = 12;
            this.labelAdresse.Text = "Adresse :";
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(693, 138);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(120, 48);
            this.buttonSupprimer.TabIndex = 4;
            this.buttonSupprimer.Text = "SUPPRIMER";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(693, 193);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(120, 48);
            this.buttonModifier.TabIndex = 5;
            this.buttonModifier.Text = "MODIFIER";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.Location = new System.Drawing.Point(425, 128);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(153, 17);
            this.labelTel.TabIndex = 11;
            this.labelTel.Text = "Numéro de téléphone :";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(693, 84);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(120, 48);
            this.buttonAjouter.TabIndex = 3;
            this.buttonAjouter.Text = "AJOUTER";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.ItemHeight = 20;
            this.listBoxClients.Location = new System.Drawing.Point(7, 7);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(415, 344);
            this.listBoxClients.TabIndex = 0;
            this.listBoxClients.SelectedIndexChanged += new System.EventHandler(this.listBoxClients_SelectedIndexChanged);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageClient);
            this.tabControlMain.Controls.Add(this.tabPageMateriel);
            this.tabControlMain.Controls.Add(this.tabPageIntervention);
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(824, 408);
            this.tabControlMain.TabIndex = 13;
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // gMDataSet2
            // 
            this.gMDataSet2.DataSetName = "GMDataSet2";
            this.gMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTBindingSource1
            // 
            this.cLIENTBindingSource1.DataMember = "CLIENT";
            this.cLIENTBindingSource1.DataSource = this.gMDataSet2;
            // 
            // cLIENTTableAdapter1
            // 
            this.cLIENTTableAdapter1.ClearBeforeFill = true;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(843, 426);
            this.Controls.Add(this.tabControlMain);
            this.MaximizeBox = false;
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Materiel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Clients_FormClosed);
            this.Load += new System.EventHandler(this.Clients_Load);
            this.tabPageMateriel.ResumeLayout(false);
            this.tabPageMateriel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMDataSet)).EndInit();
            this.tabPageClient.ResumeLayout(false);
            this.tabPageClient.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageIntervention;
        private System.Windows.Forms.TabPage tabPageMateriel;
        private System.Windows.Forms.Button buttonSuppmat;
        private System.Windows.Forms.Button buttonModifmat;
        private System.Windows.Forms.Button buttonAjoumat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNoSerie;
        private System.Windows.Forms.TextBox textBoxMTBF;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxMarque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxMateriel;
        private System.Windows.Forms.TabPage tabPageClient;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.Button buttonActualiser;
        private System.Windows.Forms.Button buttonActualiserMat;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateIns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private GMDataSet gMDataSet;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private GMDataSetTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private GMDataSet2 gMDataSet2;
        private System.Windows.Forms.BindingSource cLIENTBindingSource1;
        private GMDataSet2TableAdapters.CLIENTTableAdapter cLIENTTableAdapter1;
    }
}