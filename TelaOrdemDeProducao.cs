using MetroFramework.Controls;
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
    public partial class TelaOrdemDeProducao : Form
    {
        //Instancia os objetos dos controle
        Panel panelMenus = new Panel();
        Button btnMenuCompras = new Button();
        Button btnMenuConsultas = new Button();
        Button btnMenuEstoque = new Button();
        Button btnMenuOrdemDeProducao = new Button();
        Button btnMenuPessoasECredores = new Button();

        private int vezesBtnMenuClicado = 0;
        public TelaOrdemDeProducao(string nomeFuncionario)
        {
            InitializeComponent();
            pictureTop.Width = int.MaxValue;
            this.nomeFuncionario = nomeFuncionario;
            labelNomeFuncionario.Text = "Olá, " + nomeFuncionario;
            CarregarDados();
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
            TelaEstoque tela = new TelaEstoque(nomeFuncionario);
            tela.Show();
            Close();
        }
        private void btnMenuOrdemDeProducao_Click(object sender, EventArgs e)
        {
            //Abre tela "Ordem de Produção" e fecha a atual
            TelaOrdemDeProducao tela = new TelaOrdemDeProducao(nomeFuncionario);
            tela.Show();
        }
        private void btnMenuPessoasECredores_Click(object sender, EventArgs e)
        {
            //Abre tela "Pessoas e Credores" e fecha a atual
            TelaPessoasECredoresConsulta tela = new TelaPessoasECredoresConsulta(nomeFuncionario);
            tela.Show();
        }
        //----------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------
        //Evento de click do mouse em botão "Esc"
        private void btnEsc_Click(object sender, EventArgs e)
        {
            FecharPrograma();
        }
        private void TelaOrdemDeProducaoEmFila_KeyDown(object sender, KeyEventArgs e)
        {
            //Responsável por fechar tela atual e abrir a anterior
            if (e.KeyData == Keys.Escape)
            {
                FecharPrograma();
            }
        }
        private void TelaOrdemDeProducaoEmFila_MouseClick(object sender, MouseEventArgs e)
        {
            if (vezesBtnMenuClicado % 2 != 0)
            {
                OcultarMenu();
            }
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            AbrirForm<TelaOrdemDeProducaoNovaOrdem>(false);
        }
        // ---------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------
        // -------------------------------------- BANCO DE DADOS --------------------------------------
        // ---------------------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------------------
        private string SqlStringDeConexao = @"Data Source=CYBERLOGRA\SQLSERVER2022;Initial Catalog=DBMorangolandia;Integrated Security=True";
        private string nomeFuncionario;

        // Método para carregar os dados ao selecionar um radio button
        private void CarregarDados()
        {
            // Limpa os resultados anteriores no painel
            LimparResultados();

            // Consulta ao banco de dados com base no filtro de status
            ConsultarBancoDadosEExibirResultados();
        }

        /// <summary>
        /// Limpa o painel de resultados.
        /// </summary>
        private void LimparResultados()
        {
            panelResultado.Controls.Clear();
        }

        private void radioBtnEmProducao_CheckedChanged(object sender, EventArgs e)
        {
            CarregarDados(); // Chama o método para carregar os dados ao selecionar o radio button "Em produção"
        }

        private void radioBtnEmFila_CheckedChanged(object sender, EventArgs e)
        {
            CarregarDados(); // Chama o método para carregar os dados ao selecionar o radio button "Em fila"
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
        private void ConsultarBancoDadosEExibirResultados()
        {
            using (SqlConnection conn = new SqlConnection(SqlStringDeConexao))
            {
                try
                {
                    conn.Open();

                    // Inicia a consulta básica sem filtros
                    string query = @"SELECT [dt_prod], [cod_prod], [nome_prod], [qtd_prod], [status_producao]
                             FROM [DBMorangolandia].[dbo].[TBProducao]";

                    // Adiciona filtros para o status conforme o radio button selecionado
                    if (radioBtnEmFila.Checked)
                    {
                        query += " WHERE [status_producao] = 0"; // "Em fila"
                    }
                    else if (radioBtnEmProducao.Checked)
                    {
                        query += " WHERE [status_producao] IN (1, 2, 3)"; // "Em produção"
                    }

                    // Adiciona filtro de código de produção, se o usuário digitou algo no TextBox
                    if (!string.IsNullOrWhiteSpace(textBoxNumOrdemProducao.Text))
                    {
                        // Verifica se a consulta já tem um filtro WHERE e ajusta a consulta
                        query += query.Contains("WHERE") ? " AND" : " WHERE";
                        query += " [cod_prod] = @codigo"; // Filtro pelo código de produção
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Se o código de produção foi fornecido, adiciona o parâmetro à consulta
                        if (!string.IsNullOrWhiteSpace(textBoxNumOrdemProducao.Text))
                        {
                            cmd.Parameters.AddWithValue("@codigo", textBoxNumOrdemProducao.Text);
                        }

                        SqlDataReader reader = cmd.ExecuteReader();
                        CriarComponentesDinamicos(reader); // Cria os componentes gráficos com os resultados
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao consultar o banco: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Cria os painéis e labels dinamicamente com base nos dados retornados do banco.
        /// </summary>
        private void CriarComponentesDinamicos(SqlDataReader reader)
        {
            int yOffset = 0; // Controle da posição vertical

            // Limpa os resultados anteriores
            LimparResultados();

            while (reader.Read())
            {
                // Criar o painel principal
                Panel panel = new Panel
                {
                    Size = new Size(920, 50),
                    BackColor = Color.LavenderBlush,
                    Location = new Point(200, yOffset),
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Criar labels para as informações
                Label lblOp = new Label
                {
                    Text = $"Nº {reader["cod_prod"]}",
                    Location = new Point(10, 15),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = true
                };

                Label lblNome = new Label
                {
                    Text = $"{reader["nome_prod"]}",
                    Location = new Point(100, 15),
                    Font = new Font("Arial", 10),
                    AutoSize = true
                };

                Label lblQuantidade = new Label
                {
                    Text = $"Quantidade: {reader["qtd_prod"]}",
                    Location = new Point(170, 15),
                    Font = new Font("Arial", 10),
                    AutoSize = true
                };

                Label lblData = new Label
                {
                    // Verifica se a data é válida (não nula) e formata
                    Text = reader["dt_prod"] != DBNull.Value ?
                           $"Data: {Convert.ToDateTime(reader["dt_prod"]).ToString("dd/MM/yyyy")}" :
                           "Data: Não disponível",
                    Location = new Point(300, 15),
                    Font = new Font("Arial", 10),
                    AutoSize = true
                };

                Label lblStatus = new Label
                {
                    Text = $"Status: {reader["status_producao"]}",
                    Location = new Point(470, 15),
                    Font = new Font("Arial", 10),
                    AutoSize = true
                };

                MetroProgressBar metroProgressBarStatus = new MetroProgressBar
                {
                    Value = 33 * Convert.ToInt32(reader["status_producao"]),
                    Style = MetroFramework.MetroColorStyle.Purple,
                    Location = new Point(570, 15),
                    Size = new Size(350, 23)
                };

                // Adicionar os labels ao painel
                panel.Controls.Add(lblOp);
                panel.Controls.Add(lblNome);
                panel.Controls.Add(lblQuantidade);
                panel.Controls.Add(lblData);
                panel.Controls.Add(lblStatus);
                panel.Controls.Add(metroProgressBarStatus);

                // Adicionar o painel ao painel principal
                panelResultado.Controls.Add(panel);

                // Incrementar a posição vertical para o próximo painel
                yOffset += 60;
            }
            // Após adicionar todos os painéis, ajustar a altura do panelResultado
            panelResultado.AutoScroll = true;  // Habilita a rolagem
            panelResultado.VerticalScroll.Value = 0; // Define o valor inicial da rolagem como 0
            panelResultado.AutoScrollMinSize = new Size(0, yOffset); // Ajusta a altura total com base no número de painéis
        }
    }
}
