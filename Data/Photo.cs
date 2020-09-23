using System;

namespace MyPhotoshop
{
	public class Photo
	{
		public Photo(int width, int height)
        {
			Width = width;
			Height = height;
			Data = new Pixel[width, height];
            for (int x = 0; x < width; ++x)
                for (int y = 0; y < height; ++y)
                    Data[x, y] = new Pixel();
        }

        public readonly int Width;
        public readonly int Height;
        public readonly Pixel[,] Data;
    }
}

