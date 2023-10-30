using System.Text;

namespace DiamondKataSolver;

internal sealed class Diamond
{
    internal string CreateDiamond(char girdleLetter)
    {
        StringBuilder stringBuilder = new StringBuilder();
        int girdleLetterPosition = GetLetterPosition(girdleLetter);
        char firstAlphabetLetter = char.IsUpper(girdleLetter) ? 'A' : 'a';
        stringBuilder.Append(firstAlphabetLetter);
        for (int i = 1; i < girdleLetterPosition; ++i)
        {
            char currentLetter = (char)(firstAlphabetLetter + i);
            stringBuilder.Append($"{currentLetter}{currentLetter}");
        }

        return stringBuilder.ToString();
    }
    
    private static int GetLetterPosition(char letter)
    {
        char firstAlphabetLetter = char.IsUpper(letter) ? 'A' : 'a';
        return letter - firstAlphabetLetter + 1;
    }
}
