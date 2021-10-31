using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain
{
    /// <summary>
    /// Информация о билете на самолет
    /// </summary>
    public class Trip: IEntity
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Пункт отправления
        /// </summary>
        public string LeavingFrom { get; set; }

        /// <summary>
        /// Пункт назначения
        /// </summary>
        public string GoingTo { get; set; }

        /// <summary>
        /// Дата вылета
        /// </summary>
        public DateTime DepartingDate { get;set;  }

        /// <summary>
        /// Дата возврата
        /// </summary>
        public DateTime ReturningDate { get; set; }

        /// <summary>
        /// Изображения 
        /// </summary>
        public ICollection<DestinationImage> Images { get; set; }
    }
}
