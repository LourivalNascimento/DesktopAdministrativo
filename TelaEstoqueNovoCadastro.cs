using PdfSharp.Internal;
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

    public partial class TelaEstoqueNovoCadastro : Form
    {
        public TelaEstoqueNovoCadastro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelaEstoqueNovoCadastro_Deactivate_1(object sender, EventArgs e)
        {
            TelaEstoque telaEstoque = new TelaEstoque(nomeFuncionario);
            telaEstoque.Activate();
            this.Close();
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        //--------------------------------------BANCO DE DADOS------------------------------------------
        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private string SqlStringDeConexao = @"Data Source=CYBERLOGRA\SQLSERVER2022;Initial Catalog=DBMorangolandia;Integrated Security=True";
        private string nomeFuncionario;
        // Evento do botão de salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Verifica se o campo de código do produto/insumo foi preenchido
            if (string.IsNullOrWhiteSpace(textBoxCodigoProduto.Text))
            {
                MessageBox.Show("O campo de código do produto/insumo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isProduto = radioBtnProdutos.Checked;
            string codigo = textBoxCodigoProduto.Text;
            string valorProduto = textBoxValorProduto.Text;
            string categoria = GetCategoriaSelecionada();

            if (string.IsNullOrEmpty(categoria))
            {
                MessageBox.Show("Selecione uma categoria (Fruta, Legume, Grão ou Verdura).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se não for um produto, então é um insumo e tentamos importar da tabela de compras
            if (!isProduto)
            {
                ImportarInsumoDaCompra(codigo, categoria);

            }
            else
            {
                ImportarProdutosDaProducao(codigo, categoria, valorProduto);
            }
        }

        // Método para obter a categoria selecionada (Fruta, Legume, Grão ou Verdura)
        private string GetCategoriaSelecionada()
        {
            if (radioBtnFruta.Checked) return "Fruta";
            if (radioBtnLegume.Checked) return "Legume";
            if (radioBtnGrao.Checked) return "Grão";
            if (radioBtnVerdura.Checked) return "Verdura";
            return null;
        }
        // Método para importar dados de produto da tabela de producao para a tabela de produtos
        private void ImportarProdutosDaProducao(string codigo, string categoria, string valorProduto)
        {
            string query = "SELECT [cod_prod], [nome_prod], [qtd_prod] FROM [DBMorangolandia].[dbo].[TBProducao] WHERE [cod_prod] = @codigo";

            using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@codigo", codigo);

                try
                {
                    connection.Open(); // Tenta abrir a conexão

                    SqlDataReader reader = command.ExecuteReader(); // Executa a consulta

                    if (reader.Read()) // Verifica se há dados retornados
                    {
                        string nomeProduto = reader["nome_prod"].ToString();
                        int quantidadeProduto = Convert.ToInt32(reader["qtd_prod"]);

                        reader.Close(); // Fecha o leitor antes de continuar

                        string insertQuery = "INSERT INTO [DBMorangolandia].[dbo].[TBProdutos] (cod_prod, nome_prod, qtd_prod, valor_prod, cat_prod) VALUES (@codProd, @nomeProd, @qtdProd, @valorProd, @codProd)";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@codProd", codigo);
                            insertCommand.Parameters.AddWithValue("@nomeProd", nomeProduto);
                            insertCommand.Parameters.AddWithValue("@qtdProd", quantidadeProduto);
                            insertCommand.Parameters.AddWithValue("@valorProd", valorProduto);
                            insertCommand.Parameters.AddWithValue("@categoria", categoria);

                            insertCommand.ExecuteNonQuery(); // Executa a inserção
                        }

                        MessageBox.Show("Insumo registrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Insumo não encontrado na tabela de compras.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    // Exibe a mensagem completa do erro para diagnóstico
                    MessageBox.Show("Erro ao importar insumo da compra: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Método para importar dados de insumo da tabela de compras para a tabela de insumos
        private void ImportarInsumoDaCompra(string codigo, string categoria)
        {
            string query = "SELECT [cod_produto], [nome_produto], [qtd_produto], [valor_unit] FROM [DBMorangolandia].[dbo].[TBCompras_Inumos] WHERE [cod_produto] = @codigo";

            using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@codigo", codigo);

                try
                {
                    connection.Open(); // Tenta abrir a conexão

                    SqlDataReader reader = command.ExecuteReader(); // Executa a consulta

                    if (reader.Read()) // Verifica se há dados retornados
                    {
                        string nomeInsumo = reader["nome_produto"].ToString();
                        decimal valorInsumo = Convert.ToDecimal(reader["valor_unit"]);
                        int quantidadeInsumo = Convert.ToInt32(reader["qtd_produto"]);

                        reader.Close(); // Fecha o leitor antes de continuar

                        string insertQuery = "INSERT INTO [DBMorangolandia].[dbo].[TBInsumos] (cod_insum, nome_insum, qtd_insum, valor_insum, cat_insum) VALUES (@codInsum, @nomeInsum, @qtdInsum, @valorInsum, @categoria)";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@codInsum", codigo);
                            insertCommand.Parameters.AddWithValue("@nomeInsum", nomeInsumo);
                            insertCommand.Parameters.AddWithValue("@qtdInsum", quantidadeInsumo);
                            insertCommand.Parameters.AddWithValue("@valorInsum", valorInsumo);
                            insertCommand.Parameters.AddWithValue("@categoria", categoria);

                            insertCommand.ExecuteNonQuery(); // Executa a inserção
                        }

                        MessageBox.Show("Insumo registrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Insumo não encontrado na tabela de compras.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    // Exibe a mensagem completa do erro para diagnóstico
                    MessageBox.Show("Erro ao importar insumo da compra: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioBtnProdutos_CheckedChanged(object sender, EventArgs e)
        {
            labelValorProduto.Visible = true;
            textBoxValorProduto.Visible = true;
            pictureBox1.Visible = true;
        }

        private void radioBtnInsumos_CheckedChanged(object sender, EventArgs e)
        {
            labelValorProduto.Visible = false;
            textBoxValorProduto.Visible = false;
            pictureBox1.Visible = false;
        }
    }
}
