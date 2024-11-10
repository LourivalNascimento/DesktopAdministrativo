using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAdministrativo
{
    public partial class TelaConsultas : Form
    {
        //Instancia os objetos dos controle
        Panel panelMenus = new Panel();
        Button btnMenuCompras = new Button();
        Button btnMenuConsultas = new Button();
        Button btnMenuEstoque = new Button();
        Button btnMenuOrdemDeProducao = new Button();
        Button btnMenuPessoasECredores = new Button();

        private int vezesBtnMenuClicado = 0;
        public TelaConsultas()
        {
            InitializeComponent();
            pictureTop.Width = int.MaxValue;
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
            //AbrirForm<TelaComprasAcompanhamento>();
        }
        private void btnMenuConsultas_Click(object sender, EventArgs e)
        {
            //Oculta o menu lateral e seta o valor 0 a variável "vezesBtnMenuClicado"
            //Fazendo com que a contagem reinicie e o menu possa ser aberto novamente
            OcultarMenu();
            vezesBtnMenuClicado = 0;
            //Abre tela "Consultas" e fecha a atual
            AbrirForm<TelaConsultas>();
        }
        private void btnMenuEstoque_Click(object sender, EventArgs e)
        {
            //Oculta o menu lateral e seta o valor 0 a variável "vezesBtnMenuClicado"
            //Fazendo com que a contagem reinicie e o menu possa ser aberto novamente
            OcultarMenu();
            vezesBtnMenuClicado = 0;
            //Abre tela "Estoque de Insumos" e fecha a atual
            AbrirForm<TelaEstoque>();
        }
        private void btnMenuOrdemDeProducao_Click(object sender, EventArgs e)
        {
            //Oculta o menu lateral e seta o valor 0 a variável "vezesBtnMenuClicado"
            //Fazendo com que a contagem reinicie e o menu possa ser aberto novamente
            OcultarMenu();
            vezesBtnMenuClicado = 0;
            //Abre tela "Ordem de Produção" e fecha a atual
            AbrirForm<TelaOrdemDeProducao>();
        }
        private void btnMenuPessoasECredores_Click(object sender, EventArgs e)
        {
            //Oculta o menu lateral e seta o valor 0 a variável "vezesBtnMenuClicado"
            //Fazendo com que a contagem reinicie e o menu possa ser aberto novamente
            OcultarMenu();
            vezesBtnMenuClicado = 0;
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
        private void TelaConsultas_KeyDown(object sender, KeyEventArgs e)
        {
            //Se a tecla "Esc" for pertada, chama o método "AbrirFormAnterior()"
            //Responsável por fechar tela atual e abrir a anterior
            if (e.KeyData == Keys.Escape)
            {
                FecharPrograma();
            }
        }
        //Ao clicar na tela com o Menu aberto, fecha o menu
        private void TelaConsultas_MouseClick(object sender, MouseEventArgs e)
        {
            if (vezesBtnMenuClicado % 2 != 0)
            {
                OcultarMenu();
            }
        }
    }
}
