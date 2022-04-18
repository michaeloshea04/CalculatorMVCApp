namespace CalculatorMVC.Models
{
    public class CalculatorModel
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }
        public double Result { get; set; }
        public OperationType Operation { get; set; }

        public enum OperationType
        {
            Addition,
            Subtraction,
            Multiplication,
            Division

        }

    }
}
