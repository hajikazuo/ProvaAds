using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Pedido : Base
    {
        [OpcoesBase(ChavePrimaria = true, UsaBD = true, UsaBusca = true)]
        public int Id { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string NomeCliente { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string NomeFlor { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string Qtde { get; set; }

        [OpcoesBase(UsaBD = true)]
        public string EnderecoCliente { get; set; }

        public new List<Pedido> Todos()
        {
            List<Pedido> pd = new List<Pedido>();
            foreach (var ibase in base.Todos())
            {
                pd.Add((Pedido)ibase);
            }
            return pd;
        }
    }
}
