namespace Auth_Test.Models;

public class HomeViewModel
{
    public string? EnvironVariable { get; set; }
    public string? AppConfigVariable { get; set; }
    public string? KeyVaultVariable { get; set; }
    public string? KeyVaultSecret { get; set; }
    public string? KeyVaultVariableAppConfig { get; set; }
    public string? KeyVaultSecretAppConfig { get; set; }

}