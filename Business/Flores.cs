using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Flor : Base
    {
        [OpcoesBase(ChavePrimaria = true, UsaBD = true, UsaBusca = true)]
        public int Id { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string  Nome{ get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Descricao { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Preco { get; set; }

        public new List<Flor> Todos()
        {
            List<Flor> fl = new List<Flor>();
            foreach (var ibase in base.Todos())
            {
                fl.Add((Flor)ibase);
            }
            return fl;
        }
    }
}
