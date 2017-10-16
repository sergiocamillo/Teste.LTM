﻿using System;
using System.Collections.Generic;
using System.Web.Http;
using X.Application.Interfaces;
using X.Application.ViewModels;

namespace X.Services.REST.ClienteAPI.Controllers
{
    public class ClientesController : ApiController
    {
        private readonly IClienteAppService _clienteAppService;

        public ClientesController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        // GET: api/Clientes
        [HttpGet]
        public IEnumerable<ClienteViewModel> ListarTodos(string nome, int pageSize, int pageNumber)
        {
            return _clienteAppService.ObterTodos(nome, pageSize, pageNumber).List;
        }

        // GET: api/Clientes/5
        public ClienteViewModel Get(Guid id)
        {
            return _clienteAppService.ObterPorId(id);
        }

        // POST: api/Clientes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Clientes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Clientes/5
        public void Delete(int id)
        {
        }
    }
}
