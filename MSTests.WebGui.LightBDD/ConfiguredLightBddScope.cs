using LightBDD.Core.Configuration;
using LightBDD.MsTest2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]

namespace MSTests.WebGui.LightBDD
{
    [TestClass]
    public class ConfiguredLightBddScope
    {
        #region Публичные методы

        [AssemblyInitialize]
        public static void Setup(TestContext testContext)
        {
            LightBddScope.Initialize(OnConfigure);

            // code executed before any scenarios
        }

        [AssemblyCleanup]
        public static void Cleanup()
        {
            LightBddScope.Cleanup();

            // code executed after all scenarios
        }

        #endregion

        #region Приватные методы

        private static void OnConfigure(LightBddConfiguration configuration)
        {
            // LightBDD configuration
        }

        #endregion
    }
}