using System.Text;

namespace DiamondKataSolver;

internal sealed class Diamond
{
    private readonly StringBuilder _diamondBuilder = new();
    
    internal string CreateDiamond(char girdleLetter)
    {
        if (!char.IsLetter(girdleLetter))
        {
            throw new InvalidOperationException($"Expected a letter from the English alphabet but got: '{girdleLetter}'");
        }
        
        if (girdleLetter is 'A' or 'a')
        {
            return girdleLetter.ToString();
        }
        
        _diamondBuilder.Length = 0;
        int girdleLetterPosition = GetLetterPosition(girdleLetter);
        char firstAlphabetLetter = char.IsUpper(girdleLetter) ? 'A' : 'a';
        AppendTip(girdleLetter, firstAlphabetLetter);
        for (int i = 1; i < girdleLetterPosition; ++i)
        {
            AppendRow((char)(firstAlphabetLetter + i), girdleLetter);
        }
        
        for (int i = girdleLetterPosition - 2; i >= 1; --i)
        {
            AppendRow((char)(firstAlphabetLetter + i), girdleLetter);
        }
        
        AppendTip(girdleLetter, firstAlphabetLetter);
        return _diamondBuilder.ToString();
    }
    
    private void AppendRow(char currentRowLetter, char girdleLetter)
    {
        int currentRowLetterPosition = GetLetterPosition(currentRowLetter);
        int totalLeftSpaces = GetLetterPosition(girdleLetter) - currentRowLetterPosition;
        AppendSpaces(totalLeftSpaces);
        _diamondBuilder.Append(currentRowLetter);
        int totalMiddleSpaces = 2 * (currentRowLetterPosition - 1) - 1;
        AppendSpaces(totalMiddleSpaces);
        _diamondBuilder.Append($"{currentRowLetter}\n");
    }
    
    private void AppendSpaces(int number)
    {
        for (int i = 0; i < number; ++i)
        {
            _diamondBuilder.Append(' ');
        }
    }
    
    private void AppendTip(char letter, char firstAlphabetLetter)
    {
        AppendSpaces(GetLetterPosition(letter) - 1);
        _diamondBuilder.Append($"{firstAlphabetLetter}\n");
    }
    
    private static int GetLetterPosition(char letter)
    {
        char firstAlphabetLetter = char.IsUpper(letter) ? 'A' : 'a';
        return letter - firstAlphabetLetter + 1;
    }
}
