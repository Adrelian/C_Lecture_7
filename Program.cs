 // Задача 1. Собрать строку с числами от a до b, a<=b


// // Иттеративный метод
//  string NumberForce (int a, int b)
//  {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
//  }

//  // Рекурсия
//  string NumberRec ( int a, int b)
//  {
//     if (a < b) return $"{a} " + NumberRec( a + 1, b);
//     else return String.Empty;
//  }

//  Console.WriteLine(NumberRec (1, 10));
//  Console.WriteLine(NumberForce (1, 10));


// Факторил числа

// int FactorialFor (int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= i;
//     return result;
// }

// int FactorialRec (int n)
// {
//     if (n==1) return 1;
//     else return n*FactorialFor(n-1);
// }

// Console.WriteLine (FactorialFor(10));
// Console.WriteLine (FactorialRec(10));

//Возвести число а в степень n

// int PowerFor (int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }

// int PowerRec (int a, int n)
// {
//     return n == 0 ? 1 : PowerRec (a, n - 1) * a;
//     // if (n == 0) return 1; // движемся назад по числам степени
//     // else return PowerRec(a, n - 1) * a;
// }

// int PowerRecMath(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath (a * a, n / 2);
//     else return PowerRecMath (a, n - 1) * a;
// }

// Console.WriteLine (PowerFor(2, 10));
// Console.WriteLine (PowerRec(2, 10));

// Console.WriteLine (PowerRecMath(2, 10));

//Задача. Перебор слов

// char[] s = { 'а', 'и', 'с', 'в' };

// int count  = s.Length;

// int n = 1;

// for ( int i = 0; i < count; i++)
// {
//     Console.WriteLine($"{n++, -5}{s[i]}");
// }

// int n = 1; // счётчик
// void FindWords (string alpabet, char [] word, int leght = 0)
// {
//     if (leght == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alpabet.Length; i++)
//     {
//         word[leght] = alpabet[i];
//         FindWords(alpabet, word, leght + 1);
//     }
// }

// FindWords("аисв", new char[5]);

string path = "C:/Users/Anatolii/Documents/Учеба";
// DirectoryInfo di = new DirectoryInfo(path);

// System.Console.WriteLine(di.CreationTime);

// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name); // Вывод только имён ФАЙЛОВ
// }

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path); // информация о директории в которую зашли

//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++) // массив всех файлов в папке
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }

//     FileInfo[] files = catalog.GetFiles(); // весь список файлов и папок текеущего каталога
//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }

// CatalogInfo(path);


// Игра в башенки, отображение ходов
// void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
// {
// if (count > 1) Towers(with, some, on, count - 1);
// Console.WriteLine($"{with} >> {on}");
// if (count > 1) Towers(some, on, with, count - 1);
// }

// Towers();

// string emp = String.Empty; //пустные элементы
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// //                  0   1     2    3    4    5    6    7    8    9    10   11
// void InOrderTraversal(int pos = 1)
// {
// if (pos < tree.Length)
//     {
//         int left = 2 * pos; // левое поддерева
//         int right = 2 * pos + 1; // правое поддерево
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }

// InOrderTraversal();

git commit