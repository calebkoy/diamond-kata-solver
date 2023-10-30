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
            if (i == 1)
            {
                stringBuilder.Append("\n");
            }
            
            char currentLetter = (char)(firstAlphabetLetter + i);
            stringBuilder.Append($"{currentLetter}{currentLetter}");
            if (i < girdleLetterPosition - 1)
            {
                stringBuilder.Append("\n");
            }
        }

        return stringBuilder.ToString();
    }
    
    private static int GetLetterPosition(char letter)
    {
        char firstAlphabetLetter = char.IsUpper(letter) ? 'A' : 'a';
        return letter - firstAlphabetLetter + 1;
    }
}
