using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System.Text;

namespace Console.BenchamarkDotNet
{
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class TestBenchmark
    {
        private readonly int iterations = 6969;

        [Benchmark]
        public string TestString()
        {
            var text = string.Empty;

            for (var i = 0; i < iterations; i++)
                text += $"text{i}";

            return text;
        }

        [Benchmark]
        public string TestStringBuilder()
        {
            var stringBuilder = new StringBuilder();

            for (var i = 0; i < iterations; i++)
                stringBuilder.Append($"text{i}");

            return stringBuilder.ToString();
        }
    }
}