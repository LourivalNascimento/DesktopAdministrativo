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
            // Verifica se o código do produto/insumo está preenchido
            if (string.IsNullOrWhiteSpace(textBoxCodigoProduto.Text))
            {
                MessageBox.Show("O campo de código do produto/insumo é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Variáveis para armazenar o ID do produto/insumo e a categoria selecionada
            int idSelecionado = 0;
            bool isProduto = radioBtnProdutos.Checked;
            string codigo = textBoxCodigoProduto.Text;
            string categoria = GetCategoriaSelecionada();

            // Verifica se uma categoria foi selecionada
            if (string.IsNullOrEmpty(categoria))
            {
                MessageBox.Show("Selecione uma categoria (Fruta, Legume, Grão ou Verdura).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Busca o ID do produto/insumo com base no código fornecido
            if (isProduto)
            {
                idSelecionado = ObterIdProdutoPorCodigo(codigo);
            }
            else
            {
                idSelecionado = ObterIdInsumoPorCodigo(codigo);
            }

            // Se o ID não for encontrado, exibe uma mensagem e encerra
            if (idSelecionado == 0)
            {
                MessageBox.Show("Produto ou insumo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Salva o registro no estoque
            SalvarRegistroEstoque(idSelecionado, isProduto);
        }

        // Método para identificar a categoria selecionada
        private string GetCategoriaSelecionada()
        {
            if (radioBtnFruta.Checked) return "Fruta";
            if (radioBtnLegume.Checked) return "Legume";
            if (radioBtnGrao.Checked) return "Grão";
            if (radioBtnVerdura.Checked) return "Verdura";
            return null;
        }

        // Método para obter o ID do produto pelo código
        private int ObterIdProdutoPorCodigo(string codigo)
        {
            int id = 0;
            string query = "SELECT [id_prod] FROM [DBMorangolandia].[dbo].[TBProdutos] WHERE [cod_prod] = @codigo";

            using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@codigo", codigo);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        id = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return id;
        }

        // Método para obter o ID do insumo pelo código
        private int ObterIdInsumoPorCodigo(string codigo)
        {
            int id = 0;
            string query = "SELECT [id_insum] FROM [DBMorangolandia].[dbo].[TBInsumos] WHERE [cod_insum] = @codigo";

            using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@codigo", codigo);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        id = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o insumo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return id;
        }

        // Método para salvar o registro no estoque
        private void SalvarRegistroEstoque(int idSelecionado, bool isProduto)
        {
            string query = "INSERT INTO [DBMorangolandia].[dbo].[TBEstoque] (fk_prod, fk_insum, dt_entra_estoq) VALUES (@idProd, @idInsum, @dataEntrada)";

            using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idProd", isProduto ? idSelecionado : (object)DBNull.Value);
                command.Parameters.AddWithValue("@idInsum", isProduto ? (object)DBNull.Value : idSelecionado);
                command.Parameters.AddWithValue("@dataEntrada", DateTime.Now);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro salvo com sucesso no estoque.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao salvar o registro no estoque.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar no estoque: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
