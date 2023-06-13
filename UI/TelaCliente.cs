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
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        Cliente cli;

        private void TelaCliente_Load(object sender, EventArgs e)
        {
            new Cliente().CriarTabela();
            Carrega_DataGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            cli = new Cliente();
            cli.Id = Convert.ToInt32(txtId.Text);
            foreach(Cliente c in cli.Buscar())
            {
                txtId.Text = c.Id.ToString();
                txtNome.Text = c.Nome;
                txtCelular.Text = c.Celular;
                txtCpf.Text = c.Cpf;
                txtEndereco.Text = c.Endereco;  
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cli = new Cliente();
            if (txtId.Text != "")
            {
                cli.Id = int.Parse(txtId.Text);
            }
            cli.Nome = txtNome.Text;
            cli.Celular = txtCelular.Text;
            cli.Cpf = txtCpf.Text;
            cli.Endereco = txtEndereco.Text;
            cli.Salvar();
            Carrega_DataGrid();
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var retorno = MessageBox.Show("Tem certeza que deseja excluir?", "Excluir",  MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {
                cli = new Cliente();
                cli.Id = int.Parse(txtId.Text);
                cli.Excluir();
            }
            Carrega_DataGrid();
            Limpar();
        }

        private void Carrega_DataGrid()
        {
            cli = new Cliente();
            dgvDados.AutoGenerateColumns=false;
            dgvDados.DataSource = cli.Todos();
        }

        private void Limpar()
        {
            txtId.Text = null;
            txtNome.Text = null;
            txtCelular.Text = null;
            txtCpf.Text = null;
            txtEndereco.Text = null;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
