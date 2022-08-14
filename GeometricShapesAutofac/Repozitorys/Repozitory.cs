using GeometricShapesAutofac.Models;
using GeometricShapesAutofac.Repozitorys.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesAutofac.Repozitorys
{
    public class Repozitory : IRepozitory
    {
        public List<Shapes> _cocktails { get; set; }

        public Repozitory()
        {
            _cocktails = new List<Shapes>()
            {
                new Shapes()
                {
                    Name = "Квадрат",
                    Information = "правильный четырехугольник, что означает, " +
                    "что он имеет четыре равные стороны и четыре равных угла " +
                    "(90-градусные углы, или 100-градусные углы, или прямые углы)."
                },
                 new Shapes()
                {
                    Name = "Круг",
                    Information = "часть плоскости, ограниченная окружностью." +
                    "Точка О также называется центром круга. Расстояние от точки окружности до её центра," +
                    " а также отрезок, соединяющий центр окружности с её точкой, называется радиусом окружности/круга."
                },
                  new Shapes()
                {
                    Name = "Треугольник",
                    Information = "многоугольник с тремя ребрами и тремя вершинами. Это одна из основных фигур в геометрии."
                }


            };

        }

        public List<string> GetName()
        {
            List<string> name = new List<string>();

            foreach (var cocktail in _cocktails)
            {
                name.Add(cocktail.Name);
            }
            return name;
        }

        public List<string> GetInformation()
        {
            List<string> info = new List<string>();

            foreach (var cocktail in _cocktails)
            {
                info.Add(cocktail.Information);
            }
            return info;
        }

        public void SevaFile()
        {
            string path = "ShapesFile.txt";

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (var cocktail in _cocktails)
                {
                    writer.WriteLine($"Name: {cocktail.Name} Information: {cocktail.Information}");
                }

            }
            Console.WriteLine("Запись в файл выполнена");
        }
    }
}
