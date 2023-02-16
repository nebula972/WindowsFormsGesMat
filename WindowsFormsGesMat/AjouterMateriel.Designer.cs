namespace WindowsFormsGesMat
{
    partial class AjouterMateriel
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
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.labelDateInstal = new System.Windows.Forms.Label();
            this.labelMTBF = new System.Windows.Forms.Label();
            this.labelMarque = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxMTBF = new System.Windows.Forms.TextBox();
            this.textBoxMarque = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelNumseri = new System.Windows.Forms.Label();
            this.textBoxNumser = new System.Windows.Forms.TextBox();
            this.labelNommat = new System.Windows.Forms.Label();
            this.textBoxNommat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gMDataSet = new WindowsFormsGesMat.GMDataSet();
            this.dateTimePickerAddMat = new System.Windows.Forms.DateTimePicker();
            this.cLIENTTableAdapter = new WindowsFormsGesMat.GMDataSetTableAdapters.CLIENTTableAdapter();
            this.comboBoxAddClientMat = new System.Windows.Forms.ComboBox();
            this.gMDataSet1 = new WindowsFormsGesMat.GMDataSet1();
            this.cLIENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTTableAdapter1 = new WindowsFormsGesMat.GMDataSet1TableAdapters.CLIENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(307, 362);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(141, 58);
            this.buttonAnnuler.TabIndex = 8;
            this.buttonAnnuler.Text = "ANNULER";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(159, 362);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(141, 58);
            this.buttonAjouter.TabIndex = 7;
            this.buttonAjouter.Text = "AJOUTER";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // labelDateInstal
            // 
            this.labelDateInstal.AutoSize = true;
            this.labelDateInstal.Location = new System.Drawing.Point(18, 113);
            this.labelDateInstal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateInstal.Name = "labelDateInstal";
            this.labelDateInstal.Size = new System.Drawing.Size(133, 20);
            this.labelDateInstal.TabIndex = 17;
            this.labelDateInstal.Text = "Date Installation :";
            // 
            // labelMTBF
            // 
            this.labelMTBF.AutoSize = true;
            this.labelMTBF.Location = new System.Drawing.Point(18, 161);
            this.labelMTBF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMTBF.Name = "labelMTBF";
            this.labelMTBF.Size = new System.Drawing.Size(60, 20);
            this.labelMTBF.TabIndex = 16;
            this.labelMTBF.Text = "MTBF :";
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Location = new System.Drawing.Point(18, 255);
            this.labelMarque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(71, 20);
            this.labelMarque.TabIndex = 15;
            this.labelMarque.Text = "Marque :";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(18, 209);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(51, 20);
            this.labelType.TabIndex = 14;
            this.labelType.Text = "Type :";
            // 
            // textBoxMTBF
            // 
            this.textBoxMTBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxMTBF.Location = new System.Drawing.Point(159, 158);
            this.textBoxMTBF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMTBF.Name = "textBoxMTBF";
            this.textBoxMTBF.Size = new System.Drawing.Size(289, 37);
            this.textBoxMTBF.TabIndex = 4;
            this.textBoxMTBF.Tag = "En année";
            // 
            // textBoxMarque
            // 
            this.textBoxMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxMarque.Location = new System.Drawing.Point(159, 255);
            this.textBoxMarque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMarque.Name = "textBoxMarque";
            this.textBoxMarque.Size = new System.Drawing.Size(289, 37);
            this.textBoxMarque.TabIndex = 6;
            // 
            // textBoxType
            // 
            this.textBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxType.Location = new System.Drawing.Point(159, 206);
            this.textBoxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(289, 37);
            this.textBoxType.TabIndex = 5;
            // 
            // labelNumseri
            // 
            this.labelNumseri.AutoSize = true;
            this.labelNumseri.Location = new System.Drawing.Point(18, 65);
            this.labelNumseri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumseri.Name = "labelNumseri";
            this.labelNumseri.Size = new System.Drawing.Size(133, 20);
            this.labelNumseri.TabIndex = 21;
            this.labelNumseri.Text = "Numero de serie :";
            // 
            // textBoxNumser
            // 
            this.textBoxNumser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxNumser.Location = new System.Drawing.Point(159, 62);
            this.textBoxNumser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNumser.Name = "textBoxNumser";
            this.textBoxNumser.Size = new System.Drawing.Size(289, 37);
            this.textBoxNumser.TabIndex = 2;
            // 
            // labelNommat
            // 
            this.labelNommat.AutoSize = true;
            this.labelNommat.Location = new System.Drawing.Point(18, 17);
            this.labelNommat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNommat.Name = "labelNommat";
            this.labelNommat.Size = new System.Drawing.Size(110, 20);
            this.labelNommat.TabIndex = 23;
            this.labelNommat.Text = "Nom materiel :";
            // 
            // textBoxNommat
            // 
            this.textBoxNommat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxNommat.Location = new System.Drawing.Point(159, 14);
            this.textBoxNommat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNommat.Name = "textBoxNommat";
            this.textBoxNommat.Size = new System.Drawing.Size(289, 37);
            this.textBoxNommat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Clients :";
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
            // dateTimePickerAddMat
            // 
            this.dateTimePickerAddMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerAddMat.Location = new System.Drawing.Point(159, 113);
            this.dateTimePickerAddMat.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerAddMat.Name = "dateTimePickerAddMat";
            this.dateTimePickerAddMat.Size = new System.Drawing.Size(289, 30);
            this.dateTimePickerAddMat.TabIndex = 27;
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxAddClientMat
            // 
            this.comboBoxAddClientMat.DataSource = this.cLIENTBindingSource1;
            this.comboBoxAddClientMat.DisplayMember = "Nom";
            this.comboBoxAddClientMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddClientMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBoxAddClientMat.FormattingEnabled = true;
            this.comboBoxAddClientMat.Location = new System.Drawing.Point(159, 304);
            this.comboBoxAddClientMat.Name = "comboBoxAddClientMat";
            this.comboBoxAddClientMat.Size = new System.Drawing.Size(289, 38);
            this.comboBoxAddClientMat.TabIndex = 26;
            this.comboBoxAddClientMat.ValueMember = "ID_CLIENT";
            this.comboBoxAddClientMat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gMDataSet1
            // 
            this.gMDataSet1.DataSetName = "GMDataSet1";
            this.gMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTBindingSource1
            // 
            this.cLIENTBindingSource1.DataMember = "CLIENT";
            this.cLIENTBindingSource1.DataSource = this.gMDataSet1;
            // 
            // cLIENTTableAdapter1
            // 
            this.cLIENTTableAdapter1.ClearBeforeFill = true;
            // 
            // AjouterMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 434);
            this.Controls.Add(this.dateTimePickerAddMat);
            this.Controls.Add(this.comboBoxAddClientMat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNommat);
            this.Controls.Add(this.textBoxNommat);
            this.Controls.Add(this.labelNumseri);
            this.Controls.Add(this.textBoxNumser);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.labelDateInstal);
            this.Controls.Add(this.labelMTBF);
            this.Controls.Add(this.labelMarque);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxMTBF);
            this.Controls.Add(this.textBoxMarque);
            this.Controls.Add(this.textBoxType);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AjouterMateriel";
            this.Text = "FormMateriel";
            this.Load += new System.EventHandler(this.AjouterMateriel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Label labelDateInstal;
        private System.Windows.Forms.Label labelMTBF;
        private System.Windows.Forms.Label labelMarque;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxMTBF;
        private System.Windows.Forms.TextBox textBoxMarque;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelNumseri;
        private System.Windows.Forms.TextBox textBoxNumser;
        private System.Windows.Forms.Label labelNommat;
        private System.Windows.Forms.TextBox textBoxNommat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddMat;
        private GMDataSet gMDataSet;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private GMDataSetTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxAddClientMat;
        private GMDataSet1 gMDataSet1;
        private System.Windows.Forms.BindingSource cLIENTBindingSource1;
        private GMDataSet1TableAdapters.CLIENTTableAdapter cLIENTTableAdapter1;
    }
}