using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using  System.Data.SqlClient;   

namespace Cinema_D_e_F
{
    public partial class Painel_de_vendas : Form
    {
        
       
        public Painel_de_vendas()
        {
            InitializeComponent();


        }
        



        double ing = 00,c,d;

        SqlConnection sqlCon = null;
        private string strCon = @"Password=271200;Persist Security Info=True;User ID=usuario padrao;Initial Catalog=Cineme_D_e_F;Data Source=PEDRO-ASUS\SQLEXPRESS";
        private string strSql= string.Empty;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cad = Convert.ToInt16(txtcadeira.Text);


        }


        private void btt_compra_Click(object sender, EventArgs e)
        {
            if (d == 1)
            {
                strSql = "update dbo.sala_1 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
            }
            if (d == 2)
            {
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
            } if (d == 3)
            {
                strSql = "update dbo.sala_3 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
            }
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            c = Convert.ToInt16(txtcadeira.Text);
            if (bttnormal.Checked)
            {
                ing = 20.00;
                txtresultado.Text = Convert.ToString(ing);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = c;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 2;




            }
            if (bttmeiaa.Checked)
            {
                ing = 10.00;
                txtresultado.Text = Convert.ToString(ing);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = c;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 2;

            }
            if (bttreserva.Checked)
            {
                ing = 15.50;
                txtresultado.Text = Convert.ToString(ing);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = c;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
            }
            
            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Compra Realizada Com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlCon.Close(); }
            
            
            txtresultado.Text = Convert.ToDouble(txtresultado.Text).ToString("C");
            txtcadeira.Text = "0";

        }

        private void btt_cadeira_Click(object sender, EventArgs e)
        {

            Cadeira novaForm = new Cadeira();
            novaForm.ShowDialog();
            txtcadeira.Text = novaForm.cadeira_livre;
            d = 1;

        }

        private void bttadeira_2_Click(object sender, EventArgs e)
        {
            Cadeira2 novaForm = new Cadeira2();
            novaForm.ShowDialog();
            txtcadeira.Text = novaForm.cadeira_livre;
            d = 2;
        }

        private void bttcadeira_3_Click(object sender, EventArgs e)
        {
            Sala3 novaForm = new Sala3();
            novaForm.ShowDialog();
            txtcadeira.Text = novaForm.cadeira_livre;
            d = 3;
        }

        private void Painel_de_vendas_Load(object sender, EventArgs e)
        {

        }

        private void btt_cancel_Click(object sender, EventArgs e)
        {


            if (d == 1)
            {
                strSql = "update dbo.sala_1 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
            }
            if (d == 2)
            {
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
            } if (d == 3)
            {
                strSql = "update dbo.sala_3 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
            }
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            c = Convert.ToInt16(txtcadeira.Text);
            comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = c;
            comando.Parameters.Add("@disp", SqlDbType.Int).Value = 0;
            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cancelamento Feito Com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlCon.Close(); }
              txtcadeira.Text = "0";
        }

        
        
      
     
      

        
    }
}
