using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANSI
{
    internal class BitmapToASCIIConverter
    {
        private char[] _asciiTable = { ' ', '.', ',', ':', '+', '*', '?', '%', 'S', '#', '@' };
        private readonly Bitmap _bitmap;

        public BitmapToASCIIConverter(Bitmap bitmap)
        {
            _bitmap = bitmap;
        }

        public Tuple<char[][], Color[][]> Convert()
        {
            char[][] symbols = new char[_bitmap.Height][];
            Color[][] colors = new Color[_bitmap.Height][];

            for (int y = 0; y < _bitmap.Height; y++)
            {
                symbols[y] = new char[_bitmap.Width];
                colors[y] = new Color[_bitmap.Width];
                for (int x = 0; x < _bitmap.Width; x++)
                {
                    int mapIndex = (int)Map(_bitmap.GetPixel(x, y).R, 0,255, 0, _asciiTable.Length - 1);
                    Color color = Color.FromArgb(_bitmap.GetPixel(x, y).R, _bitmap.GetPixel(x, y).G, _bitmap.GetPixel(x, y).B);
                    colors[y][x] = color;
                    symbols[y][x] = _asciiTable[mapIndex];
                }
            }


            return Tuple.Create(symbols, colors);
        }

        private float Map(float valueToMap, float start1, float stop1, float start2, float stop2)
        {
            return ((valueToMap - start1) / (stop1 - start1)) * (stop2 - start2) + start2;
        }
    }
}
