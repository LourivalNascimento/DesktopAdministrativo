using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DllConexaoBD;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DesktopAdministrativo
{
    public partial class TelaDeLogin : Form
    {
        private string SqlStringDeConexao = @"Data Source=CYBERLOGRA\SQLSERVER2022;Initial Catalog=DBMorangolandia;Integrated Security=True";
        int clickBotao = 0;
        string usuario = "";
        string senha = "";
        bool loginValido = false;

        public TelaDeLogin()
        {
            InitializeComponent();
            
        }
        private bool FecharPrograma()
        {
             
            string queryStatus = "UPDATE TBLogin SET status_login = 0 WHERE status_login = 1 AND usuario_log = @usuario_log";
            string usuario = textBoxCodUser.Text;
            // Conectando ao banco de dados e executando a consulta
            using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(queryStatus, connection))
                    {
                        // Adiciona parâmetros para prevenir SQL Injection
                        command.Parameters.AddWithValue("@usuario_log", usuario);
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
                        {
                            loginValido = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return loginValido;
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
        private void AbrirForm(string numeroSerie)
        {
            // Cria uma nova instância da classe genérica
            TelaPaginaInicial paginaInicial = new TelaPaginaInicial(numeroSerie);
            Form openForm1 = FormJaAberto(typeof(TelaPaginaInicial));

            if (openForm1 != null)
            {
                openForm1.Focus();
            }
            else
            {
                paginaInicial.Show();
            }
        }
        private bool VerificarLogin(string usuario, string senha)
        {

            // Query SQL para verificar se o usuário e senha estão corretos
            string queryLogin = "SELECT COUNT(1) FROM TBLogin WHERE usuario_log = @usuario_log AND senha_log = @senha_log";
            string queryStatus = "UPDATE TBLogin SET status_login = 1 WHERE status_login = 0 AND usuario_log = @usuario_log";

            // Conectando ao banco de dados e executando a consulta
            using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(queryLogin, connection))
                    {
                        // Adiciona parâmetros para prevenir SQL Injection
                        command.Parameters.AddWithValue("@usuario_log", usuario);
                        command.Parameters.AddWithValue("@senha_log", senha);

                        // Executa a query e verifica se encontrou algum usuário
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
                        {
                            loginValido = true;
                        }
                    }
                    using (SqlCommand command = new SqlCommand(queryStatus, connection))
                    {
                        // Adiciona parâmetros para prevenir SQL Injection
                        command.Parameters.AddWithValue("@usuario_log", usuario);
                        // Executa a query e verifica se encontrou algum usuário
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
                        {
                            loginValido = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return loginValido;
        }
        private string LerCamposBD()
        {
            string numeroSerie;
            // Conectar ao banco de dados e verificar credenciais
            using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
            {
                
                // Consulta SQL para verificar o usuário e recuperar o nome dele
                string query = "SELECT NumeroSerie FROM TBLogin WHERE usuario_log = @usuario_log";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario_log", usuario);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())  // Se encontrou o usuário
                    {
                        numeroSerie = reader["NumeroSerie"].ToString();
                        return numeroSerie;
                    }
                    else
                    {
                        // Caso as credenciais estejam incorretas
                        MessageBox.Show("Usuário ou senha inválidos.");
                    }
                }
                catch (Exception ex)
                {
                    // Trata exceções (ex: conexão com o banco)
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                }
            }
            return numeroSerie = "";
        }
        private void AtualizarNumeroDeSerie(string numeroSerie)
        {
            using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
            {
                string query = "UPDATE TBLogin SET NumeroSerie = @numeroSerie WHERE usuario_log = @usuario_log";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@numeroSerie", numeroSerie);
                command.Parameters.AddWithValue("@usuario_log", usuario);

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
        private void Logar()
        {
            usuario = textBoxCodUser.Text;
            senha = textBoxSenha.Text;
            // Gerar um novo número de série único

            // Validações básicas de preenchimento dos campos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha ambos os campos de usuário e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica as credenciais no banco de dados
            if (VerificarLogin(usuario, senha))
            {
                // Aqui você pode redirecionar para a próxima tela ou abrir o próximo form
                // Exemplo: Abrir um novo formulário
                AbrirForm<TelaPaginaInicial>();
                // Gerar um novo número de série único
                string numeroSerie = Guid.NewGuid().ToString();

                // Atualizar o número de série no banco de dados
                AtualizarNumeroDeSerie(numeroSerie);

                LerCamposBD();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            Logar();
        }
        private void TelaDeLogin_KeyDown(object sender, KeyEventArgs e)
        {
            //Se a tecla "Esc" for pertada, chama o método "AbrirFormAnterior()"
            //Responsável por fechar tela atual e abrir a anterior
            if (e.KeyData == Keys.Escape)
            {
                if (FecharPrograma())
                {
                    Close();
                }
            }
            //Se a tecla "Enter" for pertada, chama o método "AbrirPaginaInicial()"
            if (e.KeyData == Keys.Enter)
            {
                string usuario = textBoxCodUser.Text;
                string senha = textBoxSenha.Text;

                // Validações básicas de preenchimento dos campos
                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
                {
                    MessageBox.Show("Por favor, preencha ambos os campos de usuário e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verifica as credenciais no banco de dados
                if (VerificarLogin(usuario, senha))
                {
                    // Aqui você pode redirecionar para a próxima tela ou abrir o próximo form
                    // Exemplo: Abrir um novo formulário
                    AbrirForm<TelaPaginaInicial>();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Logar();
            }
        }

        private void btnEsqueceuSenha_Click(object sender, EventArgs e)
        {
            AbrirForm<MudarSenha>();
        }

        private void btnVisualizacaoSenha_Click(object sender, EventArgs e)
        {
            clickBotao++;
            if (clickBotao % 2 != 0) 
            {
                btnVisualizacaoSenha.BackgroundImage = Properties.Resources.liberado;
                textBoxSenha.UseSystemPasswordChar = false;
            }else
            {
                btnVisualizacaoSenha.BackgroundImage = Properties.Resources.escondido;
                textBoxSenha.UseSystemPasswordChar = true;
            }
        }

        private void TelaDeLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            FecharPrograma();
        }
    }
}
