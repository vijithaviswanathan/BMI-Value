using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;


namespace levelI01
{
class Program
{
static void Main(string[] args)
{
float input1, input2;
input1 = float.Parse(Console.ReadLine()); 
input2 = float.Parse(Console.ReadLine());
Console.WriteLine(UserProgramCode.BMICalc(input1, input2));
}
}
class UserProgramCode
{
public static string BMICalc(float input1, float input2)
{
float bmi;
if (input1 <= 0 || input2 <= 0)
{
return("InvalidInput");
}
else
{
bmi = (input1 / (input2 * input2)); 
if (bmi < 18.5) return("Underweight");
else if (bmi >= 18.5 && bmi <= 24.9) return("Normalweight");
else if (bmi >= 25 && bmi <= 29.9) return("Overweight");
else if (bmi >= 30) return("Obesity");
}
return ("null");
}
}
}
