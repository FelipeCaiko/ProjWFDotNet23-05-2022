using Models;
using System.Data.SqlClient;

namespace Services
{
    public class LocadorService
    {
        string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\USERS\LOGATTI\DOCUMENTS\DBPROJALUGA.MDF;";
        SqlConnection conn;
        public LocadorService()
        {
            conn = new SqlConnection(strCon);
            conn.Open();
        }
        static List<Locador> lst = new List<Locador>();
        public int Add(Locador locador)
        {
            string strInsert = "insert into Locador (Nome, RG, Telefone) values (@Nome, @RG, @Telefone); SELECT SCOPE_IDENTITY();";
            SqlCommand commandInsert = new SqlCommand(strInsert, conn);

            commandInsert.Parameters.Add(new SqlParameter("@Nome", locador.Nome));
            commandInsert.Parameters.Add(new SqlParameter("@RG", locador.RG));
            commandInsert.Parameters.Add(new SqlParameter("@Telefone", locador.Telefone));

            var idLocacao = Convert.ToInt32(commandInsert.ExecuteScalar());

            lst.Add(locador);
            return idLocacao;
        }

        public List<Locador> findAll()
        {
            string strSelect = "select Id, Nome, RG, Telefone from Locador";
            SqlCommand commandSelect = new SqlCommand(strSelect, conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                lst.Add(new Locador()
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