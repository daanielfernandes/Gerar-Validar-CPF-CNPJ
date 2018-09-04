using DotNetMVC_04.Repositorio;
using DotNetMVC_04.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DotNetMVC_04.Controllers
{
    [RoutePrefix("api/gerar")]
    public class GerarController : ApiController
    {
        [Route("cpf")]
        public HttpResponseMessage GetCpf()
        {
            string cpf = FabricaCpf.GerarCpf();

            return Request.CreateResponse(HttpStatusCode.OK, cpf);
        }

        [Route("cnpj")]
        public HttpResponseMessage GetCnpj()
        {
            string cnpj = FabricaCnpj.gerarCnpj();

            return Request.CreateResponse(HttpStatusCode.OK, cnpj);
        }

    }
}
