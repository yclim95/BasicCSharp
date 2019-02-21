using static System.Console;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int []numbers = {0,1,2,3,4,5,6,7,8,9};

            foreach(int number in numbers){
                Write(number);
            }
        }
    }
}
