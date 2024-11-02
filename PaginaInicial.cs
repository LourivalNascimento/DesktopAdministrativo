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

        //Abre o form "Compras" principal
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
    }
}
