using DomainValidation.Interfaces.Specification;
using X.Domain.Entities;
using X.Domain.Validations.Documentos;

namespace X.Domain.Specifications.Clientes
{
    public class ClienteDeveTerEmailValidoSpecification : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return EmailValidation.Validate(cliente.Email);
        }
    }
}