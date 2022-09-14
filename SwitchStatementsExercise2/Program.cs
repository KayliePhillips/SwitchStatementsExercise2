//Ask user for their favorite school subject.

Console.WriteLine("What is your favorite school subject?");
var userInput = Console.ReadLine();

switch (userInput.ToLower())
{
	case "math":
		Console.WriteLine("Math is lots of fun!");
		break;
	case "english":
		Console.WriteLine("English is a good thing to master.");
		break ;
	case "science":
		Console.WriteLine("Science can be challenging but fun.");
		break;
	case "PE": 
	case "gym":
		Console.WriteLine("Who doesn't love gym class");
		break;
	default:
		Console.WriteLine("School is fun!");
		break;
}
