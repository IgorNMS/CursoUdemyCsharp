using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height,Color color) : base(color)
        {
            Width = width;
            Height = height;
        }
        
        //Os metodos abstratos precisam ser implementados nas classes em que são herdados da superclasse
        //vantagens de se ter a implementação do metodo abstrato fora da super classe e o polimorfismo
        //pois pode se ter diferentes resultados usando por exemplo uma lista da superclasse Shape
        public override double Area()
        {
            return Width * Height;
        }
    }
}