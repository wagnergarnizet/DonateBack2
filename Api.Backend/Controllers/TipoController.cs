using Api.Backend.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoController : ControllerBase
    {
        [HttpGet]
        public Dictionary<String,int> RecuperaTipos()
        {
            Dictionary<string, int> funcao = Enum.GetValues(typeof(Tipo))
                                .Cast<Tipo>()
                                .ToDictionary(k => k.ToString(), v => (int)v);

            return funcao;
        }
    }
}
