using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsGesMat
{
    public partial class FormLogin : Form
    {
        //connexion à la base
        public string strcon = @"Data Source=.\sqlexpress;database=GM;Integrated Security=True";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //verifier si les information rentrer dans les textboxs sont identique à ceux de la base
            SqlConnection cn = new SqlConnection(this.strcon);
            cn.Open();
            SqlCommand cm = new SqlCommand("select * from UTILISATEUR where Login = @login and PWD = @password", cn);
            cm.Parameters.AddWithValue("@login", textBoxLogin.Text);
            cm.Parameters.AddWithValue("@password", textBoxPassword.Text);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                //si oui ouvrir le form clients
                Clients clients = new Clients();
                clients.Show();
                this.Hide();
            }
            else
            {
                //si non afficher un message d'erreur
                MessageBox.Show("Login ou mot de passe incorrect");
            }
            cn.Close();
        }
    }
}