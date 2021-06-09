using FluentAssertions;
using Flurl.Http;
using NUnit.Framework;
using System;

namespace Lecture_8
{
    public class HomeTask
    {

        [Test]
        public void PostTest()
        {
            var response = "https://jsonplaceholder.typicode.com/posts"
                .PostJsonAsync(new
                {
                    title = "Custom Title",
                    body = "Custome body",
                    userId = 99
                });
            var responseBody = response.Result.ResponseMessage.Content.ReadAsStringAsync().Result;
            responseBody.Should().BeOfType(typeof(string), "Data must have string!");
            var statusCode = response.Result.StatusCode;
            Assert.AreEqual(200, statusCode, "Status Error");
        }

        [Test]
        public void DeleteReqTest()
        {

            var result = "https://jsonplaceholder.typicode.com/posts/1"
            .DeleteAsync();
            var statusCode = result.Result.StatusCode;
            Assert.AreEqual(200, statusCode, "Status Error");
        }


        [Test]
        public void GetReqTest()
        {
            var response = "https://jsonplaceholder.typicode.com/posts"
                .GetAsync();
            var responseBody = response.Result.ResponseMessage.Content.ReadAsStringAsync().Result;
            var statusCode = response.Result.StatusCode;
            Console.WriteLine(responseBody.GetType());
            Assert.AreEqual(200, statusCode, "Status Error");
            responseBody.Should().BeOfType(typeof(string), "Data must have string!");
        }

        [Test]
        public void PatchReqTest()
        {
            var response = "https://jsonplaceholder.typicode.com/posts/1"
                .PatchJsonAsync(new
                {
                    title = "Custom Title",
                    body = "Custome body",
                    userId = 99
                });
            var responseBody = response.Result.ResponseMessage.Content.ReadAsStringAsync().Result;
            responseBody.Should().BeOfType(typeof(string), "Data must have string!");
            var statusCode = response.Result.StatusCode;
            Assert.AreEqual(200, statusCode, "Status Error");

        }
    }
}
