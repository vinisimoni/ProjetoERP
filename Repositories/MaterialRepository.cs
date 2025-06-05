using Microsoft.EntityFrameworkCore;
using ProjetoCadastro.Data;
using ProjetoERP.Domain;
using ProjetoERP.Domain.Enums;
using System.Net.Http.Headers;

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

        public void IncluirMovEst(MovimentacaoEstoque movEst)
        {
            _context.MovimentacaoEstoque.Add(movEst);
            _context.SaveChanges();
        }

        public void IncluirHistValorVenda(HistoricoValorVenda hisVal)
        {
            _context.HistoricoValorVenda.Add(hisVal);
            _context.SaveChanges();
        }

        public Material ObterPorId(int id)
        {
            return _context.Materiais.FirstOrDefault(c => c.Id == id);
        }

        public string ObterDescricaoPorId(int id)
        {
            return _context.Materiais
                .AsNoTracking()
                .Where(c => c.Id == id)
                .Select(c => c.Descricao)
                .FirstOrDefault();
        }

        public decimal ObterEstoquePorId(int id)
        {
            return _context.Materiais
                .AsNoTracking()
                .Where(c => c.Id == id)
                .Select(c => c.EstoqueAtual)
                .FirstOrDefault();
        }

        public decimal ObterValorVendaPorId(int id)
        {
            return _context.Materiais
                .AsNoTracking()
                .Where(c => c.Id == id)
                .Select(c => c.ValorVenda)
                .FirstOrDefault();
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

        public IEnumerable<object> CarregarMateriaisFiltro(
            string situacao,
            string estoque,
            string filtroSelecionado,
            string filtro,
            bool somenteControlaEstoque = false)
        {
            var query = _context.Materiais.AsNoTracking();

            if (somenteControlaEstoque)
            {
                query = query.Where(c => c.ControlaEstoque == true);
            }

            if (situacao != "Ambos")
            {
                query = query.Where(c => c.Situacao == situacao);
            }

            if (estoque == "Com Estoque")
            {
                query = query.Where(c =>
                    (c.EstoqueAtual > 0 && c.ControlaEstoque) || !c.ControlaEstoque);
            }
            else if (estoque == "Sem Estoque")
            {
                query = query.Where(c => c.EstoqueAtual <= 0 && c.ControlaEstoque);
            }

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                switch (filtroSelecionado)
                {
                    case "Descrição":
                        query = query.Where(c => c.Descricao.Contains(filtro));
                        break;

                    case "Referência":
                        query = query.Where(c => c.Referencia.Contains(filtro));
                        break;
                }
            }

            return query.Select(c => new
            {
                c.Id,
                c.Descricao,
                c.Referencia,
                c.Unidade,
                c.Situacao
            }).ToList<object>();
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

        public IEnumerable<object> CarregarValoresVendaMaterial(int id)
        {
            return _context.HistoricoValorVenda
                .AsNoTracking()
                .Select(c => new
                {
                    c.IdMaterial,
                    c.DataLancamento,
                    c.ValorAnterior,
                    c.ValorNovo
                })
                .Where(c => c.IdMaterial == id)
                .OrderByDescending(m => m.DataLancamento)
                .ToList<object>();
        }
    }
}
