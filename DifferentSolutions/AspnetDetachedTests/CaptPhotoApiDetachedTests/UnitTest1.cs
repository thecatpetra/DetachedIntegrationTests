// In CatPhotoApi publish the app via
// dotnet publish --configuration Release
// Add reference to CatPhotoApi.dll of publish from CatPhotoApi
// Copy .deps.json for cat photo api to root

using CatPhotoApi;
using Microsoft.AspNetCore.Mvc.Testing;


namespace CatPhotoApiDetachedTests;

public class Tests
{
    private WebApplicationFactory<Program> _factory;

    [SetUp]
    public void Setup()
    {
        _factory = new WebApplicationFactory<Program>();
    }

    [Test]
    public async Task Test()
    {
        // Arrange
        var client = _factory.CreateClient();

        // Act
        var response = await client.GetAsync("api/get");

        // Assert
        response.EnsureSuccessStatusCode(); // Status Code 200-299
    }
}
