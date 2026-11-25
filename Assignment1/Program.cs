using System;

// ===================== Q1 =====================
// Create a Book class with a Title (string) and Pages (int).
// Create a Book object and store it in a variable of type object. Print it.
//{
//    object obj = new Book { Title = "Clean Code", Pages = 464 };
//    Console.WriteLine(obj);   // prints "Book" (the class name) because ToString() is not overridden
//}

// ===================== Q2 =====================
// Using the Book class above, print the result of calling ToString(), Equals()
// (compare book with itself), GetHashCode(), and GetType() on book.
{
    Book book = new Book { Title = "Clean Code", Pages = 464 };
    Console.WriteLine(book.ToString());
    Console.WriteLine(book.Equals(book));   // True
    Console.WriteLine(book.GetHashCode());
    Console.WriteLine(book.GetType());      // Book
}

// ===================== Q3 =====================
// Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
// int pages = "464";
// Answer: Compile-time error — you can't put text (string) into an int variable.
{
    int pages = 464;
    Console.WriteLine(pages);
}

// ===================== Q4 =====================
// Write code that divides 10 by 0 inside a try block, catches the exception,
// prints "Cannot divide by zero", and then prints "Done" in a finally block.
{
    int zero = 0;   // a variable is used, because dividing by a literal 0 is a compile-time error
    try
    {
        int result = 10 / zero;
        Console.WriteLine(result);
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero");
    }
    finally
    {
        Console.WriteLine("Done");
    }
}

// ===================== Q5 =====================
// Declare an int pages = 300; then store it in a double variable without using a cast.
{
    int pages = 300;
    double pagesDouble = pages;   // implicit conversion (int -> double, no data loss)
    Console.WriteLine(pagesDouble);
}

// ===================== Q6 =====================
// Declare a double price = 49.99; then convert it into an int using a cast.
{
    double price = 49.99;
    int priceInt = (int)price;    // explicit cast, the decimal part is cut off -> 49
    Console.WriteLine(priceInt);
}

// ===================== Q7 =====================
// Given string pagesText = "464";, convert it into an int using the Convert class.
{
    string pagesText = "464";
    int pages = Convert.ToInt32(pagesText);
    Console.WriteLine(pages);
}

// ===================== Q8 =====================
// Given string yearText = "2023";, convert it using int.Parse().
// Then given string badText = "abc";, use int.TryParse() to safely try converting it,
// and print "Invalid number" if it fails.
{
    string yearText = "2023";
    int year = int.Parse(yearText);
    Console.WriteLine(year);

    string badText = "abc";
    if (!int.TryParse(badText, out int number))
    {
        Console.WriteLine("Invalid number");
    }
    else
    {
        Console.WriteLine(number);
    }
}

// ===================== Q9 =====================
// Given int pages = 464;, convert it into a string using ToString()
// and print its type using GetType() to prove it's now a string.
{
    int pages = 464;
    string pagesString = pages.ToString();
    Console.WriteLine(pagesString);
    Console.WriteLine(pagesString.GetType());   // System.String
}

// ===================== Q10 =====================
// Declare int copies = 100;. Box it into an object variable,
// then unbox it back into a new int variable, and print both.
{
    int copies = 100;
    object boxed = copies;          // boxing
    int unboxed = (int)boxed;       // unboxing
    Console.WriteLine(boxed);
    Console.WriteLine(unboxed);
}

// ===================== Q11 =====================
// Declare an int? year = null;. Print whether it has a value,
// then assign it 2023 and print its value.
{
    int? year = null;
    Console.WriteLine(year.HasValue);   // False
    year = 2023;
    Console.WriteLine(year.Value);      // 2023
}

// ===================== Q12 =====================
// Declare a string? reviewer = null;. Print whether it is null.
{
    string? reviewer = null;
    Console.WriteLine(reviewer == null);   // True
}

// ===================== Q13 =====================
// Declare a Book? book = null;. Use ?. to safely read book.Title
// without crashing the program, and print the result.
{
    Book? book = null;
    Console.WriteLine(book?.Title);   // prints an empty line (null), no crash
}

// ===================== Q14 =====================
// Using title from the previous question, use ?? to print "Untitled" if title is null.
// Then use ??= to assign title the value "Untitled" only if it's still null.
{
    Book? book = null;
    string? title = book?.Title;      // title is null here

    Console.WriteLine(title ?? "Untitled");   // Untitled

    title ??= "Untitled";                     // assigns only if title is null
    Console.WriteLine(title);                 // Untitled
}

// ===================== Q15 =====================
// Given string? name = "Ahmed"; (you are sure it's not null here),
// assign it to a non-nullable string confirmedName using the ! operator.
{
    string? name = "Ahmed";
    string confirmedName = name!;   // ! tells the compiler "I'm sure it's not null"
    Console.WriteLine(confirmedName);
}

class Book
{
    public string Title { get; set; } = "";
    public int Pages { get; set; }
}
