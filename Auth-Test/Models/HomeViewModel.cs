namespace Auth_Test.Models;

public class HomeViewModel
{
    public string? EnvironVariable { get; set; }
    public string? AppConfigVariable { get; set; }
    public string? KeyVaultVariable { get; set; }
    public string? KeyVaultThroughAppConfig { get; set; }

}