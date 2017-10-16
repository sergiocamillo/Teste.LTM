using X.Domain.Entities;
using X.Domain.Interfaces.Repository;
using X.Infra.Data.Context;

namespace X.Infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(CrudModalDDDContext context)
            : base(context)
        {
            
        }
    }
}