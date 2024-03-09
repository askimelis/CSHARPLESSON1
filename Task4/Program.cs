int a = 4;
int b = 5000000;
int c = 16;
int d = 99;
int e = -7;

int max = a;

if (b > max) 
{
    max = b;
}

if (c > max) 
{
    max = c;
}

if (d > max) 
{
    max = d;
}

if (e > max) 
{
    max = e;
}

Console.WriteLine(max);
