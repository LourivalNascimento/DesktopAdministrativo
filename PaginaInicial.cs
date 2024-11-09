using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAdministrativo
{
    public partial class TelaPaginaInicial : Form
    {
        public TelaPaginaInicial()
        {
            InitializeComponent();
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
            AbrirForm<TelaComprasAcompanhamento>();
        }
        //Abre tela "Consultas"
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            AbrirForm<TelaConsultas>();
        }
        //Abre tela "Estoque"
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            AbrirForm<TelaEstoque>();
        }
        //Abre tela "Ordem de Produção"
        private void btnOrdemDeProducao_Click(object sender, EventArgs e)
        {
            AbrirForm<TelaOrdemDeProducao>();
        }
        //Abre tela "Pessoas e Credores"
        private void btnPessoasECredores_Click(object sender, EventArgs e)
        {
            AbrirForm<TelaPessoasECredoresConsulta>();
        }
    }
}
