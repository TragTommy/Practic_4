Console.WriteLine("Введите два цифровых значения меньше 10:");

double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double k;
double y;

if (a < 10 && b < 10)
{
    k = (a*b) / (a + b);

    switch (k)
    {
        case 0.0:
            y = 1 / (a + b);
            Console.WriteLine("Ваш ответ товарищ:", Convert.ToString(y) );
            break;
        
        case 1.2:
            y = (a + b) / Math.Pow(b,2);
            Console.WriteLine("Ваш ответ товарищ:", Convert.ToString(y));
            break;
        
        case 3.0:
            y = Math.Pow(a, 2) + Math.Pow(b, 2);
            Console.WriteLine("Ваш ответ товарищ:", Convert.ToString(y));
            break;
        
        case 4.0:
            y = b * Math.Cos(a);
            Console.WriteLine("Ваш ответ товарищ:", Convert.ToString(y));
            break;

        case 5.0:
            y = 0;
            Console.WriteLine("Ваш ответ товарищ:", Convert.ToString(y));
            break; 
    }
}

else 
{ 
    Console.WriteLine("Поздравляю! Программа не работает. А все благодаря тебе, дорогой юзер ^_^ "); 
    //но на данный момент код говно из за программиста)
}