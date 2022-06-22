using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LocacaoService
    {
        string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\USERS\LOGATTI\DOCUMENTS\dbprojaluga.mdf;";
        SqlConnection conn;
        public LocacaoService()
        {
            conn = new SqlConnection(strCon);
            conn.Open();
        }
        public void Add(Locacao locacao)
        {
            string strInsert = "insert into Locacao (Descricao, IdCliente, IdImovel) values (@Descricao, @IdCliente, @IdImovel)";
            SqlCommand commandInsert = new SqlCommand(strInsert, conn);


          //  int idCliente = new ClienteService().Add(locacao.Cliente);
          //  int idImovel = new ImovelService().Add(locacao.Imovel);

            commandInsert.Parameters.Add(new SqlParameter("@Descricao", locacao.Descricao));
            commandInsert.Parameters.Add(new SqlParameter("@IdCliente", locacao.Cliente.Id));
            commandInsert.Parameters.Add(new SqlParameter("@IdImovel", locacao.Imovel.Id));

            commandInsert.ExecuteNonQuery();

        }

        public List<Locacao> findAll()
        {

            StringBuilder sb = new StringBuilder();

            sb.Append(" select l.Id Id, ");
            sb.Append("        l.Descricao DescLocacao,  ");
            sb.Append("        c.Nome Nome,  ");
            sb.Append("        i.Descricao DescImovel ");
            sb.Append("   from Locacao l,  ");
            sb.Append("        Cliente c,  ");
            sb.Append("        Imovel i ");
            sb.Append("  where l.IdCliente = c.Id ");
            sb.Append("    and l.IdImovel = i.Id ");


            SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
            SqlDataReader dr = commandSelect.ExecuteReader();
            List<Locacao> lst = new List<Locacao>();

            while (dr.Read())
            {
                lst.Add(new Locacao()
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Descricao = dr["DescLocacao"].ToString(),
                    Cliente = new Cliente() { Nome = dr["Nome"].ToString() },
                    Imovel = new Imovel() { Descricao = dr["DescImovel"].ToString() }
                });
            }
            return lst;
        }
    }
}

