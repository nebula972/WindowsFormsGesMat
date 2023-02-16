using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WindowsFormsGesMat
{

    public partial class Clients : Form
    {
        //Connextion à la base de données
        public string strcon = @"Data Source=.\sqlexpress;database=GM;Integrated Security=True";

        //permet de selectionné un élement dans la listBox et de l'afficher dans les textBox(Materiel)
        private void listBoxMateriel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Force a choisir un materiel
            if (listBoxMateriel.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un Materiel", "Warning !",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //affiche la liste des materiels
            SqlConnection cn = null;
            SqlCommand com = null;
            SqlDataReader rd = null;

            IdObjItem idce = (IdObjItem)listBoxMateriel.SelectedItem;

            try
            {
                cn = new SqlConnection(strcon);
                cn.Open();
                string strsql = "select * from Materiel where ID_MAT = " + idce.ID.ToString();

                com = new SqlCommand(strsql, cn);
                rd = com.ExecuteReader();

                rd.Read();

                textBoxNoSerie.Text = rd["NoSerie"].ToString();
                dateTimePickerDateIns.Value = Convert.ToDateTime(rd["Date_Install"]);
                textBoxMTBF.Text = rd["MTBF"].ToString();
                textBoxType.Text = rd["Type"].ToString();
                textBoxMarque.Text = rd["Marque"].ToString();
                comboBoxClient.SelectedIndex = Convert.ToInt32(rd["ID_CLIENT"]);
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
            }
        }

        //permet de selectionné un élement dans la listBox et de l'afficher dans les textBox(Client)
        private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selectionne le premier élement de la liste
            if (listBoxClients.SelectedIndex == -1)
            {
                listBoxClients.SelectedIndex = 0;
            }
            //Afiche tous le contenue de la table CLIENT
            SqlConnection cn = null;
            SqlCommand com = null;
            SqlDataReader rd = null;

            IdObjItem idce = (IdObjItem)listBoxClients.SelectedItem;

            try
            {
                cn = new SqlConnection(strcon);
                cn.Open();
                string strsql = "select * from Client where ID_CLIENT = " + idce.ID.ToString();

                com = new SqlCommand(strsql, cn);
                rd = com.ExecuteReader();

                rd.Read();
                //met dans les textBox les infos des clients
                textBoxAdresse.Text = rd["Adresse"].ToString();
                textBoxEmail.Text = rd["Mail"].ToString();
                textBoxTel.Text = rd["Tel"].ToString();

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
            }
        }

        public Clients()
        {
            InitializeComponent();
        }

        //actualise la liste des clients et des materiels
        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gMDataSet.CLIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cLIENTTableAdapter.Fill(this.gMDataSet.CLIENT);
            Actualisation();
        }

        //refactorisation du code pour l'utiliser en méthode
        private void Actualisation()
        {
            SqlConnection cn = null;
            SqlCommand com = null;
            SqlDataReader rd = null;

            //actualise la liste des clients
            listBoxClients.Items.Clear();

            try
            {
                cn = new SqlConnection(strcon);
                cn.Open();
                string strsql = "select * from Client";

                com = new SqlCommand(strsql, cn);
                rd = com.ExecuteReader();

                IdObjItem idc;
                while (rd.Read())
                {
                    idc = new IdObjItem(Convert.ToInt32(rd["ID_CLIENT"]), rd["Nom"].ToString());
                    listBoxClients.Items.Add(idc);
                }

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
            }

            //actualise la liste des materiels
            listBoxMateriel.Items.Clear();

            try
            {
                cn = new SqlConnection(strcon);
                cn.Open();
                string strsql = "select * from Materiel";

                com = new SqlCommand(strsql, cn);
                rd = com.ExecuteReader();

                IdObjItem idc;
                while (rd.Read())
                {
                    idc = new IdObjItem(Convert.ToInt32(rd["ID_MAT"]), rd["Nom"].ToString());
                    listBoxMateriel.Items.Add(idc);
                }

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
            }
        }

        //Ouvre la form AjouterClient
        private void buttonAjouter_Click(object sender, EventArgs e)
        {         
            AjouterClient Form1 = new AjouterClient();
            Form1.ShowDialog();
        }

        //Ouvre la form AjouterMateriel
        private void buttonAjoumat_Click(object sender, EventArgs e)
        {
            AjouterMateriel FormMateriel = new AjouterMateriel();
            FormMateriel.ShowDialog();
        }

        //Actualise la liste des clients
        private void buttonActualiser_Click(object sender, EventArgs e)
        {
            Actualisation();
        }

        //Supprime un client
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (listBoxClients.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un client");
                return;
            }

            DialogResult rep = MessageBox.Show("Voulez-vous vraiment supprimer ce client ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.Yes)
            {
                if (rep == DialogResult.No)
                    return;

                SqlConnection cn = null;
                SqlCommand com = null;

                IdObjItem idce = (IdObjItem)listBoxClients.SelectedItem;

                try
                {
                    cn = new SqlConnection(strcon);
                    cn.Open();
                    string strsql = "Delete from Client where ID_CLIENT = " + idce.ID.ToString();

                    com = new SqlCommand(strsql, cn);
                    com.ExecuteNonQuery();

                    Actualisation();

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
                }
            }   
        }

        //Modifie un client
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            FormmodifClient FormModifClient = new FormmodifClient();
            FormModifClient.ShowDialog();
        }

        //Actualise la liste des materiels
        private void buttonActualiserMat_Click(object sender, EventArgs e)
        {
            Actualisation();
        }

        //Ouvre la form modifMateriel
        private void buttonModifmat_Click(object sender, EventArgs e)
        {
            FormmodifMat Form2 = new FormmodifMat();
            Form2.Show();
        }

        //supprime un materiel
        private void buttonSuppmat_Click(object sender, EventArgs e)
        {
            //supprimer le materiel selectionné
            if (listBoxMateriel.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un materiel");
                return;
            }

            DialogResult rep = MessageBox.Show("Voulez-vous vraiment supprimer ce Materiel ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.Yes)
            {
                if (rep == DialogResult.No)
                    return;

                SqlConnection cn = null;
                SqlCommand com = null;

                IdObjItem idce = (IdObjItem)listBoxMateriel.SelectedItem;

                try
                {
                    cn = new SqlConnection(strcon);
                    cn.Open();
                    string strsql = "Delete from Materiel where ID_MAT = " + idce.ID.ToString();

                    com = new SqlCommand(strsql, cn);
                    com.ExecuteNonQuery();

                    Actualisation();

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
                }
            }
        }

        private void Clients_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ferme FormLogin
            Application.Exit();
        }
    }
}
