
using Quiz.Arrays.Logic;

try
{
	Console.WriteLine("ARRAY QUIZ");
	var twoDimensions = new TwoDimensions(5, 3);
	twoDimensions.Fill();
	Console.WriteLine("Two dimensions array =>");
	Console.WriteLine(twoDimensions);
	var oneDimension = twoDimensions.ToOneDimension();
	Console.WriteLine("One dimension array =>");
	Console.WriteLine(oneDimension);

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}