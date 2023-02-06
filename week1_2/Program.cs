class Program {
    public static void Main(string[] args) {
        Console.Write("Input c0 x : "); 
        double x1 = double.Parse(Console.ReadLine());

         Console.Write("Input c0 y : "); 
        double y1 = double.Parse(Console.ReadLine());

         Console.Write("Input p0 x : "); 
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Input p0 y : "); 
        double y2 = double.Parse(Console.ReadLine());

         Console.Write("Input loop : "); 
        int loop = int.Parse(Console.ReadLine());

        double zeta = Math.Atan((y2-y1)/(x2-x1)) ;
        double distant = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
        double loopx1 = x1 ;
        double loopy1 = y1 ;
        for(int i = 1 ;i<=loop; i++){
            loopx1 = x1 ;
            loopy1 = y1 ;
            x1 = x1+(distant/(2*i))*Math.Cos(zeta+((Math.PI/2)*i));
            y1 = y1+(distant/(2*i))*Math.Sin(zeta+((Math.PI/2)*i));
            x2 = loopx1+(distant/(Math.Pow(2,i-1)))*Math.Cos(zeta+((Math.PI/2)*i));
            y2 = loopy1+(distant/(Math.Pow(2,i-1)))*Math.Sin(zeta+((Math.PI/2)*i));
        }

        Console.WriteLine(x1);
        Console.WriteLine(y1);
        Console.WriteLine(x2);
        Console.WriteLine(y2);
    }
}   
            
    