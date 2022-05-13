namespace Common.Crosscutting
{
    internal class PagerDutyGatewaySettings : IPagerDutyGatewaySettings
    {
        public const string SettingPath = "Gateways:PagerDuty";
        public string APIKey { get; set; }
        public string Endpoint { get; set; }
    }
}