using System;
using System.Reflection;
using System.Threading;
using NUnit.Framework;

namespace NUnitTests.Parallelism
{
    /// <summary>
    /// Children - запускает параллельно все дочерние элементы,
    /// независимо от того, являются ли они
    /// TestFixture или TestMethod, но не включает Self
    /// </summary>
    [TestFixture]
    [Parallelizable(ParallelScope.Children)]
    public class ParallelChildren
    {
        /// <summary>
        /// Тест-кейс
        /// </summary>
        [Test]
        public void TestCase1()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [Test]
        public void TestCase2()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [Test]
        public void TestCase3()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [Test]
        public void TestCase4()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [Test]
        public void TestCase5()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Children - указывает, что потомки теста могут выполняться параллельно друг другу.
        /// </summary>
        [TestFixture]
        [Parallelizable(ParallelScope.Children)]
        public class ParallelChildrenChild
        {
            /// <summary>
            /// Тест-кейс
            /// </summary>
            [Test]
            public void TestCase1()
            {
                Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
                Console.WriteLine();
                Thread.Sleep(3000);
            }

            /// <summary>
            /// Тест-кейс
            /// </summary>
            [Test]
            public void TestCase2()
            {
                Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
                Console.WriteLine();
                Thread.Sleep(3000);
            }

            /// <summary>
            /// Тест-кейс
            /// </summary>
            [Test]
            public void TestCase3()
            {
                Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
                Console.WriteLine();
                Thread.Sleep(3000);
            }

            /// <summary>
            /// Тест-кейс
            /// </summary>
            [Test]
            public void TestCase4()
            {
                Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
                Console.WriteLine();
                Thread.Sleep(3000);
            }

            /// <summary>
            /// Тест-кейс
            /// </summary>
            [Test]
            public void TestCase5()
            {
                Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
                Console.WriteLine();
                Thread.Sleep(3000);
            }
        }
    }
}