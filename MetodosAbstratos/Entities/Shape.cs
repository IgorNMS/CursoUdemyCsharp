using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    /*
     * Classes abstratas são classes que não podem ser instanciadas
     * E uma forma de garantir herança total: somente subclasses não abstratas
     * podem ser instanciadas, mas nunca a superclasse abstrata 
     */
    public abstract class Shape
    {
        public Color Color { get; set; }
        
        //construtor com um argumento para obrigar a instanciação da classe com um argumento
        public Shape(Color color)
        {
            Color = color;
        }
        /*
         * Metodos abstratos
         * São metodos que não possuem implementação
         * Metodos são abstratos quando a classe é generica demais para conter sua implementação
         * Se uma classe possuir pelo menos um método abstrato, então essa classe também é abstrata
         */
        public abstract double Area();
    }
}