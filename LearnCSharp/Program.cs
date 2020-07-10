using System;
using System.Data.SqlTypes;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(10.0);
			Console.WriteLine($"Compute Area: {ComputeArea(square)}");
			Console.WriteLine($"Compute Area: {ComputeAreaIs(square)}");
			Rectangle rectangle = new Rectangle(10.0, 10.0);
			Console.WriteLine($"Compute Area: {ComputeArea(rectangle)}");
			Console.WriteLine($"Compute Area: {ComputeAreaIs(rectangle)}");
		}

		public static double ComputeArea(object shape)
		{
			Console.WriteLine($"ComputeArea Calculating Area for input type: {shape.GetType()}");

			if (shape is Square)
			{
				var s = (Square)shape;
				return s.Side * s.Side;
			}
			else if (shape is Circle)
			{
				var c = (Circle)shape;
				return Math.PI * c.Radius * c.Radius;
			}
			else if (shape is Rectangle)
			{
				var r = (Rectangle) shape;
				return r.Length * r.Height;
			}
			throw new ArgumentException(message: $"Given Shape of kind: {shape.GetType()} is not of type Circle or Square", paramName: nameof(shape));
		}

		public static double ComputeAreaIs(object shape)
		{
			Console.WriteLine($"ComputeAreaIs Calculating Area for input type: {shape.GetType()}");

			if (shape is Square s)
			{
				return s.Side * s.Side;
			}
			else if (shape is Circle c)
			{
				return Math.PI * c.Radius * c.Radius;
			}
			else if (shape is Rectangle r)
			{
				return r.Length * r.Height;
			}
			throw new ArgumentException(message: $"Given Shape of kind: {shape.GetType()} is not of type Circle or Square", paramName: nameof(shape));
		}




	}


	public class Square
	{
		public double Side { get; }

		public Square(double side)
		{
			Side = side;
		}
	}

	public class Circle
	{
		public double Radius { get; }

		public Circle(double radius)
		{
			Radius = radius;
		}
	}


	public struct Rectangle
	{
		public double Length { get; }
		public double Height { get; }

		public Rectangle(double lenght, double height)
		{
			Length = lenght;
			Height = height;
		}
	}

	public class Triangle
	{
		public double Base { get; }
		public double Height { get; }

		public Triangle(double @base, double height)
		{
			Base = @base;
			Height = height;
		}
	}
}
