namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcom to carpts cleaner");
            double pricepersmallcarpt = 25.0;
            double priceperlargecarpt = 35.0;
            double taxvalue = 0.06;
            Console.WriteLine("enter number of small carpts:");
            int smallcarpt = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number of large carpts:");
            int largecarpt = int.Parse(Console.ReadLine());
            double cost = (smallcarpt * pricepersmallcarpt) + (largecarpt * priceperlargecarpt);
            Console.WriteLine($"the cost:{cost}");
            double tax = cost * taxvalue;
            Console.WriteLine($"the tax:{tax}");

            double totalestimate = cost + tax;
            Console.WriteLine($"the totalestimate:{totalestimate}");
            Console.WriteLine("this estimate is valid for 30 days");

        }
    }
}
