using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Imovel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Locador Locador { get; set; }
        public Endereco Endereco { get; set; }

        public override string ToString()
        {
            return this.Descricao;
        }
    }
}
