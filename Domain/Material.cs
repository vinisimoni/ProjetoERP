using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoERP.Domain
{
    public class Material
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Referencia { get; set; }
        public string Unidade { get; set; }
        public string Situacao { get; set; }
        public bool ControleEstoque { get; set; }
        public decimal EstoqueAtual { get; set; }
        public decimal ValorVenda { get; set; }
    }
}
