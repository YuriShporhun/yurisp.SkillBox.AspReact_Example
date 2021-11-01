using Domain.Common;

namespace Domain
{
    /// <summary>
    /// Картинка места прибытия
    /// </summary>
    public class DestinationImage: IEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public string Id { get; init; }

        /// <summary>
        /// Адрес картинки
        /// </summary>
        public string Url { get; init; }
    }
}
