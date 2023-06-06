using System;
namespace IAD_Week4B_DanielPius
{
	public class Student
	{
		//public variable not good becasue they can be viewd by other classes
		public String Name;
		private double _gpa;

		// Getter and setter are public so they can be accesed by other classes
		public void SetGpa(double value)
		{
			if (value < 0 || value > 4)
			_gpa = value;
		}

		public double GetGpa()
		{
				return _gpa;
		}

		//full property there is a get and set implementation 
		private string _email;		//FOR PRIVATE VARIABLES USE _ and lowercase BEFORE THE NAME EX: _name
		public string Email			//FOR PUBLIC VARIABLES USE FIRST LETTER UPPER CASE EX: Name
		{
			get
			{
				return _email;
			}

			set
			{
				// The todo function makes it highlighted as an important message
				//todo : add validation
				if (value == "")
					throw new Exception();
				if (!value.Contains('@'))
					throw new Exception();


				_email = value;
			}
		}
		// Even with a getter without a setter or either/ or it cant be a full property therfore this is a Full (readonly) property
		public string CollegeName
		{
			get
			{
				return "Sheridan College";

			}
		}


		// This part of code will not work becasue in the getter you are returning the property "Address" so you get a recursion (Method Calling itself)
		
		//public string Address
		//{
		//	get
		//	{
		//		return Address;

		//	}

		//	set
		//	{
		//		Address = value;
		//	}
		//}

		// Auto Property
		//todo for the assignemnt use autoproperty on the Product class, refer to Assignemnt 1 
		public string Address { get; set; }

		public string Phone { get; set; }


		
	}
}

