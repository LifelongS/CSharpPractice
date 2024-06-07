public partial class MainClass
{
    public double Add(double a, double b)
    { 
        return a + b; 
    }
    static void Main(string[] args)
    {     
        double a = 1;    
        double b = 2;    
        MainClass mainClass = new MainClass();    
        double result = mainClass.Add(a, b);    
        Console.WriteLine(result);
    }
 }