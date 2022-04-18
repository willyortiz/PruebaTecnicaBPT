using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PruebaTecnica.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [RoutePrefix("api/orden_inverso")]
    public class OrdenInversoController : ApiController
    {
        [HttpGet]
        [Route("numero/{numeroInicial}")]
        public int numeroInverso(int numeroInicial)
        {
            char[] arreglo = numeroInicial.ToString().ToCharArray();
            Array.Reverse(arreglo);

            string invertido = string.Empty;
            foreach (var item in arreglo)
            {
                invertido = string.Concat(invertido, item);
            }
            return int.Parse(invertido);
        }
    }
}
