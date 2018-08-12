using Newtonsoft.Json;
using System;

namespace Rocket.Surgery.Domain
{
    public struct ChangeData
    {
        [JsonConstructor]
        public ChangeData(string by, DateTimeOffset? at)
        {
            By = by;
            At = at;
        }

        public ChangeData(Guid by, DateTimeOffset? at)
        {
            By = by.ToString("N");
            At = at;
        }

        public string By { get; }
        public DateTimeOffset? At { get; }
    }
}
