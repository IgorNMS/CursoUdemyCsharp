namespace ExConsoleAppHerancaPolimorfismo.Entities
{
    /*
     * Classes e metodos selados
     *
     * O uso da palavra "sealed" antes de uma classe evita que ela seja herdada, porem
     * ainda e possivel extender a funcionalidade de uma classe selada usando o "extension methods"
     *
     * No Método o uso da palavra "sealed" evita que um metodo sobreposto possa ser sobreposto novamente
     * somente e possivel ser aplicado a metodos sobrepostos
     */
    public class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        /*
         * Sobreposição ou sobrescrita
         * Para que um método comun (não abstrato) possa ser
         * sobreposto, deve ser incluido nele o prefixo "virtual"
         *
         * Ao sobrescrever um metodo, devemos incluir nele o prefixo "override"
         */
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}