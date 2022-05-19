using System.Collections.Generic;

namespace Data.Gateway.PagerDuty.DataGateway
{
    public class UsersResult
    {
        public IEnumerable<UserData> users { get; set; }
    }
}