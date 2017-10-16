using X.Application;
using X.Application.Interfaces;
using X.Domain.Interfaces.Repository;
using X.Domain.Interfaces.Service;
using X.Domain.Services;
using X.Infra.CrossCutting.Logging.Data;
using X.Infra.CrossCutting.Logging.Helpers;
using X.Infra.Data.Context;
using X.Infra.Data.Interfaces;
using X.Infra.Data.Repository;
using X.Infra.Data.UoW;
using SimpleInjector;

namespace X.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe
            // Lifestyle.Scoped => Uma instancia unica para o request

            // App
            container.Register<IClienteAppService, ClienteAppService>(Lifestyle.Scoped);

            // Domain
            container.Register<IClienteService, ClienteService>(Lifestyle.Scoped);

            // Infra Dados
            container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Scoped);
            container.Register<IEnderecoRepository, EnderecoRepository>(Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<CrudModalDDDContext>(Lifestyle.Scoped);
            //container.Register(typeof (IRepository<>), typeof (Repository<>));

            // Logging
            container.Register<ILogAuditoria, LogAuditoriaHelper>(Lifestyle.Scoped);
            container.Register<LogginContext>(Lifestyle.Scoped);
        }
    }
}