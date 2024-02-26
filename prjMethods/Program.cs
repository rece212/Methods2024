namespace prjMethods
{
    internal class Program
    {

        static void Main(string[] args)
        {
            

            Class1 class1 = new Class1();


            Console.WriteLine( "Please enter your mark :" );
            int iValue=Convert.ToInt32( Console.ReadLine());
            String strOutput = class1.Results(iValue);
            Console.WriteLine(strOutput);
            strOutput = class1.Results(iValue,80,75,20);
            Console.WriteLine(strOutput);

        }
    }
}
