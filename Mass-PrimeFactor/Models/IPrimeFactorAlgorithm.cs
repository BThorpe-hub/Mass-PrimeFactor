namespace Mass_PrimeFactor.Models
{
    public interface IPrimeFactorAlgorithm
    {
        public string Calculate(double number);
        public string GetName();
    }
}
