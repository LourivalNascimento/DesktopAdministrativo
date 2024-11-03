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

        //Evento que ativa a interação do teclado com a tela
        private void PaginaInicial_KeyDown(object sender, KeyEventArgs e)
        {
            //Se a tecla "Esc" for pertada, fecha a tela atual
            if (e.KeyData == Keys.Escape)
            {
                Close();
            }
        }

        //Evento de click do mouse em botão "Esc" e fecha o form
        private void btnEsc_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Abre o form "Compras" principal e fecha a atual
        private void btnCompras_Click(object sender, EventArgs e)
        {
            Form openForm1 = FormJaAberto(typeof(TelaComprasAcompanhamento));

            if (openForm1 != null)
            {
                openForm1.Focus();
            }
            else
            {
                TelaComprasAcompanhamento telaComprasAcompanhamento = new TelaComprasAcompanhamento();
                telaComprasAcompanhamento.Show();
            }
        }
        //Abre tela "Consultas"
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Form openForm1 = FormJaAberto(typeof(TelaConsultas));

            if (openForm1 != null)
            {
                openForm1.Focus();
            }
            else
            {
                TelaConsultas telaConsultas = new TelaConsultas();
                telaConsultas.Show();
            }
        }
        //Abre tela "Estoque"
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Form openForm1 = FormJaAberto(typeof(TelaEstoque));

            if (openForm1 != null)
            {
                openForm1.Focus();
            }
            else
            {
                TelaEstoque telaEstoqueInsumos = new TelaEstoque();
                telaEstoqueInsumos.Show();
            }
        }
        //Abre tela "Ordem de Produção"
        private void btnOrdemDeProducao_Click(object sender, EventArgs e)
        {
            Form openForm1 = FormJaAberto(typeof(TelaOrdemDeProducao));

            if (openForm1 != null)
            {
                openForm1.Focus();
            }
            else
            {
                TelaOrdemDeProducao telaOrdemDeProducaoEmFila = new TelaOrdemDeProducao();
                telaOrdemDeProducaoEmFila.Show();
            }
        }
        //Abre tela "Pessoas e Credores"
        private void btnPessoasECredores_Click(object sender, EventArgs e)
        {
            Form openForm1 = FormJaAberto(typeof(TelaPessoasECredoresConsulta));

            if (openForm1 != null)
            {
                openForm1.Focus();
            }
            else
            {
                TelaPessoasECredoresConsulta telaPessoasECredoresCadastros = new TelaPessoasECredoresConsulta();
                telaPessoasECredoresCadastros.Show();
            }
        }
    }
}
