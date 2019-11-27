using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;  
using System.Windows.Forms;

namespace Cinema_D_e_F
{
    public partial class Cadeira2 : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = @"Password=271200;Persist Security Info=True;User ID=usuario padrao;Initial Catalog=Cineme_D_e_F;Data Source=PEDRO-ASUS\SQLEXPRESS";
        private string strSql = string.Empty;

        public Cadeira2()
        {
            InitializeComponent();
        }



        public string cadeira_livre { get; set; }

        string n, dis;
        int cadeira,c,d,lot=0;
        int[] teste={0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35};
        public string adisp { get; set; }
        public int acad { get; set; }




        private void bttcadeira_1_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_1.ForeColor == Color.Lime)
            {
                n = bttcadeira_1.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }

                this.Close();
            }
        }

        private void bttcadeira_2_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_2.ForeColor == Color.Lime)
            {
                n = bttcadeira_2.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_3_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_3.ForeColor == Color.Lime)
            {
                n = bttcadeira_3.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_4_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_4.ForeColor == Color.Lime)
            {
                n = bttcadeira_4.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_5_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_5.ForeColor == Color.Lime)
            {
                n = bttcadeira_5.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }
        private void bttcadeira_6_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_6.ForeColor == Color.Lime)
            {
                n = bttcadeira_6.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_7_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_7.ForeColor == Color.Lime)
            {
                n = bttcadeira_7.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }
        private void bttcadeira_8_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_8.ForeColor == Color.Lime)
            {
                n = bttcadeira_8.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }
        private void bttcadeira_9_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_9.ForeColor == Color.Lime)
            {
                n = bttcadeira_9.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_10_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_10.ForeColor == Color.Lime)
            {
                n = bttcadeira_10.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_11_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_11.ForeColor == Color.Lime)
            {
                n = bttcadeira_11.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_12_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_12.ForeColor == Color.Lime)
            {
                n = bttcadeira_12.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_13_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_13.ForeColor == Color.Lime)
            {
                n = bttcadeira_13.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }
        private void bttcadeira_14_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_14.ForeColor == Color.Lime)
            {
                n = bttcadeira_14.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_15_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_15.ForeColor == Color.Lime)
            {
                n = bttcadeira_15.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_16_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_16.ForeColor == Color.Lime)
            {
                n = bttcadeira_16.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_17_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_17.ForeColor == Color.Lime)
            {
                n = bttcadeira_17.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_18_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_18.ForeColor == Color.Lime)
            {
                n = bttcadeira_18.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }
        private void bttcadeira_19_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_19.ForeColor == Color.Lime)
            {
                n = bttcadeira_19.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }
        private void bttcadeira_20_Click_1(object sender, EventArgs e)
        {
            if (bttcadeira_20.ForeColor == Color.Lime)
            {
                n = bttcadeira_20.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_21_Click_1(object sender, EventArgs e)
        {

            if (bttcadeira_21.ForeColor == Color.Lime)
            {
                n = bttcadeira_21.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }
        private void bttcadeira_22_Click_1(object sender, EventArgs e)
        {

            if (bttcadeira_22.ForeColor == Color.Lime)
            {
                n = bttcadeira_22.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_23_Click_1(object sender, EventArgs e)
        {

            if (bttcadeira_23.ForeColor == Color.Lime)
            {
                n = bttcadeira_23.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_24_Click_1(object sender, EventArgs e)
        {

            if (bttcadeira_24.ForeColor == Color.Lime)
            {
                n = bttcadeira_24.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_25_Click_1(object sender, EventArgs e)
        {

            if (bttcadeira_25.ForeColor == Color.Lime)
            {
                n = bttcadeira_25.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_26_Click_1(object sender, EventArgs e)
        {

            if (bttcadeira_2.ForeColor == Color.Lime)
            {
                n = bttcadeira_26.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_27_Click_1(object sender, EventArgs e)
        {

            if (bttcadeira_27.ForeColor == Color.Lime)
            {
                n = bttcadeira_27.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_28_Click_1(object sender, EventArgs e)
        {

            if (bttcadeira_28.ForeColor == Color.Lime)
            {
                n = bttcadeira_28.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_29_Click_1(object sender, EventArgs e)
        {

            if (bttcadeira_29.ForeColor == Color.Lime)
            {
                n = bttcadeira_29.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_30_Click_1(object sender, EventArgs e)
        {

            if (bttcadeira_30.ForeColor == Color.Lime)
            {
                n = bttcadeira_30.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_31_Click_1(object sender, EventArgs e)
        {

            if (bttcadeira_31.ForeColor == Color.Lime)
            {
                n = bttcadeira_31.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_32_Click_1(object sender, EventArgs e)
        {

            if (bttcadeira_32.ForeColor == Color.Lime)
            {
                n = bttcadeira_32.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_33_Click_1(object sender, EventArgs e)
        {

            if (bttcadeira_33.ForeColor == Color.Lime)
            {
                n = bttcadeira_33.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_34_Click_1(object sender, EventArgs e)
        {

            if (bttcadeira_34.ForeColor == Color.Lime)
            {
                n = bttcadeira_34.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }

        private void bttcadeira_35_Click_1(object sender, EventArgs e)
        {

            if (bttcadeira_35.ForeColor == Color.Lime)
            {
                n = bttcadeira_35.Text;
                cadeira_livre = n;
                strSql = "update dbo.sala_2 set cadeira=@cadeira , disp=@disp where cadeira=@cadeira";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                cadeira = Convert.ToInt16(n);
                comando.Parameters.Add("@cadeira", SqlDbType.Int).Value = cadeira;
                comando.Parameters.Add("@disp", SqlDbType.Int).Value = 1;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado Com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlCon.Close(); }
                this.Close();
            }
        }





        private void bttcadeira_1_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_1.Text;





            try
            {
                if (bttcadeira_1.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_1.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_1.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }
        }
        private void bttcadeira_2_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_2.Text;





            try
            {
                if (bttcadeira_2.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_2.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_2.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }
        }
        private void bttcadeira_3_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_3.Text;





            try
            {
                if (bttcadeira_3.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_3.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_3.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }
        }
        private void bttcadeira_4_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_4.Text;





            try
            {
                if (bttcadeira_4.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_4.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_4.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_5_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_5.Text;





            try
            {
                if (bttcadeira_5.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_5.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_5.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }
        }
        private void bttcadeira_6_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_6.Text;





            try
            {
                if (bttcadeira_6.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_6.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_6.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_7_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_7.Text;





            try
            {
                if (bttcadeira_7.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_7.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_7.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_8_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_8.Text;





            try
            {
                if (bttcadeira_8.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_8.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_8.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_9_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_9.Text;





            try
            {
                if (bttcadeira_9.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_9.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_9.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_10_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_10.Text;





            try
            {
                if (bttcadeira_10.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_10.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_10.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_11_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_11.Text;





            try
            {
                if (bttcadeira_11.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_11.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_11.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_12_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_12.Text;





            try
            {
                if (bttcadeira_12.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_12.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_12.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_13_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_13.Text;





            try
            {
                if (bttcadeira_13.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_13.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_13.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_14_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_14.Text;





            try
            {
                if (bttcadeira_14.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_14.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_14.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_15_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_15.Text;





            try
            {
                if (bttcadeira_15.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_15.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_15.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_16_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_16.Text;





            try
            {
                if (bttcadeira_16.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_16.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_16.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_17_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_17.Text;





            try
            {
                if (bttcadeira_17.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_17.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_17.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_18_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_18.Text;





            try
            {
                if (bttcadeira_18.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_18.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_18.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_19_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_19.Text;





            try
            {
                if (bttcadeira_19.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_19.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_19.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_20_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_20.Text;





            try
            {
                if (bttcadeira_20.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_20.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_20.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_21_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_21.Text;





            try
            {
                if (bttcadeira_21.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_21.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_21.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_22_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_22.Text;





            try
            {
                if (bttcadeira_22.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_22.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_22.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_23_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_23.Text;





            try
            {
                if (bttcadeira_23.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_23.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_23.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_24_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_24.Text;





            try
            {
                if (bttcadeira_24.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_24.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_24.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_25_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_25.Text;





            try
            {
                if (bttcadeira_25.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_25.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_25.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {

                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_26_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_26.Text;





            try
            {
                if (bttcadeira_26.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_26.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_26.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_27_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_27.Text;





            try
            {
                if (bttcadeira_27.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_27.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_27.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_28_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_28.Text;





            try
            {
                if (bttcadeira_28.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_28.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_28.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_29_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_29.Text;





            try
            {
                if (bttcadeira_29.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_29.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_29.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_30_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_30.Text;





            try
            {
                if (bttcadeira_30.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_30.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_30.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_31_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_31.Text;





            try
            {
                if (bttcadeira_31.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_31.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_31.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }

        private void bttcadeira_32_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_32.Text;





            try
            {
                if (bttcadeira_32.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_32.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_32.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_33_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_33.Text;





            try
            {
                if (bttcadeira_33.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_33.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_33.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_34_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_34.Text;





            try
            {
                if (bttcadeira_34.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_34.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_34.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void bttcadeira_35_Load(object sender, EventArgs e)
        {

            strSql = "select cadeira,disp from dbo.sala_2 where cadeira=@cadeira";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);



            comando.Parameters.Add("cadeira", SqlDbType.NVarChar).Value = bttcadeira_35.Text;





            try
            {
                if (bttcadeira_35.Text == string.Empty)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {

                    c = Convert.ToInt16(dr["cadeira"]);
                    d = Convert.ToInt16(dr["disp"]);
                    if (d == 1)
                    {

                        bttcadeira_35.ForeColor = Color.Yellow;
                    }
                    if (d == 2)
                    {

                        bttcadeira_35.ForeColor = Color.Red;
                    }
                    if (d == 1 || d == 2)
                    {
                        lot = lot + 1;
                    }
                }





                if (dr.HasRows == false)
                {
                    throw new Exception("ALGO DEU ERRADO!!!");
                }
                dr.Close();
                sqlCon.Close();



            }
            finally
            {
                sqlCon.Close();
            }


        }


        private void Cadeira2_Load(object sender, EventArgs e)
        {
            if (lot == 35) {
                MessageBox.Show("Sala Cheia");
                this.Close();
            }
        }



        }
    }
  



