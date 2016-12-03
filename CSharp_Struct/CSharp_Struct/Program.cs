using System;

namespace CSharp_Struct
{
	/// <summary>
	/// Main class.2016.12.4
	/// </summary>
	/// 结构体
	struct Person
	{
		//public 类型 变量名
		public string name;
		public int age;
	}

	struct Point2D
	{
		public float x;
		public float y;
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person xiaoming = new Person();
			Point2D Point1;
			Point1.x = 2.5f;
			Point1.y = 1.0f;
			xiaoming.name = "小明";
			xiaoming.age = 18;
			Console.WriteLine (xiaoming.name);
			Console.WriteLine (xiaoming.age);
			Console.WriteLine ("P({0},{1})", Point1.x, Point1.y);
			Console.ReadKey ();
		}
	}
}
