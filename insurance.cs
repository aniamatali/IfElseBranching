using System;

class Temperature
{
    static void Main()
    {
      Console.WriteLine("Whats the temp?");
      string InputTemp = Console.ReadLine();

      int intInputTemp = int.Parse(InputTemp);

      bool cold = intInputTemp <= 50;
      bool hot = intInputTemp >= 51;

      if (cold)
      {
        Console.WriteLine("Wear a sweater");
      }
      else if (hot)
      {
        Console.WriteLine("Dont wear a sweater");
      }
    }
}


// using System;
//
// class Grades
// {
//   static void Main()
//   {
//     Console.WriteLine("What was your last grade?");
//     string inputGrade = Console.ReadLine();
//
//     bool a = inputGrade == "a";
//     bool b = inputGrade == "b";
//     bool c = inputGrade == "c";
//     bool d = inputGrade == "d";
//     bool f = inputGrade == "f";
//
//     if (a || b)
//     {
//       Console.WriteLine("Good job");
//     }
//     else if (c || d)
//     {
//       Console.WriteLine("okay job");
//     }
//     else
//     {
//       Console.WriteLine("bad job");
//     }
//     }
//   }



// using System;
//
// class Insurance
// {
//   static void Main()
//   {
//     Console.WriteLine("What is your gender? (male/female)");
//     string gender = Console.ReadLine();
//
//     Console.WriteLine("How old are you?");
//     string stringAge = Console.ReadLine();
//     int age = int.Parse(stringAge);
//
//     bool young = age < 26;
//     bool male = gender == "male";
//
//     if (!(young && male)) {
//       Console.WriteLine("Your insurance is going to be expensive, but it could be worse.");
//     } else {
//       Console.WriteLine("your insurance is going to be expensive!");
//       }
//     }
//   }
