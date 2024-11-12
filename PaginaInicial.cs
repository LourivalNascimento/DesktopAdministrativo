using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesktopAdministrativo
{

    public partial class TelaPaginaInicial : Form
    {
        private string SqlStringDeConexao = @"Data Source=CYBERLOGRA\SQLSERVER2022;Initial Catalog=DBMorangolandia;Integrated Security=True";
        private string numeroSerie;
        private string nomeFuncionario;

        public TelaPaginaInicial(string numeroSerie)
        {
            InitializeComponent();
            this.numeroSerie = numeroSerie;
            nomeFuncionario = obterNomeFuncionario();
            labelNomeFuncionario.Text = "Olá, " + nomeFuncionario;
        }
        private string obterCodigoFuncionario()
        {
            string codigoFuncionario = "";

            // Conectando ao banco de dados e executando a consulta
            using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
            {
                try
                {
                    connection.Open();
                    // Definir a query para pegar o usuário logado
                    string queryPegarCodigoFuncionario = @"SELECT usuario_log FROM TBLogin WHERE status_login = 1 AND NumeroSerie = @numeroSerie";
                    using (SqlCommand command = new SqlCommand(queryPegarCodigoFuncionario, connection))
                    {
                        // Adicionar o parâmetro de número de série
                        command.Parameters.AddWithValue("@numeroSerie", numeroSerie);

                        // Executar a consulta
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Verifica se a coluna existe e não é nula
                                if (reader["usuario_log"] != DBNull.Value)
                                {
                                    codigoFuncionario = reader["usuario_log"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Usuário logado não encontrado.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nenhum resultado encontrado com o número de série especificado.");
                            }
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Tratamento de erro específico para SQL
                    MessageBox.Show("Erro SQL: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    // Tratamento de outros tipos de exceções
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                }
            }
            return codigoFuncionario;
        }

        private string obterNomeFuncionario()
        {
            string nomeFuncionario = "";
            string codigo = obterCodigoFuncionario();
            // Conectando ao banco de dados e executando a consulta
            using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
            {
                try
                {
                    connection.Open();

                    // Definir a query para pegar o usuário logado
                    string queryPegarNomeFuncionario = @"SELECT nome_func FROM TBFuncionario WHERE cod_func = @codigo";
                    using (SqlCommand command = new SqlCommand(queryPegarNomeFuncionario, connection))
                    {
                        // Adicionar o parâmetro de número de série
                        command.Parameters.AddWithValue("@codigo", codigo);
                        // Executar a consulta
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Verifica se a coluna existe e não é nula
                                if (reader["nome_func"] != DBNull.Value)
                                {
                                    nomeFuncionario = reader["nome_func"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Usuário logado não encontrado.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nenhum resultado encontrado com o número de série especificado.");
                            }
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Tratamento de erro específico para SQL
                    MessageBox.Show("Erro SQL: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    // Tratamento de outros tipos de exceções
                    MessageBox.Show("codigoErro ao conectar com o banco de dados: " + ex.Message);
                }
            }
            return nomeFuncionario;
        }
        //Método que mostra um MessageBox perguntando se deseja fechar ou não o programa
        public void FecharPrograma()
        {
            DialogResult result = MessageBox.Show("Deseja fechar o programa Morangolandia?", "s a i r", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                //Desloga da conta e fecha o programa
                Close();
            }
        }

        //Evento que ativa a interação do teclado com a tela
        private void PaginaInicial_KeyDown(object sender, KeyEventArgs e)
        {
            //Se a tecla "Esc" for pertada, fecha a tela atual
            if (e.KeyData == Keys.Escape)
            {
                FecharPrograma();
            }
        }

        //Evento de click do mouse em botão "Esc" e fecha o form
        private void btnEsc_Click(object sender, EventArgs e)
        {
            FecharPrograma();
        }

        //Abre o form "Compras" principal e fecha a atual
        private void btnCompras_Click(object sender, EventArgs e)
        {
            TelaComprasAcompanhamento telaCompra = new TelaComprasAcompanhamento(nomeFuncionario);
            telaCompra.Show();
            Close();
        }
        //Abre tela "Estoque"
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            TelaEstoque telaEstoque = new TelaEstoque(nomeFuncionario);
            telaEstoque.Show();
            Close();
        }
        //Abre tela "Ordem de Produção"
        private void btnOrdemDeProducao_Click(object sender, EventArgs e)
        {
            TelaOrdemDeProducao telaOrdemDeProducao = new TelaOrdemDeProducao(nomeFuncionario);
            telaOrdemDeProducao.Show();
            Close();
        }
        //Abre tela "Pessoas e Credores"
        private void btnPessoasECredores_Click(object sender, EventArgs e)
        {
            TelaPessoasECredoresConsulta telaPessoasECredoresConsulta = new TelaPessoasECredoresConsulta(nomeFuncionario);
            telaPessoasECredoresConsulta.Show();
            Close();
        }

        private void TelaPaginaInicial_Load(object sender, EventArgs e)
        {
        }
    }
}
