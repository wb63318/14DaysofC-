// See https://aka.ms/new-console-template for more information

/// Data Types
/// string stringVar = "Hello World";
/// int intVar = 150;
/// float floatVar = 10.2f;
/// char charVar ='E';
/// bool boolVar = false;
/// int uses 4bits
///     Values And References
/// Value type = {}
/// reference type = {Classes, Arrays, objects, Interfaces, strings,}
///     Type Convertion
///Process of converting from One datatype to another
///  Implicit : smaller to larger datatypes And derived to base classes
///  Explicit : larger to smaller datatypes(possible data loss)
///  Cast : example (double to int ) Done when user is aware of data loss
///             Variable
///  Name given to storage area
///  Can be declared and initialised later
///  value must be assigned to variable before using it ELSE the will be a compiler error at runtime.
///             Constants
///  Fixed value that cannot be changed during application runtime


Console.WriteLine("Hello, World!");
Console.WriteLine($"Size of int {sizeof(int)}.");

// Implicit conversion
int num = 123456789;
long newNum = num;

Console.WriteLine(newNum);

// Cast (double to int)
double x = 1234.5;
int a = (int)x;

Console.WriteLine(a);

// Variable

string message;
message = "Hi there";

string firstName, lastName;

//Console.WriteLine(firstName);

// Constants
// Area of Circle = radius * pi * pi

const double pi = 3.14159;
double r = 5;
double area = pi * r * r; 

// {0} stands for place holder

Console.WriteLine("Area - {0}", area);


///                 Operators { symbols used to perform operations }

// Basic  Assignment {'=',}
int firstNr, secondNr;
firstNr = 10;
// assigning  constant to viriable
Console.WriteLine("First Number = {0}",firstNr);

// assigning a variable to another variable 

secondNr =  firstNr;

Console.WriteLine("First Number = {0}", secondNr);

            // Arithmetic operations

double ffirstNr = 5.4, ssecondNr = 3.25, result;
int num1 = 26, num2 = 4, reminder;

// Addition operator 
result = ffirstNr + ssecondNr;
Console.WriteLine("{0} + {1} ={2}", ffirstNr, ssecondNr, result);

// Substraction operator
result = ffirstNr - ssecondNr;
Console.WriteLine("{0} - {1} ={2}", ffirstNr, ssecondNr, result);

// Multiplication 
result = ffirstNr * ssecondNr;
Console.WriteLine("{0} * {1} ={2}", ffirstNr, ssecondNr, result);

//Division
result = ffirstNr / ssecondNr;
Console.WriteLine("{0} / {1} ={2}", ffirstNr, ssecondNr, result);


// modulo 
reminder = num1 % num2;
Console.WriteLine("{0} % {1} = {2}", num1 , num2, reminder);


// Relational Operators{ ==,> ,< ,>=,<=, !=}

bool resultt;
int firstNr1 = 10, secondNr1 = 20;

resultt = (firstNr1 == secondNr1);
Console.WriteLine("{0} == {1} returns {2}",firstNr1 , secondNr1, resultt);

resultt = (firstNr1 >  secondNr1);
Console.WriteLine("{0} > {1} returns {2}", firstNr1, secondNr1, resultt);

resultt = (firstNr1 < secondNr1);
Console.WriteLine("{0} < {1} returns {2}", firstNr1, secondNr1, resultt);

resultt = (firstNr1 >= secondNr1);
Console.WriteLine("{0} >= {1} returns {2}", firstNr1, secondNr1, resultt);

resultt = (firstNr1 <= secondNr1);
Console.WriteLine("{0} <= {1} returns {2}", firstNr1, secondNr1, resultt);

resultt = (firstNr1 != secondNr1);

Console.WriteLine("{0} != {1} returns {2}", firstNr1, secondNr1, resultt);

            // Logical Operators{Or(||),AND(&&)}

bool resultt2;
//OR operator

resultt2 = (firstNr1 == secondNr1) || (firstNr1 > 5);
Console.WriteLine(resultt2);

// AND operator
resultt2 = (firstNr1 == secondNr1) && (firstNr1 > 5);
Console.WriteLine(resultt2);

            // Unary operators{+,-,++,--,!}

int numm = 10, rslt;
bool flag = true;

rslt = +numm;
Console.WriteLine("+numm = " + rslt);

rslt = -numm;
Console.WriteLine("-numm = " + rslt);

rslt = ++numm;
Console.WriteLine("++numm = " + rslt);

rslt = --numm;
Console.WriteLine("--numm = " + rslt);

Console.WriteLine("!flag = " + (!flag));

        // Tenary Operator{if-then-else} (variable = Condition? Expression1 : Expression2; )

int nm = 10;
string rs;

rs = (nm < 0) ? "Greater" : "Not Greater";
Console.WriteLine("{0} is {1}",nm ,rs);

        // Bitwise and BitShift Operators{}

        // Compound Assignment Operators{}

int cnm = 10;

cnm +=5;
Console.WriteLine(cnm);

cnm -=3;
Console.WriteLine(cnm);

cnm *=2;
Console.WriteLine(cnm);

cnm /=3;
Console.WriteLine(cnm);

cnm %=3;
Console.WriteLine(cnm);

cnm &=10;
Console.WriteLine(cnm);

cnm |=14;
Console.WriteLine(cnm);

cnm ^=12;
Console.WriteLine(cnm);

cnm <<= 2;
Console.WriteLine(cnm);

cnm >>=3;
Console.WriteLine(cnm);


                    /// Decision statement{if,if/else, else/if,switch}
                    


