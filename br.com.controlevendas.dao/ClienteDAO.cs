using Controle_de_Vendas.br.com.controlevendas.conexao;
using Controle_de_Vendas.br.com.controlevendas.model;
using System.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Controle_de_Vendas.br.com.controlevendas.dao
{
    public class ClienteDAO
    {
        private SqlConnection conexao;

        public ClienteDAO() 
        {
            this.conexao = new ConnectionFactory().GetSqlConnection();
        }

        #region CadastrarCliente

        public void cadastrarCliente(Cliente obj)
        {
            try
            {
                string sql = @"insert into tb_clientes (nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado) 
                values (@nome,@rg,@cpf,@email,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                SqlCommand executacmd = new SqlCommand(sql,conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");
                conexao.Close();
            }
            catch (System.Exception erro)
            {

                MessageBox.Show("Aconteceu um erro" + erro);
            }

        }
        #endregion

        #region Alterar Cliente
        public void alterarCliente(Cliente obj)
        {
            try
            {
                string sql = @"update tb_clientes set nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,
                celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,
                cidade=@cidade,estado=@estado
                where id = @id";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso!");
                conexao.Close();
            }
            catch (System.Exception erro)
            {

                MessageBox.Show("Aconteceu um erro" + erro);
            }

        }
        #endregion

        #region Excluir Cliente
        public void exluirCliente(Cliente obj)
        {
            try
            {
                string sql = @"delete from tb_clientes where id = @id";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente excluido com sucesso!");
                conexao.Close();
            }
            catch (System.Exception erro)
            {

                MessageBox.Show("Aconteceu um erro" + erro);
            }

        }
        #endregion

        #region Listar Clientes
        public DataTable listarClientes()
        {
            try
            {
                DataTable tabeleCliente = new DataTable();
                string sql = "select * from tb_clientes";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabeleCliente);
                return tabeleCliente;
                

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando no SQL" + erro);
                return null;
            }
        }
        #endregion


    }
}
