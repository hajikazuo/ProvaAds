using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaAds
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        Form tela;


        private void btnClientes_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaCliente
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
            };
            pnTela.Controls.Add(tela);
            tela.Show();
        }

        private void btnFlores_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaFlor
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
            };
            pnTela.Controls.Add(tela);
            tela.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {

        }
    }
}
