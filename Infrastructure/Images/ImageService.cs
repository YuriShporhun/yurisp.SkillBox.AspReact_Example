using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Images
{
    public class ImageService
    {
        private readonly Cloudinary _cloudinary;
        public ImageService(IOptions<CloudinaryApiSettings> configuration)
        {
            var cloudinaryAccount = new Account(configuration.Value.CloudName, configuration.Value.ApiKey, configuration.Value.ApiSecret);
            _cloudinary = new Cloudinary(cloudinaryAccount);
        }

        public async Task<CloudinaryApiResult> AddImage(IFormFile file)
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

                return new CloudinaryApiResult
                {
                    Id = result.PublicId,
                    Url = result.SecureUrl.ToString()
                };
            }

            return null;
        }

        public async Task<CloudinaryApiResult> RemoveImage(string id)
        {

        }
    }
}
