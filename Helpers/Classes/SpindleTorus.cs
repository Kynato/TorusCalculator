using TorusCalc.Helpers.Interfaces;

namespace TorusCalc.Helpers.Classes
{
	public class SpindleTorus: ITorus
	{
		public double r { get; set; }
		public double R { get; set; }
		public double a { get; set; }
		public double b { get; set; }
		public double V { get; set; }

		public SpindleTorus(double r, double R)
		{
			this.r = r;
			this.R = R;

			if (ValidateType()) Console.WriteLine("Type validation: passed");

			CalculateRadii();

			V = CalculateVolume();
		}

		public void Print()
        {
			Console.WriteLine("Class: SPINDLE Torus");
			Console.WriteLine("Dependency: r > R");

			Console.WriteLine($"r - {r} - Radius of cross-section.");
			Console.WriteLine($"R - {R} - Distance between the center of the torus to the center of the cross-section.");
			Console.WriteLine($"a - {a} - Inner radius.");
			Console.WriteLine($"b - {b} - Outer radius.");
			Console.WriteLine($"V - {V} - VOLUME.");
        }

		public double CalculateVolume()
        {
			Console.WriteLine("Calculating volume...");
			double V = (2 / 3) * Math.PI * (2 * Math.Pow(r, 2) + Math.Pow(R, 2)) * Math.Sqrt(Math.Pow(r, 2) - Math.Pow(R, 2)) + Math.PI * Math.Pow(r, 2) * R * (Math.PI + 2 * Math.Atan(R / Math.Sqrt(Math.Pow(r, 2) - Math.Pow(R, 2))));

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
			return r > R ? true : throw new Exception("Invalid parameters for given torus type");
		}
	}
}

