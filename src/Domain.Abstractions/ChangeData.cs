using Newtonsoft.Json;
using System;

namespace Rocket.Surgery.Domain
{
    public class ChangeData<TKey>
    {

        [JsonConstructor]
        public ChangeData(TKey by, DateTimeOffset? at)
        {
            By = by;
            At = at;
        }

        public ChangeData() { }

        public TKey By { get; }
        public DateTimeOffset? At { get; }
    }
}
