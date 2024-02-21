/////pattern problem/////
//for (int i = 1; i <= 3; i = i + 2)
//{
//    for (int j = i; j <= 4; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 1; k <= i; k++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}
//for (int i = 1; i <= 3; i = i + 2)
//{
//    for (int j = i; j <= 4; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 1; k <= i; k++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}
//for (int i = 1; i <= 1; i = i + 2)
//{
//    for (int j = i; j <= 4; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 1; k <= i; k++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}


//for(int i = 1; i <= 3; i = i + 2)
//{
//    for(int j = i; j <= 4; j++)
//    {
//        Console.WriteLine("");
//    }
//    for(int k=1; k <= i; k++)
//    {
//        Console.WriteLine("* ");
//    }
//}

//Console.ReadKey(true);



/////swaping number/////
//Console.Write("Enter 1st number:");
//int num1=Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter your 2nd number:");
//int num2=Convert.ToInt32(Console.ReadLine());
//int num3 = num1;num1= num2;num2 = num3;
//Console.WriteLine($"swaping 1st number: {num1} and 2nd number swaping: {num2}");




////te a program to display area of 4 walls///
//float i, b, area;
//Console.WriteLine("Enter the lenght");
//i=float.Parse(Console.ReadLine());
//b=float.Parse(Console.ReadLine());
//area = i * b;
//Console.WriteLine("Area of wall is: " + area);






////মোট পৃষ্ঠের ক্ষেত্রফল এবং ঘনক্ষেত্রের আয়তন প্রদর্শনের জন্য একটি প্রোগ্রাম লিখুন///
////write a program to display total surface area and volume of cuboid///

//float i, b, h, area, vol;
//Console.Write("Enter the lenght : ");
//i=float.Parse(Console.ReadLine());
//b=float.Parse(Console.ReadLine());
//h=float.Parse(Console.ReadLine());
//area = 2 * (i * b + b * h + h * i);
//vol = i * b * h;
//Console.WriteLine("Total surface area is: " + area);
//Console.WriteLine("volume of cuboid is: " + vol);





//uppercase to lowercase////
//Console.Write("Enter Lower case:");
//string lower = Convert.ToString(Console.ReadLine());
//Console.WriteLine(lower.ToUpper());

//Console.Write("Enter upper case:");
//string upper = Convert.ToString(Console.ReadLine());
//Console.WriteLine(upper.ToLower());









//Console.Write("Enter Number:");
//int num = Convert.ToInt32(Console.ReadLine());
//int a = 10;
//for (int i = 0; i <= a; i++)
//{
//    Console.WriteLine(a * i);
//}




//Console.Write("Enter any year: ");
//int year = Convert.ToInt32(Console.ReadLine());
//if (year % 4 == 0 && year %100 ==0 )
//{
//    Console.WriteLine("leap year");
//}
//else if (year % 100 == 0)
//{
//    Console.WriteLine("not a leap year");
//}
//else if (year % 400 == 0)
//{
//    Console.WriteLine("Leap year");
//}
//else
//{
//    Console.WriteLine("not a leap year");
//}




/////namota problem/////
//Console.Write("Enter number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//for(int i = 1; i <=10; i++)
//{
//    Console.WriteLine($"{num} X {i}={num * i}");
//}



//Console.Write("Enter the number:");
//int num=Convert.ToInt32(Console.ReadLine());
//for(int i = 1;i <= 10; i++)
//{
//    Console.WriteLine($"{num}X{i}={num*i}");
//}








//Console.Write("Enter your problem: ");
//string num1 = Console.ReadLine();
//string num2 = num1.Replace(")(", ")*(");
//var ToDataTable = new DataTable();
//ToDataTable.Columns.Add("sum", typeof(double), num2);
//ToDataTable.Rows.Add(0);
//double a = (double)(ToDataTable.Rows[0]["sum"]);
//Console.WriteLine("Your result is : " + a);
//Console.ReadKey();



//Console.WriteLine("Enter the problem:");
//string num1=Console.ReadLine();
//string num2 = num1.Replace(")(", ")*(");
//var ToDataTable = new DataTable();
//ToDataTable.Columns.Add("sum", typeof(double), num2);
//ToDataTable.Rows.Add(0);
//double a = (double)(ToDataTable.Rows[0]["sum"]);
//Console.WriteLine("your result is: " + a);






//int row, column, j = 5, i = 0;

//for (row = 0; row <= 6; row++)
//{
//    for (column = 0; column <= 6; column++)
//    {
//        if (column == 1 || ((row == column + 1) && column != 0))
//            Console.Write("*");

//        else if (row == i && column == j)
//        {
//            Console.Write("*");
//            i = i + 1;
//            j = j - 1;
//        }
//        else
//            Console.Write(" ");
//    }
//    Console.Write("\n");
//}
//Console.Write("\n");
//Console.ReadKey(true);
