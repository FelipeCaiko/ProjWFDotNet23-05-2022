using Models;
using System.Data.SqlClient;

namespace Services
{
    public class EnderecoService
    {
        string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\USERS\LOGATTI\DOCUMENTS\dbprojaluga.mdf;";
        SqlConnection conn;
        public EnderecoService()
        {
            conn = new SqlConnection(strCon);
            conn.Open();
        }
        static List<Endereco> lst = new List<Endereco>();
        public int Add(Endereco endereco)
        {
            string strInsert = "insert into Endereco (CEP, Bairro, Numero, Complemento, Logradouro) values (@CEP, @Bairro, @Numero, @Complemento, @Logradouro); SELECT SCOPE_IDENTITY();";
            SqlCommand commandInsert = new SqlCommand(strInsert, conn);

            commandInsert.Parameters.Add(new SqlParameter("@CEP", endereco.CEP));
            commandInsert.Parameters.Add(new SqlParameter("@Bairro", endereco.Bairro));
            commandInsert.Parameters.Add(new SqlParameter("@Numero", endereco.Numero));
            commandInsert.Parameters.Add(new SqlParameter("@Complemento", endereco.Complemento));
            commandInsert.Parameters.Add(new SqlParameter("@Logradouro", endereco.Logradouro));

            int idEndereco = Convert.ToInt32(commandInsert.ExecuteScalar());

            lst.Add(endereco);
            return idEndereco;
        }

        public List<Endereco> findAll()
        {
            string strSelect = "select Id, CEP, Bairro, Numero, Complemento, Logradouro from Endereco";
            SqlCommand commandSelect = new SqlCommand(strSelect, conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                lst.Add(new Endereco()
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    CEP = dr["CEP"].ToString(),
                    Bairro = dr["Bairro"].ToString(),
                    Numero = Convert.ToInt32(dr["Numero"]),
                    Complemento = dr["Complemento"].ToString(),
                    Logradouro = dr["Logradouro"].ToString()

                });
            }
            return lst;
        }
    }
}