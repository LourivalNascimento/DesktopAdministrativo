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
    public partial class TelaComprasAcompanhamento : Form
    {
       

       //Instancia os objetos dos controle
        Panel panelMenus = new Panel();
        Button btnMenuCompras = new Button();
        Button btnMenuConsultas = new Button();
        Button btnMenuEstoque = new Button();
        Button btnMenuOrdemDeProducao = new Button();
        Button btnMenuPessoasECredores = new Button();

        private float vezesBtnMenuClicado = 0;

        public TelaComprasAcompanhamento(string nomeFuncionario)
        {
            InitializeComponent();
            pictureTop.Width = int.MaxValue;
            this.nomeFuncionario = nomeFuncionario;
            labelNomeFuncionario.Text = "Olá, " + nomeFuncionario;
            GerarLabelsClientes();

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
        private void btnMenu_MouseClick(object sender, MouseEventArgs e)
        {
            //Se a quantidade de click for par, abre o menu
            //Se a quantidade de click for impar, fecha o menu
            if(vezesBtnMenuClicado % 2 == 0)
            {
                ExibirMenu();
            }else
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
            TelaComprasAcompanhamento telaCompra = new TelaComprasAcompanhamento(nomeFuncionario);
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
        private void TelaComprasAcompanhamento_KeyDown(object sender, KeyEventArgs e)
        {
            //Responsável por fechar tela atual e abrir a anterior
            if (e.KeyData == Keys.Escape)
            {
                FecharPrograma();
            }
        }
        //Ao clicar na tela com o Menu aberto, fecha o menu
        private void TelaComprasAcompanhamento_MouseClick(object sender, MouseEventArgs e)
        {
            if (vezesBtnMenuClicado % 2 != 0)
            {
                OcultarMenu();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Abre tela "ComprasAtualizarStatus" e fecha a atual
            TelaComprasAtualizarStatus telaCompra = new TelaComprasAtualizarStatus(nomeFuncionario);
            telaCompra.Show();
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Abre tela "ComprasNovaCompra" e fecha a atual
            TelaComprasNovaCompra telaCompra = new TelaComprasNovaCompra(nomeFuncionario);
            telaCompra.Show();
            Close();
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

        private void lerBD(string query, SqlConnection connection, List<string>valoresImportados, string coluna)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Ler os dados linha a linha e adicionar à lista
                    while (reader.Read())
                    {
                        valoresImportados.Add(reader[coluna].ToString());
                    }
                }
            }
        }
        private void GerarLabelsDeConsulta(List<string> valores, string nomeValores, int posicaoX, Panel panelLabels)
        {
            // Armazena o nome da variável e o valor
            int posicaoY = 42;  // Posição inicial Y dos labels
            int espacoEntreLabels = 45;  // Espaçamento vertical entre os labels

            foreach (string nome in valores)
            {
                // Criar um novo Label
                Label labelExubirNf = new Label();
                if (nomeValores == "valoresCompras")
                {
                    labelExubirNf.Text = "R$ " + nome;
                }else if(nomeValores == "datasDeEmissao")
                {

                    DateTime data = DateTime.Parse(nome);
                    DateTime dataSomente = data.Date;
                    labelExubirNf.Text = data.ToString("dd/MM/yyyy"); ;
                }
                else
                {
                    labelExubirNf.Text = nome;
                }
                labelExubirNf.AutoSize = true;
                labelExubirNf.Font = new Font("Franklin Gothic Heavy", (float)12);
                labelExubirNf.ForeColor = Color.Black;
                labelExubirNf.BackColor = Color.FromArgb(247, 223, 255);
                labelExubirNf.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                labelExubirNf.Location = new System.Drawing.Point(posicaoX, posicaoY);
                panelLabels.Controls.Add(labelExubirNf);
                // Atualizar a posição Y para o próximo Label
                posicaoY += espacoEntreLabels;
            }
        }
        private void GerarLabelsClientes()
        {

            // A consulta SQL para obter os dados
            string queryCodigoCompra = "SELECT cod_compra FROM TBCompras";
            string queryNumNf = "SELECT nf FROM TBCompras"; 
            string queryEmissaoCompra = "SELECT dt_emissao FROM TBCompras";
            string queryNomeFornecedor = "SELECT nome_fant FROM TBFornecedor";
            string queryValorCompra = "SELECT valor_unit FROM TBCompras";
            string queryStatusCompra = "SELECT status_compras FROM TBCompras";

            // Lista para armazenar os nomes dos clientes
            List<string> codigosCompras = new List<string>();
            List<string> numerosNotasFiscais = new List<string>();
            List<string> datasDeEmissao = new List<string>();
            List<string> nomesFornecedor = new List<string>();
            List<string> valoresCompras = new List<string>();
            List<string> statusCompras = new List<string>();

            try
            {
                // Estabelecer conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
                {
                    connection.Open();
                    string coluna = "cod_compra";

                    // Executar a consulta SQL
                    lerBD(queryCodigoCompra, connection, codigosCompras, coluna);
                }
                using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
                {
                    connection.Open();
                    string coluna = "nf";
                    // Executar a consulta SQL
                    lerBD(queryNumNf, connection, numerosNotasFiscais, coluna);
                }
                using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
                {
                    connection.Open();
                    string coluna = "dt_emissao";
                    // Executar a consulta SQL
                    lerBD(queryEmissaoCompra, connection, datasDeEmissao, coluna);
                }
                using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
                {
                    connection.Open();
                    string coluna = "nome_fant";
                    // Executar a consulta SQL
                    lerBD(queryNomeFornecedor, connection, nomesFornecedor, coluna);
                }
                using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
                {
                    connection.Open();
                    string coluna = "valor_unit";
                    // Executar a consulta SQL
                    lerBD(queryValorCompra, connection, valoresCompras, coluna);
                }
                using (SqlConnection connection = new SqlConnection(SqlStringDeConexao))
                {
                    connection.Open();
                    string coluna = "status_compras";
                    // Executar a consulta SQL
                    lerBD(queryStatusCompra, connection, statusCompras, coluna);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                return;
            }

            // Variáveis para controle de layout dos Labels

            Panel panelLabels = new Panel();
            panelLabels.Location = new System.Drawing.Point(40, 140);  // Posição inicial do Panel
            panelLabels.Size = new System.Drawing.Size(1193, 70);  // Tamanho do Panel (ajustar conforme necessário)
            panelLabels.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
            panelLabels.BackColor = Color.FromArgb(252, 251, 231);
            panelLabels.AutoSize = true;
            panelLabels.BringToFront();
            panelLabels.Controls.Add(labelCodigo);
            labelCodigo.Location = new Point(22, 20);
            panelLabels.Controls.Add(labelNumNota);
            labelNumNota.Location = new System.Drawing.Point(126, 20);
            panelLabels.Controls.Add(labelEmissao);
            labelEmissao.Location = new System.Drawing.Point(226, 20);
            panelLabels.Controls.Add(labelFornecedor);
            labelFornecedor.Location = new System.Drawing.Point(338, 20);
            panelLabels.Controls.Add(labelValor);
            labelValor.Location = new System.Drawing.Point(939, 20);
            panelLabels.Controls.Add(labelStatus);
            labelStatus.Location = new System.Drawing.Point(1060, 20);

            this.Controls.Add(panelLabels);

            GerarLabelsDeConsulta(codigosCompras, "codigosCompras", 22, panelLabels);
            GerarLabelsDeConsulta(numerosNotasFiscais, "numerosNotasFiscais", 126, panelLabels);
            GerarLabelsDeConsulta(datasDeEmissao, "datasDeEmissao", 226, panelLabels);
            GerarLabelsDeConsulta(nomesFornecedor, "nomesFornecedor", 338, panelLabels);
            GerarLabelsDeConsulta(valoresCompras, "valoresCompras", 939, panelLabels);
            GerarLabelsDeConsulta(statusCompras, "statusCompras", 1060, panelLabels);

        }
        private void TelaComprasAcompanhamento_Load(object sender, EventArgs e)
        {
            
        }
    }
}
