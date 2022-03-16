// See https://aka.ms/new-console-template for more information


    
// Console.WriteLine("Hello, World!");
// System.Console.WriteLine("Hello");


// ****************************************************

//Data type conversions exercises

// Calculate rectangle's perimeter and area.

// System.Console.Write("Enter a value for short side : ");
//     int shortSide = int.Parse(Console.ReadLine());
// System.Console.Write("Enter a value for long side : ");
//     int longSide = int.Parse(Console.ReadLine());

// Console.WriteLine($"Area is {shortSide*longSide}, Perimeter is {(shortSide+longSide)*2}");



// *************************************************************

// Strings
    // System.Console.Write("Name: ");
    // string name = Console.ReadLine();
    // System.Console.Write("SurName: ");
    // string surname = Console.ReadLine();
    // System.Console.Write("Age: ");
    // int age = int.Parse(Console.ReadLine());

    // string str = $"My name is {name} {surname} and I'm {age} years old.";
    // string format_str = string.Format("My name is {0} {1} and I'm {2} years old.",name,surname,age);

    // Console.WriteLine(str);
    // Console.WriteLine(format_str);
    

// String Methods 

    string msg = "This is Ozan.";
    System.Console.WriteLine(msg.IndexOf("O"));
    System.Console.WriteLine(msg.Length);
    System.Console.WriteLine(msg.ToLower());
    System.Console.WriteLine(msg.ToUpper());
    System.Console.WriteLine(msg.Trim());
    System.Console.WriteLine(msg.Split());
    System.Console.WriteLine(msg.Split()[1]);
    System.Console.WriteLine(msg[1]);
    System.Console.WriteLine(msg.StartsWith(" "));
    System.Console.WriteLine(msg.EndsWith(" "));
    System.Console.WriteLine(msg.Contains("O"));
    System.Console.WriteLine(msg.Substring(1,6));
    System.Console.WriteLine(msg.Substring(1));
    System.Console.WriteLine(msg.Substring(1));
    System.Console.WriteLine(msg.Replace("O","o").ToUpper());
    System.Console.WriteLine(msg.Insert(msg.Length," I am learning C#."));

    System.Console.WriteLine(msg.Remove(0,msg.Length));









