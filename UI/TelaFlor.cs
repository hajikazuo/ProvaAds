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
    public partial class TelaFlor : Form
    {
        public TelaFlor()
        {
            InitializeComponent();
        }

        Flor fl;

        private void TelaFlor_Load(object sender, EventArgs e)
        {
            new Flor().CriarTabela();
            Carrega_DataGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            fl = new Flor();
            fl.Id = Convert.ToInt32(txtId.Text);
            foreach (Flor c in fl.Buscar())
            {
                txtId.Text = c.Id.ToString();
                txtNome.Text = c.Nome;
                txtDescricao.Text = c.Descricao;
                txtPreco.Text = c.Preco;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            fl = new Flor();
            if (txtId.Text != "")
            {
                fl.Id = int.Parse(txtId.Text);
            }
            fl.Nome = txtNome.Text;
            fl.Descricao = txtDescricao.Text;
            fl.Preco = txtPreco.Text;
            fl.Salvar();
            Carrega_DataGrid();
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var retorno = MessageBox.Show("Tem certeza que deseja excluir?", "Excluir", MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {
                fl = new Flor();
                fl.Id = int.Parse(txtId.Text);
                fl.Excluir();
            }
            Carrega_DataGrid();
            Limpar();
        }

        private void Carrega_DataGrid()
        {
            fl = new Flor();
            dgvDados.AutoGenerateColumns = false;
            dgvDados.DataSource = fl.Todos();
        }

        private void Limpar()
        {
            txtId.Text = null;
            txtNome.Text = null;
            txtDescricao.Text = null;
            txtPreco.Text = null;
        }
    }
}
