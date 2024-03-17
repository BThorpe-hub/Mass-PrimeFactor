using System.Text.RegularExpressions;

namespace Mass_PrimeFactor.Models
{
    internal partial class InputModel : IInputModel
    {
        private string _inputNumber = "";
      
     
        public double GetNumber()
        {
            if (Valid(_inputNumber) == true)
            {
                return double.Parse(_inputNumber);
            }
            return 0;
        }
    
        public string GetNumberAsString()
        {
            return _inputNumber;
        }

        public void SetNumber(string value)
        {
            if (Valid(value) == true)
            {
                _inputNumber = value;
            }
        }
       
        private static bool Valid(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;
            Regex regex = NumbersOnlyRegex();
            return regex.IsMatch(value);
        }

        [GeneratedRegex("^[0-9]*$")]
        private static partial Regex NumbersOnlyRegex();
    }
}
