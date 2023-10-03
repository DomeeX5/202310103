using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202310103
{
	internal class Mentor : Person
	{
		private string level;

		public Mentor()
		{
			this.level = "intermediate";
		}

		public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
		{
			this.level = level;
		}

		public override string GetGoal()
		{
			return $"Educate brilliant junior software developers.";
		}

		public override string Introduce()
		{
			return $"{base.Introduce()} {level} mentor.";
		}
	}
}
