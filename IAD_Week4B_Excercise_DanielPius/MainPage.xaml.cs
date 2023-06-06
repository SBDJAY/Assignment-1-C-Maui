namespace IAD_Week4B_Excercise_DanielPius;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		//Polygon Constructor method 
        Polygon polygon = new Polygon();

		polygon.SideLength = 4;
		polygon.NumerOfSides = 10;

		//Shapes Object Initializer
		Polygon triangle = new Polygon()
		{

		};

		Polygon square = new Polygon()
		{

		};

		Polygon pentagon = new Polygon()
		{

		};
    }
}


