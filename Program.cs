using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
 //Exercise 2
            Console.WriteLine("Exercise_2");
            Console.WriteLine("Enter the sum of purchase: ");
            double purchase1;
            double purchase=Convert.ToDouble(Console.ReadLine());
            
            if((purchase>500)&&(purchase<=1000))
            {
                Console.WriteLine("3% discount for your purchase!");
                purchase1=purchase-purchase*3/100;
                purchase-=purchase1;
                Console.WriteLine($"your purchase taking into account the discount is {purchase1}$");
                Console.WriteLine("Purchase="+purchase);

            }
            else if(purchase>1000)
            {
                Console.WriteLine("5% discount for your purchase!");
                purchase1=purchase-purchase*(1-0.05);
                purchase-=purchase1;
                Console.WriteLine($"your purchase taking into account the discount is {purchase1}$");
                Console.WriteLine("Purchase="+purchase);

            }
            if(purchase<=500)
            {
                Console.WriteLine("NO discounts!");
            }
            Console.ReadLine();
            
            //Exercise 3
            Console.WriteLine("Exercise_3");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int c=Convert.ToInt32(Console.ReadLine());
            int d=Convert.ToInt32(Console.ReadLine());
            int Min;
            
             if(a<b && b<c && c<d)
                {
                     Console.WriteLine("Number increasing!");
                }
             else 
                {
            if(a==b && b==c && c==d)
                {
              Console.WriteLine(a*b*c*d);
                }
            else 
                {
                Min=Math.Min(Math.Min(a,b),Math.Min(c,d));
                Console.WriteLine(Min);
                Console.ReadLine();
                }
                
             }
         Console.ReadLine();
          

           // Exercise 42
             System.Console.WriteLine("Exercise_4");
            double q = double.Parse (Console.ReadLine());
            double w = double.Parse (Console.ReadLine());
            double e = double.Parse (Console.ReadLine());
            double t = 0;

            if (q >= w && w >= e) System.Console.WriteLine($"q = {q}; w = {w}; e = {e}");
            else if (q <= w && w <= e && q <= e) 
            {
                t = q; q = e; e = t;
                System.Console.WriteLine($"q = {q}; w = {w}; e = {e}");
            }
            else if (w <= q && w <= e && q <= e) 
            {
                t = e; e = w; w = q; q = t;
                System.Console.WriteLine($"q = {q}; w = {w}; e = {e}");
            }
            else if (q <= w && e <= q) 
            {
                t = q; q = w; w = t;
                System.Console.WriteLine($"q = {q}; w = {w}; e = {e}");
            }
            else if (e <= w && q <= e)
            {
                t = q; q = w; w = e; e = t;
                System.Console.WriteLine($"q = {q}; w ={w};  e= {e}");
            }
                Console.ReadLine();        }
    }
}
