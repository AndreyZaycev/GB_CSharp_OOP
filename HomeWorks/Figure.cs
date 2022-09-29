using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    //перечисление: тип банковского счета
    public enum ColorFigure
    {
        красный,
        желтый,
        зеленый,
        черный
    }

    public enum TypeHorizontalDirection { вправо, влево }
    public enum TypeVerticalDirection { вниз, вверх }

    public class Figure
    {
        //поля
        private ColorFigure _color;  //цвет фигуры
        private bool _visible;       //видимость
        private int _x, _y;          //координаты любой точки фигуры (_x - по горизонтали, _y - по вертикали), например - центра тяжести 
        protected string _nameFigure;  //название фигуры

        //свойства
        public ColorFigure Color { get => _color; set => _color = value; }  //изменение цвета реализовано через свойство
        public bool Visible { get => _visible; set => _visible = value; }   //опрос и установка состояния "видимый/невидимый" в булевом представлении 
        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        //конструктор
        public Figure(ColorFigure color, bool visible, int x, int y) 
        {
            _nameFigure = "Абстрактная";
            Color = color; Visible = visible; X = x; Y = y; 
        }

        //метод: опрос состояния "видимый/невидимый" в строковом представлении
        public string GetVisible() { return (Visible) ? "Видимый" : "Невидимый"; }
        
        //перемещение по горизонтали
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
        
        //перемещение по вертикали
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

        //вывод информации о состоянии всех полей объекта
        public virtual string GetInfo() 
        { 
            return $"Фигура = {_nameFigure}; Цвет = {Color}; Состояние = {GetVisible()}; X = {X}; Y = {Y}; "; 
        }
    }

    public class Point : Figure
    {
        //конструктор
        public Point(ColorFigure color, bool visible, int x, int y) : base(color, visible, x, y) 
        { 
            _nameFigure = "Точка"; 
        }

        //вывод информации о состоянии всех полей объекта
        public override string GetInfo() { return base.GetInfo(); }

        //метод: вычисление площади
        public virtual double GetArea() { return 0.0; }
    }

    public class Circle : Point 
    {
        //поле
        private double _r;  //радиус окружности

        //свойство
        public double R { get => _r; set => _r = value; }
    
        //конструктор
        public Circle(ColorFigure color, bool visible, int x, int y, double r) : base(color, visible, x, y) 
        {
            _nameFigure = "Окружность";
            R = r;
        }

        //метод: вычисление площади
        public override double GetArea() { return Math.PI * R * R; }

        //вывод информации о состоянии всех полей объекта
        public override string GetInfo()
        {
            return base.GetInfo() + $"Радиус = {R}";
        }
    }

    public class Rectangle : Point
    {
        //поле
        private double _sizeA, _sizeB;  //размеры сторон прямоугольника

        //свойства
        public double SizeA { get => _sizeA; set => _sizeA = value; }
        public double SizeB { get => _sizeB; set => _sizeB = value; }

        //конструктор
        public Rectangle(ColorFigure color, bool visible, int x, int y, double sizeA, double sizeB) : base(color, visible, x, y)
        {
            _nameFigure = "Прямоугольник";
            SizeA = sizeA;
            SizeB = sizeB;
        }

        //метод: вычисление площади
        public override double GetArea() { return SizeA * SizeB; }

        //вывод информации о состоянии всех полей объекта
        public override string GetInfo()
        {
            return base.GetInfo() + $"Размер А = {SizeA}; Размер B = {SizeB}";
        }
    }

}
