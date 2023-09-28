namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerecConstructor<int> gn1 = new GenerecConstructor<int>(1234);
            GenerecConstructor<float> gn2 = new GenerecConstructor<float>(12.23f);
            GenerecConstructor<string> gn3 = new GenerecConstructor<string>("hello");
            GenerecConstructor<char> gn4 = new GenerecConstructor<char>('A');
            
        }
    }
    class GenerecConstructor<T>
    {
        public GenerecConstructor(T value)
        {
            Console.WriteLine($"Genirik toifasi:{value}");
        }
    }
}