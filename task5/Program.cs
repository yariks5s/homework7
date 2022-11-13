﻿using System.Text;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            IFigure figure = new Triangle(10, 20, 15);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            figure = new Circle(15);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.Read();
        }
    }

    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
    class Rectangle : IFigure
    {
        int width;
        int height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }
        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }
        public void GetInfo()
        {
            Console.WriteLine("Прямокутник довжиною {0} и шириною {1}", height, width);
        }
    }
    class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }
        public IFigure Clone()
        {
            return new Circle(this.radius);
        }
        public void GetInfo()
        {
            Console.WriteLine("Круг радіусом {0}", radius);
        }
    }

    class Triangle : IFigure
    {
        int sideA, sideB, sideC;
        public Triangle(int a, int b, int c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }
        public IFigure Clone()
        {
            return new Triangle(this.sideA, this.sideB, this.sideC);
        }
        public void GetInfo()
        {
            Console.WriteLine("Трикутник зі сторонами {0} {1} {2}", sideA, sideB, sideC);
        }
    }
}