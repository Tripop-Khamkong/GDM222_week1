class Program {
    public static void Main(string[] args) {
        Console.Write("Input number: "); 
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine(loop(x));
    }
    public static double loop(double x){
        
            if( x > -1 && x <= 0 ) {
                x = Math.Sqrt(1-Math.Pow(x,2));
                return x ;
            }
            else if( x > 0 && x <= 1 ) {
                x= Math.Sqrt(1-Math.Pow(x,2));
                return -1*x ;
            }
            else if( x <= -1) {
               x = loop(x + 2);
               return x ;
            }
            else if( x > -1) {
               x = loop(x - 2);
               return x ;
            }
            else {
                return x ;
            }
        }
    }
