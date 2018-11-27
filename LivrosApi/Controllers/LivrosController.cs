using LivrosApi.Models.DTOs;
using LivrosApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LivrosApi.Controllers
{
    [RoutePrefix("api/Livros")]
    public class LivrosController : ApiController
    {
        [HttpGet]
        [Route("{id}")]
        public string Get(int id)
        {
            return new LivrosServices().ObterPeloId(id);
        }

        [HttpPost]
        public void Post([FromBody]LivroDTO livro)
        {
            new LivrosServices().Inserir(livro);
        }

        [HttpPut]
        public void Put([FromBody]LivroDTO livro)
        {
            new LivrosServices().Atualizar(livro);
        }
    }
}
