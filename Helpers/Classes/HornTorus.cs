using TorusCalc.Helpers.Interfaces;

namespace TorusCalc.Helpers.Classes
{
	public class HornTorus : ITorus
	{
		public double r { get; set; }
		public double R { get; set; }
		public double a { get; set; }
		public double b { get; set; }
		public double V { get; set; }

		public HornTorus(double r, double R)
		{
			this.r = r;
			this.R = R;

			if (ValidateType()) Console.WriteLine("Type validation: passed");

			CalculateRadii();

			V = CalculateVolume();
		}

		public void Print()
		{
			Console.WriteLine("Class: HORN Torus");
			Console.WriteLine("Dependency: r = R");

			Console.WriteLine($"r - {r} - Radius of cross-section.");
			Console.WriteLine($"R - {R} - Distance between the center of the torus to the center of the cross-section.");
			Console.WriteLine($"a - {a} - Inner radius.");
			Console.WriteLine($"b - {b} - Outer radius.");
			Console.WriteLine($"V - {V} - VOLUME.");
		}

		public double CalculateVolume()
		{
			Console.WriteLine("Calculating volume...");

			double V = 2 * Math.Pow(Math.PI, 2) * Math.Pow(r, 2) * R;
			double V_second_method = 0.25 * Math.Pow(Math.PI, 2) * Math.Pow(b - a, 2) * (b + a);

			if (V != V_second_method)
			{
				Console.WriteLine("Something went wrong. You must have entered Spindle type torus parameters (R < r)");
			}

			return V;
		}

		private void CalculateRadii()
		{
			Console.WriteLine("\n\nCalculating radii...");

			a = R - r;
			b = R + r;
		}

		public bool ValidateType()
		{
			return r == R ? true : throw new Exception("Invalid parameters for given torus type");
		}
	}
}

