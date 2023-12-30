namespace PrimeService.Tests;

public class PrimeService_IsPrimeShouldThrow
{
    [Fact]
    public async Task IsPrime_InputIs4_ReturnNotImplementedException()
    {
        var primeService = new Prime.Services.PrimeService();
        await Assert.ThrowsAsync<NotImplementedException>(() => primeService.IsPrime(4));
    }

    [Fact]
    public async Task IsPrime_InputIs5_ReturnNotImplementedException()
    {
        var primeService = new Prime.Services.PrimeService();
        await Assert.ThrowsAsync<NotImplementedException>(() => primeService.IsPrime(5));
    }

    [Fact]
    public async Task IsPrime_InputIs6_ReturnNotImplementedException()
    {
        var primeService = new Prime.Services.PrimeService();
        await Assert.ThrowsAsync<NotImplementedException>(() => primeService.IsPrime(6));
    }
}