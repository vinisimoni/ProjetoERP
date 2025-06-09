using Microsoft.EntityFrameworkCore;
using ProjetoCadastro.Data;
using ProjetoERP.Domain;

namespace ProjetoERP.Repositories
{
    public class FormaPagamentoRepository
    {
        private readonly DataContext _context;

        public FormaPagamentoRepository()
        {
            _context = new DataContext();
        }

        public void Incluir(FormaPagamento forma)
        {
            _context.FormasPagamento.Add(forma);
            _context.SaveChanges();
        }

        public void Atualizar(FormaPagamento forma)
        {
            _context.FormasPagamento.Update(forma);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            FormaPagamento forma = _context.FormasPagamento.FirstOrDefault(c => c.Id == id);

            _context.Remove(forma);
            _context.SaveChanges();
        }

        public FormaPagamento ObterPorId(int id)
        {
            return _context.FormasPagamento.FirstOrDefault(c => c.Id == id);
        }

        public void Detached(FormaPagamento forma)
        {
            _context.Entry(forma).State = EntityState.Detached;
        }

        public IEnumerable<object> CarregarFormasPagamento()
        {
            return _context.FormasPagamento
                .AsNoTracking()
                .Select(c => new
                {
                    c.Id,
                    c.Descricao
                })
                .ToList<object>();
        }
    }
}
