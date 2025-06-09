using Microsoft.EntityFrameworkCore;
using ProjetoCadastro.Data;
using ProjetoERP.Domain;

namespace ProjetoERP.Repositories
{
    public class ContaRepository
    {
        private readonly DataContext _context;

        public ContaRepository()
        {
            _context = new DataContext();
        }

        public void Incluir(Conta conta)
        {
            _context.Contas.Add(conta);
            _context.SaveChanges();
        }

        public void Atualizar(Conta conta)
        {
            _context.Contas.Update(conta);
            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            Conta conta = _context.Contas.FirstOrDefault(c => c.Id == id);

            _context.Remove(conta);
            _context.SaveChanges();
        }

        public Conta ObterPorId(int id)
        {
            return _context.Contas.FirstOrDefault(c => c.Id == id);
        }

        public string ObterDescricaoPorId(int id)
        {
            return _context.Contas
                .AsNoTracking()
                .Where(c => c.Id == id)
                .Select(c => c.Descricao)
                .FirstOrDefault();
        }

        public void Detached(Conta conta)
        {
            _context.Entry(conta).State = EntityState.Detached;
        }

        public IEnumerable<object> CarregarContas()
        {
            return _context.Contas
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
