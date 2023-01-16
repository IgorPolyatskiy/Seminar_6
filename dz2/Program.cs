string GoodPrint(double k1, double k2, double b1, double b2, double x, double y)
{
    return $"k1 = {k1},b1 = {b1},k2 = {k2},b2 = {b2} >> [{x};{y}]";
}

double ReadUserInput(string text)
{
    Console.Write(text);
    return double.Parse(Console.ReadLine());
}

double k1 = ReadUserInput("Введите K1: ");
double b1 = ReadUserInput("Введите B1: ");
double k2 = ReadUserInput("Введите K2: ");
double b2 = ReadUserInput("Введите B2: ");


double differenceK = k1 - k2;
if (differenceK == 0)
{
    Console.WriteLine("Точка пересечения отсутствует");
}
else
{
    double x = (b2 - b1) / differenceK;
    double y = k1 * x + b1;
    Console.WriteLine(GoodPrint(k1,k2,b1,b2,x,y));
}
