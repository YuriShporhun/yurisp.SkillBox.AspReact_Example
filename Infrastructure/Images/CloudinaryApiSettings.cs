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
        /// <summary>
        /// Имя персонального облака
        /// </summary>
        public string CloudName { get; set; }

        /// <summary>
        /// Ключ для API
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Секретный ключ для API
        /// </summary>
        public string ApiSecret { get; set; }
    }
}
