using System;
namespace Assignment2
{
	public class Color
	{
        private int red;
        private int green;
        private int blue;
        private int alpha;

        
        public Color(int red, int green, int blue, int alpha)
        {
            SetRed(red);
            SetGreen(green);
            SetBlue(blue);
            SetAlpha(alpha);
        }

        
        public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

        
        public int GetRed() => red;
        public void SetRed(int value)
        {
            if (value >= 0 && value <= 255)
                red = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value), "Value must be between 0 and 255.");
        }

        
        public int GetGreen() => green;
        public void SetGreen(int value)
        {
            if (value >= 0 && value <= 255)
                green = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value), "Value must be between 0 and 255.");
        }

        
        public int GetBlue() => blue;
        public void SetBlue(int value)
        {
            if (value >= 0 && value <= 255)
                blue = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value), "Value must be between 0 and 255.");
        }

        
        public int GetAlpha() => alpha;
        public void SetAlpha(int value)
        {
            if (value >= 0 && value <= 255)
                alpha = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value), "Value must be between 0 and 255.");
        }

        
        public int GetGrayscale()
        {
            return (red + green + blue) / 3;
        }
    }
}

