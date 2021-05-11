using System.Collections;
using System.IO;
using static System.Console;

namespace Lab_18_19
{
	internal class Program
	{
		public static void Main()
		{
			//1. Створити список студентів Групи КБ-11 і вивести його на екран, к-ть чоловік,
			//відсортований список і останні 10 чоловік зі списку записати у файл
			ArrayList list = new ArrayList
			{
				"Abdullaev E.J.", "Bahmut L.O.", "Bykova N.A.", "Bondarenko D.S.", "Budz A.A.", "Vavilov I.O.",
				"Gavryliuk D.L.", "Gapko G.S.", "Derkach V.K.", "Dovbyshchyk V.A.", "Kachurko P.V.", "Kyzyma V.O.",
				"Kychenok A.V.", "Kornienko E.O.", "Korol A.S.", "Krasylnyk D.S.", "Miserbiev E.A."
			};
			IEnumerator group = list.GetEnumerator();
			while (group.MoveNext())
			{
				WriteLine(group.Current);
			}

			WriteLine(new string('x', 22) + "\nAmount of students: " + list.Count);
			WriteLine(new string('x', 22));
			string[] gr10 = new string[10];
			File.AppendAllText("10.txt", new string('-', 22) + "\n");
			for (int i = list.Count - 1, a = 0; i >= list.Count - 10 && a < 10; --i, ++a)
			{
				gr10[a] = (string) list[i];
			}

			for (int i = gr10.Length - 1; i >= 0; --i)
			{
				File.AppendAllText("10.txt", gr10[i] + "\n");
			}

			//2. Данo список студентів. Приклад містить прізвище, ім'я, по батькові, рік народження,
			//курс, номер групи, оцінки з п'яти предметів. Упорядкуйте студентів за курсом, причому
			//студенти одного курсу розташовувалися в алфавітному порядку. Знайдіть середній бал кожної
			//групи по кожному предмету. Визначте найстаршого студента і наймолодшого студентів.
			//Для кожної групи знайдіть кращого з точки зору успішності студента.
			ArrayList students = new ArrayList
			{
				"Abdullaev E.J.", 2003, 1, 11, 5, 5, 5, 5, 5,
				"Bondarenko D.S.", 2003, 1, 11, 4, 4, 4, 4, 5,
				"Bahmut L.O.", 2002, 2, 21, 1, 2, 3, 1, 3,
				"Bykova N.A.", 2004, 2, 21, 4, 5, 3, 3, 2

			};
			IEnumerator sort = students.GetEnumerator();
			{
				//створення масивів оцінок
				int[] s1 = new int[5];
				int[] s2 = new int[5];
				int[] s3 = new int[5];
				int[] s4 = new int[5];

				int z1 = 4;
				int z2 = 9;
				int z3 = 5;
				int a = 0;
				//масиви оцінок першої групи
				for (int i = z1, s1i = 0; i < z2 && s1i < 5; ++i, ++s1i)
				{
					a += (int) students[i];
					s1[s1i] = (int) students[i];
				}

				int se = a / z3;
				z1 += 9;
				z2 += 9;
				int b = 0;
				for (int i = z1, s2i = 0; i < z2 && s2i < 5; ++i, ++s2i)
				{
					b += (int) students[i];
					s2[s2i] = (int) students[i];
				}

				int sd = b / z3;

				WriteLine("\n" + new string('x', 64));
				if (se > sd)
					WriteLine($"\nMarks of {students[0]} are better than marks of {students[9]}");
				else if (se < sd)
					WriteLine($"\nMarks of {students[9]} are better than marks of {students[0]}");

				z1 += 9;
				z2 += 9;
				int c = 0;
				for (int i = z1, s3i = 0; i < z2 && s3i < 5; ++i, ++s3i)
				{
					c += (int) students[i];
					s3[s3i] = (int) students[i];
				}

				int sl = c / z3;
				z1 += 9;
				z2 += 9;
				int d = 0;
				for (int i = z1, s4i = 0; i < z2 && s4i < 5; ++i, ++s4i)
				{
					d += (int) students[i];
					s4[s4i] = (int) students[i];
				}

				int sn = d / z3;

				WriteLine("\n" + new string('x', 64));
				if (sl > sn)
					WriteLine($"\nMarks of {students[18]} are better than marks of {students[27]}");
				else if (sl < sn)
					WriteLine($"\nMarks of {students[27]} are better than marks of {students[18]}");
				WriteLine("\n" + new string('x', 64) + "\n" + new string('x', 64));

				WriteLine("\n" + new string('x', 64) + "\nAverage marks of goup 11:");
				for (int i = 0; i < 5; ++i)
				{
					double abc = (s1[i] + s2[i]) / 2.0;
					Write(abc + "  ");
				}

				WriteLine("\n" + new string('x', 64) + "\nAverage marks of goup 21:");
				for (int i = 0; i < 5; i++)
				{
					double def = (s3[i] + s4[i]) / 2.0;
					Write(def + "  ");
				}

				WriteLine("\n" + new string('x', 64) + "\n" + new string('x', 64) + "\n\n" + new string('x', 64) +
				          "\n");

				int[] years = new int[4];
				for (int i = 1, x = 0; i < students.Count && x < 4; x++)
				{
					years[x] = (int) students[i];
					i += 9;
				}

				int min = years[0];
				int max = years[3];
				for (int x = 0; x < 4; ++x)
				{
					if (years[x] > min)
						min = years[x];

					if (years[x] < max)
						max = years[x];
				}

				WriteLine("The oldest one was born in " + max);
				WriteLine("The youngest one was born in " + min);
				WriteLine("\n" + new string('x', 64));
			}
		}
	}
}
