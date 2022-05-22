using Microsoft.AspNetCore.Mvc.Testing;

namespace Codecool.Cities.Webapi.Test
{
    public class CityControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task DefaultRoute_ReturnsHelloWord()
        {
            var webAppFactory = new WebApplicationFactory<Program>();
            var httpClient = webAppFactory.CreateDefaultClient();
            
            var response = await httpClient.GetAsync("api/city");
            var stringResult = await response.Content.ReadAsStringAsync();
            Assert.AreEqual("Hello", stringResult);
        }
    }
}