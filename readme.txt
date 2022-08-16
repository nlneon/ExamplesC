Чере правую мышки на папке в VSC и открыть в интегриованном терминале (?)
dotnet new console - создание новой программы
dotnet run - запуск

string <name> = Console.WriteLine("<string>"); - задание строки (в конце переход на другую строку) (от 4 байт до 2 гб)
                Console.WriteLine($"<string> {переменная}")
int <name> = Convert.ToInt32(ConsoleReadLine()); - ввод числа и конвертация в целочисленное (32х разрядное число)
double <name> = <число> - вещественный тип данных (64х разрядное число)
bool (1 байт)
Console.Write - вывод в одну строку
Console.ReadLine -  Считать строку из терминала

Случайности
new Random().Next(min, max) - даст случайное число от min до max-1
[min, max-1] или [min, max)
                    полуинтервал


