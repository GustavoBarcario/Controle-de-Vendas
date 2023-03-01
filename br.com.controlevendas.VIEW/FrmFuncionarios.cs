using Controle_de_Vendas.br.com.controlevendas.dao;
using Controle_de_Vendas.br.com.controlevendas.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.controlevendas.view
{
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.nome = txtNome.Text;
            obj.rg = mskRG.Text;
            obj.cpf = mskCPF.Text;
            obj.email = txtEmail.Text;
            obj.senha = txtSenha.Text;
            obj.cargo = cbCargo.Text;
            obj.nivel_acesso = cbNivel.Text;
            obj.telefone = mskTelefone.Text;
            obj.celular = mskCelular.Text;
            obj.cep = mskCEP.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.complemento = txtComplemento.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cbUF.Text;

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.CadastrarFuncionarios(obj);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            txtNome.Select();
            FuncionarioDAO dao = new FuncionarioDAO();
            dgvFuncionario.DataSource = dao.listarFuncionarios();
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

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvFuncionario.CurrentRow.Cells[1].Value.ToString();
            mskRG.Text = dgvFuncionario.CurrentRow.Cells[2].Value.ToString();
            mskCPF.Text = dgvFuncionario.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvFuncionario.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = dgvFuncionario.CurrentRow.Cells[5].Value.ToString();
            cbCargo.Text = dgvFuncionario.CurrentRow.Cells[6].Value.ToString();
            cbNivel.Text = dgvFuncionario.CurrentRow.Cells[7].Value.ToString();
            mskTelefone.Text = dgvFuncionario.CurrentRow.Cells[8].Value.ToString();
            mskCelular.Text = dgvFuncionario.CurrentRow.Cells[9].Value.ToString();
            mskCEP.Text = dgvFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = dgvFuncionario.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = dgvFuncionario.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text = dgvFuncionario.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = dgvFuncionario.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = dgvFuncionario.CurrentRow.Cells[15].Value.ToString();
            cbUF.Text = dgvFuncionario.CurrentRow.Cells[16].Value.ToString();

            tabFuncionario.SelectedTab = tabPage1;
        }
    }
}
