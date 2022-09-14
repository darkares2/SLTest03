namespace SLTest03;

public class TransportPriceCalculator
{
    private const int LowestPrice = 0;
    private const int MediumPrice = 50;
    private const int HighPrice = 75;
    private const int HighestPrice = 100;
    
    public int CalculateTransportPrice(int distance, int weight)
    {
        if (TransportPriceLowest(distance, weight)) 
            return LowestPrice;
        else if (TransportPriceMedium(distance, weight))
            return MediumPrice;
        else if (TransportPriceHigh(distance, weight))
            return HighPrice;

        return HighestPrice;
    }

    private bool TransportPriceHigh(int distance, int weight)
    {
        if (distance >= 5 && weight < 10)
            return true;
        return false;
    }

    private bool TransportPriceMedium(int distance, int weight)
    {
        if (distance < 5 && weight >= 10)
            return true;
        return false;
    }

    private bool TransportPriceLowest(int distance, int weight)
    {
        if (distance < 5 && weight < 10)
            return true;
        return false;
    }
}