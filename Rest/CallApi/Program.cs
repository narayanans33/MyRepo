//// Calling an API using HttpClient
//// Using a service http://jsonplaceholder.typicode.com/ which returns dummy data to test

using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace CallApi
{
    class Program
    {
        const string urlPosts = "http://jsonplaceholder.typicode.com/posts";

        static void TestGet()
        {
            var client = new HttpClient();

            var response = client.GetAsync(urlPosts).Result;
            var result = response.Content.ReadAsStringAsync().Result;

            Console.WriteLine(result);
        }

        static void Fetch(int itemId)
        {
            using (var client = new HttpClient())
            {
                var itemUrl = urlPosts + "/" + itemId;

                var response = client.GetAsync(itemUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine ("Item: " + itemId + " found.");
                    var result = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(result);
                }
                else {
                    Console.WriteLine ("Item not found. Statuscode: " + response.StatusCode + ". Reason: " + response.ReasonPhrase);
                }
            }
        }

        static void TestPost()
        {
            var newPost = new Item() {
                UserId = 10,                
                title = "Hoodini",
                body = "Who let the dogs out ?"                
            };

            var newPostJson = JsonConvert.SerializeObject(newPost);
                        
            using (var client = new HttpClient())
            {
                var response = client.PostAsync(urlPosts, new StringContent(newPostJson)).Result;

                if (!response.IsSuccessStatusCode) {
                    Console.WriteLine("Error: " + response.StatusCode + " : " + response.ReasonPhrase);
                }
            }
 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Test REST API calls.");
            TestPost();
            Fetch(5);
        }
    }
}
