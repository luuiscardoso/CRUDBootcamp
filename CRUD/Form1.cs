using System.Data.SqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        private string strCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\luisc\\OneDrive\\Documentos\\CRUD\\CRUD\\db_crud.mdf;Integrated Security=True";
        private string strSql = "";

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            strSql = "SELECT * FROM PRODUTO WHERE ID = @ID";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = tstIdBuscar.Text;

            try
            {
                if (tstIdBuscar.Text == "")
                {
                    throw new Exception("Por favor digite um ID.");
                }
                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("ID não cadastrado.");
                }

                if (dr.Read())
                {
                    tstId.Text = Convert.ToString(dr["ID"]);
                    tstProduto.Text = Convert.ToString(dr["NOME"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            btnRemover.Enabled = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnRemover.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir esse produto?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Ação cancelada.");
            }
            else
            {
                strSql = "DELETE FROM PRODUTO WHERE ID = @ID";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = tstIdBuscar.Text;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Produto excluído com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }

                btnRemover.Enabled = false;
                tstId.Text = "";
                tstIdBuscar.Text = "";
                tstProduto.Text = "";
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            strSql = "UPDATE PRODUTO SET ID = @ID, NOME = @NOME WHERE ID = @ID";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@IdBuscar", System.Data.SqlDbType.Int).Value = tstIdBuscar.Text;
            comando.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = tstId.Text;
            comando.Parameters.Add("@NOME", System.Data.SqlDbType.VarChar).Value = tstProduto.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados atualizados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            tstId.Text = "";
            tstIdBuscar.Text = "";
            tstProduto.Text = "";
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            {
                strSql = "INSERT INTO PRODUTO (NOME, ID) VALUES (@NOME, @ID)";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = tstId.Text;
                comando.Parameters.Add("@NOME", System.Data.SqlDbType.VarChar).Value = tstProduto.Text;

                try
                {
                    if (tstProduto.Text == "" || tstId.Text == "")
                    {
                        throw new Exception("Por favor verifique se todos os campos estão preenchidos.");
                    }
                    else
                    {
                        sqlCon.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Produto adicionado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }

                btnRemover.Enabled = true;
                btnEditar.Enabled = true;
                tstId.Text = "";
                tstIdBuscar.Text = "";
                tstProduto.Text = "";

            }
        }
    }
}