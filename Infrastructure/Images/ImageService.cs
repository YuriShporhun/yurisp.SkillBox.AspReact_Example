using Application.Images.Exceptions;
using Application.Images.Infrastructure;
using Application.Images.Interfaces;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Infrastructure.Images
{
    public class ImageService: IImageService
    {
        private readonly Cloudinary _cloudinary;
        public ImageService(IOptions<CloudinaryApiSettings> configuration)
        {
            var cloudinaryAccount = new Account(configuration.Value.CloudName, configuration.Value.ApiKey, configuration.Value.ApiSecret);
            _cloudinary = new Cloudinary(cloudinaryAccount);
        }

        public async Task<ImageApiResult> AddImage(IFormFile file)
        {
            if(file.Length > 0)
            {
                await using var readStream = file.OpenReadStream();

                var parameters = new ImageUploadParams
                {
                    File = new FileDescription(file.Name, readStream),
                    Transformation = new Transformation()
                };

                var result = await _cloudinary.UploadAsync(parameters);

                if(result.Error != null)
                {
                    throw new ImageUploadException(result.Error.Message);
                }

                return new ImageApiResult
                {
                    Id = result.PublicId,
                    Url = result.SecureUrl.ToString()
                };
            }

            throw new ImageUploadException("Image file is empty");
        }

        public async Task<string> RemoveImage(string publicId)
        {
            var parameters = new DeletionParams(publicId);
            var result = await _cloudinary.DestroyAsync(parameters);
            return result.Result == "ok" ? result.Result : throw new ImageUploadException("Image removal error");
        }
    }
}
