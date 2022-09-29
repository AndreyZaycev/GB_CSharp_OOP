using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class Lesson6Task2 : ILessons
    {
        public string Number => "10";

        public string Description => "Урок № 6, дз № 2 : проверка функционирования классов Figure, Point, Circle, Rectangle";

        public void Run()
        {
            Console.WriteLine("\nРешение домашнего задания # 1 урока № 6");

            //
            Console.WriteLine("\n--- Проверка функционирования класса Figure ---");
            CheckClassFigure();

            //
            Console.WriteLine("\n--- Проверка функционирования класса Point ---");
            CheckClassPoint();
            
            //
            Console.WriteLine("\n--- Проверка функционирования класса Circle ---");
            CheckClassCircle();

            //
            Console.WriteLine("\n--- Проверка функционирования класса Rectangle ---");
            CheckClassRectangle();
        }
    
        private void CheckClassFigure()
        {
            //
            Console.WriteLine("\nCоздание объекта класса Figure и вывод всех полей на экран");
            Figure oF = new Figure(ColorFigure.зеленый, false, 100, 150);
            Console.WriteLine(oF.GetInfo());

            //
            Console.WriteLine("\nУстановка видимости фигуры (через свойство Visible) и проверка метода GetVisible() вывода информации о видимости");
            Console.WriteLine($"Текущее состояние фигуры: {oF.GetVisible()}");
            oF.Visible = true;
            Console.WriteLine($"Новое состояние фигуры: {oF.GetVisible()}");

            //
            Console.WriteLine("\nПроверка методов перемещения фигуры");
            Console.WriteLine("Перемещение фигуры вправо на 500 единиц (ось X) и вниз на 250 единиц (ось Y)");
            oF.HorizontalMove(TypeHorizontalDirection.вправо, 500);
            oF.VerticalMove(TypeVerticalDirection.вниз, 250);
            Console.WriteLine(oF.GetInfo());

            Console.WriteLine("Перемещение фигуры влево на 300 единиц (ось X) и вверх на 200 единиц (ось Y)");
            oF.HorizontalMove(TypeHorizontalDirection.влево, 300);
            oF.VerticalMove(TypeVerticalDirection.вверх, 200);
            Console.WriteLine(oF.GetInfo());

            Console.WriteLine("Перемещение фигуры влево на 1300 единиц (ось X) и вверх на 1200 единиц (ось Y)");
            oF.HorizontalMove(TypeHorizontalDirection.влево, 1300);
            oF.VerticalMove(TypeVerticalDirection.вверх, 1200);
            Console.WriteLine(oF.GetInfo());

            Console.WriteLine("\nУстановка цвета фигуры (через свойство Color)");
            oF.Color = ColorFigure.красный;
            Console.WriteLine(oF.GetInfo());
        }

        private void CheckClassPoint()
        {
            //
            Console.WriteLine("\nCоздание объекта класса Point и вывод всех полей на экран");
            Point oP = new Point(ColorFigure.зеленый, false, 100, 150);
            Console.WriteLine(oP.GetInfo());

            //
            Console.WriteLine("\nУстановка видимости точки (через свойство Visible) и проверка метода GetVisible() вывода информации о видимости");
            Console.WriteLine($"Текущее состояние точки: {oP.GetVisible()}");
            oP.Visible = true;
            Console.WriteLine($"Новое состояние точки: {oP.GetVisible()}");

            //
            Console.WriteLine("\nПроверка методов перемещения точки");
            Console.WriteLine("Перемещение точки вправо на 500 единиц (ось X) и вниз на 250 единиц (ось Y)");
            oP.HorizontalMove(TypeHorizontalDirection.вправо, 500);
            oP.VerticalMove(TypeVerticalDirection.вниз, 250);
            Console.WriteLine(oP.GetInfo());

            Console.WriteLine("Перемещение точки влево на 300 единиц (ось X) и вверх на 200 единиц (ось Y)");
            oP.HorizontalMove(TypeHorizontalDirection.влево, 300);
            oP.VerticalMove(TypeVerticalDirection.вверх, 200);
            Console.WriteLine(oP.GetInfo());

            Console.WriteLine("Перемещение точки влево на 1300 единиц (ось X) и вверх на 1200 единиц (ось Y)");
            oP.HorizontalMove(TypeHorizontalDirection.влево, 1300);
            oP.VerticalMove(TypeVerticalDirection.вверх, 1200);
            Console.WriteLine(oP.GetInfo());

            Console.WriteLine("\nУстановка цвета точки (через свойство Color)");
            oP.Color = ColorFigure.красный;
            Console.WriteLine(oP.GetInfo());

            Console.WriteLine("\nРасчет площади точки GetArea()");
            Console.WriteLine($"Площадь точки = {oP.GetArea()} квадратных единиц");
        }

        private void CheckClassCircle()
        {
            //
            Console.WriteLine("\nCоздание объекта класса Circle и вывод всех полей на экран");
            Circle oC = new Circle(ColorFigure.зеленый, false, 100, 150, 12.3);
            Console.WriteLine(oC.GetInfo());

            //
            Console.WriteLine("\nУстановка видимости окружности (через свойство Visible) и проверка метода GetVisible() вывода информации о видимости");
            Console.WriteLine($"Текущее состояние окружности: {oC.GetVisible()}");
            oC.Visible = true;
            Console.WriteLine($"Новое состояние окружности: {oC.GetVisible()}");

            //
            Console.WriteLine("\nПроверка методов перемещения окружности");
            Console.WriteLine("Перемещение окружности вправо на 500 единиц (ось X) и вниз на 250 единиц (ось Y)");
            oC.HorizontalMove(TypeHorizontalDirection.вправо, 500);
            oC.VerticalMove(TypeVerticalDirection.вниз, 250);
            Console.WriteLine(oC.GetInfo());

            Console.WriteLine("Перемещение окружности влево на 300 единиц (ось X) и вверх на 200 единиц (ось Y)");
            oC.HorizontalMove(TypeHorizontalDirection.влево, 300);
            oC.VerticalMove(TypeVerticalDirection.вверх, 200);
            Console.WriteLine(oC.GetInfo());

            Console.WriteLine("Перемещение окружности влево на 1300 единиц (ось X) и вверх на 1200 единиц (ось Y)");
            oC.HorizontalMove(TypeHorizontalDirection.влево, 1300);
            oC.VerticalMove(TypeVerticalDirection.вверх, 1200);
            Console.WriteLine(oC.GetInfo());

            Console.WriteLine("\nУстановка цвета окружности (через свойство Color)");
            oC.Color = ColorFigure.красный;
            Console.WriteLine(oC.GetInfo());

            Console.WriteLine("\nРасчет площади окружности GetArea()");
            Console.WriteLine($"Площадь окружности при радиусе {oC.R} единиц = {oC.GetArea()} квадратных единиц");
        }

        private void CheckClassRectangle()
        {
            //
            Console.WriteLine("\nCоздание объекта класса Rectangle и вывод всех полей на экран");
            Rectangle oR = new Rectangle(ColorFigure.зеленый, false, 100, 150, 100.5, 200.7);
            Console.WriteLine(oR.GetInfo());

            //
            Console.WriteLine("\nУстановка видимости прямоугольника (через свойство Visible) и проверка метода GetVisible() вывода информации о видимости");
            Console.WriteLine($"Текущее состояние прямоугольника: {oR.GetVisible()}");
            oR.Visible = true;
            Console.WriteLine($"Новое состояние прямоугольника: {oR.GetVisible()}");

            //
            Console.WriteLine("\nПроверка методов перемещения прямоугольника");
            Console.WriteLine("Перемещение прямоугольника вправо на 500 единиц (ось X) и вниз на 250 единиц (ось Y)");
            oR.HorizontalMove(TypeHorizontalDirection.вправо, 500);
            oR.VerticalMove(TypeVerticalDirection.вниз, 250);
            Console.WriteLine(oR.GetInfo());

            Console.WriteLine("Перемещение прямоугольника влево на 300 единиц (ось X) и вверх на 200 единиц (ось Y)");
            oR.HorizontalMove(TypeHorizontalDirection.влево, 300);
            oR.VerticalMove(TypeVerticalDirection.вверх, 200);
            Console.WriteLine(oR.GetInfo());

            Console.WriteLine("Перемещение прямоугольника влево на 1300 единиц (ось X) и вверх на 1200 единиц (ось Y)");
            oR.HorizontalMove(TypeHorizontalDirection.влево, 1300);
            oR.VerticalMove(TypeVerticalDirection.вверх, 1200);
            Console.WriteLine(oR.GetInfo());

            Console.WriteLine("\nУстановка цвета прямоугольника (через свойство Color)");
            oR.Color = ColorFigure.красный;
            Console.WriteLine(oR.GetInfo());

            Console.WriteLine("\nРасчет площади прямоугольника GetArea()");
            Console.WriteLine($"Площадь прямоугольника при размере стороны A {oR.SizeA} единиц " +
                $"и при размере стороны B {oR.SizeB} единиц = {oR.GetArea()} квадратных единиц");
        }
    }
}
