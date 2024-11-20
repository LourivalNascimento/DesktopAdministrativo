using System;
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

namespace DesktopAdministrativo
{
    public partial class TelaPessoasECredoresNovoCadastro : Form
    {
        //Instancia os objetos dos controle
        Panel panelMenus = new Panel();
        Button btnMenuCompras = new Button();
        Button btnMenuConsultas = new Button();
        Button btnMenuEstoque = new Button();
        Button btnMenuOrdemDeProducao = new Button();
        Button btnMenuPessoasECredores = new Button();

        private int vezesBtnMenuClicado = 0;
        private string caminhoArquivoAnexo = "";
        public TelaPessoasECredoresNovoCadastro(string nomeFuncionario)
        {
            InitializeComponent();
            pictureTop.Width = int.MaxValue;
            this.nomeFuncionario = nomeFuncionario;
            labelNomeFuncionario.Text = "Olá, " + nomeFuncionario;
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
            Controls.Add(btnMenuEstoque);
            Controls.Add(btnMenuOrdemDeProducao);
            Controls.Add(btnMenuPessoasECredores);
            //Coloca os botões e panel para a frente
            btnMenuCompras.BringToFront();
            btnMenuEstoque.BringToFront();
            btnMenuOrdemDeProducao.BringToFront();
            btnMenuPessoasECredores.BringToFront();
            //Escolhe cursor "Hand" para interação com o mouse
            btnMenuCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMenuEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMenuOrdemDeProducao.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMenuPessoasECredores.Cursor = System.Windows.Forms.Cursors.Hand;
            //Escolhe a posição que o botão irá ficar
            btnMenuCompras.Location = new Point(33, 158);
            btnMenuEstoque.Location = new Point(33, 227);
            btnMenuOrdemDeProducao.Location = new Point(33, 296);
            btnMenuPessoasECredores.Location = new Point(33, 365);
            //Torna a visibilidade do botão verdadeira
            btnMenuCompras.Visible = true;
            btnMenuEstoque.Visible = true;
            btnMenuOrdemDeProducao.Visible = true;
            btnMenuPessoasECredores.Visible = true;
            //Escolhe a fonte utilizada para o nome no botão
            btnMenuCompras.Font = new Font("Franklin Gothic Heavy", (float)15.75);
            btnMenuEstoque.Font = new Font("Franklin Gothic Heavy", (float)15.75);
            btnMenuOrdemDeProducao.Font = new Font("Franklin Gothic Heavy", (float)15.75);
            btnMenuPessoasECredores.Font = new Font("Franklin Gothic Heavy", (float)15.75);
            //Escolhe a cor da fonte do botão
            btnMenuCompras.ForeColor = Color.White;
            btnMenuEstoque.ForeColor = Color.White;
            btnMenuOrdemDeProducao.ForeColor = Color.White;
            btnMenuPessoasECredores.ForeColor = Color.White;
            //Escolhe a cor de fundo do botão
            btnMenuCompras.BackColor = Color.FromArgb(221, 139, 249);
            btnMenuEstoque.BackColor = Color.FromArgb(221, 139, 249);
            btnMenuOrdemDeProducao.BackColor = Color.FromArgb(221, 139, 249);
            btnMenuPessoasECredores.BackColor = Color.FromArgb(221, 139, 249);
            //Ancora o botão á direita superior da tela
            btnMenuCompras.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            btnMenuEstoque.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            btnMenuOrdemDeProducao.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            btnMenuPessoasECredores.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            //Redimenciona o botão automaticamente
            btnMenuCompras.AutoSize = true;
            btnMenuEstoque.AutoSize = true;
            btnMenuOrdemDeProducao.AutoSize = true;
            btnMenuPessoasECredores.AutoSize = true;
            //Indica se o controle pode interagir com o usuário
            btnMenuCompras.Enabled = true;
            btnMenuEstoque.Enabled = true;
            btnMenuOrdemDeProducao.Enabled = true;
            btnMenuPessoasECredores.Enabled = true;
            //Escolhe o estilo do botão
            btnMenuCompras.FlatStyle = FlatStyle.Flat;
            btnMenuEstoque.FlatStyle = FlatStyle.Flat;
            btnMenuOrdemDeProducao.FlatStyle = FlatStyle.Flat;
            btnMenuPessoasECredores.FlatStyle = FlatStyle.Flat;
            //Tira a borda do botão
            btnMenuCompras.FlatAppearance.BorderSize = 0;
            btnMenuEstoque.FlatAppearance.BorderSize = 0;
            btnMenuOrdemDeProducao.FlatAppearance.BorderSize = 0;
            btnMenuPessoasECredores.FlatAppearance.BorderSize = 0;
            //Escolhe a cor de fundo do botão ao deixar o mouse dentro dos limites do botão
            btnMenuCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(221, 139, 249);
            btnMenuEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(221, 139, 249);
            btnMenuOrdemDeProducao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(221, 139, 249);
            btnMenuPessoasECredores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(221, 139, 249);
            //Instancia o evento de interação quando o mouse passa por cima do botão
            btnMenuCompras.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMenuCompras_MouseMove);
            btnMenuEstoque.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMenuEstoque_MouseMove);
            btnMenuOrdemDeProducao.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMenuOrdemDeProducao_MouseMove);
            btnMenuPessoasECredores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMenuPessoasECredores_MouseMove);
            //Instancia o evento de interação quando o mouse sai de cima do botão
            btnMenuCompras.MouseLeave += new System.EventHandler(this.btnMenuCompras_MouseLeave);
            btnMenuEstoque.MouseLeave += new System.EventHandler(this.btnMenuEstoque_MouseLeave);
            btnMenuOrdemDeProducao.MouseLeave += new System.EventHandler(this.btnMenuOrdemDeProducao_MouseLeave);
            btnMenuPessoasECredores.MouseLeave += new System.EventHandler(this.btnMenuPessoasECredores_MouseLeave);
            //Instancia o evento de interação quando o usuário clica com o mouse no botão
            btnMenuCompras.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenuCompras_Click);
            btnMenuEstoque.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenuEstoque_Click);
            btnMenuOrdemDeProducao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenuOrdemDeProducao_Click);
            btnMenuPessoasECredores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenuPessoasECredores_Click);
            //Define o texto exibido no botão
            btnMenuCompras.Text = "Compras";
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
            btnMenuEstoque.Visible = false;
            btnMenuOrdemDeProducao.Visible = false;
            btnMenuPessoasECredores.Visible = false;
        }
        //Evento de click no botão "MENU"
        private void btnMenu_Click_1(object sender, EventArgs e)
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
            TelaComprasAcompanhamento tela = new TelaComprasAcompanhamento(nomeFuncionario);
            tela.Show();
            Close();
        }
        private void btnMenuEstoque_Click(object sender, EventArgs e)
        {
            //Abre tela "Estoque de Insumos" e fecha a atual
            OcultarMenu();
            TelaEstoque tela = new TelaEstoque(nomeFuncionario);
            tela.Show();
            Close();
        }
        private void btnMenuOrdemDeProducao_Click(object sender, EventArgs e)
        {
            //Abre tela "Ordem de Produção" e fecha a atual
            OcultarMenu();
            TelaOrdemDeProducao tela = new TelaOrdemDeProducao(nomeFuncionario);
            tela.Show();
        }
        private void btnMenuPessoasECredores_Click(object sender, EventArgs e)
        {
            //Abre tela "Pessoas e Credores" e fecha a atual
            OcultarMenu();
            TelaPessoasECredoresConsulta tela = new TelaPessoasECredoresConsulta(nomeFuncionario);
            tela.Show();
        }
        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        //Evento de click do mouse em botão "Esc"
        private void btnEsc_Click_1(object sender, EventArgs e)
        {
            FecharPrograma();
        }
        private void TelaPessoasECredoresNovoCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                FecharPrograma();
            }
        }
        private void TelaPessoasECredoresNovoCadastro_MouseClick(object sender, MouseEventArgs e)
        {
            if (vezesBtnMenuClicado % 2 != 0)
            {
                OcultarMenu();
            }
        }
        private void radioBtnFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            labelCpfCnpj.Location = new Point(82, 44);
            labelCpfCnpj.Text = "CPF:";
            labelNomeNomeFantasia.Location = new Point(70, 76);
            labelNomeNomeFantasia.Text = "Nome:";
            labelFuncao.Visible = true;
            pictureFuncao.Visible = true;
            textBoxFuncao.Visible = true;
            labelUser.Visible = true;
            labelSenha.Visible = true;
            pictureNickName.Visible = true;
            pictureSenha.Visible = true;
            textBoxNickName.Visible = true;
            textBoxSenha.Visible = true;
        }

        private void radioBtnFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            labelCpfCnpj.Location = new Point(72, 44);
            labelCpfCnpj.Text = "CNPJ:";
            labelNomeNomeFantasia.Location = new Point(13, 76);
            labelNomeNomeFantasia.Text = "Nome Fantasia:";
            labelFuncao.Visible = false;
            pictureFuncao.Visible = false;
            textBoxFuncao.Visible = false;
            labelUser.Visible = false;
            labelSenha.Visible = false;
            pictureNickName.Visible = false;
            pictureSenha.Visible = false;
            textBoxNickName.Visible = false;
            textBoxSenha.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaPessoasECredoresConsulta tela = new TelaPessoasECredoresConsulta(nomeFuncionario);
            tela.Show();
            Close();
        }
        private void btnAnexarNotaFiscalPdf_Click(object sender, EventArgs e)
        {
            // Configura a caixa de diálogo para selecionar um arquivo PDF
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Arquivos PDF (*.pdf)|*.pdf", // Apenas PDFs podem ser selecionados
                Title = "Selecione um arquivo PDF"
            };

            // Se o usuário selecionar um arquivo, armazena o caminho e exibe o nome do arquivo
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivoAnexo = dialog.FileName;
                labelAnexar.Text = Path.GetFileName(caminhoArquivoAnexo); // Exibe apenas o nome do arquivo
                MessageBox.Show($"Arquivo anexado: {labelAnexar.Text}", "Debug"); // Debug para exibir o nome do arquivo
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Limpa o caminho do arquivo e o rótulo que exibe o nome
            caminhoArquivoAnexo = "";
            labelAnexar.Text = ""; // Limpa o nome do arquivo exibido
        }
        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        //--------------------------------------BANCO DE DADOS------------------------------------------
        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        private string SqlStringDeConexao = @"Data Source=CYBERLOGRA\SQLSERVER2022;Initial Catalog=DBMorangolandia;Integrated Security=True";
        private string nomeFuncionario;
        private string codigoNotaFiscal, numNotaFiscal, statusCompra, nomeFornecedor;

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
                {
                    connection.Open(); // Abre a conexão com o banco de dados
                    MessageBox.Show("Conexão com o banco de dados aberta", "Debug"); // Confirmação de conexão

                    // Validação dos dados
                    if (!ValidarDados(out string mensagemErro))
                    {
                        MessageBox.Show($"Erro ao salvar os dados:\n\n{mensagemErro}", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Cancela a operação se houver erros
                    }

                    // Verifica qual RadioButton está selecionado
                    if (radioBtnFuncionario.Checked)
                    {
                        SalvarFuncionario(connection); // Salva os dados do funcionário
                    }
                    else if (radioBtnFornecedor.Checked)
                    {
                        SalvarFornecedor(connection); // Salva os dados do fornecedor
                    }

                    // Mensagem de sucesso
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpar os campos após salvar
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro em caso de falha
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarDados(out string mensagemErro)
        {
            mensagemErro = "";

            if (radioBtnFuncionario.Checked)
            {
                // Validação de Funcionário
                if (string.IsNullOrWhiteSpace(textBoxNickName.Text))
                    mensagemErro += "O campo 'Usuário' é obrigatório.\n";
                if (string.IsNullOrWhiteSpace(textBoxSenha.Text))
                    mensagemErro += "O campo 'Senha' é obrigatório.\n";
                if (string.IsNullOrWhiteSpace(textBoxNomeNomeFantasia.Text))
                    mensagemErro += "O campo 'Nome' é obrigatório.\n";
                if (!ValidarCPF(textBoxCpfCnpj.Text))
                    mensagemErro += "O CPF informado é inválido.\n";
                if (string.IsNullOrWhiteSpace(textBoxFuncao.Text))
                    mensagemErro += "O campo 'Função' é obrigatório.\n";
                if (string.IsNullOrWhiteSpace(textBoxEmail.Text) || !ValidarEmail(textBoxEmail.Text))
                    mensagemErro += "O e-mail informado é inválido.\n";
            }
            else if (radioBtnFornecedor.Checked)
            {
                // Validação de Fornecedor
                if (string.IsNullOrWhiteSpace(textBoxCpfCnpj.Text))
                    mensagemErro += "O campo 'CNPJ' é obrigatório.\n";
                if (!ValidarCNPJ(textBoxCpfCnpj.Text))
                    mensagemErro += "O CNPJ informado é inválido.\n";
                if (string.IsNullOrWhiteSpace(textBoxNomeNomeFantasia.Text))
                    mensagemErro += "O campo 'Nome Fantasia' é obrigatório.\n";
            }

            return string.IsNullOrWhiteSpace(mensagemErro);
        }

        private bool ValidarCPF(string cpf)
        {
            // Placeholder para validação de CPF
            return cpf.Length == 11 && long.TryParse(cpf, out _);
        }

        private bool ValidarCNPJ(string cnpj)
        {
            // Placeholder para validação de CNPJ
            return cnpj.Length == 14 && long.TryParse(cnpj, out _);
        }

        private bool ValidarEmail(string email)
        {
            try
            {
                var endereco = new System.Net.Mail.MailAddress(email);
                return endereco.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void LimparCampos()
        {
            // Limpar campos de Funcionário e Fornecedor
            textBoxNickName.Clear();
            textBoxSenha.Clear();
            textBoxNomeNomeFantasia.Clear();
            textBoxCpfCnpj.Clear();
            textBoxFuncao.Clear();
            textBoxEmail.Clear();
            textBoxTelefone.Clear();
            textBoxObservacoes.Clear();

            // Limpar anexos
            caminhoArquivoAnexo = string.Empty;
        }

        private void AtualizarNumeroDeSerie(Guid numeroSerie)
        {
            using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
            {
                string query = "UPDATE TBLogin SET NumeroSerie = @numeroSerie WHERE usuario_log = @usuario_log";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@numeroSerie", numeroSerie);
                command.Parameters.AddWithValue("@usuario_log", textBoxNickName.Text);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();  // Executa a atualização
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o número de série: " + ex.Message);
                }
            }
        }
        // Método para salvar os dados de um funcionário
        private void SalvarFuncionario(SqlConnection connection)
        {
            // Gerar um GUID válido (uniqueidentifier)
            Guid numeroSerie = Guid.NewGuid();
            MessageBox.Show($"Número de série gerado: {numeroSerie}", "Debug");
            string nomeArquivoFuncionario = Path.GetFileName(caminhoArquivoAnexo); // Extrai o nome do arquivo para funcionário
            // Query para inserir os dados na tabela de login
            string queryLogin = "INSERT INTO TBLogin (usuario_log, senha_log, status_login, NumeroSerie) OUTPUT INSERTED.id_login VALUES (@usuario, @senha, 1, @numeroSerie)";
            SqlCommand commandLogin = new SqlCommand(queryLogin, connection);
            commandLogin.Parameters.AddWithValue("@usuario", textBoxNickName.Text); // Parâmetro para o usuário (nickname)
            commandLogin.Parameters.AddWithValue("@senha", textBoxSenha.Text); // Parâmetro para a senha
            commandLogin.Parameters.AddWithValue("@numeroSerie", numeroSerie); // Parâmetro para o número único



            // Executa o comando e obtém o ID do login recém-criado
            int idLogin = (int)commandLogin.ExecuteScalar();
            MessageBox.Show($"Login salvo com ID: {idLogin}", "Debug"); // Exibe o ID gerado para o login

            // Query para inserir os dados na tabela de funcionário
            string queryFuncionario = "INSERT INTO TBFuncionario (cod_func, fk_login, nome_func, email_func, telefone_func, cargo_func, status_func, obs_func, anexo_func, cpf_func) VALUES (@cod_func, @fk_login, @nome, @email, @telefone, @cargo, 1, @obs, @anexo, @cpf)";
            SqlCommand commandFuncionario = new SqlCommand(queryFuncionario, connection);
            commandFuncionario.Parameters.AddWithValue("@cod_func", textBoxNickName.Text); // Parâmetro para o usuário (nickname)
            commandFuncionario.Parameters.AddWithValue("@fk_login", idLogin); // FK do login recém-criado
            commandFuncionario.Parameters.AddWithValue("@nome", textBoxNomeNomeFantasia.Text); // Nome do funcionário
            commandFuncionario.Parameters.AddWithValue("@email", textBoxEmail.Text); // Email
            commandFuncionario.Parameters.AddWithValue("@telefone", textBoxTelefone.Text); // Telefone
            commandFuncionario.Parameters.AddWithValue("@cargo", textBoxFuncao.Text); // Cargo
            commandFuncionario.Parameters.AddWithValue("@obs", textBoxObservacoes.Text); // Observações
            commandFuncionario.Parameters.AddWithValue("@anexo", caminhoArquivoAnexo); // Caminho do anexo
            commandFuncionario.Parameters.AddWithValue("@cpf", textBoxCpfCnpj.Text); // CPF do funcionário

            AtualizarNumeroDeSerie(numeroSerie);

            // Executa o comando para inserir o funcionário
            commandFuncionario.ExecuteNonQuery();
            MessageBox.Show("Funcionário salvo com sucesso!", "Debug"); // Confirmação de salvamento
        }
        // Método para salvar os dados de um fornecedor
        private void SalvarFornecedor(SqlConnection connection)
        {
            MessageBox.Show("Iniciando salvamento de fornecedor", "Debug"); // Con
            string nomeArquivoFornecedor = Path.GetFileName(caminhoArquivoAnexo); // Extrai o nome do arquivo para fornecedor

            // Query para inserir os dados na tabela de fornecedor
            string queryFornecedor = "INSERT INTO TBFornecedor (cnpj_forn, nome_fant, email_forn, telefone_forn, obs_forn, anexo_forn) VALUES (@cnpj, @fantasia, @email, @telefone, @obs, @anexo)";
            SqlCommand commandFornecedor = new SqlCommand(queryFornecedor, connection);
            commandFornecedor.Parameters.AddWithValue("@cnpj", textBoxCpfCnpj.Text); // CNPJ
            commandFornecedor.Parameters.AddWithValue("@fantasia", textBoxNomeNomeFantasia.Text); // Nome fantasia
            commandFornecedor.Parameters.AddWithValue("@email", textBoxEmail.Text); // Email
            commandFornecedor.Parameters.AddWithValue("@telefone", textBoxTelefone.Text); // Telefone
            commandFornecedor.Parameters.AddWithValue("@obs", textBoxObservacoes.Text); // Observações
            commandFornecedor.Parameters.AddWithValue("@anexo", caminhoArquivoAnexo); // Caminho do anexo

            // Executa o comando para inserir o fornecedor
            commandFornecedor.ExecuteNonQuery();
            MessageBox.Show("Fornecedor salvo com sucesso!", "Debug"); // Confirmação de s
        }
        private DateTime dataEmissao;
        private float valorUnitario;
    }
}
