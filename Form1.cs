using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.TipodeAcesso
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario ;
            usuario = txtUsuario.Text.ToUpper();

            if(usuario != "ADMINISTRADOR")
            {
                MessageBox.Show("Atenção!Usuário sem privilégios administrativos.Algumas tarefas serão bloqueadas", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                MessageBox.Show("Olá,administrador!", "Login",
                    MessageBoxButtons.OK);
            }
        }
    }
}
