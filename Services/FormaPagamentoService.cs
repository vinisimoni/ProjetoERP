using Microsoft.EntityFrameworkCore;
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

        public void Incluir(FormaPagamentoParcela parcela)
        {
            _repository.IncluirParcela(parcela);
        }

        public void Atualizar(FormaPagamento forma)
        {
            _repository.Atualizar(forma);
        }

        public void Atualizar(FormaPagamentoParcela parcela)
        {
            _repository.AtualizarParcela(parcela);
        }

        public void AtualizarParcelaSemSalvar(FormaPagamentoParcela parcela)
        {
            _repository.AtualizarParcelaSemSalvar(parcela);
        }

        public FormaPagamento ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public FormaPagamentoParcela ObterParcelaPorId(int id)
        {
            return _repository.ObterParcelaPorId(id);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }
        public void ExcluirParcela(int id, int idForma)
        {
            _repository.ExcluirParcela(id);
            ReordenarParcelas(idForma);
        }

        public void Detached(FormaPagamento forma)
        {
            _repository.Detached(forma);
        }

        public void Detached(FormaPagamentoParcela parcela)
        {
            _repository.Detached(parcela);
        }

        public IEnumerable<object> CarregarFormasPagamento()
        {
            return _repository.CarregarFormasPagamento();
        }

        public int ProximoNrParcela(int idForma)
        {
            return _repository.ProximoNrParcela(idForma);
        }

        public IEnumerable<object> CarregarParcelasFormaPgto(int idForma)
        {
            return _repository.CarregarParcelasFormaPgto(idForma);
        }

        public IEnumerable<FormaPagamentoParcela> CarregarParcelasFormaPgtoAlteracao(int idForma)
        {
            return _repository.CarregarParcelasFormaPgtoAlteracao(idForma);
        }

        public void Salvar()
        {
            _repository.Salvar();
        }

        private void ReordenarParcelas(int idForma)
        {
            var parcelas = CarregarParcelasFormaPgtoAlteracao(idForma);

            int numero = 1;

            foreach (var parcela in parcelas)
            {
                parcela.NrParcela = numero++;
                AtualizarParcelaSemSalvar(parcela);
            }

            Salvar();
        }
    }
}
