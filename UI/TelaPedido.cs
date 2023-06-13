using Business;
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
    public partial class TelaPedido : Form
    {
        public TelaPedido()
        {
            InitializeComponent();
        }

        Pedido pd;

        private void TelaPedido_Load(object sender, EventArgs e)
        {
            new Pedido().CriarTabela();
            Carrega_DataGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pd = new Pedido();
            pd.Id = Convert.ToInt32(txtId.Text);
            foreach (Pedido c in pd.Buscar())
            {
                txtId.Text = c.Id.ToString();
                txtNomeCliente.Text = c.NomeCliente;
                txtNomeFlor.Text = c.NomeFlor;
                txtQtde.Text = c.Qtde;
                txtEnderecoCliente.Text = c.EnderecoCliente;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            pd = new Pedido();
            if (txtId.Text != "")
            {
                pd.Id = int.Parse(txtId.Text);
            }
            pd.NomeCliente = txtNomeCliente.Text;
            pd.NomeFlor = txtNomeFlor.Text;
            pd.Qtde = txtQtde.Text;
            pd.EnderecoCliente = txtEnderecoCliente.Text;
            pd.Salvar();
            Carrega_DataGrid();
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var retorno = MessageBox.Show("Tem certeza que deseja excluir?", "Excluir", MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {
                pd = new Pedido();
                pd.Id = int.Parse(txtId.Text);
                pd.Excluir();
            }
            Carrega_DataGrid();
            Limpar();
        }

        private void Carrega_DataGrid()
        {
            pd = new Pedido();
            dgvDados.AutoGenerateColumns = false;
            dgvDados.DataSource = pd.Todos();
        }

        private void Limpar()
        {
            txtId.Text = null;
            txtNomeCliente.Text = null;
            txtNomeFlor.Text = null;
            txtQtde.Text = null;
            txtEnderecoCliente.Text = null;
        }
    }
}
