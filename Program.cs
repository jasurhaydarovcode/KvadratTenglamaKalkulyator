// ================================================
// Author: Jasur Haydarov
// Github: https://www.github.com/jasurhaydarovcode/KvadratTenglamaKalkulyator
// Date: 17-Feb-2025
// Description: Kvadrat tenglama hisoblash kalkulyatori
// Language: C#
// ================================================


// Kerakli matematik formulalar
/*
✅ Kvadrat tenglama shakli: ax² + bx + c = 0
Bu yerda:
          a, b, va c — tenglamaning koeffitsiyentlari.

Diskriminant: 
            D = b * b - 4ac

Ildizlar: 
    - Agar D > 0 bo‘lsa, ikkita haqiqiy ildiz mavjud:
            x1 = (-b + sqrt(D)) / (2a)
            x2 = (-b - sqrt(D)) / (2a)
    
    - Agar D = 0 bo‘lsa, bitta haqiqiy ildiz mavjud:
            x = -b / (2a)
    
    - Agar D < 0 bo‘lsa, haqiqiy ildizlar mavjud emas (kompleks ildizlar bo‘ladi).
*/

using System;
using static System.Console;

WriteLine("Kvadrat tenglama ildizlarini hisoblovchi kalkulyatorga xush kelibsiz!");
WriteLine("\n");

Write("a ozod hadini kiring: ");
double a = Convert.ToDouble(ReadLine());
WriteLine("\n");

Write("b ozod hadini kiring: ");
double b = Convert.ToDouble(ReadLine());
WriteLine("\n");

Write("c ozod hadini kiring: ");
double c = Convert.ToDouble(ReadLine());
WriteLine("\n");

// Diskriminant
double d = (b * b) - (4 * a * c);

// Ildizlar
if (d > 0)
{
        double x1 = (-b + Math.Sqrt(d)) / (2 * a);
        double x2 = (-b - Math.Sqrt(d)) / (2 * a);
        WriteLine($"Kiritilgan misol: {a}x² + {b}x + {c} = 0");
        WriteLine($"Ushbu misolning ildizlari: x1 = {x1}, x2 = {x2}");
}
else if (d == 0)
{
        double x = -b / (2 * a);
        WriteLine($"Kiritilgan misol: {a}x² + {b}x + {c} = 0");
        WriteLine($"Ushbu misolning bitta ildizi bor: x = {x}");
}
else
{
        WriteLine($"Kiritilgan misol: {a}x² + {b}x + {c} = 0");
        WriteLine("Ushbu misolning haqiqiy ildizlari mavjud emas.");
}