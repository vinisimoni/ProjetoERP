using Microsoft.EntityFrameworkCore;
using ProjetoCadastro.Data;
using ProjetoERP.Domain;
using ProjetoERP.Domain.Enums;

namespace ProjetoERP.Repositories
{
    public class MaterialRepository
    {
        private readonly DataContext _context;

        public MaterialRepository()
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

        public IEnumerable<object> CarregarMateriaisControlaEstoque()
        {
            return _context.Materiais
                .AsNoTracking()
                .Select(c => new
                {
                    c.Id,
                    c.Descricao,
                    c.Referencia,
                    c.Unidade,
                    c.Situacao,
                    c.ControlaEstoque
                })
                .Where(x => x.ControlaEstoque == true && x.Situacao == "Ativo")
                .ToList<object>();
        }

        public IEnumerable<object> CarregarMovMateriaisManual(int id)
        {
            return _context.MovimentacaoEstoque
                .AsNoTracking()
                .Select(c => new
                {
                    c.Id,
                    c.DataMovimentacao,
                    c.TipoMovimentacao,
                    c.Descricao,
                    c.IdMaterial,
                    c.Quantidade,
                    c.OrigemMovimentacao                    
                })
                .Where(c => c.IdMaterial == id && 
                    c.OrigemMovimentacao == EOrigemMovMaterial.Manual)
                .OrderByDescending(m => m.DataMovimentacao)
                .ToList<object>();
        }
    }
}
