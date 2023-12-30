namespace PrimeService.Tests;

public class PrimeService_IsPrimeShould
{
    [Fact]
    public async Task IsPrime_InputIs1_ReturnFalse()
    {
        var primeService = new Prime.Services.PrimeService();
        bool result = await primeService.IsPrime(1);

        Assert.False(result, "1 should not be prime");
    }

    [Fact]
    public async Task IsPrime_InputIs2_ReturnTrue()
    {
        var primeService = new Prime.Services.PrimeService();
        bool result = await primeService.IsPrime(2);

        Assert.True(result, "2 should be prime");
    }

    [Fact]
    public async Task IsPrime_InputIs3_ReturnTrue()
    {
        var primeService = new Prime.Services.PrimeService();
        bool result = await primeService.IsPrime(3);

        Assert.True(result, "3 should be prime");
    }
}