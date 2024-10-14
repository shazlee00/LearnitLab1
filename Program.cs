using ClassLibrary1;

namespace LearnitLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*--------------------Task1-------------------------*/


            Console.WriteLine("/*--------------------Task1-------------------------*/\r\n");

            var student = new Student("Ahmed")
            {
                PhoneNumber = "0123456789"
            };

            Console.WriteLine(student.ToString());
            Console.WriteLine();



            Console.WriteLine("/*--------------------Task2-------------------------*/\r\n");



            /*------------------------Task2-----------------------*/
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());
            //Output: Hours: 1, Minutes: 10 , Seconds: 15
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());
            // Output: Hours: 1, Minutes: 0 , Seconds: 0
            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());
            // Output: Hours: 2, Minutes: 10 , Seconds: 0
            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());
            // Output: Minutes
        }
    }
}
