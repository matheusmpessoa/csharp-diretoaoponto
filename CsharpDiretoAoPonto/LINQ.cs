using System;
namespace CsharpDiretoAoPonto
{
	public class LINQ
	{
		public LINQ()
		{
            #region LINQ
            // LINQ = Language-Integrated Query, sintaxe para consultas em .NET
            // Amplamente utilizado no dia a dia, extendendo a capacide de coleções como List

            var students = new List<Student>
			{
				new Student(1, "Luis", "123456789", 100),
				new Student(2, "Matheus", "827585823", 35),
				new Student(3, "Karol", "381673811", 85),
				new Student(4, "Karina", "49827833", 70),
				new Student(5, "Luis", "81731872", 75),
            };

			var any = students.Any();
			var any100 = students.Any(s => s.Grade == 100);

			var single = students.Single(s => s.Id == 1);
			// Realiza busca e existindo apenas 1, retorna
			// Se existir nenhum => excecao
			// Se existir mais de 1 => excecao

			var singleDefault = students.SingleOrDefault(s => s.Grade == 0);
			// retorna nulo se nao existir


			var first = students.First(s => s.FullName == "Luis");
			var firstOrDefault = students.FirstOrDefault(s => s.Grade == 0);

			var orderedByGrade = students.OrderBy(s => s.Grade);
			var orderedByGradeDescending = students.OrderByDescending(s => s.Grade);

			var approvedStudents = students.Where(s => s.Grade >= 70);

			var grades = students.Select(s => s.Grade);
			var phoneNumbers = students.SelectMany(s => s.PhoneNumbers);

			var sum = students.Sum(s => s.Grade);
			var min = students.Min(s => s.Grade);
			var max = students.Max(s => s.Grade);
			var count = students.Count;
			#endregion LINQ

			Console.ReadKey();
        }
    }

	public class Student
	{
		public Student(int id, string fullName, string document, int grade)
		{
			Id = id;
			FullName = fullName;
			Document = document;
			Grade = grade;

			PhoneNumbers = new List<string> { "123123123", "234234234", "345345345" };
		}

		public int Id { get; set; }
		public string FullName { get; set; }
		public string Document { get; set; }
		public int Grade { get; set; }
		public List<string> PhoneNumbers { get; set; }
    }
}
