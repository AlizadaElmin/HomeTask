namespace Power;

class Program
{
    static void Main(string[] args)
    {
   
    }

    static double Power(double number, int pow=2)
    {
        double result = 1;

       
        if(pow < 0)
        {
            for (int i = 1; i <= -pow; i++)
            {
                result *= number;
            }
            result = 1 / result;
        }

        else
        {
            for (int i = 1; i <= pow; i++)
            {
                result *= number;
            }
        }



        return result;
    }
}

