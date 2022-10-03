using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    public interface IAreaFigure 
    { 
        double GetArea();
    }

    public abstract class Figure2
    {
        public ColorFigure Color { get; set; }  
        public bool Visible { get; set; }    
        public int X { get; set; }
        public int Y { get; set; }
        public string NameFig { get; set; }

        public Figure2(ColorFigure color, bool visible, int x, int y)
        {
            NameFig = "Абстрактная";
            Color = color; Visible = visible; X = x; Y = y;
        }
        public string GetVisible() { return (Visible) ? "Видимый" : "Невидимый"; }
        public void HorizontalMove(TypeHorizontalDirection typeHorizontalDirection, int distance)
        {
            if (typeHorizontalDirection == TypeHorizontalDirection.вправо)
            {
                X += distance;
            }
            else
            {
                X -= distance;
                if (X < 0) X = 0;
            }
        }

        public void VerticalMove(TypeVerticalDirection typeVerticalDirection, int distance)
        {
            if (typeVerticalDirection == TypeVerticalDirection.вниз)
            {
                Y += distance;
            }
            else
            {
                Y -= distance;
                if (Y < 0) Y = 0;
            }
        }

        public virtual string GetInfo()
        {
            return $"Фигура = {NameFig}; Цвет = {Color}; Состояние = {GetVisible()}; X = {X}; Y = {Y}; ";
        }
    }

    public class Point2 : Figure2
    {
        public Point2(ColorFigure color, bool visible, int x, int y) : base(color, visible, x, y)
        {
            NameFig = "Точка";
        }
        public override string GetInfo() { return base.GetInfo(); }
    }

    public class Circle2 : Figure2, IAreaFigure
    {
        private double _r;  

        public double R { get => _r; set => _r = value; }

        //конструктор
        public Circle2(ColorFigure color, bool visible, int x, int y, double r) : base(color, visible, x, y)
        {
            NameFig = "Окружность";
            R = r;
        }

        public double GetArea() { return Math.PI * R * R; }
    }

    public class Rectangle2 : Figure2, IAreaFigure
    {
        private double _sizeA, _sizeB;  
        
        public double SizeA { get => _sizeA; set => _sizeA = value; }
        public double SizeB { get => _sizeB; set => _sizeB = value; }

        public Rectangle2(ColorFigure color, bool visible, int x, int y, double sizeA, double sizeB) : base(color, visible, x, y)
        {
            NameFig = "Прямоугольник";
            SizeA = sizeA;
            SizeB = sizeB;
        }
       
        public double GetArea() { return SizeA * SizeB; }
        
        public override string GetInfo()
        {
            return base.GetInfo() + $"Размер А = {SizeA}; Размер B = {SizeB}";
        }
    }
}
