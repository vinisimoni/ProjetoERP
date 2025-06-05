using ProjetoCadastro.Domain;
using ProjetoCadastro.Repositories;
using ProjetoERP.Domain;
using ProjetoERP.Repositories;

namespace ProjetoERP.Services
{
    public class MaterialService
    {
        private readonly MaterialRepository _repository;

        public MaterialService()
        {
            _repository = new MaterialRepository();
        }

        public void Incluir(Material material)
        {
            _repository.Incluir(material);
        }

        public void Atualizar(Material material)
        {
            _repository.Atualizar(material);
        }

        public void Incluir(MovimentacaoEstoque movEst)
        {
            movEst.DataMovimentacao = DateTime.Now;
            movEst.EstoqueAnterior = ObterEstoquePorId(movEst.IdMaterial);

            if (movEst.TipoMovimentacao == "Entrada")
            {
                movEst.EstoqueNovo = movEst.EstoqueAnterior + movEst.Quantidade;
            }
            else
            {
                movEst.EstoqueNovo = movEst.EstoqueAnterior - movEst.Quantidade;
            }

            _repository.IncluirMovEst(movEst);

            AtualizarEstoqueMaterial(movEst.IdMaterial, movEst.TipoMovimentacao, movEst.EstoqueNovo);
        }

        public void AtualizarEstoqueMaterial(int idMaterial, string tipoMov, decimal estoqueNovo)
        {
            Material material = ObterPorId(idMaterial);

            material.EstoqueAtual = estoqueNovo;

            Atualizar(material);
        }

        public Material ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public void DetachedMaterial(Material material)
        {
            _repository.DetachedMaterial(material);
        }

        public IEnumerable<object> CarregarMateriais()
        {
            return _repository.CarregarMateriais();
        }

        public IEnumerable<object> CarregarMovMateriaisManual(int id)
        {
            return _repository.CarregarMovMateriaisManual(id);
        }

        public IEnumerable<object> CarregarMateriaisFiltro(string situacao, string estoque,
            string filtroSelecionado, string filtro, bool somenteControlaEstoque = false)
        {
            return _repository.CarregarMateriaisFiltro(situacao, estoque, filtroSelecionado, filtro, somenteControlaEstoque);
        }

        public string ObterDescricaoPorId(int id)
        {
            return _repository.ObterDescricaoPorId(id);
        }

        public decimal ObterEstoquePorId(int id)
        {
            return _repository.ObterEstoquePorId(id);
        }
    }
}
