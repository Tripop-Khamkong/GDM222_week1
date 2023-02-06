class Program {
    public static void Main(string[] args) {
        Console.Write("Input number: "); 
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine(loop(x));
    }
    public static double loop(double x){
        
            if(Math.Pow(x,2) <= 4 ) {
                return x = 2;
            }
            else if(Math.Pow(x,2) > 4) {
               x = 1+loop(x-(4*Math.Abs(x))/x);
               return x ;
            }
            else {
                return x ;
            }
        }
    }
