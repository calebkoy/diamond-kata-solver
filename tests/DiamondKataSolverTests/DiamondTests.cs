using DiamondKataSolver;

namespace DiamondKataSolverTests;

public sealed class DiamondTests
{
    [Fact]
    public void Given_A_Create_Returns_Expected_Output()
    {
        // Arrange
        Diamond diamond = new Diamond();
        
        // Act/Assert
        Assert.Equal("A", diamond.Create('A'));
    }
}
