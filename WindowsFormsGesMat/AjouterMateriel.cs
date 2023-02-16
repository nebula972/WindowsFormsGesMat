using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsGesMat
{
    public partial class AjouterMateriel : Form
    {
        public string strconnect = @"Data Source=.\sqlexpress;database=GM;Integrated Security=True";
        public AjouterMateriel()
        {
            InitializeComponent();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            //Ajouter un  nouveau materiel a partir de AjouterMateriel
            SqlConnection sqlcon = null;
            SqlCommand sqlcom = null;
            try
            {
                sqlcon = new SqlConnection(strconnect);
                sqlcon.Open();
                sqlcom = new SqlCommand("insert into Materiel values(@Nom, @NoSerie, @Date_Install, @MTBF, @Type, @Marque, @ID_CLIENT)", sqlcon);
                sqlcom.Parameters.AddWithValue("@Nom", textBoxNommat.Text);
                sqlcom.Parameters.AddWithValue("@NoSerie", textBoxNumser.Text);
                sqlcom.Parameters.AddWithValue("@Date_Install", dateTimePickerAddMat.Value);
                
                sqlcom.Parameters.Add("@MTBF", SqlDbType.Int);
                sqlcom.Parameters["@MTBF"].Value = textBoxMTBF.Text;

                
                sqlcom.Parameters.AddWithValue("@Type", textBoxType.Text);
                sqlcom.Parameters.AddWithValue("@Marque", textBoxMarque.Text);

                sqlcom.Parameters.Add("@ID_CLIENT", SqlDbType.Int);
                sqlcom.Parameters["@ID_CLIENT"].Value = comboBoxAddClientMat.SelectedValue;

                sqlcom.ExecuteNonQuery();
                MessageBox.Show("Materiel ajouté avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlcom != null)
                {
                    sqlcom.Dispose();
                }
                if (sqlcon != null)
                {
                    sqlcon.Close();
                }
            }
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AjouterMateriel_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gMDataSet1.CLIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cLIENTTableAdapter1.Fill(this.gMDataSet1.CLIENT);
            // TODO: cette ligne de code charge les données dans la table 'gMDataSet.CLIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cLIENTTableAdapter.Fill(this.gMDataSet.CLIENT);

        }
    }
}
