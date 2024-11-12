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
    public partial class TelaOrdemDeProducaoNovaOrdem : Form
    {
        private string nomeFuncionario;
        public TelaOrdemDeProducaoNovaOrdem()
        {
            InitializeComponent();
        }

        private void btnCancelar_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void TelaOrdemDeProducaoNovaOrdem_Deactivate(object sender, EventArgs e)
        {
            TelaEstoque telaEstoque = new TelaEstoque(nomeFuncionario);
            telaEstoque.Activate();
            this.Close();
        }
    }
}
