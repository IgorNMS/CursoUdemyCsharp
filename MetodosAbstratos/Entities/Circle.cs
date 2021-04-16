using System;
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        //Os metodos abstratos precisam ser implementados nas classes em que são herdados da superclasse
        //vantagens de se ter a implementação do metodo abstrato fora da super classe e o polimorfismo
        //pois pode se ter diferentes resultados usando por exemplo uma lista da superclasse Shape
        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}