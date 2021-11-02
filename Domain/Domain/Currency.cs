using CSharpFunctionalExtensions;

namespace Entities.Domain
{
    public class Currency : Entity<int>
    {
        /// <summary>
        /// Код валюты
        /// </summary>
        public string Code { get; set; }
    }
}
