// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//     Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using static FinalProject_MainBlock.Functions;

var examples = new List<string[]>()
{
    new [] {"Hello", "2", "world", ":-)" },
    new [] {"1234", "1567", "-2", "computer science"},
    new [] {"Russia", "Denmark", "Kazan"}
};

Console.WriteLine("Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,\n" +
                  " длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,\n" +
                  " либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,\n" +
                  " лучше обойтись исключительно массивами.");
Console.WriteLine("---------------------------------------------------------------------------------------------------");
Console.WriteLine("1. Выбрать ввод из \"примеров\"");
Console.WriteLine("2. Ввести массив в ручную");
Console.WriteLine("---------------------------------------------------------------------------------------------------");

var userSelect = GetUserInt(variableDescription: "номер опции", minLimit:1, maxLimit:2);

string[] testArray = 

switch (userSelect)
{
    case 1:
        foreach (var example in examples.Select((item, index) => (item, index)))
        {
            Console.WriteLine($"{example.index + 1}: Пример {FormattedStringFromArray(example.item)}");
        }
        var chosenExample = GetUserInt(variableDescription: "номер \"примера\"", minLimit:1, maxLimit: examples.Count);
        testArray = examples[chosenExample - 1];
        break;
    case 2:
        var testArraySize = GetUserInt(variableDescription: "размер массива", minLimit: 1);
        testArray = new string[testArraySize];
        for (var i=0; i < testArray.Length; i++)
        {
            Console.Write($"Введите {i + 1} элемент: ");
            testArray[i] = Console.ReadLine() ?? "";
        }
        Console.WriteLine($"Введен массив {FormattedStringFromArray(testArray)}");
        break;
}
Console.WriteLine(FormattedStringFromArray(testArray));




string FormattedStringFromArray(IEnumerable<string> array)
{
    return "[" + string.Join(", ", array.Select(str => "“" + str + "“")) + "]";
}
