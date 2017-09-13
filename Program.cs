using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var heigth = Int32.Parse(args[0]);
            var width = Int32.Parse(args[1]);

            bool[,] persons = new bool[heigth, width];

            var nextGeneration = new bool[heigth, heigth];
            int count = 0;
            for (int i = 2; i < args.Length; i++)
            {
                var parts = args[i].Split(new []{','});
                persons[Int32.Parse(parts[0]), Int32.Parse(parts[1])] = true;
            }
            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i < heigth - 1 && j < width - 1)
                    {
                        count = 0;
                        if (!persons[i, j] && persons[i + 1, j])
                        {
                            count += 1;
                        }

                        if (!persons[i, j] && persons[i - 1, j])
                        {
                            count += 1;
                        }

                        if (!persons[i, j] && persons[i, j + 1])
                        {
                            count += 1;
                        }
                        if (!persons[i, j] && count >= 3)
                        {
                            nextGeneration[i, j] = true; 
                        }

                        if (persons[i, j] && persons[i + 1, j])
                        {
                            count += 1;
                        }

                        if (persons[i, j] && persons[i - 1, j])
                        {
                            count += 1;
                        }

                        if (persons[i, j] && persons[i, j + 1])
                        {
                            count += 1;
                        }
                        if (persons[i, j] && persons[i, j - 1])
                        {
                            count += 1;
                        }
                    }
                }
            }

        }
    }
}
