using System;
namespace IAD_Week4B_Excercise_DanielPius
{
	public class Polygon
	{

       
        //Auto Porperty for Number of Sides
        public int NumerOfSides { get; set; }

        
        //Fullproperty for side legnth 
        private double _sideLength;
        public double SideLength
        // Getter and Setter 
        {
            get
            {
                return _sideLength;
            }

            set
            {
                _sideLength = value;
            }
        }

    }
}

