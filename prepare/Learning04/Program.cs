using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment anAssignment = new Assignment("Pedro Pocho", "Music");
        Console.WriteLine(anAssignment.GetSummary());
        MathAssignment mathAssignment = new MathAssignment("Ghibli Studio", "Fractions", "Section 5.2", "Problems 1-99");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        NewWritingAssignment wAssignment = new NewWritingAssignment("Roger Waters", "Music History", "How to write The Wall");
        Console.WriteLine(wAssignment.GetSummary());
        Console.WriteLine(wAssignment.GetWritingInformation());
    }
}