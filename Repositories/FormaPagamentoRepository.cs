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

        public void IncluirParcela(FormaPagamentoParcela parcela)
        {
            _context.FormasPagamentoParcelas.Add(parcela);
            _context.SaveChanges();
        }

        public void AtualizarParcela(FormaPagamentoParcela parcela)
        {
            _context.FormasPagamentoParcelas.Update(parcela);
            _context.SaveChanges();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void AtualizarParcelaSemSalvar(FormaPagamentoParcela parcela)
        {
            _context.FormasPagamentoParcelas.Update(parcela);
        }

        public void ExcluirParcela(int id)
        {
            FormaPagamentoParcela parcela = _context.FormasPagamentoParcelas.FirstOrDefault(c => c.Id == id);

            _context.Remove(parcela);
            _context.SaveChanges();
        }

        public FormaPagamento ObterPorId(int id)
        {
            return _context.FormasPagamento.FirstOrDefault(c => c.Id == id);
        }

        public FormaPagamentoParcela ObterParcelaPorId(int id)
        {
            return _context.FormasPagamentoParcelas.FirstOrDefault(c => c.Id == id);
        }

        public void Detached(FormaPagamento forma)
        {
            _context.Entry(forma).State = EntityState.Detached;
        }

        public void Detached(FormaPagamentoParcela parcela)
        {
            _context.Entry(parcela).State = EntityState.Detached;
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

        public IEnumerable<object> CarregarParcelasFormaPgto(int idForma)
        {
            return _context.FormasPagamentoParcelas
                .AsNoTracking()
                .Select(c => new
                {
                    c.Id,
                    c.IdFormaPagamento,
                    c.NrParcela,
                    c.Dias
                })
                .Where(c => c.IdFormaPagamento == idForma)
                .ToList<object>();
        }

        public IEnumerable<FormaPagamentoParcela> CarregarParcelasFormaPgtoAlteracao(int idForma)
        {
            return _context.FormasPagamentoParcelas
                .Where(c => c.IdFormaPagamento == idForma)
                .ToList();
        }

        public int ProximoNrParcela(int idForma)
        {
            return (_context.FormasPagamentoParcelas
                .AsNoTracking()
                .Where(p => p.IdFormaPagamento == idForma)
                .Select(p => (int?)p.NrParcela)
                .Max() ?? 0) + 1;
        }
    }
}
