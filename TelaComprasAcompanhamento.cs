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
    public partial class TelaComprasAcompanhamento : Form
    {
        private int clickMouse = 0;
        public TelaComprasAcompanhamento()
        {
            InitializeComponent();
        }
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
            AbrirFormAnterior();
        }

        private void TelaComprasAcompanhamento_KeyDown(object sender, KeyEventArgs e)
        {
            AbrirFormAnterior();
        }

        private void btnMenu_MouseClick(object sender, MouseEventArgs e)
        {
            clickMouse ++;
            if(clickMouse % 2 != 0)
            {
                pictureLogoMorangolandia.Location = new Point(309, 3);
                btnMenu.BackColor = Color.FromArgb(221, 139, 249);
                panelMenu.Visible = true;
                btnMenuCompras.Visible = true;
                btnMenuConsultas.Visible = true;
                btnMenuEstoque.Visible = true;
                btnMenuOrdemDeProducao.Visible = true;
                btnMenuPessoasECredores.Visible = true;
            }else
            {
                pictureLogoMorangolandia.Location = new Point(118, 3);
                btnMenu.BackColor = Color.FromArgb(162, 66, 195);
                panelMenu.Visible = false;
                btnMenuCompras.Visible = false;
                btnMenuConsultas.Visible = false;
                btnMenuEstoque.Visible = false;
                btnMenuOrdemDeProducao.Visible= false;
                btnMenuPessoasECredores.Visible= false;
            }
        }
    }
}
