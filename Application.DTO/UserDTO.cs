namespace Application.DTO
{
    using System.Collections.Generic;

    namespace Data.Gateway.PagerDuty.DataGateway
    {
        public class ContactMethodDTO
        {
            public string html_url { get; set; }
            public string id { get; set; }
            public string self { get; set; }
            public string summary { get; set; }
            public string type { get; set; }
        }

        public class NotificationRuleDTO
        {
            public string html_url { get; set; }
            public string id { get; set; }
            public string self { get; set; }
            public string summary { get; set; }
            public string type { get; set; }
        }

        public class TeamDTO
        {
            public string html_url { get; set; }
            public string id { get; set; }
            public string self { get; set; }
            public string summary { get; set; }
            public string type { get; set; }
        }

        public class UserDTO
        {
            public string avatar_url { get; set; }
            public bool billed { get; set; }
            public string color { get; set; }
            public IEnumerable<ContactMethodDTO> contact_methods { get; set; }
            public List<object> coordinated_incidents { get; set; }
            public string description { get; set; }
            public string email { get; set; }
            public string html_url { get; set; }
            public string id { get; set; }
            public bool invitation_sent { get; set; }
            public string job_title { get; set; }
            public string name { get; set; }
            public List<NotificationRuleDTO> notification_rules { get; set; }
            public string role { get; set; }
            public string self { get; set; }
            public string summary { get; set; }
            public List<TeamDTO> teams { get; set; }
            public string time_zone { get; set; }
            public string type { get; set; }
        }
    }
}