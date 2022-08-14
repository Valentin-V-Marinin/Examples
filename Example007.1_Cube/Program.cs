
int xa = 1, ya = 18, xb = 1, yb = 18,
    xc = 40, yc = 1, xd = 40, yd = 36,
    xe = 80, ye = 18, xf = 80, yf = 18;
string znak = "7";// 

Console.Clear();
Console.SetCursorPosition(xa, ya);
Console.WriteLine(znak);
Console.SetCursorPosition(xb, yb);
Console.WriteLine(znak);
Console.SetCursorPosition(xc, yc);
Console.WriteLine(znak);
Console.SetCursorPosition(xd, yd);
Console.WriteLine(znak);
Console.SetCursorPosition(xe, ye);
Console.WriteLine(znak);
Console.SetCursorPosition(xf, yf);
Console.WriteLine(znak);

int x = xa, y = yf;
int count = 0;

while (count < 10000)
{
    int dot = new Random().Next(0, 6);
    if (dot == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (dot == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (dot == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    if (dot == 3)
    {
        x = (x + xd) / 2;
        y = (y + yd) / 2;
    }

    if (dot == 4)
    {
        x = (x + xe) / 2;
        y = (y + ye) / 2;
    }
    if (dot == 5)
    {
        x = (x + xf) / 2;
        y = (y + yf) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine(znak);
    count++;
}