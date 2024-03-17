using System.Text.RegularExpressions;

namespace Mass_PrimeFactor.Models
{
    internal class InputModel : IInputModel
    {
        private string inputNumber = "";

        public double GetNumber()
        {
            if (Valid(inputNumber) == true)
            {
                return double.Parse(inputNumber);
            }
            return 0;
        }
        public string GetNumberAsString()
        {
            return inputNumber;
        }

        public void SetNumber(string value)
        {
            if (Valid(value) == true)
            {
                inputNumber =value;
            }
        }
        private bool Valid(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;
            Regex _regex = new Regex("^[0-9]*$");
            return _regex.IsMatch(value);
        }
    }
}
