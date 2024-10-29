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
        Panel panelMenus = new Panel();
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

        private void ExibirMenu()
        {
            Controls.Add(panelMenus);
            panelMenus.Show();
            pictureTop.SendToBack();
            pictureTop.Width = int.MaxValue;
            panelMenus.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            panelMenus.Visible = true;
            panelMenus.BackColor = Color.FromArgb(221, 139, 249);
            panelMenus.Location = new Point(0 - 2);
            //panelMenus.Size = new Size(2, 500);
            panelMenus.Width = 284;
            panelMenus.Height = int.MaxValue;
            panelMenus.AutoSize = true;
        }
        private void OcultarMenu()
        {
            Controls.Add(panelMenus);
            panelMenus.Hide();
            panelMenus.Visible = false;
        }
        //MANIPULAÇÃO DO MENU
        private void btnMenu_MouseClick(object sender, MouseEventArgs e)
        {
            clickMouse ++;
            if(clickMouse % 2 != 0)
            {
                ExibirMenu();
                pictureLogoMorangolandia.Location = new Point(309, 3);
                btnMenu.BackColor = Color.FromArgb(221, 139, 249);
                //panelMenu.Visible = true;
                btnMenuCompras.Visible = true;
                btnMenuConsultas.Visible = true;
                btnMenuEstoque.Visible = true;
                btnMenuOrdemDeProducao.Visible = true;
                btnMenuPessoasECredores.Visible = true;
            }else
            {
                OcultarMenu();
                pictureLogoMorangolandia.Location = new Point(118, 3);
                btnMenu.BackColor = Color.FromArgb(162, 66, 195);
                //panelMenu.Visible = false;
                btnMenuCompras.Visible = false;
                btnMenuConsultas.Visible = false;
                btnMenuEstoque.Visible = false;
                btnMenuOrdemDeProducao.Visible= false;
                btnMenuPessoasECredores.Visible= false;
            }
        }
        //----------------------------------------------------------------------------------------------
        //CONFIRMAÇÃO DE BOTÕES DO MENU
        private void btnMenuCompras_MouseMove(object sender, MouseEventArgs e)
        {
            btnMenuCompras.Font = new Font("Franklin Gothic Heavy", (float)15.75, FontStyle.Underline);
        }

        private void btnMenuCompras_MouseLeave(object sender, EventArgs e)
        {
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
        //------------------------------------------------------------------------------------- 
    }
}
