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
            

        }
    }
}
