using System;
using Newtonsoft.Json;

namespace Rocket.Surgery.Domain
{
    public struct OwnerData
    {
        [JsonConstructor]
        public OwnerData(string id)
        {
            Id = id;
        }
        public OwnerData(Guid id)
        {
            Id = id.ToString("N");
        }

        public string Id { get; }
    }
}
