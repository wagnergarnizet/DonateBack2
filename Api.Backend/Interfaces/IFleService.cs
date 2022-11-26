using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Backend.Imagem;

namespace Api.Backend.Interfaces
{
    public interface IFileService
    {
        Task SaveFiles(List<IFormFile> files);
        Task<IList<File>> GetFiles();
    }
}