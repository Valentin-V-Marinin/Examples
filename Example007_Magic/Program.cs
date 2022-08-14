
int xa = 55, ya = 1, xb = 1, yb = 30, xc = 110, yc = 30;
string znak = "*";// 

Console.Clear();
Console.SetCursorPosition(xa, ya);
Console.WriteLine(znak);
Console.SetCursorPosition(xb, yb);
Console.WriteLine(znak);
Console.SetCursorPosition(xc, yc);
Console.WriteLine(znak);

int x = xa, y = yb;
int count = 0;

while(count < 15000)
{
    int dot = new Random().Next(0,3);
    if (dot == 0)
    {
        x = (x + xa) /2;
        y = (y + ya) /2;
    }

    if (dot == 1)
    {
        x = (x + xb) /2;
        y = (y + yb) /2;
    }

    if (dot == 2)
    {
        x = (x + xc) /2;
        y = (y + yc) /2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine(znak);
    count++;
}

