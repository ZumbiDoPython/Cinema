using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;  

namespace Cinema_D_e_F
{
    public partial class Login : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = @"Password=271200;Persist Security Info=True;User ID=usuario padrao;Initial Catalog=Cineme_D_e_F;Data Source=PEDRO-ASUS\SQLEXPRESS";
        private string strSql = string.Empty;
        public Login()
        {
            InitializeComponent();
        }
        string autl, auts;

        

        private void btt_ent_Click(object sender, EventArgs e)
        {
            strSql = "select login,senha from dbo.users where login=@login";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

           

                comando.Parameters.Add("@login", SqlDbType.NVarChar).Value = loginTxt.Text;
                


            

            try
            {
                if (loginTxt.Text == string.Empty)
                {
                    MessageBox.Show("Insira um Usuario e Senha");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while(dr.Read())
            {
                
                    autl = Convert.ToString(dr["login"]);
                auts = Convert.ToString(dr["senha"]);
            }


                
           
               
                if (dr.HasRows == false)
                {
                    MessageBox.Show("Nome De Usuario Incorreto");
                }
                dr.Close();
                sqlCon.Close();

                if (autl == loginTxt.Text && auts == senhaTxt.Text)
                {
                    MessageBox.Show("Seja Bem Vindo "+loginTxt.Text);
                    Painel_de_vendas novaForm = new Painel_de_vendas();
                    novaForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senha Incorreta");
                }

                
            }
            finally
            {   
                sqlCon.Close();
            }


            
            

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
