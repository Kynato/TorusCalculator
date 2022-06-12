using System;
namespace TorusCalc.Helpers.Interfaces
{
	public interface ITorus
	{
		public double r { get; set; }
		public double R { get; set; }
		public double a { get; set; }
		public double b { get; set; }
		public double V { get; set; }

		public void Print();
		public double CalculateVolume();
		public bool ValidateType();
	}
}

