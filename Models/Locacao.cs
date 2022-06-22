using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Locacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Cliente Cliente { get; set; }
        public Imovel Imovel { get; set; }
        public override string ToString()
        {
            return this.Cliente.Nome + '-' + this.Imovel.Descricao;
        }
    }
}
