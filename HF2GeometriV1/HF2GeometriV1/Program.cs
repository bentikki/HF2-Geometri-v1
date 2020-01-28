using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HF2GeometriV1.Classes;

namespace HF2GeometriV1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inputError;
            int UserInputSideA;
            do
            {
                inputError = false;
                try
                {
                    List<GeometriForm> sqList = new List<GeometriForm>();
                    GeometriForm sq = new Square(10);
                    sqList.Add(sq);
                    GeometriForm rec = new Rectangular(10, 5);
                    sqList.Add(rec);
                    GeometriForm paral = new Parallelogram(3, 5, 20);
                    sqList.Add(paral);
                    GeometriForm trapez = new Trapez(10,9,8,9);
                    sqList.Add(trapez);
                    GeometriForm triangle = new Triangle(10,5,2);
                    sqList.Add(triangle);


                    foreach (GeometriForm item in sqList)
                    {
                        Console.WriteLine("Type: " + item.ToString());
                        Console.WriteLine("The perimeter of the square is: " + item.GetPerimiter());
                        Console.WriteLine("The area of the square is: " + item.GetArea());
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine();
                    }
                    
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a valid input try again:");
                    inputError = true;
                }
            } while (inputError);

        }
    }
}
