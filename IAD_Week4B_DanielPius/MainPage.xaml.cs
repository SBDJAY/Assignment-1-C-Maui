namespace IAD_Week4B_DanielPius;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

		Student student = new Student(); // THIS IS A CONSTRUCTOR METHOD 
		student.Name = "";
		student.SetGpa(-3.62);

		student.Email = "sbdjay183@gmail.com";
		//^^If you run this code, and Email is empty and does not have a @ symbol, the code will break^^

		string college = student.CollegeName;
		//Student.CollegeName = "";
		//^^This will not work becasue the college string variable is read only and cannot be changed"^^

		student.Address = "123 Plagrnd stret";


        string s;
        //^^ If you not use the syntax above it will be an empty string^^


        //This is a Constructor method it used to help intialize objects 
        Student anotherStudent = new Student()
		{
			Name = "Daniel",
			Address = "ABC",
			Email = "sbdjay183@gmail.com",
			
		};

		//List Ex1
		//List<Student> students = new List<Student>();
		//students.Add(student);
		//students.Add(anotherStudent);

		//List Ex2
		//List<Student> students1 = new List<Student>
		//{
		//	student, anotherStudent

		//};

		//Use this version of the List constructor for the Assigment 1 Products
		List<Student> students = new List<Student>
		{
			new Student
			{
				Name = "stacy"
			},
			new Student
			{
				Name = "Daniel"
			}
		};

    }
}


