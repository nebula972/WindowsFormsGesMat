using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsGesMat
{
    public partial class AjouterClient : Form
    {
        public  string strconnect = @"Data Source=.\sqlexpress;database=GM;Integrated Security=True";

        public AjouterClient()
        {
            InitializeComponent();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            //Insert un nouveau client dans la base
            SqlConnection sqlcon = null;
            SqlCommand sqlcom = null;
            SqlDataReader reader = null;
            try
            {
                sqlcon = new SqlConnection(strconnect);
                sqlcon.Open();
                sqlcom = new SqlCommand("insert into client values(@nom, @adresse, @mail, @tel)", sqlcon);
                sqlcom.Parameters.AddWithValue("@nom", textBoxNewClient.Text);
                sqlcom.Parameters.AddWithValue("@adresse", textBoxNewAdresse.Text);               
                sqlcom.Parameters.AddWithValue("@mail", textBoxNewMail.Text);
                sqlcom.Parameters.AddWithValue("@tel", textBoxNewTel.Text);
                reader = sqlcom.ExecuteReader();
                MessageBox.Show("Client ajouté");
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
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

        private void AjouterClient_Load(object sender, EventArgs e)
        {

        }
    }
}
