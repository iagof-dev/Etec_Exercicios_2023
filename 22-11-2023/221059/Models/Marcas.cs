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
    public class Marcas
    {
        public int id { get; set; }
        public string marca { get; set; }

        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.comando = new MySqlCommand("USE vendas; SELECT * FROM Marcas where marca like @Marca order by marca", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@Marca", marca + "%");
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
                Banco.comando = new MySqlCommand("USE VENDAS; INSERT INTO Marcas (marca) VALUES (@marca)", Banco.conexao);
                Banco.comando.Parameters.AddWithValue("@marca", marca);
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

                Banco.comando = new MySqlCommand("USE VENDAS; UPDATE Marcas SET marca = @marca where id = @id", Banco.conexao);

                Banco.comando.Parameters.AddWithValue("@id", id);
                Banco.comando.Parameters.AddWithValue("@marca", marca);

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

                Banco.comando = new MySqlCommand("USE VENDAS; delete from Marcas where id = @id;", Banco.conexao);
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
