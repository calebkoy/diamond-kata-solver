using DiamondKataSolver;

namespace DiamondKataSolverTests;

public sealed class DiamondTests
{
    [Fact]
    public void Given_A_CreateDiamond_Returns_Expected_Output()
    {
        // Arrange
        Diamond diamond = new Diamond();
        
        // Act/Assert
        Assert.Equal("A", diamond.CreateDiamond('A'));
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void Given_Valid_Letter_CreateDiamond_Returns_Correct_Character_Sequence(char girdleLetter, string expectedOutput)
    {
        // Arrange
        Diamond diamond = new Diamond();

        // Act/Assert
        Assert.Equal(expectedOutput, diamond.CreateDiamond(girdleLetter));
    }
    
    public static IEnumerable<object[]> GetTestData()
    {
        return new List<object[]>
        {
            new object[] { 'a', "a" },
            new object[] { 'A', "A" },
            new object[] { 'b', "ab" },
            new object[] { 'B', "AB" },
            new object[] { 'c', "abc" },
            new object[] { 'C', "ABC" },
            new object[] { 'd', "abcd" },
            new object[] { 'D', "ABCD" },
            new object[] { 'e', "abcde" },
            new object[] { 'E', "ABCDE" },
            new object[] { 'f', "abcdef" },
            new object[] { 'F', "ABCDEF" },
            new object[] { 'g', "abcdefg" },
            new object[] { 'G', "ABCDEFG" },
            new object[] { 'h', "abcdefgh" },
            new object[] { 'H', "ABCDEFGH" },
            new object[] { 'i', "abcdefghi" },
            new object[] { 'I', "ABCDEFGHI" },
            new object[] { 'j', "abcdefghij" },
            new object[] { 'J', "ABCDEFGHIJ" },
            new object[] { 'k', "abcdefghijk" },
            new object[] { 'K', "ABCDEFGHIJK" },
            new object[] { 'l', "abcdefghijkl" },
            new object[] { 'L', "ABCDEFGHIJKL" },
            new object[] { 'm', "abcdefghijklm" },
            new object[] { 'M', "ABCDEFGHIJKLM" },
            new object[] { 'n', "abcdefghijklmn" },
            new object[] { 'N', "ABCDEFGHIJKLMN" },
            new object[] { 'o', "abcdefghijklmno" },
            new object[] { 'O', "ABCDEFGHIJKLMNO" },
            new object[] { 'p', "abcdefghijklmnop" },
            new object[] { 'P', "ABCDEFGHIJKLMNOP" },
            new object[] { 'q', "abcdefghijklmnopq" },
            new object[] { 'Q', "ABCDEFGHIJKLMNOPQ" },
            new object[] { 'r', "abcdefghijklmnopqr" },
            new object[] { 'R', "ABCDEFGHIJKLMNOPQR" },
            new object[] { 's', "abcdefghijklmnopqrs" },
            new object[] { 'S', "ABCDEFGHIJKLMNOPQRS" },
            new object[] { 't', "abcdefghijklmnopqrst" },
            new object[] { 'T', "ABCDEFGHIJKLMNOPQRST" },
            new object[] { 'u', "abcdefghijklmnopqrstu" },
            new object[] { 'U', "ABCDEFGHIJKLMNOPQRSTU" },
            new object[] { 'v', "abcdefghijklmnopqrstuv" },
            new object[] { 'V', "ABCDEFGHIJKLMNOPQRSTUV" },
            new object[] { 'w', "abcdefghijklmnopqrstuvw" },
            new object[] { 'W', "ABCDEFGHIJKLMNOPQRSTUVW" },
            new object[] { 'x', "abcdefghijklmnopqrstuvwx" },
            new object[] { 'X', "ABCDEFGHIJKLMNOPQRSTUVWX" },
            new object[] { 'y', "abcdefghijklmnopqrstuvwxy" },
            new object[] { 'Y', "ABCDEFGHIJKLMNOPQRSTUVWXY" },
            new object[] { 'z', "abcdefghijklmnopqrstuvwxyz" },
            new object[] { 'Z', "ABCDEFGHIJKLMNOPQRSTUVWXYZ" }
        };
    }
}
