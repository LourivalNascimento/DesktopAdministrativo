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
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
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

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            //Form openForm1 = FormJaAberto(typeof(TelaPaginaInicial));

            //if (openForm1 != null)
            //{
            //    openForm1.Focus();
            //}
            //else
            //{
            //    TelaPaginaInicial paginaInicial = new TelaPaginaInicial();
            //    paginaInicial.MdiParent = this;
            //    paginaInicial.Show();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
