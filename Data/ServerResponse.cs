using System.Diagnostics.CodeAnalysis;

namespace Name_Gender_API.Data;


public class ServerResponse
{
    public string? Name { get; set; }
    public string? Q { get; set; }
    public string? Gender { get; set; }
    public int? Totalnames { get; set; }
    public string? Country { get; set; }
    public string? Probability { get; set; }
    public bool Status { get; set; }
    public string? Duration { get; set; }
    public int? Usedcredits { get; set; }
    public int? Remainingcredits { get; set; }
    public DateTime Expires { get; set; }
    public string? Server { get; set; }
}