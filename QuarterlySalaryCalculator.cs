﻿namespace Dependencies.Services
{
	public class QuarterlySalaryCalculator : ISalaryCalculator
	{
		public Double CalculateSalary(Double yearlyAmount)
		{
			return yearlyAmount / 4;
		}
	}
}
