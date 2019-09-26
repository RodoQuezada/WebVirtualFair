using System;
using System.Net.Http;

namespace WebVirtualFair.Helper
{


    public class UserAPI
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            return client;
        }
        
        
        
    }
    
    
}