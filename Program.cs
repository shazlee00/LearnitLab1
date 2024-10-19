using ClassLibrary1;

namespace LearnitLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            #region Task1
            //--------------------Task1-------------------------


            Console.WriteLine("--------------------Task1-------------------------\r\n");

            var student = new Student("Ahmed")
            {
                PhoneNumber = "0123456789"
            };

            Console.WriteLine(student.ToString());
            Console.WriteLine();



            Console.WriteLine("--------------------Task2-------------------------\r\n");

            #endregion

            #region Task2

            //------------------------Task2-----------------------
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


            #endregion

            #region Task3
            //------------------------Task3-----------------------
            Console.WriteLine("-------------------Task3-------------------------\r\n");
            D3 = D1 + D2;

            Console.WriteLine((D3).ToString());
            D3 = D3 + 666;
            Console.WriteLine((D3).ToString());
            D3++;
            Console.WriteLine(D3);
            D3 = --D2;
            Console.WriteLine(D3);

            Console.WriteLine(D1<=D2);

            #endregion
            */
            #region Task4
          // ------------------------Task4-----------------------
            Console.WriteLine("--------------------Task4-------------------------\r\n");

            //Lab4Queue();

            var exam = new Dictionary<Question, List<Answer>>();

            exam[new Question("Question 1", 1)] = new List<Answer>()
            {
                new Answer(1, "Answer 1"),
                new Answer(2, "Answer 2"),
                new Answer(3, "Answer 3"),
                new Answer(4, "Answer 4")
            };
        exam[new Question("Question 2", 1)] = new List<Answer>()
            {
                new Answer(1, "Answer 1"),
                new Answer(2, "Answer 2"),
                new Answer(3, "Answer 3"),
                new Answer(4, "Answer 4")
            };
            exam[new Question("Question 3", 1)] = new List<Answer>()
            {
                new Answer(1, "Answer 1"),
                new Answer(2, "Answer 2"),
                new Answer(3, "Answer 3"),
                new Answer(4, "Answer 4")
            };

            foreach (var question in exam.Keys)
            {
                Console.WriteLine(question);
                foreach (var answer in exam[question])
                {
                    Console.WriteLine(answer);
                }
                Console.WriteLine("---------------------------------------");
            }





            #endregion








        }

        public static void Lab4Queue()
        {

            var q = new Queue<int>(5);

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(5);
            q.Enqueue(5);

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
        }

    }
}
