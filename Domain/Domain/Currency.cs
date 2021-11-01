using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Domain
{
    public class Currency
    {
        /// <summary>
        /// Идентификатор валюты
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Код валюты
        /// </summary>
        public string Code { get; set; }
    }
}
