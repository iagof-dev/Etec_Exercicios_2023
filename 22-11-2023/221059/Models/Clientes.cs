using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221059.Models
{
    public class Clientes
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idCidade { get; set; }
        public DateTime dataNasc { get; set; }
        public double renda {  get; set; }
        public string cpf { get; set; }
        public string foto {  get; set; }
        public bool venda { get; set; }
        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.comando = new MySqlCommand("USE vendas; SELECT * FROM clientes where nome like @nome order by nome", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@nome", nome + "%");
                Banco.adaptador = new MySqlDataAdapter(Banco.comando);
                Banco.datTabela = new DataTable();
                Banco.adaptador.Fill(Banco.datTabela);
                Banco.FecharConexao();
                return Banco.datTabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.comando = new MySqlCommand("USE VENDAS; INSERT INTO clientes (nome, idCidade, dataNasc, renda, cpf," +
                    " foto, venda) values (@nome, @idCidade, @dataNasc, @renda, @cpf, @foto, @venda);", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@nome", nome);
                Banco.comando.Parameters.AddWithValue("@idCidade", idCidade);
                Banco.comando.Parameters.AddWithValue("@dataNasc", dataNasc);
                Banco.comando.Parameters.AddWithValue("@renda", renda);
                Banco.comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.comando.Parameters.AddWithValue("@foto", foto);
                Banco.comando.Parameters.AddWithValue("@venda", venda);
                Banco.comando.ExecuteNonQuery();

                Banco.FecharConexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Alterar()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.comando = new MySqlCommand("USE VENDAS; UPDATE Clientes SET nome = @cat where id = @id", Banco.conexao);

                Banco.comando.Parameters.AddWithValue("@id", id);
                Banco.comando.Parameters.AddWithValue("@cat", nome);

                Banco.comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Excluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.comando = new MySqlCommand("USE VENDAS; delete from clientes where id = @id;", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@id", id);
                Banco.comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
