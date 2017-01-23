using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Animal
    {
        string name;
        public int age;
        double mass;
    }

    class Rectangle
    {

        private double width;
        private double square;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            this.square = this.width * this.height;
        }
        public double GetHeight()
        {
            return this.height;
        }
        public double GetWidth()
        {
            return this.width;
        }
        public void SetWidth(double width)
        {
            this.width = width;
            this.square = this.width * this.height;
        }
        public void SetHeight(double height)
        {
            this.height = height;
            this.square = this.width * this.height;
        }
        public double GetSquare()
        {
            return square;
        }
    }

    public class Rectangle2
    {
        private double square;
        private double height;
        private double width;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                this.height = value;
                this.square = this.height * this.width;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                this.width = value;
                this.square = this.height * this.width;
            }
        }
        public double Square
        {
            get
            {
                return square;
            }
        }

        public static Rectangle2 operator +(Rectangle2 l, Rectangle2 r)
        {
            Rectangle2 res = new Rectangle2();
            res.Height = r.Height + l.Height;
            res.Width = r.Width + l.Width;
            return res;
        }

        public string GetInfo()
        {
            //return "Width: " + this.Width + " " + this.Height + " " + this.Square;
            return string.Format("Width: {0}, Height: {1}, Square:{2}",
                Width, Height, Square);
        }

        public override string ToString()
        {
            return string.Format("Width: {0}, Height: {1}, Square:{2}",
              Width, Height, Square);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.age = 10;

            Rectangle r = new Rectangle(10, 7);
            Console.WriteLine(r.GetSquare());

            Rectangle2 r2 = new Rectangle2 { Height = 3, Width = 4 };
            Rectangle2 r3 = new Rectangle2 { Height = 30, Width = 2 };
            Rectangle2 r4 = r2 + r3;

            Console.WriteLine(r4);

            /*Console.WriteLine((new Rectangle2 { Height = 3, Width = 4 }
                          + new Rectangle2 { Height = 30, Width = 2 }).Square);*/
        }
    }
}