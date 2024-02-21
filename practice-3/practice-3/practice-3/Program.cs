


//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());

//Console.WriteLine("A=" + a);
//Console.WriteLine("B=" + b);
//Console.WriteLine();
//Console.WriteLine("A+B=" + (a + b));
//Console.WriteLine("A-B+" + (a - b));
//Console.WriteLine("A*B+" + (a * b));
//Console.WriteLine();


Console.Write("Enter your 1st number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your 2nd number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your 3rd number: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your ans is: 6 + 9 * 4 =" + (a + b * c));
Console.ReadKey(true);
Console.WriteLine();




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
//Console.ReadKey(true);



////ractangle Area//
//Console.Write("Enter your height :");
//double height=Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter your height :");
//double width = Convert.ToDouble(Console.ReadLine());
//double area=width*height;
//Console.WriteLine("Area=" +area);



/////bool/////
//if (true)
//{
//    Console.WriteLine("a");
//}
//if (false)
//{
//    Console.WriteLine("b");
//}
//bool varName = true;
//if (varName)
//{
//    Console.WriteLine ("C");
//}



//int age = 14;
//if (age >= 21)
//{
//    Console.WriteLine("Adult");
//}
//else if (age < 18)
//{
//    Console.WriteLine("Child");
//}







//Console.Write("Enter your number: ");
//int score=Convert.ToInt32(Console.ReadLine());
//if(score>=0&& score <= 50)
//{
//    Console.WriteLine("Low");
//}
//else if(score>=51&& score <= 75)
//{
//    Console.WriteLine("Medium");
//}
//else if (score >= 76 && score <= 100)
//{
//    Console.WriteLine("high");
//}
//else
//{
//    Console.WriteLine("Invalid");
//}



//Console.Write("Enter your number: ");
//int number = Convert.ToInt32(Console.ReadLine());
//string color = Convert.ToString(Console.ReadLine());
//switch (number)
//{
//    case 1:
//        color= "red";
//        break;
//     case 2:
//        color= "Blue";
//        break;
//    case 3:
//        color= "Yellow";
//        break;

//}
//Console.WriteLine(color);




////while loop///
//int num = 1;
//while (num <= 10)
//{
//    Console.Write(num + " ");
//    num++;
//}


//int num = 1;
//while(num < 5){
//    Console.Write(num + " ");
//}



////do while loop////
//int num = 14;
//do
//{
//    Console.WriteLine(num + " ");
//    num++;
//}
//while (num < 10);


/////for loop////
//for(int i = 1; i <= 10;i++)
//{
//    Console.WriteLine(i);
//}


/////break and continue/////
//int sum = 0;
//for (int i = 1; i <= 10; i++)
//{
//    if (sum >= 30)
//    {
//        break;
//    }
//    sum += i;
//}
//Console.WriteLine(sum);


//int sum = 0;
//for (int i = 1; i <= 10; i++)
//{
//    if (sum > 15)
//    {
//        break;
//    }
//    sum += i;
//}
//Console.WriteLine(sum);



//for(int i = 1; i <=6; i++)
//{
//    if(i == 4)
//    {
//        continue;
//    }
//    Console.WriteLine(i + " ");
//}


/////nested for loop////
//for (int i = 1; i <=6; i++)
//{
//    for (int j = 1; j <=6; j++)
//    {
//        Console.WriteLine(i +" "+j);
//    }
//} 




//int width = 5;
//int height = 5;
//int heightIndex = 0;
//while (heightIndex < height)
//{
//    int widthIndex = 0;
//    while (widthIndex < width)
//    {
//        Console.Write("* ");
//        widthIndex++;
//    }
//    Console.WriteLine();
//    heightIndex++;
//}



//int a = 0;
//int b= 0;
//Console.WriteLine(a++ + "" + ++b);
//Console.WriteLine(b + "" + b);

