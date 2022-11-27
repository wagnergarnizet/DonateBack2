using Api.Backend.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VolumeController : ControllerBase
    {
        [HttpGet]
        public Dictionary<String,int> RecuperaVolumes()
        {
            Dictionary<string, int> funcao = Enum.GetValues(typeof(Volume))
                                .Cast<Volume>()
                                .ToDictionary(k => k.ToString(), v => (int)v);

            return funcao;
        }
    }
}
