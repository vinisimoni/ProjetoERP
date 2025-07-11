﻿using Microsoft.EntityFrameworkCore;
using ProjetoCadastro.Data;
using ProjetoCadastro.Domain;
using ProjetoCadastro.Domain.Enums;

namespace ProjetoCadastro.Repositories
{
    public class ClienteRepository
    {
        private readonly DataContext _context;

        public ClienteRepository()
        {
            _context = new DataContext();
        }

        public void Incluir(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Atualizar(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        public IEnumerable<object> CarregarClientes()
        {
            return _context.Clientes
                .AsNoTracking()
                .Select(c => new
                {
                    c.Id,
                    c.Dados.CpfCnpj,
                    c.Dados.RazaoSocial,
                    c.Dados.NomeFantasia,
                    c.Situacao
                })
                .ToList<object>();
        }

        public IEnumerable<object> CarregarClientesFiltro(string situacao, string tipoPessoa,
            string filtroSelecionado, string filtro)
        {
            ETipoPessoa? tipoPessoaEnum = null;
            if (tipoPessoa != "Ambos" && Enum.TryParse<ETipoPessoa>(tipoPessoa, true, out var parsedTipo))
                tipoPessoaEnum = parsedTipo;

            var query = _context.Clientes.AsNoTracking()
                .Where(c => (situacao == "Ambos" || c.Situacao == situacao) &&
                            (tipoPessoaEnum == null || c.Dados.TipoPessoa == tipoPessoaEnum));

            // Aplica filtro por texto se houver
            query = AplicarFiltroPorCampo(query, filtroSelecionado, filtro);

            // Aplica projeção específica por campo
            return AplicarProjecaoPorCampo(query, filtroSelecionado)
                .ToList<object>();
        }

        private IQueryable<Cliente> AplicarFiltroPorCampo(IQueryable<Cliente> query, string campo, string filtro)
        {
            if (string.IsNullOrEmpty(filtro)) return query;

            return campo switch
            {
                "Razão Social" => query.Where(c => c.Dados.RazaoSocial.Contains(filtro)),
                "CPF/CNPJ" => query.Where(c => c.Dados.CpfCnpj.Contains(filtro)),
                "Nome Fantasia" => query.Where(c => c.Dados.NomeFantasia.Contains(filtro)),
                "Endereço" => query.Where(c => c.Endereco.Rua.Contains(filtro)),
                "Cidade" => query.Where(c => c.Endereco.Cidade.Contains(filtro)),
                "Endereço Entrega" => query.Where(c => c.EnderecoEntrega.Rua.Contains(filtro)),
                "Cidade Entrega" => query.Where(c => c.EnderecoEntrega.Cidade.Contains(filtro)),
                _ => query
            };
        }

        private IQueryable<object> AplicarProjecaoPorCampo(IQueryable<Cliente> query, string campo)
        {
            return campo switch
            {
                "Endereço" => query.Select(c => new { c.Id, c.Dados.CpfCnpj, c.Dados.RazaoSocial, c.Endereco.Rua, c.Situacao, c.Dados.TipoPessoa }),
                "Cidade" => query.Select(c => new { c.Id, c.Dados.CpfCnpj, c.Dados.RazaoSocial, c.Endereco.Cidade, c.Situacao, c.Dados.TipoPessoa }),
                "Endereço Entrega" => query.Select(c => new { c.Id, c.Dados.CpfCnpj, c.Dados.RazaoSocial, c.EnderecoEntrega.Rua, c.Situacao, c.Dados.TipoPessoa }),
                "Cidade Entrega" => query.Select(c => new { c.Id, c.Dados.CpfCnpj, c.Dados.RazaoSocial, c.EnderecoEntrega.Cidade, c.Situacao, c.Dados.TipoPessoa }),
                _ => query.Select(c => new { c.Id, c.Dados.CpfCnpj, c.Dados.RazaoSocial, c.Dados.NomeFantasia, c.Situacao, c.Dados.TipoPessoa })
            };
        }

        public Cliente ObterPorId(int id)
        {
            return _context.Clientes.FirstOrDefault(c => c.Id == id);
        }

        public void Excluir(int id)
        {
            Cliente cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);

            _context.Remove(cliente);
            _context.SaveChanges();
        }

        public void DetachedCliente(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Detached;
        }
    }
}
