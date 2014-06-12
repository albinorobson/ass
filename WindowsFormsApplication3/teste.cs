using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Teste
    {
        public int ID { get; set; }

        public string Descricao { get; set; }

        public Teste(int id, string descricao)
        {
            this.ID = id;
            this.Descricao = descricao;
        }
        public Teste()
        {
        }
    }
}
