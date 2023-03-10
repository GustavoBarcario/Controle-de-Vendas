using Controle_de_Vendas.br.com.controlevendas.dao;
using Controle_de_Vendas.br.com.controlevendas.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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
            if (int.TryParse(txtNumero.Text, out int numero))
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

                ClienteDAO dao = new ClienteDAO();
                dao.cadastrarCliente(obj);

                dgvCliente.DataSource = dao.listarClientes();
            }
            else
            {
                MessageBox.Show("Não é possivel colocar número como TEXTO\nCaso queira deixar sem numero digite 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            txtNome.Select();

            ClienteDAO dao = new ClienteDAO();

            dgvCliente.DataSource = dao.listarClientes();


        #region Cores no Botão 

        //    Color highlightBlue = ColorTranslator.FromHtml("#0078D7");


        //    // Adiciona o manipulador de eventos GotFocus a vários botões do formulário
        //    btnSalvar.GotFocus += btn_GotFocus;
        //    btnNovo.GotFocus += btn_GotFocus;
        //    btnEditar.GotFocus += btn_GotFocus;
        //    btnExcluir.GotFocus += btn_GotFocus;

        //    // Adiciona o manipulador de eventos LostFocus a vários botões do formulário
        //    btnSalvar.LostFocus += btn_LostFocus;
        //    btnNovo.LostFocus += btn_LostFocus;
        //    btnEditar.LostFocus += btn_LostFocus;
        //    btnExcluir.LostFocus += btn_LostFocus;
        //}

        //private void btn_GotFocus(object sender, EventArgs e)
        //{
        //    // Altera a cor de fundo do botão quando ele ganha o foco
        //    Button btn = (Button)sender;
        //    btn.BackColor = Color.LightBlue;
        //    btn.ForeColor = Color.Black;
        //}

        //private void btn_LostFocus(object sender, EventArgs e)
        //{
        //    // Restaura a cor de fundo do botão quando ele perde o foco
        //    Button btn = (Button)sender;
        //    btn.BackColor = ColorTranslator.FromHtml("#0078D7");
        //    btn.ForeColor = Color.White;
        #endregion
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
            if (int.TryParse(txtCodigo.Text, out int codigo))
            {
                Cliente obj = new Cliente();
                obj.codigo = int.Parse(txtCodigo.Text);

                ClienteDAO dao = new ClienteDAO();
                dao.exluirCliente(obj);

                dgvCliente.DataSource = dao.listarClientes();
            }
            else
            {
                MessageBox.Show("Nenhum Cadastro Selecionado", "Erro 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Nenhum Cadastro Selecionado", "Erro 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txtNumero.Text, out int numero))
            {
                MessageBox.Show("Numero Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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

        private void btnCEP_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mskCEP.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(mskCEP.Text.Trim());
                        txtBairro.Text = endereco.bairro;
                        txtCidade.Text = endereco.cidade;
                        cbUF.Text = endereco.uf;
                        txtEndereco.Text = endereco.end;

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisar.Text;
            ClienteDAO dao = new ClienteDAO();

            dgvCliente.DataSource = dao.buscarClientePorNome(nome);

            if (dgvCliente.Rows.Count == 0)
            {
                dgvCliente.DataSource = dao.listarClientes();
            }
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisar.Text + "%";

            ClienteDAO dao = new ClienteDAO();

            dgvCliente.DataSource = dao.ListarClientePorNome(nome);

            if (dgvCliente.Rows.Count == 0)
            {
                dgvCliente.DataSource = dao.listarClientes();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);

            txtNome.Select();
        }
    }
}
