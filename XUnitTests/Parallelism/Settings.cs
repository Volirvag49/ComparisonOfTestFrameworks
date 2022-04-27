using Xunit;

//[assembly: CollectionBehavior(CollectionBehavior.CollectionPerAssembly,
//    MaxParallelThreads = 30)]
[assembly: CollectionBehavior(CollectionBehavior.CollectionPerClass,
    MaxParallelThreads = 30)]

//[assembly: CollectionBehavior(MaxParallelThreads = 30)]

namespace XUnitTests.Parallelism
{
}