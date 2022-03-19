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

    // string msg = "This is Ozan.";
    // System.Console.WriteLine(msg.IndexOf("O"));
    // System.Console.WriteLine(msg.Length);
    // System.Console.WriteLine(msg.ToLower());
    // System.Console.WriteLine(msg.ToUpper());
    // System.Console.WriteLine(msg.Trim());
    // System.Console.WriteLine(msg.Split());
    // System.Console.WriteLine(msg.Split()[1]);
    // System.Console.WriteLine(msg[1]);
    // System.Console.WriteLine(msg.StartsWith(" "));
    // System.Console.WriteLine(msg.EndsWith(" "));
    // System.Console.WriteLine(msg.Contains("O"));
    // System.Console.WriteLine(msg.Substring(1,6));
    // System.Console.WriteLine(msg.Substring(1));
    // System.Console.WriteLine(msg.Substring(1));
    // System.Console.WriteLine(msg.Replace("O","o").ToUpper());
    // System.Console.WriteLine(msg.Insert(msg.Length," I am learning C#."));

    // System.Console.WriteLine(msg.Remove(0,msg.Length));


// Arrays

    // string message =  "This is an array list.";
    // var result = message.Split();
    // System.Console.WriteLine(message.Split());
    // System.Console.WriteLine(result[0]);
    // System.Console.WriteLine(result[1]);
    // System.Console.WriteLine(result[2]);
    // System.Console.WriteLine(result[3]);
    // System.Console.WriteLine(result[4]);


    // int[] list = new int[4];

    // list[0] = 102;
    // list[1] = 11;
    // list[2] = 4;
    // list[3] = 54;

    // Console.WriteLine($"Banana {list[0]} Euro, Apple is {list[1]}Euro");
    

    // string[] names = {"Ozan","James","Kobe","Hank"};

    // Console.WriteLine($"1st: {names[0]}");
    // Console.WriteLine($"2nd: {names[1]}");
    // Console.WriteLine($"3rd: {names[2]}");
    // Console.WriteLine($"4th: {names[3]}");
    
    // int[] points = {80,70,90,75,60,37};
    // Console.WriteLine(points[0]);
      
    //   ******************************************

// Array Methods

    string[] names = {"Ozan","Mert","Yigit","Ahmet","Eylul"};
    
    names.SetValue("Ceren",0);
    // Console.WriteLine(names.GetValue(1));
    // Array.Sort(names);
    // Console.WriteLine(names[0]);
    // Console.WriteLine(names[^1]);
    // Console.WriteLine(names[1]);
    // Array.Reverse(names);
    // Console.WriteLine(names[names.Length-1]);
    
    // Console.WriteLine(Array.IndexOf(names,"Eylul"));
    // string[] actors = names[..];

    //     foreach (var name in names[..])
    //     {
    //         Console.WriteLine($"{name}");
             
    //     }

        // foreach(var actor in actors){
        //         Console.WriteLine(actor);
        // }

    // string msg = "Hello There!";
    // Console.WriteLine(msg[0..7]);
    
// ************************************************


// DateTime

    // DateTime newDate = DateTime.Now;
    // System.Console.WriteLine(newDate);

    // System.Console.WriteLine(newDate.Year);
    // System.Console.WriteLine(newDate.Month);
    // System.Console.WriteLine(newDate.Second);
    // System.Console.WriteLine(newDate.DayOfWeek);


// ARITHMETIC OPERATORS

// int a = 50;
// int b = 10;
// int c = a + b;
// c++;
// ++c;
// --c;
// System.Console.WriteLine(c);
// Console.WriteLine(a*b);
// Console.WriteLine(a+b);
// Console.WriteLine(a-b);
// Console.WriteLine(a/b);
// Console.WriteLine(a%b);

























