using System;
using System.Net.Http;
using Xablu.WebApiClient;
using System.Collections.Generic;
using Sample.Core.Models;
using Fusillade;
using System.Threading.Tasks;

namespace Sample.Core
{
    public class Client
    {
        public static IRestApiClient SampleClient;
        private const string ApiBaseAddress = "https://my-json-server.typicode.com/typicode/demo/";

        public static void Initialize(Func<HttpMessageHandler> messageHandler)
        {
            var clientOptions = new RestApiClientOptions(ApiBaseAddress);
            clientOptions.DefaultHttpMessageHandler = messageHandler;
            SampleClient = new RestApiClient(clientOptions);
        }

        public static async Task<IEnumerable<Post>> Getposts()
        {
            var result = await GetResult<List<Post>>("posts");

            if (result.IsSuccessStatusCode)
                return result.Content;

            return new List<Post>();
        }

        private static async Task<IRestApiResult<T>> GetResult<T>(string pathSuffix)
        {
            var path = GetRequestPath(pathSuffix);

            var result = await SampleClient
                .GetAsync<T>(Priority.UserInitiated, path)
                .ConfigureAwait(false);

            return result;
        }

        private static string GetRequestPath(string verb = "")
        {
            return string.Concat(ApiBaseAddress, verb);
        }
    }
}
