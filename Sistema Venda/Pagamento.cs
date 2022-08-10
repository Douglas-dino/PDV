using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venda
{
    class Pagamento
    {
        public Int32 codigo;
        public Int32 cod_venda;
        public Int32 cod_usuario;
        public string tipo_pg;
        public decimal total;
        public decimal troco;
    }
}
