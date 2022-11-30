using Operator;

//Exercise 1

//Create 2 integer variables
//Use these variables:
//int a = 17;
//int b = 4;
//Create 2 more integer variables
//Use these variables:
//int quotient = a / b;
//int remainder = a % b;
//Use an if statement:
//if (a == 17 && b == 4)
//  Write out the results in the following form: 
//17 / 4 is 4 remainder 1
//Use string interpolation 
//Stay inside the Main() method’s scope 







int a = 17;
int b = 4;
int quotient = a / b;
int remainder = a % b;

if (a == 17 && b == 4)
{
    Console.WriteLine($"{a} / {b} is 4 remainder 1");
}








//    Exercise 2

//Create a method that will Calculate the area of a circle based on its radius - you can name the method AreaOfCircle. Finish all the steps below
//Allow a user to input a value for radius in the console using the following code:
//Type Console.WriteLine(“What is the radius of your circle ?”);
//Type var radius = double.Parse(Console.ReadLine());
//Outside the scope of the Main() method, declare the AreaOfCircle method:
//Make this method public & static
//This method will use this formula: (Math.PI * radius * radius)
//This method’s return type is of type double
//This method will have 1 parameter of type double called radius
//Once you have successfully declared your method
//Call this method inside the scope of the Main() method
//Make sure you pass in the radius variable from earlier


Console.WriteLine("Choose a number that represents the radius of your circle.");

var radius = double.Parse(Console.ReadLine());

var area = Methods.AreaOfACircle(radius);

Console.WriteLine($"The are of your circle is {area}");
    