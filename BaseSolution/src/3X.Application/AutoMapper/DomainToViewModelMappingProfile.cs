using AutoMapper;
using X.Application.ViewModels;
using X.Domain.DTO;
using X.Domain.Entities;

namespace X.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Cliente, ClienteEnderecoViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Endereco, ClienteEnderecoViewModel>();
            CreateMap<Paged<Cliente>, PagedViewModel<ClienteViewModel>>();
        }
    }
}