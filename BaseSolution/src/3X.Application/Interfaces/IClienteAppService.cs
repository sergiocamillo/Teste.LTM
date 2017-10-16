using System;
using X.Application.ViewModels;

namespace X.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel);
        ClienteViewModel ObterPorId(Guid id);
        ClienteViewModel ObterPorCpf(string cpf);
        ClienteViewModel ObterPorEmail(string email);
        PagedViewModel<ClienteViewModel> ObterTodos(string nome, int pageSize, int pageNumber);
        ClienteViewModel Atualizar(ClienteViewModel clienteViewModel);
        void Remover(Guid id);

        EnderecoViewModel AdicionarEndereco(EnderecoViewModel enderecoViewModel);
        EnderecoViewModel AtualizarEndereco(EnderecoViewModel enderecoViewModel);
        EnderecoViewModel ObterEnderecoPorId(Guid id);
        void RemoverEndereco(Guid id);
    }
}