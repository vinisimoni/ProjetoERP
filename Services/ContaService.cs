using ProjetoERP.Domain;
using ProjetoERP.Repositories;

namespace ProjetoERP.Services
{
    public class ContaService
    {
        private readonly ContaRepository _repository;

        public ContaService()
        {
            _repository = new ContaRepository();
        }

        public void Incluir(Conta conta)
        {
            _repository.Incluir(conta);
        }

        public void Atualizar(Conta conta)
        {
            _repository.Atualizar(conta);
        }

        public Conta ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public void Detached(Conta conta)
        {
            _repository.Detached(conta);
        }

        public IEnumerable<object> CarregarContas()
        {
            return _repository.CarregarContas();
        }
    }
}
