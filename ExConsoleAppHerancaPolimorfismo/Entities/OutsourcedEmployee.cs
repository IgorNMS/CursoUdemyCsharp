namespace ExConsoleAppHerancaPolimorfismo.Entities
{
    //herança e um tipo de associação que permite que uma classe herde dados e comportamentos de outra
    /*
     *Sintaxe:
     *   : (estende)
     *   base (estende para a superclasse)
    */
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
            
        }
        
        
        //Palavra "base" utilizada em construtores para reaproveitar o construtor da superclasse
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            :base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        
        //Ao sobrescrever um metodo, devemos incluir nele o prefixo "override"
        //E possivel chamar a implementação da superclasse usando a palavra "base"
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}