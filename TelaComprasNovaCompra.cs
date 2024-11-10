﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace DesktopAdministrativo
{
    
    public partial class TelaComprasNovaCompra : Form
    {
        //Instancia os objetos dos controle
        Panel panelMenus = new Panel();
        Button btnMenuCompras = new Button();
        Button btnMenuConsultas = new Button();
        Button btnMenuEstoque = new Button();
        Button btnMenuOrdemDeProducao = new Button();
        Button btnMenuPessoasECredores = new Button();

        private float vezesBtnMenuClicado = 0;
        public TelaComprasNovaCompra(string nomeFuncionario)
        {
            InitializeComponent();
            pictureTop.Width = int.MaxValue;
            this.nomeFuncionario = nomeFuncionario;
            labelNomeFuncionario.Text = "Olá, " + nomeFuncionario;
            CarregarFornecedores();
        }
        //Método que mostrar um MessageBox perguntando se deseja fechar ou não o programa
        public void FecharPrograma()
        {
            DialogResult result = MessageBox.Show("Deseja fechar o programa Morangolandia?", "s a i r", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                //Desloga da conta e fecha o programa
                Close();
            }
        }
        //Métódo usado para saber que um form foi aberto
        private Form FormJaAberto(Type formType)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == formType)
                {
                    return openForm;
                }
            }
            return null;
        }

        //Método usado para abrir um form qualquer
        private void AbrirForm<ClasseQualquer>(bool fecharFormAtual = true) where ClasseQualquer : Form, new()
        {
            // Cria uma nova instância da classe genérica
            ClasseQualquer objetoDaClasseQualquer = new ClasseQualquer();
            Form openForm1 = FormJaAberto(typeof(ClasseQualquer));

            if (openForm1 != null)
            {
                openForm1.Focus();
            }
            else
            {
                objetoDaClasseQualquer.Show();
                if (fecharFormAtual)
                {
                    Close();
                }
            }
        }

        //Método usado para abrir o form anterior dando impressão de "voltar", fechando o form atual
        private void AbrirFormAnterior<ClasseQualquer>() where ClasseQualquer : Form, new()
        {
            Form openForm1 = FormJaAberto(typeof(ClasseQualquer));

            if (openForm1 != null)
            {
                openForm1.Focus();
            }
            else
            {
                ClasseQualquer objetoDaClasseQualquer = new ClasseQualquer();
                objetoDaClasseQualquer.Show();
            }
            Close();
        }
        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        //MANIPULAÇÃO DO MENU
        //Método para abrir menu lateral
        private void ExibirMenu()
        {
            vezesBtnMenuClicado++;
            //Adiciona o controle panel para ser fundo do menu e o exibe
            Controls.Add(panelMenus);
            panelMenus.Show();
            pictureTop.SendToBack();
            pictureTop.Width = int.MaxValue;
            panelMenus.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            panelMenus.Visible = true;
            panelMenus.BackColor = Color.FromArgb(221, 139, 249);
            panelMenus.Location = new Point(0 - 2);
            panelMenus.Width = 284;
            panelMenus.Height = int.MaxValue;
            panelMenus.AutoSize = true;
            panelMenus.BringToFront();
            pictureLogoMorangolandia.Location = new Point(309, 3);
            btnMenu.BackColor = Color.FromArgb(221, 139, 249);
            btnMenu.BringToFront();

            //Adiciona o controle botão
            Controls.Add(btnMenuCompras);
            Controls.Add(btnMenuConsultas);
            Controls.Add(btnMenuEstoque);
            Controls.Add(btnMenuOrdemDeProducao);
            Controls.Add(btnMenuPessoasECredores);
            //Coloca os botões e panel para a frente
            btnMenuCompras.BringToFront();
            btnMenuConsultas.BringToFront();
            btnMenuEstoque.BringToFront();
            btnMenuOrdemDeProducao.BringToFront();
            btnMenuPessoasECredores.BringToFront();
            //Escolhe cursor "Hand" para interação com o mouse
            btnMenuCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMenuConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMenuEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMenuOrdemDeProducao.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMenuPessoasECredores.Cursor = System.Windows.Forms.Cursors.Hand;
            //Escolhe a posição que o botão irá ficar
            btnMenuCompras.Location = new Point(33, 89);
            btnMenuConsultas.Location = new Point(33, 158);
            btnMenuEstoque.Location = new Point(33, 227);
            btnMenuOrdemDeProducao.Location = new Point(33, 296);
            btnMenuPessoasECredores.Location = new Point(33, 365);
            //Torna a visibilidade do botão verdadeira
            btnMenuCompras.Visible = true;
            btnMenuConsultas.Visible = true;
            btnMenuEstoque.Visible = true;
            btnMenuOrdemDeProducao.Visible = true;
            btnMenuPessoasECredores.Visible = true;
            //Escolhe a fonte utilizada para o nome no botão
            btnMenuCompras.Font = new Font("Franklin Gothic Heavy", (float)15.75);
            btnMenuConsultas.Font = new Font("Franklin Gothic Heavy", (float)15.75);
            btnMenuEstoque.Font = new Font("Franklin Gothic Heavy", (float)15.75);
            btnMenuOrdemDeProducao.Font = new Font("Franklin Gothic Heavy", (float)15.75);
            btnMenuPessoasECredores.Font = new Font("Franklin Gothic Heavy", (float)15.75);
            //Escolhe a cor da fonte do botão
            btnMenuCompras.ForeColor = Color.White;
            btnMenuConsultas.ForeColor = Color.White;
            btnMenuEstoque.ForeColor = Color.White;
            btnMenuOrdemDeProducao.ForeColor = Color.White;
            btnMenuPessoasECredores.ForeColor = Color.White;
            //Escolhe a cor de fundo do botão
            btnMenuCompras.BackColor = Color.FromArgb(221, 139, 249);
            btnMenuConsultas.BackColor = Color.FromArgb(221, 139, 249);
            btnMenuEstoque.BackColor = Color.FromArgb(221, 139, 249);
            btnMenuOrdemDeProducao.BackColor = Color.FromArgb(221, 139, 249);
            btnMenuPessoasECredores.BackColor = Color.FromArgb(221, 139, 249);
            //Ancora o botão á direita superior da tela
            btnMenuCompras.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            btnMenuConsultas.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            btnMenuEstoque.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            btnMenuOrdemDeProducao.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            btnMenuPessoasECredores.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //Redimenciona o botão automaticamente
            btnMenuCompras.AutoSize = true;
            btnMenuConsultas.AutoSize = true;
            btnMenuEstoque.AutoSize = true;
            btnMenuOrdemDeProducao.AutoSize = true;
            btnMenuPessoasECredores.AutoSize = true;
            //Indica se o controle pode interagir com o usuário
            btnMenuCompras.Enabled = true;
            btnMenuConsultas.Enabled = true;
            btnMenuEstoque.Enabled = true;
            btnMenuOrdemDeProducao.Enabled = true;
            btnMenuPessoasECredores.Enabled = true;
            //Escolhe o estilo do botão
            btnMenuCompras.FlatStyle = FlatStyle.Flat;
            btnMenuConsultas.FlatStyle = FlatStyle.Flat;
            btnMenuEstoque.FlatStyle = FlatStyle.Flat;
            btnMenuOrdemDeProducao.FlatStyle = FlatStyle.Flat;
            btnMenuPessoasECredores.FlatStyle = FlatStyle.Flat;
            //Traz o controle botão para frente dos componentes da tela
            btnMenuCompras.BringToFront();
            btnMenuConsultas.BringToFront();
            btnMenuEstoque.BringToFront();
            btnMenuOrdemDeProducao.BringToFront();
            btnMenuPessoasECredores.BringToFront();
            //Tira a borda do botão
            btnMenuCompras.FlatAppearance.BorderSize = 0;
            btnMenuConsultas.FlatAppearance.BorderSize = 0;
            btnMenuEstoque.FlatAppearance.BorderSize = 0;
            btnMenuOrdemDeProducao.FlatAppearance.BorderSize = 0;
            btnMenuPessoasECredores.FlatAppearance.BorderSize = 0;
            //Escolhe a cor de fundo do botão ao deixar o mouse dentro dos limites do botão
            btnMenuCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(221, 139, 249);
            btnMenuConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(221, 139, 249);
            btnMenuEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(221, 139, 249);
            btnMenuOrdemDeProducao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(221, 139, 249);
            btnMenuPessoasECredores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(221, 139, 249);
            //Instancia o evento de interação quando o mouse passa por cima do botão
            btnMenuCompras.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMenuCompras_MouseMove);
            btnMenuConsultas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMenuConsultas_MouseMove);
            btnMenuEstoque.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMenuEstoque_MouseMove);
            btnMenuOrdemDeProducao.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMenuOrdemDeProducao_MouseMove);
            btnMenuPessoasECredores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMenuPessoasECredores_MouseMove);
            //Instancia o evento de interação quando o mouse sai de cima do botão
            btnMenuCompras.MouseLeave += new System.EventHandler(this.btnMenuCompras_MouseLeave);
            btnMenuConsultas.MouseLeave += new System.EventHandler(this.btnMenuConsultas_MouseLeave);
            btnMenuEstoque.MouseLeave += new System.EventHandler(this.btnMenuEstoque_MouseLeave);
            btnMenuOrdemDeProducao.MouseLeave += new System.EventHandler(this.btnMenuOrdemDeProducao_MouseLeave);
            btnMenuPessoasECredores.MouseLeave += new System.EventHandler(this.btnMenuPessoasECredores_MouseLeave);
            //Instancia o evento de interação quando o usuário clica com o mouse no botão
            btnMenuCompras.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenuCompras_Click);
            btnMenuConsultas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenuConsultas_Click);
            btnMenuEstoque.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenuEstoque_Click);
            btnMenuOrdemDeProducao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenuOrdemDeProducao_Click);
            btnMenuPessoasECredores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenuPessoasECredores_Click);
            //Define o texto exibido no botão
            btnMenuCompras.Text = "Compras";
            btnMenuConsultas.Text = "Consultas";
            btnMenuEstoque.Text = "Estoque";
            btnMenuOrdemDeProducao.Text = "Ordem de Produção";
            btnMenuPessoasECredores.Text = "Pessoas e Credores";
        }
        //Método para "fechar"(ocultar) menu lateral
        private void OcultarMenu()
        {
            vezesBtnMenuClicado++;
            Controls.Add(panelMenus);
            panelMenus.Hide();
            pictureLogoMorangolandia.Location = new Point(118, 3);
            btnMenu.BackColor = Color.FromArgb(162, 66, 195);
            btnMenuCompras.Visible = false;
            btnMenuConsultas.Visible = false;
            btnMenuEstoque.Visible = false;
            btnMenuOrdemDeProducao.Visible = false;
            btnMenuPessoasECredores.Visible = false;
        }
        //Evento de click no botão "MENU"
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //Se a quantidade de click for par, abre o menu
            //Se a quantidade de click for impar, fecha o menu
            if (vezesBtnMenuClicado % 2 == 0)
            {
                ExibirMenu();
            }
            else
            {
                OcultarMenu();
            }
        }
        //CONFIRMAÇÃO DE BOTÕES DO MENU:
        //MouseMove: evento de interação quando o mouse passa por cima do botão
        //MouseLeave: evento de interação quando o mouse passa por cima do botão
        private void btnMenuCompras_MouseMove(object sender, MouseEventArgs e)
        {
            //Adiciona sublinhado ao texto do botão
            btnMenuCompras.Font = new Font("Franklin Gothic Heavy", (float)15.75, FontStyle.Underline);
        }
        private void btnMenuCompras_MouseLeave(object sender, EventArgs e)
        {
            //"Retira" sublianhado do botão
            btnMenuCompras.Font = new Font("Franklin Gothic Heavy", (float)15.75);
        }
        private void btnMenuConsultas_MouseMove(object sender, MouseEventArgs e)
        {
            btnMenuConsultas.Font = new Font("Franklin Gothic Heavy", (float)15.75, FontStyle.Underline);
        }
        private void btnMenuConsultas_MouseLeave(object sender, EventArgs e)
        {
            btnMenuConsultas.Font = new Font("Franklin Gothic Heavy", (float)15.75);
        }
        private void btnMenuEstoque_MouseMove(object sender, MouseEventArgs e)
        {
            btnMenuEstoque.Font = new Font("Franklin Gothic Heavy", (float)15.75, FontStyle.Underline);
        }
        private void btnMenuEstoque_MouseLeave(object sender, EventArgs e)
        {
            btnMenuEstoque.Font = new Font("Franklin Gothic Heavy", (float)15.75);
        }
        private void btnMenuOrdemDeProducao_MouseMove(object sender, MouseEventArgs e)
        {
            btnMenuOrdemDeProducao.Font = new Font("Franklin Gothic Heavy", (float)15.75, FontStyle.Underline);
        }
        private void btnMenuOrdemDeProducao_MouseLeave(object sender, EventArgs e)
        {
            btnMenuOrdemDeProducao.Font = new Font("Franklin Gothic Heavy", (float)15.75);
        }
        private void btnMenuPessoasECredores_MouseMove(object sender, MouseEventArgs e)
        {
            btnMenuPessoasECredores.Font = new Font("Franklin Gothic Heavy", (float)15.75, FontStyle.Underline);
        }
        private void btnMenuPessoasECredores_MouseLeave(object sender, EventArgs e)
        {
            btnMenuPessoasECredores.Font = new Font("Franklin Gothic Heavy", (float)15.75);
        }
        //Eventos de click do mouse em botões do menu
        private void btnMenuCompras_Click(object sender, EventArgs e)
        {
            //Oculta o menu lateral e seta o valor 0 a variável "vezesBtnMenuClicado"
            //Fazendo com que a contagem reinicie e o menu possa ser aberto novamente
            OcultarMenu();
            vezesBtnMenuClicado = 0;
            //Abre tela "Compras" e fecha a atual
            TelaComprasAtualizarStatus telaCompra = new TelaComprasAtualizarStatus(nomeFuncionario);
            telaCompra.Show();
            Close();
        }
        private void btnMenuConsultas_Click(object sender, EventArgs e)
        {
            //Abre tela "Consultas" e fecha a atual
            AbrirForm<TelaConsultas>();
        }
        private void btnMenuEstoque_Click(object sender, EventArgs e)
        {
            //Abre tela "Estoque de Insumos" e fecha a atual
            AbrirForm<TelaEstoque>();
        }
        private void btnMenuOrdemDeProducao_Click(object sender, EventArgs e)
        {
            //Abre tela "Ordem de Produção" e fecha a atual
            AbrirForm<TelaOrdemDeProducao>();
        }
        private void btnMenuPessoasECredores_Click(object sender, EventArgs e)
        {
            //Abre tela "Pessoas e Credores" e fecha a atual
            AbrirForm<TelaPessoasECredoresConsulta>();
        }
        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        //Evento de click do mouse em botão "Esc"
        private void btnEsc_Click(object sender, EventArgs e)
        {
            FecharPrograma();
        }
        //Evento que ativa a interação do teclado com a tela
        private void TelaComprasNovaCompra_KeyDown(object sender, KeyEventArgs e)
        {
            //Responsável por fechar tela atual e abrir a anterior
            if (e.KeyData == Keys.Escape)
            {
                FecharPrograma();
            }
        }
        //Ao clicar na tela com o Menu aberto, fecha o menu
        private void TelaComprasNovaCompra_MouseClick(object sender, MouseEventArgs e)
        {
            if (vezesBtnMenuClicado % 2 != 0)
            {
                OcultarMenu();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Chama método "AbrirFormAnterior()", responsável por fechar tela atual e abrir a anterior
            TelaComprasAcompanhamento telaCompra = new TelaComprasAcompanhamento(nomeFuncionario);
            telaCompra.Show();
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você tem certeza que deseja remover o PDF?", "Confirmar remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Limpa o campo de texto
                textBoxAnexarPDF.Clear();
            }
        }


        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        //--------------------------------------BANCO DE DADOS------------------------------------------
        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private string SqlStringDeConexao = @"Data Source=CYBERLOGRA\SQLSERVER2022;Initial Catalog=DBMorangolandia;Integrated Security=True";
        private string nomeFuncionario;
        private string codigoNotaFiscal, numNotaFiscal, statusCompra, nomeFornecedor;
        private DateTime dataEmissao;
        private float valorUnitario;

        // Carregar os fornecedores no ComboBox
        private void CarregarFornecedores()
        {
            using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
            {
                connection.Open();

                string query = "SELECT id_forn, nome_fant FROM TBFornecedor";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                comboBoxFornecedor.DisplayMember = "nome_fant"; // Nome que será mostrado na ComboBox
                comboBoxFornecedor.ValueMember = "id_forn";     // Valor que será passado ao selecionar
                comboBoxFornecedor.DataSource = dataTable;
            }
        }
        public class Produto
        {
            public int Codigo { get; set; }
            public string Nome { get; set; }
            public int Quantidade { get; set; }
            public float Valor { get; set; }
        }
        private List<Produto> listaProdutos = new List<Produto>();
        // Evento de salvar a compra
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Coletando as informações do formulário
            int fornecedorId = int.Parse(comboBoxFornecedor.SelectedValue.ToString());
            string numeroNota = textBoxNumNota.Text;
            string codigoCompra = textBoxCodigoCompra.Text;
            DateTime emissaoNota = dtpEmissaoNota.Value;
            string observacoes = textBoxObservacoes.Text;
            string status = GetStatus();
            byte[] anexoNota = null;

            // Verifica se o campo do anexo não está vazio e converte para byte[]
            if (string.IsNullOrEmpty(textBoxAnexarPDF.Text))
            {
                MessageBox.Show("É obrigatório anexar o arquivo da Nota Fiscal em PDF.", "Anexo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Interrompe o fluxo para permitir que o usuário faça o anexo
            }

            // Converte o arquivo PDF em byte[]
            string arquivoNotaPath = textBoxAnexarPDF.Text;
            anexoNota = File.ReadAllBytes(arquivoNotaPath);

            try
            {
                // Verificar duplicidade antes de tentar inserir
                using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
                {
                    connection.Open();

                    string verificaDuplicidadeQuery = @"
                SELECT COUNT(1) FROM TBCompras WHERE nf = @nf";

                    using (SqlCommand cmdVerifica = new SqlCommand(verificaDuplicidadeQuery, connection))
                    {
                        cmdVerifica.Parameters.AddWithValue("@nf", numeroNota);
                        int duplicidade = (int)cmdVerifica.ExecuteScalar();

                        if (duplicidade > 0)
                        {
                            MessageBox.Show("O número da nota já existe. Por favor, insira um número de nota diferente.",
                                            "Erro de duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            // Reseta o campo do número da nota
                            textBoxNumNota.Clear();
                            textBoxNumNota.Focus(); // Coloca o cursor diretamente no campo para que o usuário insira um novo valor
                            return; // Interrompe o fluxo para permitir que o usuário insira um novo número de nota
                        }
                    }

                    // Inserir a compra no banco
                    string insertCompraQuery = @"
                INSERT INTO TBCompras (fk_forn, nf, anexo_nf, dt_emissao, status_compras, obs_compras, cod_compra)
                VALUES (@fk_forn, @nf, @anexo_nf, @dt_emissao, @status_compras, @obs_compras, @cod_compra);
                SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(insertCompraQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@fk_forn", fornecedorId);
                        cmd.Parameters.AddWithValue("@nf", numeroNota);
                        cmd.Parameters.AddWithValue("@anexo_nf", anexoNota);
                        cmd.Parameters.AddWithValue("@dt_emissao", emissaoNota);
                        cmd.Parameters.AddWithValue("@status_compras", status);
                        cmd.Parameters.AddWithValue("@obs_compras", observacoes);
                        cmd.Parameters.AddWithValue("@cod_compra", codigoCompra);

                        // Tentar executar a inserção e obter o ID da compra
                        int compraId = Convert.ToInt32(cmd.ExecuteScalar());

                        if (compraId != 0)
                        {
                            // Inserir os produtos relacionados à compra
                            foreach (Produto produto in listaProdutos)
                            {
                                string insertProdutoQuery = @"
                            INSERT INTO TBCompras_Inumos (fk_compras, cod_produto, nome_produto, qtd_produto, valor_unit)
                            VALUES (@fk_compras, @cod_produto, @nome_produto, @qtd_produto, @valor_unit);";

                                using (SqlCommand cmdProduto = new SqlCommand(insertProdutoQuery, connection))
                                {
                                    cmdProduto.Parameters.AddWithValue("@fk_compras", compraId);
                                    cmdProduto.Parameters.AddWithValue("@cod_produto", produto.Codigo);
                                    cmdProduto.Parameters.AddWithValue("@nome_produto", produto.Nome);
                                    cmdProduto.Parameters.AddWithValue("@qtd_produto", produto.Quantidade);
                                    cmdProduto.Parameters.AddWithValue("@valor_unit", produto.Valor);

                                    cmdProduto.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("Compra registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBoxNumNota.Clear();
                            textBoxNumNota.Focus();
                            textBoxAnexarPDF.Clear();
                            textBoxObservacoes.Clear();
                            textBoxCodigoCompra.Clear();                        }
                        else
                        {
                            MessageBox.Show("Erro ao registrar a compra. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Erro de violação de chave única (duplicidade)
                {
                    MessageBox.Show("O número da nota já existe. Por favor, insira um número de nota diferente.", "Erro de duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Reseta o campo do número da nota
                    textBoxNumNota.Clear();
                    textBoxNumNota.Focus();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao salvar a compra: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            // Verificar se os campos de produto estão preenchidos corretamente
            if (string.IsNullOrEmpty(textBoxCodigo.Text) || string.IsNullOrEmpty(textBoxNomeDoProduto.Text) ||
                string.IsNullOrEmpty(textBoxQuantidade.Text) || string.IsNullOrEmpty(textBoxValor.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Criar um novo objeto Produto com os dados fornecidos
            Produto produto = new Produto
            {
                Codigo = int.Parse(textBoxCodigo.Text),
                Nome = textBoxNomeDoProduto.Text,
                Quantidade = int.Parse(textBoxQuantidade.Text),
                Valor = float.Parse(textBoxValor.Text)
            };

            // Adicionar o produto à lista
            listaProdutos.Add(produto);

            // Limpar os campos de entrada para novos produtos
            textBoxCodigo.Clear();
            textBoxNomeDoProduto.Clear();
            textBoxQuantidade.Clear();
            textBoxValor.Clear();
        }
        private void btnAnexarNotaFiscalPdf_Click(object sender, EventArgs e)
        {
            // Abrir o seletor de arquivos para anexar o PDF
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxAnexarPDF.Text = openFileDialog.FileName;
            }
        }

        // Método para obter o status da compra
        private string GetStatus()
        {
            if (radioBtnEmAberto.Checked) return "Em Aberto";
            if (radioBtnDespachado.Checked) return "Despachado";
            if (radioBtnConcluido.Checked) return "Concluído";
            return string.Empty;
        }

        // Carregar os dados no formulário quando ele for carregado
        private void FormCompra_Load(object sender, EventArgs e)
        {
            CarregarFornecedores();
        }
    }
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                Text = caption
            };

            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox inputBox = new TextBox() { Left = 50, Top = 50, Width = 400 };

            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            prompt.ShowDialog();
            return inputBox.Text;
        }
    }
}
