using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _202310103
{
	internal class Sponsor : Person
	{
		private string company;
		private int hiredStudents;

		public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
		{
			this.company = company;
			hiredStudents = 0;
		}

		public Sponsor()
		{
			this.company = "Google";
		}

		public override string Introduce()
		{
			return $"{base.Introduce()} who represents {company} and hired {hiredStudents} students so far.";
		}

		public int Hire()
		{
			return hiredStudents++;
		}

		public override string GetGoal()
		{
			return $"Hire brilliant junior software developers.";
		}
	}
}
