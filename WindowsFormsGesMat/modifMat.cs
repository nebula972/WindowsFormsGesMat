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
    public partial class FormmodifMat : Form
    {
        string strcon = @"Data Source=.\sqlexpress;database=GM;Integrated Security=True";
        public FormmodifMat()
        {
            InitializeComponent();
        }

        private void buttonmodifMat_Click(object sender, EventArgs e)
        {
            //met a jour les informations du materiel
            SqlConnection sqlcon = null;
            SqlCommand sqlcom = null;
            IdObjItem idce = (IdObjItem)listBoxmodifMat.SelectedItem;
            try
            {
                sqlcon = new SqlConnection(strcon);
                sqlcon.Open();
                sqlcom = new SqlCommand("update Materiel set Nom=@Nom, NoSerie=@NoSerie, Date_Install=@Date_Install, MTBF=@MTBF, Type=@Type, Marque=@Marque ID_CLIENT=@ID_CLIENT where ID_Mat=@ID_Mat", sqlcon);
                sqlcom.Parameters.AddWithValue("@Nom", textBoxmodifNommat.Text);
                sqlcom.Parameters.AddWithValue("@NoSerie", textBoxmodifNumser.Text);
                sqlcom.Parameters.AddWithValue("@Date_Install", dateTimePickermodifmat.Value);

                sqlcom.Parameters.Add("@MTBF", SqlDbType.Int);
                sqlcom.Parameters["@MTBF"].Value = textBoxmodifMTBF.Text;


                sqlcom.Parameters.AddWithValue("@Type", textBoxmodifType.Text);
                sqlcom.Parameters.AddWithValue("@Marque", textBoxmodifMarque.Text);

                sqlcom.Parameters.AddWithValue("@ID_CLIENT", SqlDbType.Int);
                sqlcom.Parameters["@ID_CLIENT"].Value = comboBoxmodifMat.SelectedValue;
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("Materiel modifié avec succès");
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
        }

        private void FormmodifMat_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gMDataSet3.CLIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cLIENTTableAdapter.Fill(this.gMDataSet3.CLIENT);
            string phrase;
            SqlConnection sqlcon = new SqlConnection(this.strcon);
            sqlcon.Open();
            string sql = "select Nom from MATERIEL";
            SqlCommand cmd = new SqlCommand(sql, sqlcon);
            SqlDataReader sqr = cmd.ExecuteReader();
            while (sqr.Read() == true)
            {
                phrase = sqr["Nom"].ToString();
                listBoxmodifMat.Items.Add(phrase);
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxmodifMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxmodifMat.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez selectionner un materiel");
                return;
            }
            //Affiche dans les texteBox les info du client selectionné
            SqlConnection cn = null;
            SqlCommand com = null;
            SqlDataReader rd = null;
            IdObjItem idce = (IdObjItem)listBoxmodifMat.SelectedItem;
            try
            {
                cn = new SqlConnection(strcon);
                cn.Open();
                string strsql = "select * from Materiel where ID_CLIENT = " + idce.ID.ToString();
                com = new SqlCommand(strsql, cn);
                rd = com.ExecuteReader();
                rd.Read();
                textBoxmodifNommat.Text = rd["NOM"].ToString();
                textBoxmodifNumser.Text = rd["NoSerie"].ToString();
                dateTimePickermodifmat.Value = (DateTime)rd["Date_Install"];
                textBoxmodifMTBF.Text = rd["MTBF"].ToString();
                textBoxmodifType.Text = rd["Type"].ToString();
                textBoxmodifMarque.Text = rd["Marque"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
                Application.Exit();
            }
            finally
            {
                if (cn != null)
                {
                    cn.Close();
                    cn.Dispose();
                }
                if (com != null)
                {
                    com.Dispose();
                }
                if (rd != null)
                {
                    rd.Close();
                }
            }
        }
    }
}
