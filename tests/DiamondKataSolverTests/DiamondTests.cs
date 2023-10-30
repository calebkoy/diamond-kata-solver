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
    public void Given_Valid_Letter_CreateDiamond_Returns_Correct_Repeated_Character_Sequence_With_New_Lines(char girdleLetter, string expectedOutput)
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
            new object[] { 'b', "a\nbb" },
            new object[] { 'B', "A\nBB" },
            new object[] { 'c', "a\nbb\ncc" },
            new object[] { 'C', "A\nBB\nCC" },
            new object[] { 'd', "a\nbb\ncc\ndd" },
            new object[] { 'D', "A\nBB\nCC\nDD" },
            new object[] { 'e', "a\nbb\ncc\ndd\nee" },
            new object[] { 'E', "A\nBB\nCC\nDD\nEE" },
            new object[] { 'f', "a\nbb\ncc\ndd\nee\nff" },
            new object[] { 'F', "A\nBB\nCC\nDD\nEE\nFF" },
            new object[] { 'g', "a\nbb\ncc\ndd\nee\nff\ngg" },
            new object[] { 'G', "A\nBB\nCC\nDD\nEE\nFF\nGG" },
            new object[] { 'h', "a\nbb\ncc\ndd\nee\nff\ngg\nhh" },
            new object[] { 'H', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH" },
            new object[] { 'i', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii" },
            new object[] { 'I', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII" },
            new object[] { 'j', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj" },
            new object[] { 'J', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ" },
            new object[] { 'k', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj\nkk" },
            new object[] { 'K', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ\nKK" },
            new object[] { 'l', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj\nkk\nll" },
            new object[] { 'L', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ\nKK\nLL" },
            new object[] { 'm', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj\nkk\nll\nmm" },
            new object[] { 'M', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ\nKK\nLL\nMM" },
            new object[] { 'n', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj\nkk\nll\nmm\nnn" },
            new object[] { 'N', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ\nKK\nLL\nMM\nNN" },
            new object[] { 'o', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj\nkk\nll\nmm\nnn\noo" },
            new object[] { 'O', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ\nKK\nLL\nMM\nNN\nOO" },
            new object[] { 'p', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj\nkk\nll\nmm\nnn\noo\npp" },
            new object[] { 'P', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ\nKK\nLL\nMM\nNN\nOO\nPP" },
            new object[] { 'q', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj\nkk\nll\nmm\nnn\noo\npp\nqq" },
            new object[] { 'Q', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ\nKK\nLL\nMM\nNN\nOO\nPP\nQQ" },
            new object[] { 'r', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj\nkk\nll\nmm\nnn\noo\npp\nqq\nrr" },
            new object[] { 'R', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ\nKK\nLL\nMM\nNN\nOO\nPP\nQQ\nRR" },
            new object[] { 's', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj\nkk\nll\nmm\nnn\noo\npp\nqq\nrr\nss" },
            new object[] { 'S', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ\nKK\nLL\nMM\nNN\nOO\nPP\nQQ\nRR\nSS" },
            new object[] { 't', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj\nkk\nll\nmm\nnn\noo\npp\nqq\nrr\nss\ntt" },
            new object[] { 'T', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ\nKK\nLL\nMM\nNN\nOO\nPP\nQQ\nRR\nSS\nTT" },
            new object[] { 'u', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj\nkk\nll\nmm\nnn\noo\npp\nqq\nrr\nss\ntt\nuu" },
            new object[] { 'U', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ\nKK\nLL\nMM\nNN\nOO\nPP\nQQ\nRR\nSS\nTT\nUU" },
            new object[] { 'v', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj\nkk\nll\nmm\nnn\noo\npp\nqq\nrr\nss\ntt\nuu\nvv" },
            new object[] { 'V', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ\nKK\nLL\nMM\nNN\nOO\nPP\nQQ\nRR\nSS\nTT\nUU\nVV" },
            new object[] { 'w', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj\nkk\nll\nmm\nnn\noo\npp\nqq\nrr\nss\ntt\nuu\nvv\nww" },
            new object[] { 'W', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ\nKK\nLL\nMM\nNN\nOO\nPP\nQQ\nRR\nSS\nTT\nUU\nVV\nWW" },
            new object[] { 'x', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj\nkk\nll\nmm\nnn\noo\npp\nqq\nrr\nss\ntt\nuu\nvv\nww\nxx" },
            new object[] { 'X', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ\nKK\nLL\nMM\nNN\nOO\nPP\nQQ\nRR\nSS\nTT\nUU\nVV\nWW\nXX" },
            new object[] { 'y', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj\nkk\nll\nmm\nnn\noo\npp\nqq\nrr\nss\ntt\nuu\nvv\nww\nxx\nyy" },
            new object[] { 'Y', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ\nKK\nLL\nMM\nNN\nOO\nPP\nQQ\nRR\nSS\nTT\nUU\nVV\nWW\nXX\nYY" },
            new object[] { 'z', "a\nbb\ncc\ndd\nee\nff\ngg\nhh\nii\njj\nkk\nll\nmm\nnn\noo\npp\nqq\nrr\nss\ntt\nuu\nvv\nww\nxx\nyy\nzz" },
            new object[] { 'Z', "A\nBB\nCC\nDD\nEE\nFF\nGG\nHH\nII\nJJ\nKK\nLL\nMM\nNN\nOO\nPP\nQQ\nRR\nSS\nTT\nUU\nVV\nWW\nXX\nYY\nZZ" }
        };
    }
}
