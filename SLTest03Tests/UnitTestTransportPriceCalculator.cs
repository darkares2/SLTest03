using SLTest03;

namespace SLTest03Tests;

public class UnitTestTransportPriceCalculator
{
    [Theory]
    [InlineData(2,5,0)]
    [InlineData(4,9,0)]
    [InlineData(2,10,50)]
    [InlineData(4,10,50)]
    [InlineData(5,9,75)]
    [InlineData(9,9,75)]
    [InlineData(10,10,100)]
    [InlineData(20,15,100)]
    public void TestPrices(int distance, int weight, int price)
    {
        var sut = new TransportPriceCalculator();

        var result = sut.CalculateTransportPrice(distance, weight);
        
        Assert.Equal(price, result);
    }
}