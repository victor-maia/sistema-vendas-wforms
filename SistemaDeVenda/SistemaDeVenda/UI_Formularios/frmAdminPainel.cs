using SistemaDeVenda.UI_Formularios;

namespace SistemaDeVenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIdUsuario user = new frmIdUsuario();
            user.Show();
        }
    }
}
