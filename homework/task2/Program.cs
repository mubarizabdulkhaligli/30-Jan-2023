using System;

namespace task2
{
	class Program
	{
		static void Main(string[] args)
		{
			Student[] students = new Student[0];
			string click;
			
			do
			{
				Console.WriteLine("1. View all students");
				Console.WriteLine("2. Search on students");
				Console.WriteLine("3. Add student");
				Console.WriteLine("0. Exit menu");

				click = Console.ReadLine();


				if (click == "1")
				{
					if (students.Length == 0)
					{
						Console.WriteLine("There are no students");
					}

					foreach (var student in students)
					{
						Console.WriteLine($"Student: {student.FullName} - GroupNo: {student.GroupNo}");
					}
				}

				if (click == "2")
				{
					Console.WriteLine("Enter the value: ");
					string WantedValue = Console.ReadLine();

					if (students.Length == 0)
					{
						Console.WriteLine("There are no students");
					}

					int count = 0;
					foreach (var student in students)
					{
						if (student.FullName.Contains(WantedValue) || student.GroupNo.Contains(WantedValue))
						{
							Console.WriteLine($"Student: {student.FullName} - GroupNo: {student.GroupNo}");
						}
						else
						{
							count++;

							if (count==students.Length)
							{
								Console.WriteLine("There are no results matching your search");
							}
						}
					}
				}

				if (click == "3")
				{
					Student student1 = new Student();

					do
					{
						Console.WriteLine("Enter fullname (Fullname must contains just letters): ");
						student1.FullName = Console.ReadLine();
					}
					while (!IsFullName(student1.FullName));
					do
					{
						Console.WriteLine("Enter the Group No (Group number must contain 4 characters. " +
						"The first character must be an uppercase letter and the others must be a number.) : ");
						student1.GroupNo = Console.ReadLine();

					} while (!IsGroupNo(student1.GroupNo));

                            Array.Resize(ref students, students.Length + 1);

                            students[students.Length - 1] = student1;

                            Console.WriteLine("The student added");
				}
			} while (click != "0");

			if (click == "0")
			{
				Console.WriteLine("You have exited the menu");
			}
		}

		static bool IsFullName(string fullname)
		{
			if (string.IsNullOrWhiteSpace(fullname))
				return false;

			for (int i = 0; i < fullname.Length; i++)
			{
				if (char.IsDigit(fullname[i]))
				{
					return false;
				}
			}
			return true;
		}

		static bool IsGroupNo(string groupNo)
		{
			if(string.IsNullOrWhiteSpace(groupNo))
				return false;

			if (groupNo.Length!=4)
			{
				return false;
			}

			for (int i = 0; i < groupNo.Length; i++)
			{
				if (!char.IsUpper(groupNo[0]))
					return false;
			}
			for (int i = 1; i < groupNo.Length; i++)
			{
				if (!char.IsDigit(groupNo[i]))
					return false;
			}
			return true;
		}
	}
}

