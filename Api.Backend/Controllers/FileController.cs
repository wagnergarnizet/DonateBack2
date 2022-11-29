using Api.Backend.Imagem;
using Api.Backend.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using Microsoft.Extensions.Configuration;


namespace Api.Backend.Controllers
{
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileService _fileService;
        public static IWebHostEnvironment _environment;
        private readonly IConfiguration _configuration;

        public FileController(IFileService fileService, IWebHostEnvironment environment, IConfiguration configuration)
        {
            _fileService = fileService;
            _environment = environment;
            _configuration = configuration;
        }

  

        private List<IFormFile> arquivos = new List<IFormFile>();

        [HttpPost]
        [Route("/api/v1/file/upload")]
        public async Task<IActionResult> SaveFiles(List<IFormFile> files)
        {
            try
            {
                if (files.Count > 0)
                {
                    if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), _configuration["Directories:Files"])))
                    {
                        Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), _configuration["Directories:Files"]));
                    }
                    await _fileService.SaveFiles(files);
                    IList<Api.Backend.Imagem.File> imagens = await _fileService.GetFiles();
                    return Ok(imagens[imagens.Count-1]);
                }
                else
                {
                    return StatusCode(204, "Nenhum arquivo enviado!");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("/api/v1/file/get-files")]
        public async Task<IActionResult> GetFiles()
        {
            try
            {
                return Ok(await _fileService.GetFiles());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}