
using Xunit;

namespace PrimeService.Tests;

public class SubtractSumTest1
{
    [Fact]
    public void Test11ReturnsCorrectString()
    {
        SubtractSums subtractSums = new SubtractSums();
        var result = subtractSums.SubtractSum(11);
        Assert.Equal("apple", result);
    }

    [Fact]
    public void Test20ReturnsCorrectString()
    {
        SubtractSums subtractSums = new SubtractSums();
        var result = subtractSums.SubtractSum(20);
        Assert.Equal("apple", result);
    }
}