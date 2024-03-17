using System.Reflection.Metadata;

namespace Mass_PrimeFactor.Models
{
    internal interface IInputModel
    {
        public double GetNumber();
        public string GetNumberAsString();
        public void SetNumber(string value);
    }
}
