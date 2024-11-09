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
    public partial class TelaDeLogin : Form
    {
        public TelaDeLogin()
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
        //Método usado para abrir um form qualquer
        private void AbrirForm<ClasseQualquer>() where ClasseQualquer : Form, new()
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
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            AbrirForm<TelaPaginaInicial>();
        }

        private void TelaDeLogin_KeyDown(object sender, KeyEventArgs e)
        {
            //Se a tecla "Esc" for pertada, chama o método "AbrirFormAnterior()"
            //Responsável por fechar tela atual e abrir a anterior
            if (e.KeyData == Keys.Escape)
            {
                Close();
            }
            //Se a tecla "Enter" for pertada, chama o método "AbrirPaginaInicial()"
            if (e.KeyData == Keys.Enter)
            {
                AbrirForm<TelaPaginaInicial>();
            }
        }
    }
}
