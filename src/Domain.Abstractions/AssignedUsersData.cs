using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rocket.Surgery.Domain
{
    public class AssignedUsersData<TKey>
    {
        [JsonConstructor]
        public AssignedUsersData(IEnumerable<TKey> userIds)
        {
            UserIds = new HashSet<TKey>(userIds);
        }

        public AssignedUsersData()
        {
            UserIds = new HashSet<TKey>();
        }

        public ISet<TKey> UserIds { get; }
    }
}
