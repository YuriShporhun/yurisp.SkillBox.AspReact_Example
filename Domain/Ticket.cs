﻿using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain
{
    /// <summary>
    /// Информация о билете на самолет
    /// </summary>
    public class Ticket: IEntity
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Пункт отправления
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Пункт назначения
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Дата вылета
        /// </summary>
        public DateTime Departing { get;set;  }

        /// <summary>
        /// Дата возврата
        /// </summary>
        public DateTime Returning { get; set; }

        /// <summary>
        /// Изображения 
        /// </summary>
        public ICollection<DestinationImage> Images { get; set; }
    }
}
