using Domain.Common;

namespace Domain
{
    public class DestinationImage: IEntity
    {
        public string Id { get; set; }
        public string Url { get; set; }
    }
}
