namespace Common.Crosscutting
{
    public interface IPagerDutyGatewaySettings
    {
        string APIKey { get; set; }
        string Endpoint { get; set; }
    }
}