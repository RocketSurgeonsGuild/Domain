using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rocket.Surgery.Domain
{
    public struct AssignedUsersData
    {
        [JsonConstructor]
        public AssignedUsersData(IEnumerable<string> userIds)
        {
            UserIds = new HashSet<string>(userIds, StringComparer.OrdinalIgnoreCase);
        }

        public ISet<string> UserIds { get; }
    }
}
