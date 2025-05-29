using ProjetoCadastro.Data;
using ProjetoCadastro.Domain;
using System;

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
    }
}
