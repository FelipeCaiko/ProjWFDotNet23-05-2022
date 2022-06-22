using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ImovelService
    {
        string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\USERS\LOGATTI\DOCUMENTS\dbprojaluga.mdf;";
        SqlConnection conn;
        public ImovelService()
        {
            conn = new SqlConnection(strCon);
            conn.Open();
        }
       
        public int Add(Imovel imovel)
        {
            string strInsert = "insert into Imovel (Descricao, IdLocador, IdEndereco) values (@Descricao, @IdLocador, @IdEndereco); SELECT SCOPE_IDENTITY();";
            SqlCommand commandInsert = new SqlCommand(strInsert, conn);


            int idLocador = new LocadorService().Add(imovel.Locador);
            int idEndereco = new EnderecoService().Add(imovel.Endereco);

            commandInsert.Parameters.Add(new SqlParameter("@Descricao", imovel.Descricao));
            commandInsert.Parameters.Add(new SqlParameter("@IdLocador", idLocador));
            commandInsert.Parameters.Add(new SqlParameter("@IdEndereco", idEndereco));

            int idImovel = Convert.ToInt32(commandInsert.ExecuteScalar());

  
            return idImovel;
        }

        public List<Imovel> findAll()
        {

            StringBuilder sb = new StringBuilder();

            sb.Append(" select i.Id Id, ");
            sb.Append("        i.Descricao Descricao,  ");
            sb.Append("        l.Nome Nome,  ");
            sb.Append("        e.Logradouro Logradouro, ");
            sb.Append("        e.Numero Numero ");
            sb.Append("   from Imovel i,  ");
            sb.Append("        Endereco e,  ");
            sb.Append("        Locador l ");
            sb.Append("  where i.IdEndereco = e.Id ");
            sb.Append("    and i.IdLocador = l.Id ");


            SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
            SqlDataReader dr = commandSelect.ExecuteReader();
            List<Imovel> lst = new List<Imovel>();
            while (dr.Read())
            {

                lst.Add(new Imovel()
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Descricao = dr["Descricao"].ToString(),
                    Locador = new Locador() { Nome = dr["Nome"].ToString() },
                    Endereco = new Endereco() { Logradouro = dr["Logradouro"].ToString() , Numero = Convert.ToInt32(dr["Numero"]) }
                });
            }
            return lst;
        }
    }
}
