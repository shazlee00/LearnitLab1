namespace ClassLibrary1
{
    public class Student(string name)
    {
        public string Name { get; set; } = name;


        public string PhoneNumber { get; init; }
        

        public override string ToString()
        {
            return $"Name: {Name}, PhoneNumber: {PhoneNumber}";
        }

    }
}
