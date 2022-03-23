using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace WindowsFormsApplication317
{
    class HeightMap
    {
        /// <summary>
        /// Результирующее изображение
        /// </summary>
        public Bitmap map;
        static string path = @"D:\\4 курс\\УЧМИ\\WindowsFormsApplication317 - 4\\WindowsFormsApplication317\\bin\\Release\\res.txt";
        private int GetNumber(Color color)
        {
            return color.R;
        }

        public HeightMap(int size)
        {
            map = new Bitmap(size, size);
            var rand = new Random();
            StreamWriter writer = new StreamWriter(path, false);
            //случайное заполнение
            for (int i = 0; i < size; i++)
            {
                map.SetPixel(i, 0, Color.FromArgb(0, 0, 0));
                writer.Write("0 ");
            }
            writer.Write("\n\n");
            for (int x = 1; x < size - 1; x++)
            {              
                map.SetPixel(x, 0, Color.FromArgb(0, 0, 0));
                writer.Write("0 ");
                for (int y = 1; y < size - 1; y++)
                {
                    int num = rand.Next(0, 255);
                    map.SetPixel(x, y, Color.FromArgb(num, num, num));
                    writer.Write(num + " ");
                }
                map.SetPixel(x, size - 1, Color.FromArgb(0, 0, 0));
                writer.Write("0 ");
                writer.Write("\n\n");
            }
            for (int j = 0; j < size; j++)
            {              
                writer.Write("0 ");
            }

            //сглаживание
            for (int b = 0; b < 20; b++)
            {
                for (int x = 1; x < size - 1; x++)
                {
                    for (int y = 1; y < size - 1; y++)
                    {
                        float sum = 0;
                        sum = GetNumber(map.GetPixel(x - 1, y - 1)) +
                              GetNumber(map.GetPixel(x - 1, y)) +
                              GetNumber(map.GetPixel(x - 1, y + 1)) +
                              GetNumber(map.GetPixel(x, y - 1)) +
                              GetNumber(map.GetPixel(x, y)) +
                              GetNumber(map.GetPixel(x, y + 1)) +
                              GetNumber(map.GetPixel(x + 1, y - 1)) +
                              GetNumber(map.GetPixel(x + 1, y)) +
                              GetNumber(map.GetPixel(x + 1, y + 1));
                        sum /= 9;
                        map.SetPixel(x, y, Color.FromArgb((int)sum, (int)sum, (int)sum));
                    }
                }
            }

            
            for (int a = 0; a < 1000; a++)
            {
                int i = rand.Next(0, size);
                int j = rand.Next(0, size);
                int num = rand.Next(0, 255);
                map.SetPixel(i, j, Color.FromArgb(num, num, num));

            }

            for (int x = 1; x < size - 1; x++)
            {
                for (int y = 1; y < size - 1; y++)
                {
                    float sum = 0;
                    sum = GetNumber(map.GetPixel(x - 1, y - 1)) +
                          GetNumber(map.GetPixel(x - 1, y)) +
                          GetNumber(map.GetPixel(x - 1, y + 1)) +
                          GetNumber(map.GetPixel(x, y - 1)) +
                          GetNumber(map.GetPixel(x, y)) +
                          GetNumber(map.GetPixel(x, y + 1)) +
                          GetNumber(map.GetPixel(x + 1, y - 1)) +
                          GetNumber(map.GetPixel(x + 1, y)) +
                          GetNumber(map.GetPixel(x + 1, y + 1));
                    sum /= 9;
                    map.SetPixel(x, y, Color.FromArgb((int)sum, (int)sum, (int)sum));
                }
            }

            for (int a = 0; a < 1000; a++)
            {
                int i = rand.Next(0, size);
                int j = rand.Next(0, size);
                int num = rand.Next(0, 255);
                map.SetPixel(i, j, Color.FromArgb(num, num, num));

            }

            for (int x = 1; x < size - 1; x++)
            {
                for (int y = 1; y < size - 1; y++)
                {
                    float sum = 0;
                    sum = GetNumber(map.GetPixel(x - 1, y - 1)) +
                          GetNumber(map.GetPixel(x - 1, y)) +
                          GetNumber(map.GetPixel(x - 1, y + 1)) +
                          GetNumber(map.GetPixel(x, y - 1)) +
                          GetNumber(map.GetPixel(x, y)) +
                          GetNumber(map.GetPixel(x, y + 1)) +
                          GetNumber(map.GetPixel(x + 1, y - 1)) +
                          GetNumber(map.GetPixel(x + 1, y)) +
                          GetNumber(map.GetPixel(x + 1, y + 1));
                    sum /= 9;
                    map.SetPixel(x, y, Color.FromArgb((int)sum, (int)sum, (int)sum));
                }
            }

            for (int a = 0; a < 1000; a++)
            {
                int i = rand.Next(0, size);
                int j = rand.Next(0, size);
                int num = rand.Next(0, 255);
                map.SetPixel(i, j, Color.FromArgb(num, num, num));

            }

            for (int x = 1; x < size - 1; x++)
            {
                for (int y = 1; y < size - 1; y++)
                {
                    float sum = 0;
                    sum = GetNumber(map.GetPixel(x - 1, y - 1)) +
                          GetNumber(map.GetPixel(x - 1, y)) +
                          GetNumber(map.GetPixel(x - 1, y + 1)) +
                          GetNumber(map.GetPixel(x, y - 1)) +
                          GetNumber(map.GetPixel(x, y)) +
                          GetNumber(map.GetPixel(x, y + 1)) +
                          GetNumber(map.GetPixel(x + 1, y - 1)) +
                          GetNumber(map.GetPixel(x + 1, y)) +
                          GetNumber(map.GetPixel(x + 1, y + 1));
                    sum /= 9;
                    map.SetPixel(x, y, Color.FromArgb((int)sum, (int)sum, (int)sum));
                }
            }
        }

        public Bitmap GetImage()
        {
            return map;
        }

        
    }
}
