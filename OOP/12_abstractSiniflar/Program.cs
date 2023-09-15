namespace _12_abstractSiniflar;


abstract class Shape{
    public int Width { get; set; }
    public int Height { get; set; }

    public  Shape(int w, int h){
        this.Width = w;
        this.Height = h;

    }


    public int calculateArea(){
        return this.Width * this.Height;
    }
}


class Square: Shape{

     public  Square(int w, int h):base(w,h) {

    }

}


class Rectangle: Shape{

    public  Rectangle(int w, int h):base(w,h) {

    }

    public int calculateArea(int w, int h){
        this.Width = w;
        this.Height = h;

        return (w * h) / 2;
    }

} 

class Program
{
    static void Main(string[] args)
    {
        var shapes = new Shape[3];

        shapes[0] = new Rectangle(10,15);
        shapes[1] = new Square(20,10);
        shapes[2] = new Rectangle(15,20);

        foreach(var s in shapes){
            System.Console.WriteLine($"alan: {s.calculateArea()}");;
        }


    }
}
