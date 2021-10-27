using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Images
{
    /// <summary>
    /// Настроки для облачного сервиса Cloudinary
    /// </summary>
    public class CloudinaryApiSettings
    {
        public string CloudName { get; set; }
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
    }
}
