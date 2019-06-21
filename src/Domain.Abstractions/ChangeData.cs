using Newtonsoft.Json;
using NodaTime;
using System;

namespace Rocket.Surgery.Domain
{
    public class ChangeData<TKey>
    {
        [JsonConstructor]
        public ChangeData(TKey by, Instant? at)
        {
            By = by;
            At = at;
        }

        public ChangeData(TKey by, DateTimeOffset? at)
        {
            By = by;
            if (at.HasValue)
            {
                At = Instant.FromDateTimeOffset(at.Value);
            }
        }

        public ChangeData() { }

        public TKey By { get; }
        public Instant? At { get; }
    }
}
