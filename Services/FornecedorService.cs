using ProjetoERP.Domain;
using ProjetoERP.Repositories;

namespace ProjetoERP.Services
{
    public class FornecedorService
    {
        private readonly FornecedorRepository _repository;

        public FornecedorService()
        {
            _repository = new FornecedorRepository();
        }

        public void Incluir(Fornecedor fornecedor)
        {
            _repository.Incluir(fornecedor);
        }

        public void Atualizar(Fornecedor fornecedor)
        {
            _repository.Atualizar(fornecedor);
        }

        public IEnumerable<object> CarregarFornecedores()
        {
            return _repository.CarregarFornecedores();
        }

        public Fornecedor ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public void DetachedFornecedor(Fornecedor fornecedor)
        {
            _repository.DetachedFornecedor(fornecedor);
        }
    }
}
