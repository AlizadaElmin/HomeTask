namespace Area;

class Program
{
    static void Main(string[] args)
    {
    }

    static float Area(float radius)
    {
        int p = 3;
        float circleArea = p * radius * radius;
        return circleArea;
    }
    static float Area(float a, float b)
    {
        float rectangleArea = a * b;
        return rectangleArea;
    }
    static float Area(float a, float b,float c)
    {
        float parallelepipedArea = 2 * (a * b + a * c + b * c);
        return parallelepipedArea;
    }
    static float Area(float a, float b, float c,float radius)
    {
        float perimeter = (a + b + c) / 2.0f;
        float s = perimeter * radius;
        return s;
    }
}

