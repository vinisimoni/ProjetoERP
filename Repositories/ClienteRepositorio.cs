using Microsoft.EntityFrameworkCore;
using ProjetoCadastro.Data;
using ProjetoCadastro.Domain;

namespace ProjetoCadastro.Repositories
{
    public class ClienteRepositorio
    {
        private readonly DataContext _context;

        public ClienteRepositorio()
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

        public List<object> CarregarClientes()
        {
            return _context.Clientes
                .AsNoTracking()
                .Select(c => new
                {
                    c.Id,
                    c.CpfCnpj,
                    c.RazaoSocial,
                    c.Situacao
                })
                .ToList<object>();
        }

        public Cliente ObterPorId(int id)
        {
            return _context.Clientes
                .FirstOrDefault(c => c.Id == id);
        }

        public void DetachedCliente(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Detached;
        }
    }
}
