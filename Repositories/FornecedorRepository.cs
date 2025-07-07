using Microsoft.EntityFrameworkCore;
using ProjetoCadastro.Data;
using ProjetoERP.Domain;

namespace ProjetoERP.Repositories
{
    public class FornecedorRepository
    {
        private readonly DataContext _context;

        public FornecedorRepository()
        {
            _context = new DataContext();
        }

        public void Incluir(Fornecedor fornecedor)
        {
            _context.Fornecedores.Add(fornecedor);
            _context.SaveChanges();
        }

        public void Atualizar(Fornecedor fornecedor)
        {
            _context.Fornecedores.Update(fornecedor);
            _context.SaveChanges();
        }

        public IEnumerable<object> CarregarFornecedores()
        {
            return _context.Fornecedores
                .AsNoTracking()
                .Select(c => new
                {
                    c.Id,
                    c.Dados.CpfCnpj,
                    c.Dados.RazaoSocial,
                    c.Dados.NomeFantasia,
                    c.Situacao
                })
                .ToList<object>();
        }

        public Fornecedor ObterPorId(int id)
        {
            return _context.Fornecedores.FirstOrDefault(c => c.Id == id);
        }

        public void Excluir(int id)
        {
            Fornecedor fornecedor = _context.Fornecedores.FirstOrDefault(c => c.Id == id);

            _context.Remove(fornecedor);
            _context.SaveChanges();
        }

        public void DetachedFornecedor(Fornecedor fornecedor)
        {
            _context.Entry(fornecedor).State = EntityState.Detached;
        }
    }
}
