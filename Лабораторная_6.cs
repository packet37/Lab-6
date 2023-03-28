//Задание 1 (a)

//abcd2023111111102023

//using System.Text.RegularExpressions;
//string target = "happy new year ";
//string s = Console.ReadLine();
//string pattern = @"2023";
//Regex regex = new Regex(@"abcd(2023)1{7}0\1");
//if (regex.IsMatch(s) == true)
//{
//    Regex reg = new Regex(pattern);
//    string result = reg.Replace(s, target);
//    Console.WriteLine(result);
//}

//Задание 1 (b)

//abcd2023111111102023

//using System.Text.RegularExpressions;
//long max = 0;
//long sum = 0;
//int max_index = 0;
//string s1 = Console.ReadLine();
//Regex regex1 = new Regex(@"\d");
//MatchCollection textNumbers = regex1.Matches(s1);
//List<long> numbers = new List<long>();
//foreach (Match m in textNumbers)
//{
//    numbers.Add(long.Parse(m.Value));
//    Console.WriteLine(m.Value);
//}
//for (int i = 0; i < numbers.Count; i++)
//{
//    sum += numbers[i];
//    if (numbers[i] > max)
//    {
//        max = numbers[i];
//        max_index = i + 1;
//    }
//}
//Console.WriteLine("Сумма чисел: "+ sum);
//Console.WriteLine("Максимальное число: "+ max);
//Console.WriteLine("Порядковый номер максимального числа: "+ max_index);

//Задание 1 (c)

//Строка для проверки -1.23 цифры +4,56 

//using System.Text.RegularExpressions;
//string s2 = Console.ReadLine();
//Regex regex2 = new Regex(@"[-+]?[0-9]+[.,]?[0-9]+");
//MatchCollection matches = regex2.Matches(s2);
//foreach (Match m in matches)
//{
//    Console.WriteLine(m.Value);
//}
//string output = regex2.Replace(s2, "number");
//Console.WriteLine(output);

//Задание 1 (d)

//Строка для проверки C:\Windows\System32\calc.exe

//using System.Text.RegularExpressions;
//string s3 = Console.ReadLine();
//Regex regex3 = new Regex(@"\\[^.;,]*\\");
//MatchCollection matches = regex3.Matches(s3);
//foreach (Match match in matches)
//{
//    Console.WriteLine(match.Value);
//}

//Задание 2 (a) 

//using System.Text.RegularExpressions;

//for (int i=0; i<5;i++)
//{
//    string s = Console.ReadLine();
//    Regex regex = new Regex(@"(cat){2}");
//    MatchCollection matches = regex.Matches(s);
//    foreach(Match match in matches)
//    {
//        Console.WriteLine(match);
//    }
//}

//Задание 2 (b)

//using System.Text.RegularExpressions;

//for (int i = 0; i < 5; i++)
//{
//    string s = Console.ReadLine();
//    Regex regex = new Regex(@"\b[A-Za-z0-9]{10,}\b");
//    MatchCollection matches = regex.Matches(s);
//    foreach (Match match in matches)
//    {
//        string s1 = regex.Replace(s, "*");
//        Console.WriteLine(s1);
//        //Спросить про замену на первую букву и разницу между пунктами 2 и 3 
//        //string s2 = regex.Replace(s,
//        //Console.WriteLine(s2);

//    }

//}

//Задание 2 (с)

//using System.Text.RegularExpressions;

//for (int i =0;i<5;i++)
//{
//    string s = Console.ReadLine();
//    Regex regex = new Regex(@"(ик\b)");
//    string result = regex.Replace(s, string.Empty);
//    Console.WriteLine(result);
//}

//Задание 2 (d)

//using System.Text.RegularExpressions;

//for (int i =0;i<5;i++)
//{
//    string s = Console.ReadLine();
//    Regex regex = new Regex(@"#[ABCDEF0-9]{6}");
//    MatchCollection matches = regex.Matches(s);
//    foreach (Match match in matches)
//    {
//        Console.WriteLine(match);
//    }
//}

//Задание 2 (e)

//Строка для проверки e02fd0e4-00fd-090A-ca30-0d00a0038ba0

using System.Text.RegularExpressions;

for (int i = 0; i < 5; i++)
{
    string s = Console.ReadLine();
    Regex regex = new Regex(@"([a-fA-F0-9]){8}-\1{4}-\1{4}-\1{4}-\1{12}");
    MatchCollection matches = regex.Matches(s);
    foreach (Match match in matches)
    {
        Console.WriteLine(match);
    }
}

//2b доделать