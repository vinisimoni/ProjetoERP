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
            _repository.IncluirMovEst(movEst);
            AtualizarEstoqueMaterial(movEst.IdMaterial, movEst.TipoMovimentacao, movEst.Quantidade);
        }

        public void AtualizarEstoqueMaterial(int idMaterial, string tipoMov, decimal quantidade)
        {
            Material material = ObterPorId(idMaterial);

            if(tipoMov == "Entrada")
            {
                material.EstoqueAtual += quantidade;
            }
            else
            {
                material.EstoqueAtual -= quantidade;
            }

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
    }
}
