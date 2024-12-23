// See https://aka.ms/new-console-template for more information

public class CalculatorTests
{
    [Test]
    public async Task TestOne()
    {
        var result = AddTwo(1, 2);
        
        await Assert.That(result).IsEqualTo(3);
        await Assert.That(result).IsNotEqualTo(2);
    }
    
    private int AddTwo(int x, int y)
    {
        return x + y;
    }
}