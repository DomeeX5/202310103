using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202310103
{
	internal class Cohort
	{
		private string name;
		private List<Student> students;
		private List<Mentor> mentors;

		public Cohort(string name)
		{
			this.name = name;
			this.students = new List<Student>();
			this.mentors = new List<Mentor>();
		}

		public void AddStudent(Student student)
		{
			this.students.Add(student);
		}

		public void AddMentor(Mentor mentor)
		{
			this.mentors.Add(mentor);
		}

		public string Info()
		{
			return $"The {name} cohort has {students.Count} students and {mentors.Count()} mentors.";
		}
	}
}
