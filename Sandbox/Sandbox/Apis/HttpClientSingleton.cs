namespace Sandbox.Apis;

public sealed class HttpClientSingleton
{
    private static HttpClientSingleton _instance;

    public HttpClient client {
        get;
    }
    private HttpClientSingleton()
    {
        client = new HttpClient();
    }
    

    public static HttpClientSingleton GetInstance()
    {
        if (_instance == null)
            _instance = new HttpClientSingleton();
        
        return _instance;
    }
    
}