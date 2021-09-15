using System;

namespace Domain
{
    /// <summary>
    /// Информация о билете на самолет
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id {  get; set; }

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

    }
}
