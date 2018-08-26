using System;
using Newtonsoft.Json;

namespace Rocket.Surgery.Domain
{
    public class OwnerData<TKey>
    {
        [JsonConstructor]
        public OwnerData(TKey id)
        {
            Id = id;
        }

        public TKey Id { get; }
    }
}
