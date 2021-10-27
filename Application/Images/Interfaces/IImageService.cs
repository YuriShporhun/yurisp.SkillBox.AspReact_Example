using Application.Images.Infrastructure;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Application.Images.Interfaces
{
    public interface IImageService
    {
        Task<ImageApiResult> AddImage(IFormFile file);

        Task<string> RemoveImage(string publicId);
    }
}
