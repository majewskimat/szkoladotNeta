using System;

namespace Task11
{
    class Program
    {
        //11.Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
        //Ocena Opis
        //6 Celujący
        //5 Bardzo dobry
        //4 Dobry
        //3 Dostateczny
        //2 Dopuszczający
        //1 Niedostateczny
        //Dane testowe : 3
        //Rezultat w terminalu :
        //Dostateczny
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade:");
            int grade = int.Parse(Console.ReadLine());
            string gradeString;
            switch (grade)
            {
                case 1:
                    gradeString = "Niedostateczny";
                    break;

                case 2:
                    gradeString = "Dopuszczający";
                    break;

                case 3:
                    gradeString = "Dostateczny";
                    break;

                case 4:
                    gradeString = "Dobry";
                    break;

                case 5:
                    gradeString = "Bardzo dobry";
                    break;

                case 6:
                    gradeString = "Celujący";
                    break;

                default:
                    gradeString = "wrongGrade";
                    Console.WriteLine("You entered wrong grade");
                    break;
            }
            if (gradeString != "wrongGrade")
            {
                Console.WriteLine($"Grade: {grade}, description of the grade: {gradeString}");
            }


        }
    }
}
