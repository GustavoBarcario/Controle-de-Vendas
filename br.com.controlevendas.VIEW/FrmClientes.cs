using Controle_de_Vendas.br.com.controlevendas.dao;
using Controle_de_Vendas.br.com.controlevendas.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.controlevendas.VIEW
{ 
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.nome = txtNome.Text;
            obj.rg = mskRG.Text;
            obj.cpf = mskCPF.Text;
            obj.email = txtEmail.Text;
            obj.telefone = mskTelefone.Text;
            obj.celular = mskCelular.Text;
            obj.cep = mskCEP.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.complemento= txtComplemento.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cbUF.Text;

            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            dgvCliente.DataSource = dao.listarClientes();

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();

            dgvCliente.DataSource = dao.listarClientes();


        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            mskRG.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            mskCPF.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            mskTelefone.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
            mskCelular.Text = dgvCliente.CurrentRow.Cells[6].Value.ToString();
            mskCEP.Text = dgvCliente.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = dgvCliente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = dgvCliente.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = dgvCliente.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = dgvCliente.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = dgvCliente.CurrentRow.Cells[12].Value.ToString();
            cbUF.Text = dgvCliente.CurrentRow.Cells[13].Value.ToString();

            tabClientes.SelectedTab = tabPage1;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.codigo = int.Parse(txtCodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.exluirCliente(obj);
            
            dgvCliente.DataSource = dao.listarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.nome = txtNome.Text;
            obj.rg = mskRG.Text;
            obj.cpf = mskCPF.Text;
            obj.email = txtEmail.Text;
            obj.telefone = mskTelefone.Text;
            obj.celular = mskCelular.Text;
            obj.cep = mskCEP.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.complemento = txtComplemento.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cbUF.Text;

            obj.codigo = int.Parse(txtCodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);

            dgvCliente.DataSource = dao.listarClientes();
        }
    }
}
