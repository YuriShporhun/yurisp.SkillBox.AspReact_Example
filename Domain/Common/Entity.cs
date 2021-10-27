using System;

namespace Domain.Common
{
    /// <summary>
    /// Базовый класс для сущности
    /// </summary>
    public class Entity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
    }
}
