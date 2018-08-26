using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rocket.Surgery.Domain
{
    public class AssignedUsersData
    {
        [JsonConstructor]
        public AssignedUsersData(IEnumerable<string> userIds)
        {
            UserIds = new HashSet<string>(userIds, StringComparer.OrdinalIgnoreCase);
        }

        public AssignedUsersData()
        {
            UserIds = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }

        public ISet<string> UserIds { get; }
    }
}
