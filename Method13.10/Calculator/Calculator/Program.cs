namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine( Calculator(9, 0, '/'));
        Console.ReadLine();
    }

    static double Calculator(double firstNumber, double secondNumber, char operation)
    {
        double result = 0;
        switch (operation){
            case '+':
                result= firstNumber + secondNumber;
                break;
            case '-':
                result= firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
                if (secondNumber != 0)
                {
                    result = firstNumber / secondNumber;
                }
                else
                {
                    Console.WriteLine("0-a bölmək olmaz");
                   
                }
                break;
            default:
                Console.WriteLine("Səhv operator daxil edilib");
                break;
            }
            return result; 
    }
}

