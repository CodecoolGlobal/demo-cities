using Microsoft.AspNetCore.Mvc.Testing;

namespace Codecool.Cities.WebApi.Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public async Task TestMethod1()
    {
        var webAppFactory = new WebApplicationFactory<Program>();
        var httpClient = webAppFactory.CreateDefaultClient();

        var response = await httpClient.GetAsync("api/city");
        var stringResult = await response.Content.ReadAsStringAsync();
        Assert.IsNotNull(stringResult);
    }
}