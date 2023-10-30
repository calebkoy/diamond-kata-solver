using System.Text;

namespace DiamondKataSolver;

internal sealed class Diamond
{
    internal string CreateDiamond(char girdleLetter)
    {
        StringBuilder stringBuilder = new StringBuilder();
        int girdleLetterPosition = GetLetterPosition(girdleLetter);
        char firstAlphabetLetter = char.IsUpper(girdleLetter) ? 'A' : 'a';
        for (int i = 0; i < girdleLetterPosition; ++i)
        {
            stringBuilder.Append((char)(firstAlphabetLetter + i));
        }

        return stringBuilder.ToString();
    }
    
    private static int GetLetterPosition(char letter)
    {
        char firstAlphabetLetter = char.IsUpper(letter) ? 'A' : 'a';
        return letter - firstAlphabetLetter + 1;
    }
}
