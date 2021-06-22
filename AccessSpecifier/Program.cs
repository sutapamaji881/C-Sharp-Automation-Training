using System;

namespace AccessSpecifier
{
    class AccessSpecifier
	{
		private int _reservedArea;
		string _identifier;
		int _power;

		public int Length;
		public int Width;

		public AccessSpecifier()
		{
			_power = 10;
			_identifier = "Default";
		}
		public int GetArea()
		{
		
			return Length * Width - _reservedArea;
		}

		private void PrintReservedArea()
		{
			Console.WriteLine($"Secret reserved area size is: {_reservedArea}");
		}

		void SecretMethod() // Private by default
		{

		}
	}


    class Program
    {
        static void Main(string[] args)
        {
			AccessSpecifier myObj = new AccessSpecifier();
            Console.WriteLine(myObj.PrintReservedArea); // "Access denied".You are allowed to change no more than two access modifiers
			Console.WriteLine(myObj.GetArea());//"Access granted"
		}
    }
}
