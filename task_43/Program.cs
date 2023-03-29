double k1 = UserInput("Введите k1: ");
double b1 = UserInput("Введите b1: ");
double k2 = UserInput("Введите k2: ");
double b2 = UserInput("Введите b2: ");

string result = string.Empty;

if (k1 != k2)
{
        (double, double) coordinate = CrossPoint(k1, b1, k2, b2);
        result = $"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} - > {coordinate}";
}
else result = $"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} - > прямые параллельны или совпадают";

Console.Write(result);



//----------------Расчет точки пересечения прямых

(double x, double y) CrossPoint(double k1, double b1, double k2, double b2)
{

    double x = Math.Round(((b2 - b1) / (k1 - k2)), 3);
    double y = Math.Round((k1 * x + b1), 3);
    //return $"точка пересечения ({x}; {y})";
    var coord = (x, y);
    return coord;
}



//----------------Ввод данных
static double UserInput(string messageToUser)
{
    Console.Write(messageToUser);
    try
    {
        return double.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}
