using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Engines;

namespace list_perf
{
    public class Program
    {
        [RPlotExporter, RankColumn]
        public class ListIntersectBenchmark
        {
            private int[][] data;

            [Params(100, 500)]
            public int ListCount;
            [Params(100, 1000)]
            public int ItemCount;
            [Params(1000, 10000)]
            public int MaxValue;

            [GlobalSetup]
            public void Setup()
            {
                var rnd = new Random(1209032);
                data = Enumerable.Range(0, ListCount).Select(i => Enumerable.Range(0, ItemCount).Select(ii => rnd.Next(MaxValue)).ToArray()).ToArray();
            }

            [Benchmark]
            public int[] Aggregate()
            {
                return data.Aggregate((a, i) => a.Intersect(i).ToArray()).ToArray();
            }

            [Benchmark]
            public int[] AggregateWithHashSet()
            {
                return data.Aggregate(data[0].ToHashSet(), (a, i) =>
                {
                    a.IntersectWith(i);
                    return a;
                }).ToArray();
            }

        }
        public static void Main()
        {
            var summary = BenchmarkRunner.Run<ListIntersectBenchmark>();
        }
    }
}
