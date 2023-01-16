string GoodPrint(string input, int positiveNumberCount)
{
    return $"{input} >> {positiveNumberCount}";
}

string ReadUserInput(string text)
{
    Console.Write(text);
    return Console.ReadLine();

}

string[] FormatInput(string input)
{
    return input.Replace(" ", "").Split(",");
}

int GetPositiveNumbersCount(string[] array)
{
    int positiveNumberCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int currentNumber = int.Parse(array[i]);
        if (currentNumber > 0)
        {
            positiveNumberCount++;
        }
    }
    return positiveNumberCount;
}

string input = ReadUserInput("Введите числа через запятую: ");
string[] formattedInput = FormatInput(input);
int positiveNumberCount = GetPositiveNumbersCount(formattedInput);
Console.WriteLine(GoodPrint(input, positiveNumberCount));