Console.Clear();                // очистка экрана консоли
//Console.SetCursorPosition(10,4);  // установить курсор на позицию: отступ от левого края 10 символов, отступ от верхнего края 4 символа 
//Console.WriteLine("+");
int xa = 50, ya = 1,              // задаем координаты вершин треугольника
    xb = 1,  yb = 30,
    xc = 100, yc = 30;

Console.SetCursorPosition(xa, ya);   
Console.WriteLine("*");
Console.SetCursorPosition(xb, yb);   
Console.WriteLine("*");
Console.SetCursorPosition(xc, yc);   
Console.WriteLine("*");

int x = xa, y = ya;
int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0,3);  // [0;3) 0 1 2
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count++;
}