using System.Security.Principal;

var number1 = 50;
var number2 = 10;

if (number1 > number2)
{
    Console.WriteLine($"Liczba {number1} jest większa od liczby {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"Liczba {number1} jest mniejsza od liczby {number2}");
}
else
{
    Console.WriteLine($"Liczba {number1} jest równa liczbie {number2}"); ;
}




// Operatory relacyjne
// ==
// !=
// >
// <
// >=
// <=

// Operatory logiczne
// && (i)
// || (lub)
// ! (negacja)

var name = "Jan";
var age = 30;

if (name == "Jan" && age >= 18)
{
    Console.WriteLine("Jan jest pełnoletni.");
}
else if (name == "Jan" && age < 18)
{
    Console.WriteLine("Jan jest niepełnoletni.");
}

else if (name != "Jan" && age >= 18)
{
    Console.WriteLine("To nie jest Jan, ale ktoś pełnoletni");
}
else if (name != "Jan" && age < 18)
{
    Console.WriteLine("To nie jest Jan, ale ktoś niepełnoletni");
}

if (age >= 18)
{
    if (name == "Jan")
    {
        Console.WriteLine("Jan jest pełnoletni.");
    }
    else
    {
        Console.WriteLine("To nie jest Jan, ale ktoś pełnoletni");
    }
}


