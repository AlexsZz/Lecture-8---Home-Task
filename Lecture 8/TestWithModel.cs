using FluentAssertions;
using Flurl.Http;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using static Lecture_8.Model;

namespace Lecture_8
{
    [TestFixture]
    class TestWithModel
    {
        [Test]
        public void PostTest()
        {
            var UserData = new Data
            {
                userId = 99,
                id = 1,
                title = "Test title",
                body = "Test descr"
            };

            var response = "https://jsonplaceholder.typicode.com/posts"
                .PostJsonAsync(UserData);
            var responseBody = response.Result.ResponseMessage.Content.ReadAsStringAsync().Result;
            var parsedData = JsonConvert.DeserializeObject<Data>(responseBody);
            Console.WriteLine(parsedData.userId);
        }
    }
}
