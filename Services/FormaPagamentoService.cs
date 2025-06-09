using ProjetoERP.Domain;
using ProjetoERP.Repositories;

namespace ProjetoERP.Services
{
    public class FormaPagamentoService
    {
        private readonly FormaPagamentoRepository _repository;

        public FormaPagamentoService()
        {
            _repository = new FormaPagamentoRepository();
        }

        public void Incluir(FormaPagamento forma)
        {
            _repository.Incluir(forma);
        }

        public void Atualizar(FormaPagamento forma)
        {
            _repository.Atualizar(forma);
        }

        public FormaPagamento ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public void Detached(FormaPagamento forma)
        {
            _repository.Detached(forma);
        }

        public IEnumerable<object> CarregarFormasPagamento()
        {
            return _repository.CarregarFormasPagamento();
        }
    }
}
