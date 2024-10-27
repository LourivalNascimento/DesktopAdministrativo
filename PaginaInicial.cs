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
    public partial class TelaPaginaInicial : Form
    {
        public TelaPaginaInicial()
        {
            InitializeComponent();
        }

        private void PaginaInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                Close();
            }
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
