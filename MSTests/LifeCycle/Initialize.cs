using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTests.LifeCycle
{
    /// <summary>
    /// Инициализатор
    /// </summary>
    [TestClass]
    public class Initialize : IDisposable
    {
        #region Конструктор

        /// <summary>
        /// Конструктор - не вызывается
        /// </summary>
        public Initialize()
        {
            Console.WriteLine("Initialize_Constructor");
            Console.WriteLine();
        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// [AssemblyInitialize] - вызывается один раз для всех тестов в сборке
        /// </summary>
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            Console.WriteLine("Initialize_AssemblyInitialize");
            Console.WriteLine();
        }

        /// <summary>
        /// [AssemblyCleanup] - вызывается один раз для всех тестов в сборке. Не вызывается ???
        /// </summary>
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Debug.WriteLine("Initialize_AssemblyCleanup");
            Console.WriteLine();
        }

        /// <summary>
        /// Dispose - Не вызывается
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine("Initialize_Dispose");
        }

        #endregion
    }
}