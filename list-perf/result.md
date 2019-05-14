```
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.706 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.1.300
  [Host]     : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
```

|               Method | ListCount | ItemCount | MaxValue |          Mean |       Error |      StdDev | Rank |
|--------------------- |---------- |---------- |--------- |--------------:|------------:|------------:|-----:|
|            Aggregate |       100 |       100 |     1000 |    351.722 us |   6.0908 us |   5.6973 us |    7 |
| AggregateWithHashSet |       100 |       100 |     1000 |     11.610 us |   0.1969 us |   0.1842 us |    2 |
|            Aggregate |       100 |       100 |    10000 |    346.813 us |   5.5951 us |   5.2336 us |    7 |
| AggregateWithHashSet |       100 |       100 |    10000 |      9.043 us |   0.1442 us |   0.1349 us |    1 |
|            Aggregate |       100 |      1000 |     1000 |  3,195.924 us |  51.5674 us |  48.2361 us |    9 |
| AggregateWithHashSet |       100 |      1000 |     1000 |    277.694 us |   4.2467 us |   3.9724 us |    6 |
|            Aggregate |       100 |      1000 |    10000 |  3,215.967 us |  41.0935 us |  36.4283 us |    9 |
| AggregateWithHashSet |       100 |      1000 |    10000 |    122.373 us |   2.4084 us |   2.5770 us |    5 |
|            Aggregate |       500 |       100 |     1000 |  1,759.093 us |  29.2762 us |  27.3850 us |    8 |
| AggregateWithHashSet |       500 |       100 |     1000 |     14.890 us |   0.3023 us |   0.3824 us |    4 |
|            Aggregate |       500 |       100 |    10000 |  1,740.951 us |  21.3782 us |  19.9972 us |    8 |
| AggregateWithHashSet |       500 |       100 |    10000 |     12.364 us |   0.2469 us |   0.3541 us |    3 |
|            Aggregate |       500 |      1000 |     1000 | 15,816.923 us | 348.7960 us | 326.2640 us |   10 |
| AggregateWithHashSet |       500 |      1000 |     1000 |    281.331 us |   5.6017 us |   5.5016 us |    6 |
|            Aggregate |       500 |      1000 |    10000 | 15,898.548 us | 145.6403 us | 129.1063 us |   10 |
| AggregateWithHashSet |       500 |      1000 |    10000 |    125.014 us |   3.0373 us |   2.8411 us |    5 |
