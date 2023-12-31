﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202310103
{
	internal class Student : Person
	{
		private string previousOrganization;
		private int skippedDays;

		public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
		{
			skippedDays = 0;
			this.previousOrganization = previousOrganization;
		}

		public Student()
		{
			this.previousOrganization = "The School of Life";
			this.skippedDays = 0;
		}

		public override string GetGoal()
		{
			return $"Be a junior software developer.";
		}

		public override string Introduce()
		{
			return $"{base.Introduce()} from {previousOrganization} who skipped {skippedDays} days from the course already.";
		}

		public int SkipDays(int NumberOfDays)
		{
			return skippedDays += NumberOfDays;
		}
	}
}
