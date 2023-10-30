using DiamondKataSolver;

const string invalidInputMessage =
    "Invalid input. Expected usage is `DiamondKataSolver.exe <letter>, where <letter> is a single letter from the English alphabet.";

if (args.Length == 1)
{
    Diamond diamond = new();
    try
    {
        string firstInput = args[0];
        if (firstInput.Length == 1)
        {
            char letter = char.Parse(args[0]);
            Console.WriteLine(diamond.CreateDiamond(letter));
        }
        else
        {
            Console.WriteLine(invalidInputMessage);
        }
    }
    catch (InvalidOperationException e)
    {
        Console.WriteLine($"{invalidInputMessage} Error message: {e}");
    }
    catch (FormatException e)
    {
        Console.WriteLine($"{invalidInputMessage} Error message: {e}");
    }
}
else
{
    Console.WriteLine(invalidInputMessage);
}
