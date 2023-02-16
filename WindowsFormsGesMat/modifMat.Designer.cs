namespace WindowsFormsGesMat
{
    partial class FormmodifMat
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
            this.labelNommat = new System.Windows.Forms.Label();
            this.textBoxmodifNommat = new System.Windows.Forms.TextBox();
            this.labelNumseri = new System.Windows.Forms.Label();
            this.textBoxmodifNumser = new System.Windows.Forms.TextBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonmodifMat = new System.Windows.Forms.Button();
            this.labelDateInstal = new System.Windows.Forms.Label();
            this.labelMTBF = new System.Windows.Forms.Label();
            this.labelMarque = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxmodifMTBF = new System.Windows.Forms.TextBox();
            this.textBoxmodifMarque = new System.Windows.Forms.TextBox();
            this.textBoxmodifType = new System.Windows.Forms.TextBox();
            this.listBoxmodifMat = new System.Windows.Forms.ListBox();
            this.dateTimePickermodifmat = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxmodifMat = new System.Windows.Forms.ComboBox();
            this.gMDataSet3 = new WindowsFormsGesMat.GMDataSet3();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTTableAdapter = new WindowsFormsGesMat.GMDataSet3TableAdapters.CLIENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gMDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNommat
            // 
            this.labelNommat.AutoSize = true;
            this.labelNommat.Location = new System.Drawing.Point(14, 26);
            this.labelNommat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNommat.Name = "labelNommat";
            this.labelNommat.Size = new System.Drawing.Size(110, 20);
            this.labelNommat.TabIndex = 37;
            this.labelNommat.Text = "Nom materiel :";
            // 
            // textBoxmodifNommat
            // 
            this.textBoxmodifNommat.Location = new System.Drawing.Point(154, 23);
            this.textBoxmodifNommat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxmodifNommat.Multiline = true;
            this.textBoxmodifNommat.Name = "textBoxmodifNommat";
            this.textBoxmodifNommat.Size = new System.Drawing.Size(289, 38);
            this.textBoxmodifNommat.TabIndex = 36;
            // 
            // labelNumseri
            // 
            this.labelNumseri.AutoSize = true;
            this.labelNumseri.Location = new System.Drawing.Point(14, 74);
            this.labelNumseri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumseri.Name = "labelNumseri";
            this.labelNumseri.Size = new System.Drawing.Size(133, 20);
            this.labelNumseri.TabIndex = 35;
            this.labelNumseri.Text = "Numero de serie :";
            // 
            // textBoxmodifNumser
            // 
            this.textBoxmodifNumser.Location = new System.Drawing.Point(154, 71);
            this.textBoxmodifNumser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxmodifNumser.Multiline = true;
            this.textBoxmodifNumser.Name = "textBoxmodifNumser";
            this.textBoxmodifNumser.Size = new System.Drawing.Size(289, 38);
            this.textBoxmodifNumser.TabIndex = 34;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnnuler.Location = new System.Drawing.Point(318, 437);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(141, 58);
            this.buttonAnnuler.TabIndex = 33;
            this.buttonAnnuler.Text = "ANNULER";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonmodifMat
            // 
            this.buttonmodifMat.Location = new System.Drawing.Point(123, 437);
            this.buttonmodifMat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonmodifMat.Name = "buttonmodifMat";
            this.buttonmodifMat.Size = new System.Drawing.Size(141, 58);
            this.buttonmodifMat.TabIndex = 32;
            this.buttonmodifMat.Text = "MODIFIER";
            this.buttonmodifMat.UseVisualStyleBackColor = true;
            this.buttonmodifMat.Click += new System.EventHandler(this.buttonmodifMat_Click);
            // 
            // labelDateInstal
            // 
            this.labelDateInstal.AutoSize = true;
            this.labelDateInstal.Location = new System.Drawing.Point(14, 122);
            this.labelDateInstal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateInstal.Name = "labelDateInstal";
            this.labelDateInstal.Size = new System.Drawing.Size(133, 20);
            this.labelDateInstal.TabIndex = 31;
            this.labelDateInstal.Text = "Date Installation :";
            // 
            // labelMTBF
            // 
            this.labelMTBF.AutoSize = true;
            this.labelMTBF.Location = new System.Drawing.Point(14, 169);
            this.labelMTBF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMTBF.Name = "labelMTBF";
            this.labelMTBF.Size = new System.Drawing.Size(60, 20);
            this.labelMTBF.TabIndex = 30;
            this.labelMTBF.Text = "MTBF :";
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Location = new System.Drawing.Point(14, 265);
            this.labelMarque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(71, 20);
            this.labelMarque.TabIndex = 29;
            this.labelMarque.Text = "Marque :";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(14, 218);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(51, 20);
            this.labelType.TabIndex = 28;
            this.labelType.Text = "Type :";
            // 
            // textBoxmodifMTBF
            // 
            this.textBoxmodifMTBF.Location = new System.Drawing.Point(154, 168);
            this.textBoxmodifMTBF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxmodifMTBF.Multiline = true;
            this.textBoxmodifMTBF.Name = "textBoxmodifMTBF";
            this.textBoxmodifMTBF.Size = new System.Drawing.Size(289, 38);
            this.textBoxmodifMTBF.TabIndex = 26;
            // 
            // textBoxmodifMarque
            // 
            this.textBoxmodifMarque.Location = new System.Drawing.Point(154, 265);
            this.textBoxmodifMarque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxmodifMarque.Multiline = true;
            this.textBoxmodifMarque.Name = "textBoxmodifMarque";
            this.textBoxmodifMarque.Size = new System.Drawing.Size(289, 39);
            this.textBoxmodifMarque.TabIndex = 25;
            // 
            // textBoxmodifType
            // 
            this.textBoxmodifType.Location = new System.Drawing.Point(154, 215);
            this.textBoxmodifType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxmodifType.Multiline = true;
            this.textBoxmodifType.Name = "textBoxmodifType";
            this.textBoxmodifType.Size = new System.Drawing.Size(289, 39);
            this.textBoxmodifType.TabIndex = 24;
            // 
            // listBoxmodifMat
            // 
            this.listBoxmodifMat.FormattingEnabled = true;
            this.listBoxmodifMat.ItemHeight = 20;
            this.listBoxmodifMat.Location = new System.Drawing.Point(452, 23);
            this.listBoxmodifMat.Name = "listBoxmodifMat";
            this.listBoxmodifMat.Size = new System.Drawing.Size(374, 344);
            this.listBoxmodifMat.TabIndex = 38;
            this.listBoxmodifMat.SelectedIndexChanged += new System.EventHandler(this.listBoxmodifMat_SelectedIndexChanged);
            // 
            // dateTimePickermodifmat
            // 
            this.dateTimePickermodifmat.Location = new System.Drawing.Point(158, 122);
            this.dateTimePickermodifmat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickermodifmat.Name = "dateTimePickermodifmat";
            this.dateTimePickermodifmat.Size = new System.Drawing.Size(284, 26);
            this.dateTimePickermodifmat.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 320);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Client :";
            // 
            // comboBoxmodifMat
            // 
            this.comboBoxmodifMat.DataSource = this.cLIENTBindingSource;
            this.comboBoxmodifMat.DisplayMember = "Nom";
            this.comboBoxmodifMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBoxmodifMat.FormattingEnabled = true;
            this.comboBoxmodifMat.Location = new System.Drawing.Point(158, 320);
            this.comboBoxmodifMat.Name = "comboBoxmodifMat";
            this.comboBoxmodifMat.Size = new System.Drawing.Size(285, 38);
            this.comboBoxmodifMat.TabIndex = 42;
            this.comboBoxmodifMat.ValueMember = "ID_CLIENT";
            // 
            // gMDataSet3
            // 
            this.gMDataSet3.DataSetName = "GMDataSet3";
            this.gMDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.gMDataSet3;
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // FormmodifMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 571);
            this.Controls.Add(this.comboBoxmodifMat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickermodifmat);
            this.Controls.Add(this.listBoxmodifMat);
            this.Controls.Add(this.labelNommat);
            this.Controls.Add(this.textBoxmodifNommat);
            this.Controls.Add(this.labelNumseri);
            this.Controls.Add(this.textBoxmodifNumser);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonmodifMat);
            this.Controls.Add(this.labelDateInstal);
            this.Controls.Add(this.labelMTBF);
            this.Controls.Add(this.labelMarque);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxmodifMTBF);
            this.Controls.Add(this.textBoxmodifMarque);
            this.Controls.Add(this.textBoxmodifType);
            this.Name = "FormmodifMat";
            this.Text = "Modifier Materiel";
            this.Load += new System.EventHandler(this.FormmodifMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gMDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNommat;
        private System.Windows.Forms.TextBox textBoxmodifNommat;
        private System.Windows.Forms.Label labelNumseri;
        private System.Windows.Forms.TextBox textBoxmodifNumser;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonmodifMat;
        private System.Windows.Forms.Label labelDateInstal;
        private System.Windows.Forms.Label labelMTBF;
        private System.Windows.Forms.Label labelMarque;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxmodifMTBF;
        private System.Windows.Forms.TextBox textBoxmodifMarque;
        private System.Windows.Forms.TextBox textBoxmodifType;
        private System.Windows.Forms.ListBox listBoxmodifMat;
        private System.Windows.Forms.DateTimePicker dateTimePickermodifmat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxmodifMat;
        private GMDataSet3 gMDataSet3;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private GMDataSet3TableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
    }
}