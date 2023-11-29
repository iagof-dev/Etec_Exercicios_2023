using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySqlConnector;

namespace _221059.Models
{
    public class Banco
    {
        public static MySqlConnection conexao;
        public static MySqlCommand comando;
        public static MySqlDataAdapter adaptador;
        public static DataTable datTabela;

        public static void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");
                conexao.Open();
                Console.WriteLine("Banco de Dados Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public static void FecharConexao()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public static void CriarBanco()
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas;", conexao);
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("USE vendas;CREATE TABLE IF NOT EXISTS Cidades (id int auto_increment primary key, nome char(40), uf char(2));", conexao);
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("USE vendas;CREATE TABLE IF NOT EXISTS Marcas (id int auto_increment primary key, marca char(20));", conexao);
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("USE vendas;CREATE TABLE IF NOT EXISTS Categorias (id int auto_increment primary key, categoria char(20));", conexao);
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("USE vendas;CREATE TABLE IF NOT EXISTS Clientes(ID integer auto_increment primary key,nome char(40),idCidade integer,dataNasc date,renda decimal(10,2),cpf char(14),foto varchar(100),venda boolean);", conexao);
                comando.ExecuteNonQuery();

                FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
