namespace UnitTesting
{
    public class Employee
    {
        public int Age { get; set; }

        public bool IsSenior(int age)
        {
            return age >= 60;
        }
    }
}
