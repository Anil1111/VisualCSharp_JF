///Write a console-based program for a college’s admissions
///office. The user enters a numeric high school grade point
///average (for example, 3.2) and an admission test score.
///Display the message “Accept” if the student meets either 
///of the following requirements: 
///• A grade point average of 3.0 or higher and an admission test
///score of at least 60 
///• A grade point average of less than 3.0 and an admission test 
///score of at least 80 
///If the student does not meet either of the qualification
///criteria, display “Reject”. Save the program as Admission.cs.

using System;

namespace Admission
{
	class Program
	{
		static void Main(string [] args)
		{
			//Define variables
			const double GPA_REQUIRE = 2.9;
			const int ADMISSION_MIN = 59;
			const int ADMISSION_MAX = 79;

			//Get GPA
			Console.Write("Enter your High School GPA:  ");
			string gpaEntry = Console.ReadLine();
			double gpa = Convert.ToDouble(gpaEntry);

			//Get test score
			Console.Write("Enter admisson test score:  ");
			string testEntry = Console.ReadLine();
			int testScore = Convert.ToInt32(testEntry);

			//Check qualifications
			if (gpa > GPA_REQUIRE)
				if(testScore > ADMISSION_MIN)
					Console.WriteLine("Acceptd");
			if(gpa < GPA_REQUIRE)
				if(testScore > ADMISSION_MAX)
					Console.WriteLine("Accepted");
			else
					Console.WriteLine("Rejected");
		}
	}
}
