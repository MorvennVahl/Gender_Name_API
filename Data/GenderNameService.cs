namespace Name_Gender_API.Data;

using System;

public class GenderNameService : IGenderNameService
{
    private static string _apiKey = "6222b9d76532823cd248ae22";  //ideally in a databank
    private HttpClient _httpClient = new HttpClient();

    public async Task<string> DetermineNameRequest(string name)
    {
        try
        {
            string? data;
            Task<string> result = _httpClient.GetStringAsync("https://genderapi.io/api?name=" + name + "&key=" + _apiKey);
            data = result.Result;           
            return data;
        }
        catch(Exception e)
        {
            Console.Out.WriteLine("FEHLER" + e.StackTrace);
        }
        return await Task.FromResult<string>("");
    }
    
}