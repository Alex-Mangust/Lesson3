// Вид 1
// void Method()
// {
//     Console.WriteLine("Автор: Alex Mangust");
// }
//Чтобы вызвать метод:
//Method();

// Вид2
// void Method2(string msg, int count)
// {
//     int i = 0;
//     while(i < count)
//     {
//     Console.WriteLine(msg);
//     i++;
//     }
// }
// // При указании параметров метода(функции(не знаю пока есть ли разница)), нужно
// // указывать параметры по порядку, так как указано при создании этой функции.
// Method2("Alex", 4);
// // Можно указывать парметры также и не по порядку, то тогда необходимо перед этим
// // писать {название_параметра: значение, которое мы хотим ему дать}
// Method2(count: 4, msg: "Anna");
// Console.WriteLine("");
// // Пример:
// void Method2_1(string nameBoy, string nameGirl, int count, string couple)
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine($"{nameBoy} и {nameGirl} теперь {couple}");
//         i++;
//     }
// }
// Method2_1(nameGirl: "Аня", nameBoy: "Саша", count: 4, couple:"пара");

// Вид 3
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int Year = Method3();
// Console.WriteLine(Year);

// Вид 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     } 
//     return result;
// }
// string res = Method4(10, "Я люблю Аню! ");
// Console.WriteLine(res);

// Цикл for;
// string Method4_1(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4_1(10, "Аня, я тебя люблю! ");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine("");
// }

/*Работа с текстом
Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к"
заменить большими "К", а большие "С" заменить маленькими "с"*/

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, ежели бы вас послали " +
//               "вместе нашего милого Винценгероде, вы бы взяли приступом согласие прусского " +
//               "короля. Вы так красноречивы. Вы дадите мне чаю?";
// // string s = "qwerty"
// //             012345
// // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for(int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result += $"{newValue}";
//         else result += $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'c');
// Console.WriteLine(newText);

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);