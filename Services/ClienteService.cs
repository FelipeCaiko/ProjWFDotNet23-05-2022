using Models;
using System.Data.SqlClient;

namespace Services
{
    public class ClienteService
    {
        string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\USERS\LOGATTI\DOCUMENTS\dbprojaluga.mdf;";

        SqlConnection conn;
        public ClienteService()
        {
            conn = new SqlConnection(strCon);
            conn.Open();
        }
        public int Add(Cliente cliente)
        {
            string strInsert = "insert into Cliente (Nome, RG, Telefone) values (@Nome, @RG, @Telefone); SELECT SCOPE_IDENTITY();";
            SqlCommand commandInsert = new SqlCommand(strInsert, conn);

            commandInsert.Parameters.Add(new SqlParameter("@Nome", cliente.Nome));
            commandInsert.Parameters.Add(new SqlParameter("@RG", cliente.RG));
            commandInsert.Parameters.Add(new SqlParameter("@Telefone", cliente.Telefone));

            int idCliente = Convert.ToInt32(commandInsert.ExecuteScalar());
            
            return idCliente;
        }

        public List<Cliente> findAll()
        {
            string strSelect = "select Id, Nome, RG, Telefone from Cliente";
            SqlCommand commandSelect = new SqlCommand(strSelect, conn);
            SqlDataReader dr = commandSelect.ExecuteReader();
            List<Cliente> lst = new List<Cliente>();

            while (dr.Read())
            {
                lst.Add(new Cliente()
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Nome = dr["Nome"].ToString(),
                    RG = dr["RG"].ToString(),
                    Telefone = dr["Telefone"].ToString()
                });
            }
            return lst;
        }
    }
}