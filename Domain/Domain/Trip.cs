using CSharpFunctionalExtensions;
using Domain;
using System;
using System.Collections.Generic;

namespace Entities.Domain
{
    /// <summary>
    /// Информация о билете на самолет
    /// </summary>
    public class Trip: Entity<Guid>
    {
        /// <summary>
        /// Пункт отправления
        /// </summary>
        public Destination LeavingFrom { get; init; }

        /// <summary>
        /// Пункт назначения
        /// </summary>
        public Destination GoingTo { get; init; }

        /// <summary>
        /// Дата вылета
        /// </summary>
        public DateTime DepartingDate { get;init;  }

        /// <summary>
        /// Дата возврата
        /// </summary>
        public DateTime ReturningDate { get; init; }

        /// <summary>
        /// Изображения 
        /// </summary>
        public ICollection<DestinationImage> Images { get; init; }

        /// <summary>
        /// Стоимость поездки
        /// </summary>
        public Price Price { get; init; }
    }
}
