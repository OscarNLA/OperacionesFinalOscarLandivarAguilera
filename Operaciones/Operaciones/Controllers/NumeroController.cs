using operaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace operaciones.Controllers
{
    [RoutePrefix("api/operaciones")]
    public class NumeroController : ApiController
    {
        [HttpGet]
        [Route("{number:int}")]
        public numeromodelo Operations(int number)
        {
            numeromodelo model = new numeromodelo();
            model.numero = number;

            if (number < 0)
                model.mensaje = "ERROR";

            if (number == 0)
                model.mensaje = "Realizado por Oscar Landivar";

            if (number > 0)
                model.mensaje = "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg";

            return model;
        }
    }
}
