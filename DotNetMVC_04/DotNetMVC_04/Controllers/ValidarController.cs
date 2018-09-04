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
    [RoutePrefix("api/validar")]
    public class ValidarController : ApiController
    {

        [Route("cpf/{cpf}")]
        [HttpPost]
        public HttpResponseMessage PostCpf(string cpf)
        {
            bool cpfValido = ValidarCpf.IsCpf(cpf);
            string mensagem = "";

            if (cpfValido == true)
            {
                mensagem = "CPF válido";
            }
            else
            {
                mensagem = "CPF inválido";
            }

            return Request.CreateResponse(HttpStatusCode.OK, mensagem);
        }

        [Route("cnpj/{cnpj}")]
        [HttpPost]
        public HttpResponseMessage PostCnpj(string cnpj)
        {         
            bool cnpjValido = ValidarCnpj.IsCnpj(cnpj);
            string mensagem = "";

            if (cnpjValido == true)
            {
                 mensagem = "CNPJ válido";
            }
            else
            {
                 mensagem = "CNPJ inválido";
            }          
            
            return Request.CreateResponse(HttpStatusCode.OK, mensagem);
        }
    }
}
