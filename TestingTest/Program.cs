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

    [Test]
    public async Task TestTwo()
    {
        var result = AddThree(1, 2, 3);
        
        await Assert.That(result).IsEqualTo(6);
        await Assert.That(result).IsNotEqualTo(5);
    }
    
    private int AddTwo(int x, int y)
    {
        return x + y;
    }
    
    private int AddThree(int x, int y, int z)
    {
        return x + y + z;
    }
}