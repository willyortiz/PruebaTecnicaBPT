using System.Collections.Generic;
using System.Web.Http;

namespace PruebaTecnica.Controllers
{
    [RoutePrefix("api/hora_ingreso")]
    public class HorarioLlegadaController : ApiController
    {
        [HttpGet]
        [Route("orden/{ordenLlegada}")]
        public string Horario(string ordenLlegada)
        {
            List<string> nombres = new List<string>  {
                "andrea",
                "juan",
                "catalina",
                "carlos",
                "jorge"
            };

            List<string> Resultnombres = new List<string>();

            foreach (var item in nombres)
            {
                switch (item)
                {
                    case "catalina":
                        Resultnombres.InsertRange(0, new string[]
                        {
                            "jorge",
                            "catalina",
                            "juan"
                        });
                        break;
                    case "andrea":

                        if (Resultnombres.Exists(e => e.EndsWith("carlos")))
                        {
                            Resultnombres.Remove("carlos");
                            Resultnombres.Insert(Resultnombres.Count, "andrea");
                            Resultnombres.Insert(Resultnombres.Count, "carlos");
                        }
                        else
                        {
                            Resultnombres.Insert(Resultnombres.Count, "andrea");
                        }
                        break;
                    case "carlos":
                        Resultnombres.Insert(Resultnombres.Count, "carlos");
                        break;
                    default:
                        break;
                }
            }

            if (ordenLlegada == "primero")
            {
                return Resultnombres[0];
            }
            else
            {
                return Resultnombres[Resultnombres.Count - 1];
            }
        }
    }
}
