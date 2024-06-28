using System;
namespace Assignment2
{
	public abstract class Person
	{
		private string name;
		private int age;
		private string address;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		public virtual void PrintDetails()
		{
			Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
		}

		public abstract void PerformTask();
	}

	public class Student : Person
	{
		private int stdid;

		public int StdId
		{
			get { return stdid; }
			set { stdid = value; }
		}

		public override void PerformTask()
		{
			Console.WriteLine($"My name is {Name}, My StudentID is {StdId}");
		}
	}

	public class Instructor: Person
	{
		private decimal salary;
		private string email;

		public decimal Salary
		{
			get { return salary; }
			set { salary = value; }
		}

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

        public override void PrintDetails()
        {
			Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}");
        }

        public override void PerformTask()
        {
            Console.WriteLine($"My name is {Name}, My EmailId is {Em} ,Salary: {Salary}");
        }
    }
}

