using X.Domain.DTO;
using X.Domain.Entities;

namespace X.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorCpf(string cpf);
        Cliente ObterPorEmail(string email);
        Paged<Cliente> ObterTodos(string nome, int pageSize, int pageNumber);
    }
}