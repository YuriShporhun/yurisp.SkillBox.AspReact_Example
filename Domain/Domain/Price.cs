﻿using Entities.ValueObjects;

namespace Entities.Domain
{
    public class Price
    {
        public int Id { get; init; }
        public Currency Currency { get; init; }
        public Money Value { get; set; }
    }
}
