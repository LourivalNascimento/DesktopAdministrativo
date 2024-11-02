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
    public partial class TelaComprasAtualizarStatus : Form
    {
        public TelaComprasAtualizarStatus()
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

        //Método usado para abrir o form anterior dando impressão de "voltar", fechando o form atual
        private void AbrirFormAnterior()
        {
            Form openForm1 = FormJaAberto(typeof(TelaPaginaInicial));

            if (openForm1 != null)
            {
                openForm1.Focus();
            }
            else
            {
                TelaPaginaInicial paginaInicial = new TelaPaginaInicial();
                paginaInicial.Show();
            }
            Close();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            //Chama método "AbrirFormAnterior()", responsável por fechar tela atual e abrir a anterior
            AbrirFormAnterior();
        }
    }
}
