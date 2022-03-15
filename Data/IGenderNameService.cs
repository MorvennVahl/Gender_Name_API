using System.Data;

namespace Name_Gender_API.Data;

public interface IGenderNameService
{
    
    //not async Implementation of Functions
    public Task<string> DetermineNameRequest(string name);
}

