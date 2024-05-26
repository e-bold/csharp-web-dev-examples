using System;
namespace TemperatureExample
{
	public class Temperature
	{
        private double fahrenheit;
        public const double ABSOLUTE_ZERO_FAHRENHEIT = -459.67;
        public static double absoluteZeroFahrenheit { get; } = -459.67;

        public double Fahrenheit
        {
            get
            {
                return fahrenheit;
            }
            set
            {

                if (value < absoluteZeroFahrenheit)
                {
                    throw new ArgumentOutOfRangeException("Value is below absolute zero");
                }

                fahrenheit = value;
            }
        }
    }
}

