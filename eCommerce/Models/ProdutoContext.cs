using System.Collections.Generic;
using System.Data.Entity;
using System.Data.OleDb;

namespace eCommerce.Models
{
    public class ProdutoContext 
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<eCommerce.Models.ProdutoContext>());
        public Banco banco { get; set; }
        public ProdutoContext()
        {
            banco = new Banco();
        }

        public List<Produto> ToList()
        {
            OleDbConnection conn = banco.getDataBase();
            List<Produto> resp = new List<Produto>();
            try
            {
                conn.Open();
                System.Data.OleDb.OleDbCommand comando = new System.Data.OleDb.OleDbCommand();
                System.Data.OleDb.OleDbDataReader reader;
                comando.Connection = conn;
                comando.CommandText = "select * from Produtos";
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Produto p = new Produto((int)reader["Código"], (string)reader["Nome"], (string)reader["Descricao"], (decimal)reader["Preco"], (string)reader["imglink"]);
                    resp.Add(p);
                }
                conn.Close();
            }
            catch {
                conn.Close();
            }
            return resp;
        }

        public Produto Find(int id = 0)
        {
            OleDbConnection conn = banco.getDataBase();
            Produto resp = new Produto();
            try
            {
                conn.Open();
                System.Data.OleDb.OleDbCommand comando = new System.Data.OleDb.OleDbCommand();
                System.Data.OleDb.OleDbDataReader reader;
                comando.Connection = conn;
                comando.CommandText = "select * from Produtos where Código=" + id;
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    resp = new Produto((int)reader["Código"], (string)reader["Nome"], (string)reader["Descricao"], (decimal)reader["Preco"], (string)reader["imglink"]);
                    System.Diagnostics.Debug.WriteLine((int)reader["Código"]);
                    System.Diagnostics.Debug.WriteLine((string)reader["Nome"]);
                    System.Diagnostics.Debug.WriteLine((string)reader["Descricao"]);
                    System.Diagnostics.Debug.WriteLine((decimal)reader["Preco"]);
                    System.Diagnostics.Debug.WriteLine((string)reader["imglink"]);
                }
                conn.Close();
            }
            catch
            {
                conn.Close();
            }
            return resp;
        }
        public void Add(Produto p)
        {
            OleDbConnection conn = banco.getDataBase();
            Produto resp = new Produto();
            try
            {
                conn.Open();
                System.Data.OleDb.OleDbCommand comando = new System.Data.OleDb.OleDbCommand();
                comando.Connection = conn;
                comando.CommandText = "insert into Produtos (Nome, Descricao, Preco, imglink) values ('" + p.nome + "', '" + p.detalhes + "', " + p.preco + ", '"+p.imglink +"')";
                comando.ExecuteNonQuery();

                conn.Close();
            }
            catch
            {
                conn.Close();
            }
        }
        public void Remove(Produto p)
        {
            OleDbConnection conn = banco.getDataBase();
            Produto resp = new Produto();
            try
            {
                conn.Open();
                System.Data.OleDb.OleDbCommand comando = new System.Data.OleDb.OleDbCommand();
                comando.Connection = conn;
                comando.CommandText = "delete from Produtos where Código = " + p.id;
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                conn.Close();
            }
        }
        public void Update(Produto p)
        {
            OleDbConnection conn = banco.getDataBase();
            Produto resp = new Produto();
            try
            {
                conn.Open();
                System.Data.OleDb.OleDbCommand comando = new System.Data.OleDb.OleDbCommand();
                comando.Connection = conn;
                comando.CommandText = "update Produtos set Nome='" + p.nome + "', Descricao= '" + p.detalhes + "', Preco = "+ p.preco +", imglink = '" + p.imglink + "' where Código = " + p.id ;
                comando.ExecuteNonQuery();

                conn.Close();
            }
            catch
            {
                conn.Close();
            }
        }
    }
}
