using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsGesMat
{
    public partial class FormmodifClient : Form
    {
        public string strcon = @"Data Source=.\sqlexpress;database=GM;Integrated Security=True";
        public FormmodifClient()
        {
            InitializeComponent();           
        }

        private void buttonmodifAjouter_Click(object sender, EventArgs e)
        {
            //selectionne le premier élement de la liste
            if (listBoxmodifClient.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un client");
                return;
            }
            
            //modifie le client selectionné
            SqlConnection cn = null;
            SqlCommand com = null;
            IdObjItem idce = (IdObjItem)listBoxmodifClient.SelectedItem;
            try
            {
                cn = new SqlConnection(strcon);
                cn.Open();
                string strsql = "update Client set Nom = '" + textBoxmodifClient.Text +
                    "', Adresse = '"+ textBoxmodifAdresse.Text + "', Tel = '" + textBoxmodifTel.Text +
                    "', Mail = '" + textBoxmodifMail.Text + "' where ID_CLIENT = " + idce.ID.ToString();
                com = new SqlCommand(strsql, cn);
                com.ExecuteNonQuery();
                MessageBox.Show("Client modifié");
                this.Close();
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

        private void FormmodifClient_Load(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            SqlCommand com = null;
            SqlDataReader rd = null;

            listBoxmodifClient.Items.Clear();

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
                    listBoxmodifClient.Items.Add(idc);
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

        private void listBoxmodifClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxmodifClient.SelectedIndex == -1)
            {
                listBoxmodifClient.SelectedIndex = 0;
            }
            //Affiche dans les texteBox les info du client selectionné
            SqlConnection cn = null;
            SqlCommand com = null;
            SqlDataReader rd = null;
            IdObjItem idce = (IdObjItem)listBoxmodifClient.SelectedItem;
            try
            {
                cn = new SqlConnection(strcon);
                cn.Open();
                string strsql = "select * from Client where ID_CLIENT = " + idce.ID.ToString();
                com = new SqlCommand(strsql, cn);
                rd = com.ExecuteReader();
                rd.Read();
                textBoxmodifClient.Text = rd["NOM"].ToString();
                textBoxmodifAdresse.Text = rd["ADRESSE"].ToString();
                textBoxmodifTel.Text = rd["TEL"].ToString();
                textBoxmodifMail.Text = rd["MAIL"].ToString();
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
