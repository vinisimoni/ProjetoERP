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

        public IEnumerable<object> CarregarMateriaisControlaEstoque()
        {
            return _repository.CarregarMateriaisControlaEstoque();
        }
    }
}
