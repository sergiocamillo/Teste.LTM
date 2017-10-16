using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web.Mvc;
using X.Infra.CrossCutting.Logging.Model;

namespace X.Infra.CrossCutting.Logging.Helpers
{
    public interface ILogAuditoria : IDisposable
    {
        void RegistrarLog(ActionExecutedContext filterContext);
        IEnumerable<Auditoria> ObterLogs();
        IEnumerable<Auditoria> Buscar(Expression<Func<Auditoria, bool>> predicate);
    }
}