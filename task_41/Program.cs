int m = GetUserNumber("Введите количество вводимых чисел: ", "Ошибка ввода!");
int[] tempArray = GetArray(m);
int countPositive = CountPositive(tempArray);

Console.WriteLine($"{String.Join(" ", tempArray)} -> {countPositive}");


//-----------------Получение чисел от пользователя
int GetUserNumber(string messageToUser, string errorMessage)
{
    while (true)
    {
        Console.Write(messageToUser);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


//-----------------Заполнение массива вручную
int[] GetArray(int inputLenght)
{
    int[] userArray = new int[inputLenght];
    for (int i = 0; i < inputLenght; i++)
    {
        userArray[i] = GetUserNumber($"Введите число {i}: ", "Ошибка ввода!");
    }
    return userArray;
}



//-----------------Подсчет чисел больше 0
int CountPositive(int[] array)
{
    int countPositive = 0;
    foreach (int el in array)
    {
        if (el > 0) countPositive += 1;
    }
    return countPositive;

}
