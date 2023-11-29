using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221059.Models
{
    public class Categorias
    {
        public int id { get; set; }
        public string Categoria { get; set; }
        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.comando = new MySqlCommand("USE vendas; SELECT * FROM Categorias where categoria like @cat order by categoria", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@cat", Categoria + "%");
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
                Banco.comando = new MySqlCommand("USE VENDAS; INSERT INTO Categorias (categoria) VALUES (@cat)", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@cat", Categoria);
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

                Banco.comando = new MySqlCommand("USE VENDAS; UPDATE Categorias SET categoria = @cat where id = @id", Banco.conexao);

                Banco.comando.Parameters.AddWithValue("@id", id);
                Banco.comando.Parameters.AddWithValue("@cat", Categoria);

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

                Banco.comando = new MySqlCommand("USE VENDAS; delete from Categorias where id = @id;", Banco.conexao);
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
