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

namespace DesktopAdministrativo
{
    public partial class TelaOrdemDeProducaoNovaOrdem : Form
    {
        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        //--------------------------------------BANCO DE DADOS------------------------------------------
        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private string SqlStringDeConexao = @"Data Source=CYBERLOGRA\SQLSERVER2022;Initial Catalog=DBMorangolandia;Integrated Security=True";
        private string nomeFuncionario;
        public TelaOrdemDeProducaoNovaOrdem()
        {
            InitializeComponent();
        }

        private void btnCancelar_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void TelaOrdemDeProducaoNovaOrdem_Deactivate(object sender, EventArgs e)
        {
            TelaEstoque telaEstoque = new TelaEstoque(nomeFuncionario);
            telaEstoque.Activate();
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Capturando os dados da interface
            string codOp = textBoxNumOrdemDeProducao.Text;
            string nomeProdOp = textBoxNomeProduto.Text;
            int quantidade = int.Parse(textBoxQuantidade.Text);
            DateTime dataOp = dtpData.Value;

            using (SqlConnection conn = new SqlConnection(SqlStringDeConexao))
            {
                try
                {
                    conn.Open();

                    // Comando SQL para inserir dados na tabela
                    string query = "INSERT INTO TBOP (cod_op, nome_prod_op, qtd_op, dt_op) VALUES (@codOp, @nomeProdOp, @quantidade, @dataOp)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Adicionando parâmetros
                        cmd.Parameters.AddWithValue("@codOp", codOp);
                        cmd.Parameters.AddWithValue("@nomeProdOp", nomeProdOp);
                        cmd.Parameters.AddWithValue("@quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@dataOp", dataOp);

                        // Executando o comando
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar os dados: " + ex.Message);
                }
            }
        }
    }
}
