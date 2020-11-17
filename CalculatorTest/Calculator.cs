namespace CalculatorTest
{
    public class Calculator
    {
        private double firstNumber;
        private double secondNumber;


        public double FirstNumber

        {
            get { return firstNumber; }
            set { firstNumber = value; }
        }

        public double SecondNumber
        {
            get { return secondNumber; }
            set { secondNumber = value; }

        }

        public double add()
        {
            return firstNumber + secondNumber;
        }

        public double sub()
        {
            return firstNumber - secondNumber;
        }

        public double Multiply()
        {
            return firstNumber * secondNumber;
        }

        public double Divide()
        {
            if (secondNumber == 0)
            {
                return 0.0;
            }
            return firstNumber / secondNumber;
        }

        public double Modulus()
        {
            return firstNumber % secondNumber;
        }
    }
}