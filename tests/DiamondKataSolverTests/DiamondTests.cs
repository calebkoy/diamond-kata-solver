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
    public void Given_Valid_Letter_CreateDiamond_Returns_Correct_Repeated_Character_Sequence(char girdleLetter, string expectedOutput)
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
            new object[] { 'b', "abb" },
            new object[] { 'B', "ABB" },
            new object[] { 'c', "abbcc" },
            new object[] { 'C', "ABBCC" },
            new object[] { 'd', "abbccdd" },
            new object[] { 'D', "ABBCCDD" },
            new object[] { 'e', "abbccddee" },
            new object[] { 'E', "ABBCCDDEE" },
            new object[] { 'f', "abbccddeeff" },
            new object[] { 'F', "ABBCCDDEEFF" },
            new object[] { 'g', "abbccddeeffgg" },
            new object[] { 'G', "ABBCCDDEEFFGG" },
            new object[] { 'h', "abbccddeeffgghh" },
            new object[] { 'H', "ABBCCDDEEFFGGHH" },
            new object[] { 'i', "abbccddeeffgghhii" },
            new object[] { 'I', "ABBCCDDEEFFGGHHII" },
            new object[] { 'j', "abbccddeeffgghhiijj" },
            new object[] { 'J', "ABBCCDDEEFFGGHHIIJJ" },
            new object[] { 'k', "abbccddeeffgghhiijjkk" },
            new object[] { 'K', "ABBCCDDEEFFGGHHIIJJKK" },
            new object[] { 'l', "abbccddeeffgghhiijjkkll" },
            new object[] { 'L', "ABBCCDDEEFFGGHHIIJJKKLL" },
            new object[] { 'm', "abbccddeeffgghhiijjkkllmm" },
            new object[] { 'M', "ABBCCDDEEFFGGHHIIJJKKLLMM" },
            new object[] { 'n', "abbccddeeffgghhiijjkkllmmnn" },
            new object[] { 'N', "ABBCCDDEEFFGGHHIIJJKKLLMMNN" },
            new object[] { 'o', "abbccddeeffgghhiijjkkllmmnnoo" },
            new object[] { 'O', "ABBCCDDEEFFGGHHIIJJKKLLMMNNOO" },
            new object[] { 'p', "abbccddeeffgghhiijjkkllmmnnoopp" },
            new object[] { 'P', "ABBCCDDEEFFGGHHIIJJKKLLMMNNOOPP" },
            new object[] { 'q', "abbccddeeffgghhiijjkkllmmnnooppqq" },
            new object[] { 'Q', "ABBCCDDEEFFGGHHIIJJKKLLMMNNOOPPQQ" },
            new object[] { 'r', "abbccddeeffgghhiijjkkllmmnnooppqqrr" },
            new object[] { 'R', "ABBCCDDEEFFGGHHIIJJKKLLMMNNOOPPQQRR" },
            new object[] { 's', "abbccddeeffgghhiijjkkllmmnnooppqqrrss" },
            new object[] { 'S', "ABBCCDDEEFFGGHHIIJJKKLLMMNNOOPPQQRRSS" },
            new object[] { 't', "abbccddeeffgghhiijjkkllmmnnooppqqrrsstt" },
            new object[] { 'T', "ABBCCDDEEFFGGHHIIJJKKLLMMNNOOPPQQRRSSTT" },
            new object[] { 'u', "abbccddeeffgghhiijjkkllmmnnooppqqrrssttuu" },
            new object[] { 'U', "ABBCCDDEEFFGGHHIIJJKKLLMMNNOOPPQQRRSSTTUU" },
            new object[] { 'v', "abbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvv" },
            new object[] { 'V', "ABBCCDDEEFFGGHHIIJJKKLLMMNNOOPPQQRRSSTTUUVV" },
            new object[] { 'w', "abbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvww" },
            new object[] { 'W', "ABBCCDDEEFFGGHHIIJJKKLLMMNNOOPPQQRRSSTTUUVVWW" },
            new object[] { 'x', "abbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxx" },
            new object[] { 'X', "ABBCCDDEEFFGGHHIIJJKKLLMMNNOOPPQQRRSSTTUUVVWWXX" },
            new object[] { 'y', "abbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxyy" },
            new object[] { 'Y', "ABBCCDDEEFFGGHHIIJJKKLLMMNNOOPPQQRRSSTTUUVVWWXXYY" },
            new object[] { 'z', "abbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxyyzz" },
            new object[] { 'Z', "ABBCCDDEEFFGGHHIIJJKKLLMMNNOOPPQQRRSSTTUUVVWWXXYYZZ" }
        };
    }
}
