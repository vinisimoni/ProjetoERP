using Microsoft.EntityFrameworkCore;
using ProjetoCadastro.Data;
using ProjetoCadastro.Domain;
using ProjetoERP.Domain;

namespace ProjetoERP.Repositories
{
    public class MaterialRepositorio
    {
        private readonly DataContext _context;

        public MaterialRepositorio()
        {
            _context = new DataContext();
        }

        public void Incluir(Material material)
        {
            _context.Materiais.Add(material);
            _context.SaveChanges();
        }

        public void Atualizar(Material material)
        {
            _context.Materiais.Update(material);
            _context.SaveChanges();
        }

        public Material ObterPorId(int id)
        {
            return _context.Materiais.FirstOrDefault(c => c.Id == id);
        }

        public void Excluir(int id)
        {
            Material material = _context.Materiais.FirstOrDefault(c => c.Id == id);

            _context.Remove(material);
            _context.SaveChanges();
        }

        public void DetachedMaterial(Material material)
        {
            _context.Entry(material).State = EntityState.Detached;
        }

        public IEnumerable<object> CarregarMateriais()
        {
            return _context.Materiais
                .AsNoTracking()
                .Select(c => new
                {
                    c.Id,
                    c.Descricao,
                    c.Referencia,
                    c.Unidade,
                    c.Situacao
                })
                .ToList<object>();
        }
    }
}
