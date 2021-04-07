using BenchmarkDotNet.Running;

namespace Console.BenchamarkDotNet
{
    internal class Program
    {
        private static void Main()
        {
            System.Console.WriteLine("string vs StringBuilder");
            BenchmarkRunner.Run<TestBenchmark>();
            System.Console.WriteLine("¡Benchmark ha terminado!. Presione cualquier tecla para continuar...");
            System.Console.ReadKey();
        }
    }
}