using CSharpFunctionalExtensions;

namespace Domain
{
    /// <summary>
    /// Картинка места прибытия
    /// </summary>
    public class DestinationImage: Entity<int>
    {

        /// <summary>
        /// Адрес картинки
        /// </summary>
        public string Url { get; init; }
    }
}
