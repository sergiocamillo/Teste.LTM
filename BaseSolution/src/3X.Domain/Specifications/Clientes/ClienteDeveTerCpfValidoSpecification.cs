using DomainValidation.Interfaces.Specification;
using X.Domain.Entities;
using X.Domain.Validations.Documentos;

namespace X.Domain.Specifications.Clientes
{
    public class ClienteDeveTerCpfValidoSpecification : ISpecification<Cliente>
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return CPFValidation.Validar(cliente.CPF);
        }
    }
}